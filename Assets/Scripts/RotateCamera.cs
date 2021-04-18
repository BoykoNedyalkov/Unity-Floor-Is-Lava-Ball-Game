using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private float rotationSpeed = 200f;   
    // Start is called before the first frame update
    void Start()
    {     
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalMouseInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalMouseInput);
    }
}
