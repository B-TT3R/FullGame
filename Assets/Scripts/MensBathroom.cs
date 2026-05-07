using UnityEngine;
using UnityEngine.SceneManagement;

public class MensBathroom : MonoBehaviour
{
    public void NextScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MensBathroom");
    }
}