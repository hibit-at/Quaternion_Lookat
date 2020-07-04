using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatRotation : MonoBehaviour
{

    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = targetObject.transform.position - transform.position;
        Quaternion look = Quaternion.LookRotation(target);
        transform.rotation = look;
    }
}
