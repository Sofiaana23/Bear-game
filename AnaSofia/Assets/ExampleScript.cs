using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public float randomNumber = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            randomNumber = Random.Range(1, 4);

            if (randomNumber == 1)
            {
                Debug.Log("Rock");
            }

            if (randomNumber == 2)
            {
                Debug.Log("Paper");
            }

            if (randomNumber == 3)
            {
                Debug.Log("Scissors");
            }
        }
    }
}
