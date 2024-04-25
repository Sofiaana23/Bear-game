using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] fruit;

    public float interval;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = interval;  
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(fruit[Random.Range(0, 5)], new Vector3(Random.Range(-118f, 118f), Random.Range(0f, 135f), transform.position.z), Quaternion.identity);
            timer = interval;
        }
        
    }
}
