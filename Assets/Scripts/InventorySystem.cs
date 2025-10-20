using System;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

  

    [SerializeField] List<string> items = new List<string>();
    public   GameManager gameManager;
    

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


        if(gameManager.state == GameManager.GameStates.GamePlay)
        // if(Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     Add("something");
        // }

        // if(Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     Remove("something");
        // }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gameManager = null;
        }

    

    
    }

    void OnControllerColliderHit(ControllerColliderHit hit )
    {
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();


        if (collisionItem != null)
        {
        items.Add(collisionItem.name);
        


        Destroy(collisionItem.gameObject);
        }
    }
}
