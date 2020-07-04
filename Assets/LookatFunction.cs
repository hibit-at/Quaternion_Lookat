using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatFunction : MonoBehaviour
{
    public GameObject targetObject;

    void Start()
    {
    }

    void Update()
    {
        transform.LookAt(targetObject.transform.position);
    }
}
