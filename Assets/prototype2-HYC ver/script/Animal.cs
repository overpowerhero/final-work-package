using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// tset github
// shiouuu test 這是琇1/09晚上傳的
//HYC test 1/08 10pm

public class Animal : MonoBehaviour
{
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
