using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float forwardVelocity = 1.0f;
    private float sidewaysVelocity = 1.0f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * forwardVelocity * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * sidewaysVelocity * horizontalInput);
        
    }
}
