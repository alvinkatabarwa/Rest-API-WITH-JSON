using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public string playerName;
    public int level;
    public float health;
    public Vector3 position; 
    public List<Item> inventory;
}

[Serializable]
public class Item
{
    public string itemName;
    public int quantity;
    public float weight;
}

[Serializable]
public class Metadata
{
    public string id;
    public bool isPrivate;
    public string createdAt;
    public string name;
}

[Serializable]
public class RootObject
{
    public PlayerData record;
    public Metadata metadata;
}
