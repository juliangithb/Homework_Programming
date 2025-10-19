using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    float xspeed;
    float yspeed;

    public float speed = 3;

    string InputX = "Horizontal";
    string InputY = "Vertical";

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        xspeed = Input.GetAxis(InputX);
        yspeed = Input.GetAxis(InputY);

        rb.velocity = new Vector2(xspeed, yspeed) * speed;
    }
}
