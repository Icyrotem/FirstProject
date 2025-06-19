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
    public GameObject dos;
    // Start is called before the first frame update
    void Start()
    {
        speed = 20;
        timeLeft = 5;
        target = Quaternion.Euler(0, 0, -90);
    }

    // Update is called once per frame
    void Update()
    {
        speed -= (int)(20 * Time.deltaTime);

        if (speed <= 0)
            speed = 0;

        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        transform.rotation = Quaternion.Slerp(transform.rotation, target, 1 * Time.deltaTime);

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0 || transform.position.y <= -10)
            Destroy(this.gameObject);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dos"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Spawner.counter--;
        }
    }
}
