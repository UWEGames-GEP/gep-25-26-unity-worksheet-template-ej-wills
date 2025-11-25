using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public InventorySystem inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();
  

  private void OnEnable()
  {
    RefreshInventory();
  }

  public  void RefreshInventory()
  {
    Debug.Log("Refresh Inventory UI");
  

  foreach (GameObject uiButton in inventoryUIButtons)
  {
    uiButton.gameObject.SetActive(false);
  }

  for(int i = 0; i < inventory.items.Count; i++)
  {
    if(i < inventoryUIButtons.Count )
    {
        InventoryUIButtons uiButton = inventoryUIButtons[i].GetComponent<InventoryUIButtons>();
        ItemObject item = inventory.items[i];

        uiButton.gameObject.SetActive(true);
        uiButton.SetButton(item);
    }
  }
}


 

    public void OnInventoryUIButton(int i)
    {
        inventory.Remove(i);
        RefreshInventory();
    }
}
