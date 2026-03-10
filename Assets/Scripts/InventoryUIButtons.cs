using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIButtons : MonoBehaviour
{
    public TMP_Text text;
    public Image iconImage;
    public ItemData data;

    private int slotIndex;
    private InventoryUI inventoryUI;
  
 public void SetButton(InventorySlot slot, int index, InventoryUI ui)
 {

   slotIndex =index;
   inventoryUI = ui;


   if(slot == null || slot.item == null) return;

    text.text = slot.item.name + "   x " + slot.amount;
    
    iconImage.sprite = slot.item.icon;
    iconImage.enabled = true;
      iconImage.color = slot.item.iconColor;
 }


 public void onClick()
 {
   inventoryUI.OnInventoryUIButton(slotIndex);
 }
}
