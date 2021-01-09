using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
// tset github
// shiouuu test 這是琇1/09晚上傳的
//HYC test 1/08 10pm

=======
>>>>>>> parent of 7492140... 1/08-10.23
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
