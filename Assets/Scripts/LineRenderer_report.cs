using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class LineRenderer_report : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //LineRenderer l = gameObject.AddComponent<LineRenderer>();

        //List<Vector3> pos = new List<Vector3>();
        //pos.Add(new Vector3(0, 5));
        //pos.Add(new Vector3(0, -10));
        //l.startWidth = 0f;
        //l.endWidth = 15f;
        //l.SetPositions(pos.ToArray());
        //l.useWorldSpace = true;

        var segments = 360;
        var line = gameObject.AddComponent<LineRenderer>();
        line.useWorldSpace = true;
        line.startWidth = 0.2f;
        line.endWidth = 0.2f;
        line.positionCount = segments + 1;

        var pointCount = segments + 1; // add extra point to make startpoint and endpoint the same to close the circle
        var points = new Vector3[pointCount];

        for (int i = 0; i < pointCount; i++)
        {
            var rad = Mathf.Deg2Rad * (i * 360f / segments);
            points[i] = new Vector3(Mathf.Sin(rad) * 1, 0, Mathf.Cos(rad) * 1);
        }

        line.SetPositions(points);

    }
}
