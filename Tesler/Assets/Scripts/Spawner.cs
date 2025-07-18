using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int level = 0;
    public float random;
    public static List<GameObject> enemies = new List<GameObject>();
    
    // Constants for spawn configuration
    private const int LEVEL_INCREMENT = 5;
    private const float SPAWN_RANGE_MIN = -22.0f;
    private const float SPAWN_RANGE_MAX = 22.0f;
    private const float SPAWN_Y_POSITION = -6.5f;
    private const float AMMO_MULTIPLIER = 1.5f;
    private const int SCORE_DIVISOR = 2;

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
            DestroyObject.destroyAllTzav();
            ParticleDestroy.destroyAllParticles();

            level = level + LEVEL_INCREMENT;
            ScoreLogic.updateText(level / SCORE_DIVISOR);
            newWave();
        }
    }

    void newWave()
    {
        for (int i = 1; i < level + LEVEL_INCREMENT; i++)
        {
            random = Random.Range(SPAWN_RANGE_MIN, SPAWN_RANGE_MAX);
            enemies.Add(Instantiate(enemy, new Vector3(random, SPAWN_Y_POSITION, 0), Quaternion.identity));
        }
        PlayerController.ammo = (int)(enemies.Count * AMMO_MULTIPLIER);
    }

}
