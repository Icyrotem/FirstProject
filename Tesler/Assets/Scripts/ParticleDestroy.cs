using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
    // Constants
    private const float DEFAULT_PARTICLE_DURATION = 1f;
    
    private float duration = DEFAULT_PARTICLE_DURATION;
    
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
