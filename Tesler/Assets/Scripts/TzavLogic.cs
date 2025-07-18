using UnityEngine;

public class TzavLogic : MonoBehaviour
{
    Quaternion target;
    public int speed = 14;
    public GameObject dos;
    private float horizontal;
    public Rigidbody2D tzav;
    public ParticleSystem drafted;
    
    // Constants
    private const float TARGET_ROTATION_Z = -90f;
    private const float ROTATION_LERP_SPEED = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        horizontal = PlayerController.horizontalInput;
        target = Quaternion.Euler(0, 0, TARGET_ROTATION_Z);
        tzav.velocity = new Vector2(speed * horizontal, tzav.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, target, ROTATION_LERP_SPEED * Time.deltaTime);
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
                    Instantiate(drafted, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
                    Destroy(collision.gameObject);
                }
            }
            ScoreLogic.updateText(1);
            Destroy(this.gameObject);
        }
    }
}
