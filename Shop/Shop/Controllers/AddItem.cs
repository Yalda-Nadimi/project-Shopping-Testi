using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class AddItem : Controller
    {
        public IActionResult NewItem()
        {
            return View();
        }
        public static List<ShopItem> Items = new List<ShopItem>();

        [HttpPost]
        public IActionResult NewItem(ShopItem item)
        {
            if (ModelState.IsValid)
            {
                Items.Add(item);
                TempData["SuccessMessage"] = "محصول با موفقیت سیو شد!";
                return RedirectToAction("NewItem");
            }
            return View(item);
        }

    }
}
