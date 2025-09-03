using System;
using MyBlazorApp.Core;

namespace MyBlazorApp.UseCases.Inventories.Interfaces;

public interface IViewInventoriesByNameUseCase
{
    Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
}
