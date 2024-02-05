using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    // Start is called before the first frame update
    public string itemName;
    public int Quantity;
    public int itemID;

    InventorySystem inventorySystem;
    void Start()
    {
        inventorySystem = GameObject.FindWithTag("Player").GetComponent<InventorySystem>();
    }
    
    public void CollectItem()
    {
        Item itemToAdd= new Item(itemName, itemID, Quantity);
        inventorySystem.AddItem(itemToAdd);
        Destroy(gameObject);
    }
 
}
