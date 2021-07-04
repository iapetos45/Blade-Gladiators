using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    private float dirX;
    private float dirZ;
    public float speedSide = 3;
    public float speedForward = 3;

    void Start()
    {
        
    }

    void Update()
    {
        dirX = 0;
        dirZ = 0;

        // 왼쪽 컨트롤러 스틱
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);

            // Debug.Log($"coord.x = {coord.x} , coord.y = {coord.y}");
            if (absX > 0.01f || absY > 0.01f)
            {
                if (absX > absY)
                {
                    // Right
                    if (coord.x > 0)
                    {

                        dirX = +1;

                        /*if (coord.y > 0)
                            dirZ = +1;
                        else
                            dirZ = -1;*/
                    }
                    // Left
                    else
                    {
                        dirX = -1;

                        /*if (coord.y > 0)
                            dirZ = +1;
                        else
                            dirZ = -1;*/
                    }
                }
                else
                {
                    // Up
                    if (coord.y > 0)
                    {
                        dirZ = +1;

                        /*if (coord.x > 0)
                            dirX = +1;
                        else
                            dirX = -1;*/
                    }
                    // Down
                    else
                    {
                        dirZ = -1;

                        /*if (coord.x > 0)
                            dirX = +1;
                        else
                            dirX = -1;*/
                    }
                }
            }
            

        }

        // 이동 방향 설정 후 이동
        Vector3 moveDir = new Vector3(dirX * speedSide, 0, dirZ * speedForward);
        transform.Translate(moveDir * Time.smoothDeltaTime);
        
    }
}
