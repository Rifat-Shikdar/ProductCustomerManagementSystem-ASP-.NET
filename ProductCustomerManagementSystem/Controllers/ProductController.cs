using ProductCustomerManagementSystem.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductCustomerManagementSystem.DTO;

namespace ProductCustomerManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        CrudWithDTOEntities1 db = new CrudWithDTOEntities1();

        public static Product Convert(ProductDTO p)
        {
            return new Product
            {
                ProductId = p.ProductId,
                Name = p.Name,
                CategoryId = p.CategoryId,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                
            };
        }

        public static ProductDTO Convert(Product p)
        {
            return new ProductDTO
            {
                ProductId = p.ProductId,
                Name = p.Name,
                CategoryId = p.CategoryId,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
               
            };
        }

        public static List<ProductDTO> Convert(List<Product> data)
        {

            var list = new List<ProductDTO>();
            foreach (var p in data)
            {
                list.Add(Convert(p));
            }
            return list;
        }

        public ActionResult List()
        {
            var data = db.Products.ToList();
            return View(Convert(data));
        }

    }
}