using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float timeLeft;
    
    // Constants
    private const float DEFAULT_LIFETIME = 5f;
    private const float DESTROY_Y_THRESHOLD = -10f;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = DEFAULT_LIFETIME;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0 || transform.position.y <= DESTROY_Y_THRESHOLD)
            Destroy(this.gameObject);
    }

    public static void destroyAllTzav()
    {
        GameObject[] tzavim = GameObject.FindGameObjectsWithTag("tzav");

        foreach (GameObject tzav in tzavim)
            Destroy(tzav);
    }
}
