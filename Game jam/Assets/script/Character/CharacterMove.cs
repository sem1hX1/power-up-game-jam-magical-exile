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
    Vector2 forward;
    [SerializeField]
    float speed = 1.0f;
    [SerializeField]
    //float isJumging = 5f;

    playerCombar playerCombar;

    float speedAmount = 5f;
    float jumpAmount = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        playerCombar = GetComponent<playerCombar>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleJump();
        attack();
        HandleJump();
        GroundCheck();
        runattack();

        float inputX = Input.GetAxis("Horizontal");

        velocity = new Vector3(inputX, 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;

         speed = Mathf.Abs(inputX);
        animator.SetFloat("Speed", speed);

        

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



    private void attack()
    {
       

        if(Input.GetKeyDown(KeyCode.E)&&speed==0f)
        {
            animator.SetTrigger("attack");
            playerCombar.DamageEnemy();
        }
    }
    void runattack()
    {
        if(Input.GetKeyDown(KeyCode.E)&&speed>1f||Input.GetKeyDown(KeyCode.E)&&speed<1f)
       {
            animator.SetTrigger("runattack");
            playerCombar.DamageEnemy();
        }
    }

}
