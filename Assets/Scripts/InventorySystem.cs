using System;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

  

    public List<ItemObject> items = new List<ItemObject>();
    public   GameManager gameManager;
    Interaction interactable;
    

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();

         Transform worldItemsTransform = GameObject.Find("WorldItems").transform;
    }

    public void Add(ItemObject item)
    {
        if(item != null)
        {
        items.Add(item);
        }
    }

  

    public void Remove(ItemObject item)
    {
        if(gameManager.state == GameStates.GamePlay && items.Count > 0)
        {
            ItemObject ittem = items[0];

            Vector3 currentPosition = transform.position;
            Vector3 forward = transform.forward;

            Vector3 newPosition = currentPosition + forward;
            newPosition += new Vector3(0,1,0);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = currentRotation * Quaternion.Euler(0,0,180);

            GameObject newItem = Instantiate(ittem.gameObject, newPosition, newRotation, worldItemsTransform);
            //newItem.setActive(true);
        
            items.Remove(ittem);
            Destroy(item.gameObject);
        
        }
    }


   

    // Update is called once per frame
    void Update()
    {


       

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gameManager = null;
        }

    

    
    }

    // void OnControllerColliderHit(ControllerColliderHit hit )
    // {
    //     ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();


    //     if (collisionItem != null)
    //     {
    //     items.Add(interactable.name);
        


    //     Destroy(interactable.gameObject);
    //     }
    // }

    //  public void Item(ItemObject item)
    //  {
    //     items.Add(item.name);

    // }
}
