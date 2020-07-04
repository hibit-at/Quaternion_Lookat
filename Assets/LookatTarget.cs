﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatTarget : MonoBehaviour
{
    public GameObject targetObject;
    void Start()
    {
    }
    void Update()
    {
        Vector3 target = targetObject.transform.position - transform.position;
        target = target.normalized;
        Vector3 norm = new Vector3(0, 0, 1);
        float dot = Vector3.Dot(norm,target);
        float theta = Mathf.Acos(dot);
        Vector3 cross = Vector3.Cross(norm, target);
        Quaternion q;
        cross = cross.normalized;
        theta = theta / 2;
        q.x = cross.x * Mathf.Sin(theta);
        q.y = cross.y * Mathf.Sin(theta);
        q.z = cross.z * Mathf.Sin(theta);
        q.w = Mathf.Cos(theta);
        transform.rotation = q;
    }
}
