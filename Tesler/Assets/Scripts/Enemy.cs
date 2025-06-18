using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public int speed = 10;
    public BoxCollider2D wall1;
    public BoxCollider2D wall2;
    public BoxCollider2D enemycollider;
    // Start is called before the first frame update
    void Start()
    {
        wall1 = GetComponent<BoxCollider2D>();
        wall2 = GetComponent<BoxCollider2D>();
        enemycollider = GetComponent<BoxCollider2D>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.Translate(Vector3.right * Time.deltaTime * -speed);
    }
}
