using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SimpleRotatorScript: MonoBehaviour
{
    private Vector3 rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = new Vector3(0, 0, (float)(0.1+Math.Sqrt(gameObject.transform.localPosition.z*0.7)));
    }

    void Update()
    {
        gameObject.transform.Rotate(rotationSpeed);
    }

}