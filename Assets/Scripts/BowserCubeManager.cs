using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BowserCubeManager : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] float spacing;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            GameObject newCube = Instantiate(cube); // This will create a new cube
            newCube.transform.localPosition = new Vector3(spacing * (i%10),(float)(spacing * (Math.Floor(i/10f)%10)),(float)(spacing * Math.Floor(i/100f)));
            newCube.SetActive(true);
        }
    }
}
