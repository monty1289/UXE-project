/*
gives item prefab an id, name, value and icon for displaying in inventory 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName ="Item/Create New Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;
}
