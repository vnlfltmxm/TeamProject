using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ttest : Turret
{
    public bool b;
    // Start is called before the first frame update
    void Start()
    {
        b = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void Attack()
    {
    }

    IEnumerator TestC()
    {
        while (true)
        {
            yield return new WaitUntil(() => b);
            yield return new WaitForSeconds(1);

            Debug.Log("aaa");

        }
    }
}
