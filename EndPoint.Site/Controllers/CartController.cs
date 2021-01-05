using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADStore.Application.Services.Carts;
using ADStore.Domain.Entities.Carts;
using EndPoint.Site.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly CookiesManeger cookiesManeger ;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
            cookiesManeger = new CookiesManeger();
        }

        public IActionResult Index()
        {
           var userId=  ClaimUtility.GetUserId(User);

           var resultGetLst=  _cartService.GetMyCart(cookiesManeger.GetBrowserId(HttpContext), userId);

            return View(resultGetLst.Data);
        }

        public IActionResult AddToCart(long ProductId)
        {
           

           var resultAdd= _cartService.AddToCart(ProductId, cookiesManeger.GetBrowserId(HttpContext));

            return RedirectToAction("Index");
        }


        public IActionResult Add(long CartItemId)
        {
            _cartService.Add(CartItemId);
            return RedirectToAction("Index");
        }  
        
        public IActionResult LowOff(long CartItemId)
        {
            _cartService.LowOff(CartItemId);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(long ProductId)
        {
            _cartService.RemoveFromCart(ProductId, cookiesManeger.GetBrowserId(HttpContext));
            return RedirectToAction("Index");

        }
    }
}
