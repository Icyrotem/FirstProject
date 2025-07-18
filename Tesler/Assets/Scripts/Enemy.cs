using UnityEngine;
public class Enemy : MonoBehaviour
{
    public float xRange = 21;
    public int speed = 10;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if(transform.position.x >= xRange || transform.position.x <= -xRange)
        {
            speed *= -1;
        }
    }
}
