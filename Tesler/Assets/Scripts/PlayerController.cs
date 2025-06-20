using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static float horizontalInput;
    public const int speed = 10;
    public float fireRate;
    public float lastFire;
    public GameObject tzav;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKey(KeyCode.S) && (Time.time - lastFire > 1 / fireRate))
        {
            lastFire = Time.time;

            GameObject clone;
            clone = Instantiate(tzav, this.transform.position, new Quaternion());
            clone.transform.Rotate(0, 0, -90 + 90 * horizontalInput);
        }
    }
}
