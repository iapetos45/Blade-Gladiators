using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickControll : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("STICK"))
        {
            Debug.Log("스틱 , 스틱");
        }

        if (col.CompareTag("BLADE"))
        {
            Debug.Log("방어 성공!");
        }
    }
}
