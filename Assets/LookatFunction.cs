using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatFunction : MonoBehaviour
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
        //Move script
        float now = Time.time;
        Vector3 location = new Vector3(5 * Mathf.Sin(now - start_time), 3, 2);
        transform.position = location;

        //Rotation script
        transform.LookAt(targetObject.transform.position);
    }
}
