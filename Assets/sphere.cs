using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    float start_time;

    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float now = Time.time;
        Vector3 location = new Vector3(5*Mathf.Sin(now - start_time), 1, 1);
        transform.position = location;
    }
}
