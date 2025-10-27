using System;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

  

    public List<string> items = new List<string>();
    public   GameManager gameManager;
    Interaction interactable;
    

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    public void Add(string ItemName)
    {
        items.Add(ItemName);
        
    }

  

    public void Remove(string ItemName)
    {
        items.Remove(ItemName);
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

     public void Item()
     {
        items.Add(interactable.name);

    }
}
