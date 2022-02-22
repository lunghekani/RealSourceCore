using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using RealSourceCore.Data;
using RealSourceCore.Models;
using RealSourceCore.Services;
using System.Web;
using Microsoft.AspNetCore.Identity;

namespace RealSourceCore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        //public OrderController(IOrderService orderService)
        //{
        //    _orderService = orderService;
        //}

        //public IActionResult Index()
        //{
        //    _orderService.GetCustomerList();
        //    return View();
        //}

        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Order> objList = _db.Orders;
            return View(objList);
        }

        //Get-Create
        public IActionResult Create()
        {
            return View();
        }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order obj)
        {
            if (ModelState.IsValid)
            {
                obj.AppUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                obj.CustomerName = User.Identity.Name;
                _db.Orders.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //Post-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteOrder(int? id)
        {
            var obj = _db.Orders.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Orders.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        //Get-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Orders.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.SaveChanges();
            return View(obj);

        }

        //Get-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Orders.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.SaveChanges();
            return View(obj);

        }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Order obj)
        {
            if (ModelState.IsValid)
            {

                _db.Orders.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
