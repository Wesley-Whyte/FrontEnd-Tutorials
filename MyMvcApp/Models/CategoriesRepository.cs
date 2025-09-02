using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcApp.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>
        {
            new Category { CategoryId = 1, Name = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" },
            new Category { CategoryId = 2, Name = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" },
            new Category { CategoryId = 3, Name = "Bakery", Description = "Desserts, candies, and sweet breads" },
            new Category { CategoryId = 4, Name = "Dairy Products", Description = "Cheeses" },
            new Category { CategoryId = 5, Name = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" },
            new Category { CategoryId = 6, Name = "Meat/Poultry", Description = "Prepared meats" },
            new Category { CategoryId = 7, Name = "Produce", Description = "Dried fruit and bean curd" },
            new Category { CategoryId = 8, Name = "Seafood", Description = "Seaweed and fish" }
        };

        public static List<Category> GetCategories()
        {
            return _categories;
        }

        public static void AddCategory(Category category)
        {
            category.CategoryId = _categories.Max(c => c.CategoryId) + 1;
            _categories.Add(category);
        }

        public static Category? GetCategoryById(int id)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };
            }
            return null;
        }

        public static void UpdateCategory(Category category)
        {
            var existingCategory = _categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
            }
        }

        public static void DeleteCategory(int id)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}