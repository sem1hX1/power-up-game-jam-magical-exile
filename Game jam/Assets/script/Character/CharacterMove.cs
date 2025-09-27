using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    Rigidbody2D rgb;
    Vector3 velocity;
    public Animator animator;

    [SerializeField]
    Transform groundCheck;

    [SerializeField]
    LayerMask groundLayer;

    [SerializeField]
    float groundCheckRadius = 0.4f;

    float speedAmount = 5f;
    float jumpAmount = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        velocity = new Vector3(inputX, 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;

        float speed = Mathf.Abs(inputX);
        animator.SetFloat("Speed", speed);

        HandleJump();

        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxis("Horizontal") >= 0)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && GroundCheck())
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
        }
        else

        if (GroundCheck() && rgb.linearVelocityY <= 0)
        {
            animator.SetBool("isJumping", false);
        }


    }

    private bool GroundCheck()
    {
        return Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

}
