using UnityEngine;

public class GamePlay2 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public float rotationSpeed = 300f;

    
    public Transform groundCheckPoint;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private float targetRotationZ = 0f;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
      
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        Debug.Log(isGrounded);
       
        transform.position += Vector3.right * moveSpeed * Time.fixedDeltaTime;

        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            targetRotationZ -= 90f;


        }

        float currentZ = transform.rotation.eulerAngles.z;
        float newZ = Mathf.MoveTowardsAngle(currentZ, targetRotationZ, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 0, newZ);
    }

    private void OnDrawGizmosSelected()
    {
        if (groundCheckPoint == null) return;
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(groundCheckPoint.position, groundCheckRadius);
    }
}
