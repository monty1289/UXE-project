using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorItemControllor : MonoBehaviour
{

    Item item;

    bool playerWeaponsManager;

    public Button RemoveButton;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        
        Destroy(gameObject);
    }
    
    public void AddItem(Item newItem){
        item = newItem;
    }
}