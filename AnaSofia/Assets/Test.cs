using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Vector3 newScale;

    private void Start()
    {
        newScale = new Vector3(1, 1, 1);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))

        {
            this.transform.localScale += newScale * Time.deltaTime; 
        }
    }

}
