using UnityEngine;

public class ItemObject : MonoBehaviour
{

  public ItemData data;
  public string itemName => data != null ? data.itemName : "";
  public Sprite Icon => data.icon;
  public GameObject WorldPrefab => data.worldPrefab;
 public Color IconColor => data != null ? data.iconColor : Color.white;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
  

    
    }

}
