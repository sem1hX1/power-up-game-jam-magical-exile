using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    float horizontal;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
<<<<<<< Updated upstream
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
=======
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
>>>>>>> Stashed changes

        if (horizontal > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (horizontal < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }
}
