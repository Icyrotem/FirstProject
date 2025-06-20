using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class destroyObject : MonoBehaviour
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
        if (timeLeft <= 0 || transform.position.y <= -10)
            Destroy(this.gameObject);
    }

    public static void destroyAllTzav()
    {
        GameObject[] tzavim = GameObject.FindGameObjectsWithTag("tzav");

        foreach (GameObject tzav in tzavim)
            Destroy(tzav);
    }
}
