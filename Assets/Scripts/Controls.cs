using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour {
   
    public GameObject MainMenu;
    
    // Update is called once per frame
    void Update () {
       
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            // Check whether it's active / inactive 
            bool isActive = MainMenu.activeSelf;
                MainMenu.SetActive(!isActive);
        }
    }
}
