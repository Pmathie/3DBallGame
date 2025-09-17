using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDirection;
    public float moveSpeed;
    public float jumpSpeed;
    public bool isGrounded;
    
    public Transform cameraTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0f;
        right.y = 0f;

        moveDirection = (forward * Input.GetAxis("Vertical") + right * Input.GetAxis("Horizontal")).normalized;
        
        if(isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*jumpSpeed, ForceMode.Impulse);
        }
   
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * moveSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            isGrounded = true;
        }
        
        
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isGrounded = false;
        }
            
    }
}
