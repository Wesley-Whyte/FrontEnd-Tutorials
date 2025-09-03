using System;
using MyBlazorApp.Core;
using MyBlazorApp.UseCases.Interfaces;

namespace MyBlazorApp.Plugins.InMemory;

public class InventoryRepository : IInventoryRepository
{
    private List<Inventory> _inventories;

    public InventoryRepository()
    {
        _inventories = new List<Inventory>
        {
            new Inventory { InventoryId = 1, Name = "Bike Seat", Quantity = 10, Price = 15.5 },
            new Inventory { InventoryId = 2, Name = "Bike Body", Quantity = 5, Price = 25.0 },
            new Inventory { InventoryId = 3, Name = "Bike Wheels", Quantity = 20, Price = 7.75 },
            new Inventory { InventoryId = 4, Name = "Bike Pedals", Quantity = 8, Price = 12.0 }
        };
    }
    public async Task<IEnumerable<Inventory>> GetByNameAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);
        return _inventories.Where(i => i.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
    }
}
