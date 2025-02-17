using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMonster : Monster
{
    protected override void Awake()
    {
        base.Awake();
        defaultTarget = GameObject.FindWithTag("Core").GetComponent<Transform>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        ChaseTarget();
    }

    protected override void Update()
    {
        base.Update();
        PriorityTarget();
        LookAt();

        //Debug.Log($"{gameObject.name} ���� : {state}");
    }

    protected override void ChaseTarget()
    {
        StartCoroutine(MonsterState());
    }
}