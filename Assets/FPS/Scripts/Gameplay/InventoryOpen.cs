using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpen : MonoBehaviour
{
    public static bool inventoryActive = false;

    public GameObject pauseUI;   

    //The game object that holds the canvas for the pause menu
    public GameObject PauseMenu; 

    

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.activeSelf == false)
        {
            // Lock cursor when clicking outside of menu
            if (!pauseUI.activeSelf && Input.GetMouseButtonDown(0))
            {
               Cursor.lockState = CursorLockMode.Locked;
               Cursor.visible = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.I)){
           if(inventoryActive == true){
                Resume();
           } else{
                Pause();
           }
        }
    }

    void Resume(){ //close inventory       
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        inventoryActive = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;       
    }
    
    void Pause(){   //open inventory        
        pauseUI.SetActive(true);        
        inventoryActive = true;        
        Time.timeScale = 0f;            
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        InventoryManager.Instance.ListItems();     
        
               
    }
}
