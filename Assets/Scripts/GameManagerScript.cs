using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public GameObject gameOverUI;
    public GameObject timesuptext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timesuptext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);  
        timesuptext.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}