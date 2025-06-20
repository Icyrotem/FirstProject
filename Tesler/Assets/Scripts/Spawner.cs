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
    public static List<GameObject> enemies = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        newWave();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemies.Count <= 0)
        {
            destroyObject.destroyAllTzav();

            level = level + 5;
            newWave();

        }
    }

    void newWave()
    {
        for (int i = 1; i < level + 5; i++)
        {
            random = Random.Range(-22.0f, 22.0f);
            enemies.Add(Instantiate(enemy, new Vector3(random, -6.5f, 0), Quaternion.identity));
        }
        PlayerController.ammo = (int)(enemies.Count * 1.5);
    }

}
