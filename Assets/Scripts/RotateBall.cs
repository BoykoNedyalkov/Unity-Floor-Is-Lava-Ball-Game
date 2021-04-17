using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : MonoBehaviour
{
    public float roationSpeed = 0.5f;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        _rigidbody.AddTorque(Vector3.right * Time.deltaTime * verticalInput * roationSpeed);
        _rigidbody.AddTorque(Vector3.back * Time.deltaTime * horizontalInput * roationSpeed);

    }
}
