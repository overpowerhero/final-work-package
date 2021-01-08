using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outoffbound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for food
        if (transform.position.z > 40)
        {
            Destroy(gameObject);
        }
        //for dog
        if (transform.position.z < -20)
        {
            Destroy(gameObject);
        }
    }
}
