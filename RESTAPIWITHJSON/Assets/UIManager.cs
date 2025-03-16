using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Transform contentPanel;
    public GameObject itemPrefab;

    void Awake()
    {
        Instance = this;
    }

    public void DisplayData(PlayerData playerData)
    {
        // Instantiate a new item and set up the UI with player data
        GameObject newItem = Instantiate(itemPrefab, contentPanel);
        newItem.GetComponent<ItemUI>().Setup(playerData);
    }
}
