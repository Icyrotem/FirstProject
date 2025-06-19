using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class detroyObject : MonoBehaviour
{
    public float timeOut;
    public float timeLeft;
    Quaternion target;
    public int speed;
    public GameObject dos;
    public Rigidbody2D tzav;
    public float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        horizontal = PlayerController.horizontalInput;
        speed = 14;
        timeLeft = 5;
        target = Quaternion.Euler(0, 0, -90);
    }

    // Update is called once per frame
    void Update()
    {
        speed -= (int)(14 * Time.deltaTime);

        if (speed <= 0)
            speed = 0;

        tzav.velocity = new Vector2(speed * horizontal, tzav.velocity.y);
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
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            tzav.AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
        }
    }
}
