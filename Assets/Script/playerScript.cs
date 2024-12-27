using UnityEngine;
using UnityEngine.UI;
public class playerScript : MonoBehaviour
{

    public gameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.gameObject.tag == "Coin")
        {
              gameManager.UpdateScore();
              Destroy(hit.gameObject);
        }

        if (hit.gameObject.tag == "Finish_coin")
        {
            gameManager.GameCompleted();
            Destroy(hit.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ocean_spike")
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
    
        if (col.gameObject.tag == "shark")
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "jellyfish")
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
    }
}
