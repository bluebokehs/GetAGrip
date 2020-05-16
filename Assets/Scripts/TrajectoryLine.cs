﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TrajectoryLine : MonoBehaviour
{
    public LineRenderer lr;
    
    void Awake()
    {
        lr = gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    public void RenderLine(Vector3 startPos, Vector3 endPos)
    {
        lr.positionCount = 2;
        Vector3[] points = new Vector3[2];
        points[0] = startPos;
        points[1] = endPos;

        lr.SetPositions(points);
    }

    public void EndLine()
	{
        lr.positionCount = 0;
	}
}
