using System;
using MyBlazorApp.Core;
using MyBlazorApp.UseCases.Interfaces;
using MyBlazorApp.UseCases.Inventories.Interfaces;

namespace MyBlazorApp.UseCases.Inventories;

public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
{
    private readonly IInventoryRepository _inventoryRepository;
    public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
    {
        return await _inventoryRepository.GetByNameAsync(name);
    }
}
