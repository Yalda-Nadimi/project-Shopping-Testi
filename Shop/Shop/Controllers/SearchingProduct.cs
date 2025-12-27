using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class SearchingProduct : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
        public static List<ShopItem> Items = AddItem.Items;
        [HttpPost]
        public IActionResult Search(string query)
        {
            List<ShopItem> results = new List<ShopItem>();

            if (!string.IsNullOrEmpty(query))
            {
                results = Items
                    .Where(x => x.Name.Contains(query, System.StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return View(results);
        }
    }
}
