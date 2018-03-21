using MVC_Data;
using MVC_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.Mappers;

namespace MVC_Web.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _repository;
        public ProductController()
        {
            this._repository = new ProductRepository(new StoreDemoWithCustomerProductEntities());
        }

        public ProductController(ProductRepository customerRepository)
        {
            this._repository = customerRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            //var products = _repository.GetProducts();
            //var vModel = new ProductViewModel();
            //var orderItem = new OrderItemViewModel();

            //foreach (var item in vModel.OrderItems)
            //{
            //    item.Id = orderItem.Id;
            //    item.OrderId = orderItem.OrderId;
            //    item.ProductId = orderItem.OrderId;

            //}
            //vModel.Products = AutoMapper.Mapper.Map<ProductViewModel, Product>(products);

            //var items = AutoMapper.Mapper.Map<Product, ProductViewModel>();
            //vm.Products = M_repository.GetProducts();
            //AutoMapper.Mapper.Map<Product, ProductViewModel>(products);
            
            return View();


            
        }
    }
}