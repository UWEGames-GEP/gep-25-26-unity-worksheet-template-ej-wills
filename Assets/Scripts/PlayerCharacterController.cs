using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class PlayerCharacterController : ThirdPersonController
{
    public GameManager PauseButton;

   private void OnPause(InputValue value)
   {
    if(value.isPressed)
    {
       PauseButton.PauseOption();
       Debug.Log("pressed");
    }
   }

   private void OnRemoveItem(InputValue value)
   {
    if(value.isPressed)
    {
        Debug.Log("remove");
        GetComponent<InventorySystem>().Remove(GetComponent<InventorySystem>().items[0]);
    }
   }
}
