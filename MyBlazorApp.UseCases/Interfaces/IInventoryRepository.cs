using System;
using MyBlazorApp.Core;

namespace MyBlazorApp.UseCases.Interfaces;

public interface IInventoryRepository
{
    Task<IEnumerable<Inventory>> GetByNameAsync(string name);
}
