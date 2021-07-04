using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabMgr : MonoBehaviour
{
    private Transform grabObject;
    [SerializeField]
    private bool isTouched = false;


    void Start()
    {

    }

    void Update()
    {
        // 오른손 조이스틱
        /*if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            Vector2 stick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);
            Debug.Log($"x = {stick.x} / y = {stick.y}");
        }*/

        /*if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("Left Trigger Down");
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
            Debug.Log("Left Hand Down");
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Debug.Log("Right Trigger Down");
        }*/

        if (isTouched && OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            grabObject.SetParent(this.transform);
            grabObject.GetComponent<Rigidbody>().isKinematic = true;
        }

        if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
        {
            grabObject.SetParent(null);
            Vector3 _velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
            grabObject.GetComponent<Rigidbody>().isKinematic = false;
            grabObject.GetComponent<Rigidbody>().velocity = _velocity;

            isTouched = false;
            grabObject = null;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("BALL"))
        {
            isTouched = true;
            grabObject = col.transform;
        }
    }

}

