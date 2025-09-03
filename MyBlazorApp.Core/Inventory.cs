using System;

namespace MyBlazorApp.Core;

public class Inventory
{
    public int InventoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double Price { get; set; }
}
