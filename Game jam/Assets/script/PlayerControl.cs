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
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);

        if (horizontal > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (horizontal < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }
}
