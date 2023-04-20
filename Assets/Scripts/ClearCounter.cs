using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            //There is no KitchenObject here
            if (player.HasKitchenObject())
            {
                //Player has KitchenObject
                player.GetKitchenObject().SetKitcheObjectParent(this);
            } 
            else
            {
                //Player has nothing
            }
        } else
        {
            //There is a KitchenObject here
            if (player.HasKitchenObject())
            {
                //Player has KitchenObject
               
            }
            else
            {
                //Player has nothing
                GetKitchenObject().SetKitcheObjectParent(player);
            }
        }
    }

}
