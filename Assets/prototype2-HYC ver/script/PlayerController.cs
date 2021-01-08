using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 30;
    public float horizontalInput;
    public float verticalInput;

    // 1/8 zixinma
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;

    

    private int xRange = 20;
    public GameObject flyFood;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //limit bound
        if (transform.position.x < -xRange) // too left
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) // too right
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Generate fly food
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(flyFood, transform.position, flyFood.transform.rotation);
        }

        // 1/8 zixinma

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    // 1/8 zixinma

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }

}

