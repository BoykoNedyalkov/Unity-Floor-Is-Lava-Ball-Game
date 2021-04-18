using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float roationSpeed = 30f;
    public float jumpSpeed = 200f;
    private Rigidbody _rigidbody;
    private GameObject _focalPoint;

    private bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        _rigidbody.AddTorque( _focalPoint.transform.right * Time.deltaTime * verticalInput * roationSpeed);
        _rigidbody.AddTorque(-_focalPoint.transform.forward * Time.deltaTime * horizontalInput * roationSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
             {
            _rigidbody.AddForce(_focalPoint.transform.up * Time.deltaTime * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
