using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetTouch(0).position.x < Screen.width / 2)
            {
                transform.Translate(Vector2.left * Time.deltaTime * 10);
            }
            else
            {
                transform.Translate(-Vector2.left * Time.deltaTime * 10);
            }
        }
    }
}
