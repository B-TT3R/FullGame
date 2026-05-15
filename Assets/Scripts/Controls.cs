using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class Controls : MonoBehaviour {
   
    [FormerlySerializedAs("MainMenu")] public GameObject mainMenu;
    
    void Update()
    {

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MenuScreen");
        }
        
    }
}
