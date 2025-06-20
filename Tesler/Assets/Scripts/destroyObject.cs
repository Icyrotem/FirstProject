using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class detroyObject : MonoBehaviour
{
    public float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0 || transform.position.y <= -10 || Spawner.enemies.Count == 0)
            Destroy(this.gameObject);
    }
}
