using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BladeControll : MonoBehaviour
{
    // 날 부분
    private GameObject rootObj;
    private PlayerStat targetStat;
    [SerializeField]
    private bool isAtk = false;

    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        // 몸에 닿았을 때 & 닿은 상태가 아닐때
        if (col.CompareTag("Player") && !isAtk)
        {
            Debug.Log("공격 성공");
            isAtk = true;
            try
            {
                rootObj = col.gameObject.transform.root.gameObject;
                targetStat = rootObj.GetComponent<PlayerStat>();

                targetStat.playerHp -= 25;
            }
            catch (NullReferenceException) { }
        }

        if (col.CompareTag("STICK"))
        {
            Debug.Log("날 , 스틱");
        }

        if (col.CompareTag("BLADE"))
        {
            Debug.Log("날 , 날");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("BODY"))
        {
            isAtk = false;
        }
    }
}
