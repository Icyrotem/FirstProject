using UnityEngine;

public class particleDestroy : MonoBehaviour
{
    private float duration = 1f;
    
    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
        if (duration <= 0)
            Destroy(this.gameObject);
    }

    public static void destroyAllParticles()
    {
        GameObject[] particles = GameObject.FindGameObjectsWithTag("particleDrafted");

        foreach (GameObject particle in particles)
            Destroy(particle);
    }
}
