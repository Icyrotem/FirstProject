using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paricleDestroy : MonoBehaviour
{
    private float duration = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
