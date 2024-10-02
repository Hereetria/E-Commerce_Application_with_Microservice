using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.BasketDtos;
using MultiShop.WebUI.Services.BasketServices;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;

namespace MultiShop.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBasketService _basketService;
        public ShoppingCartController(IProductService productService, IBasketService basketService)
        {
            _productService = productService;
            _basketService = basketService;
        }
        public async Task<IActionResult> Index(string code, int discountRate, decimal totalNewPriceWithDiscount)
        {

            ShoppingCartViewBagList(code, discountRate, totalNewPriceWithDiscount);
            var values = await _basketService.GetBasket();

            if (values == null)
            {
                return RedirectToAction("Index", "Login");
            }

            decimal totalPrice = values.TotalPrice;
            ShoppingCartResponseViewBagList(totalPrice);

            return View();
        }


        //[HttpPost]
        public async Task<IActionResult> AddBasketItem(string id)
        {
            var values = await _productService.GetByIdAsync(id);
            var items = new BasketItemDto
            {
                ProductId = values.ProductId,
                ProductName = values.ProductName,
                Price = values.ProductPrice,
                Quantity = 1,
                ProductImageUrl = values.ProductImageUrl
            };
            await _basketService.AddBasketItem(items);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveBasketItem(string id)
        {
            await _basketService.RemoveBasketItem(id);
            return RedirectToAction("Index");
        }

        private void ShoppingCartViewBagList(string code, int discountRate, decimal totalNewPriceWithDiscount)
        {
            ViewBag.code = code;
            ViewBag.discountRate = discountRate;
            ViewBag.totalNewPriceWithDiscount = totalNewPriceWithDiscount;
            ViewBag.directory1 = "Ana Sayfa";
            ViewBag.directory2 = "Ürünler";
            ViewBag.directory3 = "Sepetim";
        }

        private void ShoppingCartResponseViewBagList(decimal totalPrice)
        {
            ViewBag.total = totalPrice;
            var totalPriceWithTax = totalPrice + totalPrice / 100 * 10;
            var tax = totalPrice / 100 * 10;
            ViewBag.totalPriceWithTax = totalPriceWithTax;
            ViewBag.tax = tax;
        }
    }
}