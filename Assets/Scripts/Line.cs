using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer line;
    [SerializeField] private TextMeshProUGUI distanceText;
    
    private Vector2 _startPosition;
    private Vector2 _finishPosition;

    private float _distance;
    private float _height;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    public void SetTextWidth()
    {
        GetDistance();
        distanceText.text = string.Format("{0:N2}", _distance);
        distanceText.transform.localPosition = new Vector3(_distance / 10,_height,0);
    }

    public float GetDistance()
    {
        _startPosition = new Vector2(line.GetPosition(0).x,line.GetPosition(0).y);
        _finishPosition = new Vector2(line.GetPosition(1).x,line.GetPosition(1).y);
        _distance = (_startPosition - _finishPosition).magnitude;
        _height = (_startPosition.y + _finishPosition.y);
        return _distance;
    }

    public void SetTextRotation()
    {
        distanceText.transform.Rotate(0,0,_height * 10);
    }
}
