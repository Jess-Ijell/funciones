using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject clon = Instantiate(gameObject);
            clon.AddComponent<Rigidbody>();
        }
    }
}
