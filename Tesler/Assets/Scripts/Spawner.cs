using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int level = 0;
    public float random;
    public static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        newWave();
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(counter);
        if (counter <= 0)
        {
            level=level + 5;
            newWave();
            
        }
    }
    void newWave()
    {
        for (int i = 1; i < level + 5; i++)
        {
            random = Random.Range(-22.0f, 22.0f);
            Instantiate(enemy, new Vector3(random, -6.5f, 0), Quaternion.identity);
            counter++;
        }
    }

}
