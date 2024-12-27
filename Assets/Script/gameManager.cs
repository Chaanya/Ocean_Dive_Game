using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public int Score;

    public Text ScoreTxt;

    public Text GOScoreTxt;

    public GameObject GOPanel;

    public GameObject WinPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GOPanel.SetActive(false);
        WinPanel.SetActive(false);
        Score = 0;
        ScoreTxt.text = "Score : " + Score;
    }

    public void UpdateScore()
    {
        Score += 10;
        ScoreTxt.text = "Score : " + Score;
    }

    public void GameOver()
    {
        GOPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }


    public void GameCompleted()
    {
        GOScoreTxt.text = "Score : " + Score; 
        WinPanel.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
