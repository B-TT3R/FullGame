using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class Controls : MonoBehaviour {
   
    [FormerlySerializedAs("MainMenu")] public GameObject mainMenu;
    
    void Update()
    {

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
            mainMenu.SetActive(true);
            if(mainMenu.activeInHierarchy)
                Time.timeScale = 0f;
                
        }
        
    }
}
