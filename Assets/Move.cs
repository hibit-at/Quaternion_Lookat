using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float start_time;
    // Start is called before the first frame update
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float now = Time.time;
        Vector3 location = new Vector3(2.5f*Mathf.Sin(now - start_time), 4, 2.5f * Mathf.Cos(now - start_time));
        transform.position = location;
    }
}
