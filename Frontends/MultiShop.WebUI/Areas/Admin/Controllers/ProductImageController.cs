using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.ProductImageDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductImageServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/ProductImage")]
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [Route("ProductImageDetail/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateProductImageDetail(string id)
        {
            ProductImageViewBagList();
            var values = _productImageService.GetByIdAsync(id);
            return View(values);


        }
        [Route("ProductImageDetail/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateProductImageDetail(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateAsync(updateProductImageDto);
            return RedirectToAction("Index", "FeatureSlider", new { area = "Admin" });
        }

        private void ProductImageViewBagList()
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Ürünler";
            ViewBag.v3 = "Ürün Görsel Güncelleme Sayfası";
            ViewBag.v0 = "Ürün Görsel İşlemleri";
        }
    }
}
