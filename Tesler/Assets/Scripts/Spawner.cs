using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int level = 1;
    public float random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(-22.0f, 22.0f);
        for (int i = 0; i < level; i++)
        {
            Instantiate(enemy, new Vector3(random, -6.5f, 0), Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
