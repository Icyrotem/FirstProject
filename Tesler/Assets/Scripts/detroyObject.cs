using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class detroyObject : MonoBehaviour
{
    public float timeOut;
    public float timeLeft;
    Quaternion target;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 30;
        timeLeft = 5;
        target = Quaternion.Euler(0, 0, -90);
    }

    // Update is called once per frame
    void Update()
    {
        speed *= (int)(0.9 * Time.deltaTime);
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        transform.rotation = Quaternion.Slerp(transform.rotation, target, 1 * Time.deltaTime);

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
            Destroy(this.gameObject);
    }
}
