using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackScript : MonoBehaviour
{
    public void NextScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SecurityGuardScene");
    }
}
