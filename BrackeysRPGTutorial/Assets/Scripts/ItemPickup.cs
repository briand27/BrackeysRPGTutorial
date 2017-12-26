using UnityEngine;

public class ItemPickup : Interactable {

    public Item item;

    public override void Interact ()
    {
        base.Interact(); // base in C# calls super class

        PickUp();
    }

    void PickUp ()
    {
        Debug.Log("Picking up " + item.name);
        // add to inventory
        bool wasPickedUp = Inventory.instance.Add(item);
        // remove game object from scene
        if (wasPickedUp)
            Destroy(gameObject);
    }

}
