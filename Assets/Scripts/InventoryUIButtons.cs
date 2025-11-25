using TMPro;
using UnityEngine;

public class InventoryUIButtons : MonoBehaviour
{
    public TMP_Text text;

 public void SetButton(ItemObject item)
 {
    text.text = item.name;
 }
}
