using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 5;
    public int facingDirection = 1;
    public Rigidbody2D rb;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        if ((Horizontal > 0 && transform.localScale.x < 0) || (Horizontal < 0 && transform.localScale.x > 0))
        {
            Flip();
        }
        animator.SetFloat("Horizontal", Mathf.Abs(Horizontal));
        animator.SetFloat("Vertical", Mathf.Abs(Vertical));

        rb.linearVelocity = new Vector2(Horizontal, Vertical) * speed;
    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
