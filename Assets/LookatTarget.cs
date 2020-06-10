using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatTarget : MonoBehaviour
{
    Quaternion start_rot;
    float start_time;
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        start_rot = transform.rotation;
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float now = Time.time;
        Vector3 target = targetObject.transform.position - transform.position;
        Vector3 origin = new Vector3(0, 0, 1);
        float dot = Vector3.Dot(target, origin);
        float norm = target.magnitude;
        float theta = Mathf.Acos(dot / norm);
        theta = theta * 180 / Mathf.PI;
        Vector3 cross = Vector3.Cross(origin, target);
        cross = cross.normalized;
        Quaternion q = Quaternion.AngleAxis(theta, cross);
        transform.rotation = q * start_rot;
    }
}
