using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpen : MonoBehaviour
{
    public static bool inventoryActive = false;

    public GameObject pauseUI;    

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)){
           if(inventoryActive){
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
        Time.timeScale = 0f;
        inventoryActive = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        InventoryManager.Instance.ListItems();
    }
}
