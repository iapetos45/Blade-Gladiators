using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public int playerHp = 100;
    private Animator ani;

    // 추후 애니메이션 추가
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        Debug.Log(playerHp);

        if(playerHp <= 0)
        {
            Debug.Log($"{gameObject.name} 죽음");
            ani.SetBool("isDie", true);
        }
    }

    public void PlayerDead()
    {
        // Die 애니메이션에서 호출되는 함수
        // 애니메이션이 끝난 후, 스폰 포인트로 순간이동해서 재시작
    }

}
