using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIButtons : MonoBehaviour
{
    public TMP_Text text;
    public Image iconImage;
    public ItemData data;
  
 public void SetButton(ItemObject item)
 {
    text.text = item.data.name;
    
    iconImage.sprite = item.data.icon;
    iconImage.enabled = true;
      iconImage.color = item.data.iconColor;
 }
}
