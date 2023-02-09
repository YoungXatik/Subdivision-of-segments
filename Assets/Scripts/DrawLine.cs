using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    [SerializeField] private Line linePrefab;
    private Line createdLine;
    private LineRenderer createdLineRenderer;

    private Vector2 mousePos;
    private Vector2 startMousePos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            createdLine = Instantiate(linePrefab);
            createdLineRenderer = createdLine.line;
        }

        if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            createdLineRenderer.SetPosition(0,new Vector3(startMousePos.x,startMousePos.y,0f));
            createdLineRenderer.SetPosition(1,new Vector3(mousePos.x,mousePos.y,0f));
            createdLine.SetTextWidth();
        }

        if (Input.GetMouseButtonUp(0))
        {
            createdLine.SetTextRotation();
        }
    }
}
