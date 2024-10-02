using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using MultiShop.DtoLayer.CommentDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;
using MultiShop.WebUI.Services.CommentServices;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
   public class ProductListController : Controller
   {
       private readonly IProductService _productService;
       private readonly ICommentService _commentService;

        public ProductListController(IProductService productService, ICommentService commentService)
        {
            _productService = productService;
            _commentService = commentService;
        }

        public IActionResult Index(string id)
       {
           ProductListViewBagList(id);
           return View();
       }

        public IActionResult ProductDetail(string id)
       {
            ProduntDetailViewBagList(id);
           return View();
       }
       [HttpGet]
       public PartialViewResult AddComment() 
       {
           return PartialView();
       }

       [HttpPost]
       public async Task<IActionResult> AddComment(CreateCommentDto createCommentDto)
       {
            createCommentDto.ImageUrl = "test";
            createCommentDto.Rating = 1;
            createCommentDto.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            createCommentDto.Status = false;
            createCommentDto.ProductId = TempData["detailId"].ToString();

            await _commentService.CreateCommentAsync(createCommentDto);
            return RedirectToAction("Index", "Default");
        }

       private void ProductListViewBagList(string id)
       {
           ViewBag.directory1 = "Ana Sayfa";
           ViewBag.directory2 = "Ürünler";
           ViewBag.directory3 = "Ürün Listesi";
           ViewBag.i = id;
       }

        private void ProduntDetailViewBagList(string id)
        {
            ViewBag.directory1 = "Ana Sayfa";
            ViewBag.directory2 = "Ürün Listesi";
            ViewBag.directory3 = "Ürün Detayları";
            ViewBag.x = id;
            TempData["detailId"] = id;
        }
    }
}
