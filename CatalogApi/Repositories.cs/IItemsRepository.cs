using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
  public interface IItemsRepository
    {
        Item GetItems(Guid id);
        IEnumerable<Item> GetItems();
        
    }
}