using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tzavLogic : MonoBehaviour
{
    Quaternion target;
    public int speed = 14;
    public GameObject dos;
    private float horizontal;
    public Rigidbody2D tzav;
    // Start is called before the first frame update
    void Start()
    {
        horizontal = PlayerController.horizontalInput;
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

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dos"))
        {
            for(int i = 0; i < Spawner.enemies.Count; i++)
            {
                if (Spawner.enemies[i].GetInstanceID() == collision.gameObject.GetInstanceID())
                {
                    Spawner.enemies.Remove(collision.gameObject);
                    Destroy(collision.gameObject);
                }
            }
            Destroy(this.gameObject);
        }
    }

}
