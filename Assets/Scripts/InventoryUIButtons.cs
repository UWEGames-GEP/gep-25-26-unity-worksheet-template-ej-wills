using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIButtons : MonoBehaviour
{
    public TMP_Text text;
    public Image iconImage;
    public ItemData data;
  
 public void SetButton(InventorySlot slot)
 {
    text.text = slot.item.name + "x" + slot.amount;
    
    iconImage.sprite = slot.item.icon;
    iconImage.enabled = true;
      iconImage.color = slot.item.iconColor;
 }
}
