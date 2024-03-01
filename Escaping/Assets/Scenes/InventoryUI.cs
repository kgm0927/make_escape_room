using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool activeInventory1 = false;

    private void Start() {
        inventoryPanel.SetActive(activeInventory1);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activeInventory1 = !activeInventory1;
            inventoryPanel.SetActive(activeInventory1);
        }
    }
}
