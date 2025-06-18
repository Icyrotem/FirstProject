using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    public float xRange = 21;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange, transform.position.y);
        }
        if (transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y);
        }
    }
}
