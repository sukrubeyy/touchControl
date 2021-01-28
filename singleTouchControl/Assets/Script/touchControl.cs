using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchControl : MonoBehaviour
{
    Touch touch;
    Vector3 touchPosition;
    void Update()
    {
        if(Input.touchCount>0)
        {
            touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            transform.position = touchPosition;
        }
     
    }
}
