using UnityEngine;


[CreateAssetMenu(menuName = "Inventory/Item")]

public class ItemData : ScriptableObject
{

    public string itemName;
    public Sprite icon;
    public GameObject worldPrefab;
   public Color iconColor = Color.white; 

   
}
