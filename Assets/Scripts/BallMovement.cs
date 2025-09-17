using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDirection;
    public float moveSpeed;
    public Transform cameraTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        rb.AddForce(moveDirection*moveSpeed);

        
    }
}
