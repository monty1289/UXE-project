

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    void InvenPickUp(){
        InventoryManager.Instance.Add(item);
        Destroy(gameObject);
    }

    
}
