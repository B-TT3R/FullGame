using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour {
   
    public GameObject MainMenu;
    
    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MenuScreen");
        }
        
    }
}
