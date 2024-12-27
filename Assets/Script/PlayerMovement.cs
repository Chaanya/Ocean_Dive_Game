using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public float Speed;

    public float JumpForce;

    Rigidbody2D rb;

    bool Grounded = true; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        float MoveX = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(MoveX * Speed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && Grounded == true)
        {
            //Jump
            rb.AddForce(transform.up * JumpForce);
            Grounded = false;
        }

    }
    void OnCollisionEnter2D(Collision2D Col)
    {
        if(Col.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
    }
}
