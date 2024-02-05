[System.Serializable]

public struct Item
{
    public string itemName;
    public int itemID;
    public int quantity;
    public Item(string name, int id, int Quantity)
    {
        itemName = name;
        itemID = id;
        quantity = Quantity;
    }
}
