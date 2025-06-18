using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class detroyObject : MonoBehaviour
{
    public float timeOut;
    public float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
            Destroy(this.gameObject);
    }
}
