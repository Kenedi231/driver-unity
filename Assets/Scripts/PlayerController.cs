using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;
    private float turnSpeed = 55.0f;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        if (verticalInput == 0)
        {
            return;
        }
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        // Move the vichle forward   
    }
}
