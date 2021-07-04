using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeaponControll : MonoBehaviour
{
    private PlayerStat targetStat;
    private GameObject rootObj;
    private CapsuleCollider rootCollider;
    private CapsuleCollider weaponCollider;

    [SerializeField]
    private bool isAtk = false;

    void Start()
    {
        weaponCollider = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        // 스틱 , 몸
        if (gameObject.tag.Equals("STICK") && col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("스틱 , 몸");
        }

        // 날 , 몸
        if (gameObject.tag.Equals("BLADE") && col.gameObject.tag.Equals("Player"))
        {
            weaponCollider.enabled = false; // 무기 콜라이더 비활성화

            rootObj = col.gameObject.transform.root.gameObject;
            Debug.Log(rootObj.name);
            try
            {
                targetStat = rootObj.transform.GetComponent<PlayerStat>();
                targetStat.playerHp -= 25;
            }
            catch (NullReferenceException) { }
            
            Debug.Log("날 , 몸");
        }

        // 스틱 , 스틱
        if (gameObject.tag.Equals("STICK") && col.gameObject.tag.Equals("STICK"))
        {
            Debug.Log("스틱 , 스틱");
        }

        // 스틱, 날
        if (gameObject.tag.Equals("STICK") && col.gameObject.tag.Equals("BLADE"))
        {
            Debug.Log("스틱, 날");
        }

        // 날, 날
        if (gameObject.tag.Equals("BLADE") && col.gameObject.tag.Equals("BLADE"))
        {
            Debug.Log("날, 날");
        }
    }
}
