using UnityEngine;
using UnityEngine.SceneManagement;

public class WomensBathroom : MonoBehaviour
{
    public void NextScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MazeGeneration");
    }
}
