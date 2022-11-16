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

    public InventorItemControllor[] InventorItems;

    public Toggle EnableRemove;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        foreach(Transform item in ItemContent)
        { //clean content before open 
            Destroy(item.gameObject);
        }

        //displays item image and item name to inveventory 

        foreach(Item item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            Debug.Log(obj.transform.Find("ItemName").GetComponent<Text>().text);
            Debug.Log(item.itemName);
            obj.transform.Find("ItemName").GetComponent<Text>().text = item.itemName;            
            obj.transform.Find("ItemIcon").GetComponent<Image>().sprite = item.icon;  

            var removeButton = obj.transform.Find("RemoveButton").GetComponent<Button>();

            Debug.Log(item.itemName);

            if (EnableRemove.isOn){
                removeButton.gameObject.SetActive(true);
            }
            
        }

        SetInventoryItems();
    }
//enables remore button in items when click removeItem button
    public void EnableItemsRemove()
    {
        if(EnableRemove.isOn){
            foreach(Transform item in ItemContent)
            {
                item.Find("RemoveButton").gameObject.SetActive(true);    
            }
        }else{
            foreach(Transform item in ItemContent)
            {
                item.Find("RemoveButton").gameObject.SetActive(false);    
            }
        }
    }
//calls item contraller to remove item prefab
    public void SetInventoryItems()
    {
        InventorItems = ItemContent.GetComponentsInChildren<InventorItemControllor>();

        for (int i = 0; i < Items.Count; i++)
        {
            InventorItems[i].AddItem(Items[i]);
        }
    }
}
