using UnityEngine;

public class enemyShark : MonoBehaviour
{
    public float speed;
    public float rayDist;
    public bool movingRight;
    public Transform groundArea;
    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundCheck = Physics2D.Raycast(groundArea.position, Vector2.down, rayDist);
        
        if (groundCheck.collider == false)
        {
            if(movingRight)
            {
                transform.eulerAngles = new Vector3(0,-180, 0);
                movingRight = false;
            }

            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
