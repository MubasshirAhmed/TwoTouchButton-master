﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UITouchToMove : MonoBehaviour
{
    public GameObject go;



    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            CheckUIObjectsInPosition(Input.GetTouch(0).position);
    }

    void CheckUIObjectsInPosition(Vector2 position)
    {
        PointerEventData pointer = new PointerEventData(EventSystem.current);
        pointer.position = position;
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointer, raycastResults);

        if (raycastResults.Count > 0)
        {
            foreach (var item in raycastResults)
            {
                if (item.gameObject.name == "LeftButton")
                    go.transform.Translate(Vector2.left * Time.deltaTime * 10);
                else if (item.gameObject.name == "RightButton")
                    go.transform.Translate(-Vector2.left * Time.deltaTime * 10);
            }
        }
    }
}
