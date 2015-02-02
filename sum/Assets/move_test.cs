using UnityEngine;
using System.Collections;
public class move : MonoBehaviour
{

    public float Speed;
    public Vector2 nowPos, prePos;
    public Vector3 movePos;
    void Update()
        {
            Screen.SetResolution(640, 480, true, 60);
            if(Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
                if(touch.phase == TouchPhase.Began)
                {
                    prePos = touch.position - touch.deltaPosition;
                }
                else if(touch.phase == TouchPhase.Moved)
                {
                nowPos = touch.position - touch.deltaPosition;
                movePos = (Vector3)(prePos - nowPos) * Speed;
                camera.transform.Translate(movePos);
                prePos = touch.position - touch.deltaPosition;
                }
                else if(touch.phase == TouchPhase.Ended)
                { }
            }
         }
}