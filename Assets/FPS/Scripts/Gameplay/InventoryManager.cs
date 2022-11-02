using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item){
        Items.Add(item);
    }

    public void Remove(Item item){
        Items.Remove(item);
    }

    public void ListItems(){
        foreach(Transform item in ItemContent){ //clean content before open 
            Destroy(item.gameObject);
        }

        foreach(Item item in Items){
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            obj.transform.Find("ItemName").GetComponent<Text>().text = item.itemName;   
            obj.transform.Find("ItemIcon").GetComponent<Image>().sprite = item.icon;            

            Debug.Log(item.itemName);
            
        }
    }
}
