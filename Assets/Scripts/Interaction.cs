using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{

   [SerializeField] private LayerMask interactableLayer;
    private PlayerInput _playerInput;
    private Transform _transform;
   [SerializeField] InventorySystem items;
   public Interactables interactable;
   ItemObject objects;
    public List<string> item = new List<string>();

    private void Awake()
   {
      _transform = transform;
      _playerInput = GetComponent<PlayerInput>();
   }

   private void OnEnable()
   {
      _playerInput.actions["Interact"].performed += DoInteract;
   }

   private void OnDisable()
   {
    _playerInput.actions["Interact"].performed -= DoInteract;
   }

   private void DoInteract(InputAction.CallbackContext callbackContext)
   {
      if(!Physics.Raycast(_transform.position + (_transform.forward * .2f), _transform.forward, out var hit, 1.5f, interactableLayer)) return;


      if(!hit.transform.TryGetComponent(out  interactable)) return;


    

    interactable.Interact();
      objects = interactable.GetComponent<ItemObject>();
     // items.Add(objects.name);
        items.Item(objects);
      Debug.Log("Interact");
   }
}
