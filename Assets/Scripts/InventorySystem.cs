using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SerializableKeyValuePair<Tkey, TValue>
{
    public Tkey Key;
    public TValue Value;
    public SerializableKeyValuePair(Tkey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}
public class InventorySystem : MonoBehaviour
{
    // Start is called before the first frame update
    public Dictionary<int, Item> inventory = new Dictionary<int, Item>();
    public List<SerializableKeyValuePair<int, Item>> inventoryList = 
        new List<SerializableKeyValuePair<int, Item>>();
    private void SyncWithListDictionary()
    {
        inventoryList.Clear();
        foreach (var pair in inventory)
        {
            inventoryList.Add(new SerializableKeyValuePair<int, Item>(pair.Key, pair.Value));
        }
    }
    public void AddItem(Item item)
    {
        if (inventory.ContainsKey(item.itemID))
        {

        }
        else
        {
            inventory.Add(item.itemID, item);
        }
        SyncWithListDictionary();
    }
    public bool RemoveItem(int itemID)
    {
        bool removed = inventory.Remove(itemID);
        if (removed)
        {

        }
        return removed;
    }

    public bool CheckItem(int itemID)
    {
        return inventory.ContainsKey(itemID);
    }
}
