using RealSourceCore.Data;
using RealSourceCore.Models.ViewModels;
using RealSourceCore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RealSourceCore.Services
{
    public class OrderService : IOrderService
    {
        
        private readonly ApplicationDbContext  _db;

        public OrderService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<CustomerVM> GetCustomerList()
        {
            var customers = (from u in _db.Users
                             join userRoles in _db.UserRoles on u.Id equals userRoles.UserId
                             join roles in _db.Roles.Where(r => r.Name ==Helper.Customer) on userRoles.RoleId equals roles.Id
                             select new CustomerVM
                             {
                                 Id = u.Id,
                                 Name = u.Name
                             }).ToList();
            return customers;
        }

        public List<WriterVM> GetWriterList()
        {
            var writers = (from u in _db.Users
                             join userRoles in _db.UserRoles on u.Id equals userRoles.UserId
                             join roles in _db.Roles.Where(r => r.Name == Helper.Writer) on userRoles.RoleId equals roles.Id
                             select new WriterVM
                             {
                                 Id = u.Id,
                                 Name = u.Name
                             }).ToList();
            return writers;
        }

        public List<WriterVM> GetUserList(string role)
        {
            var writers = (from u in _db.Users
                           join userRoles in _db.UserRoles on u.Id equals userRoles.UserId
                           join roles in _db.Roles.Where(r => r.Name == role) on userRoles.RoleId equals roles.Id
                           select new WriterVM
                           {
                               Id = u.Id,
                               Name = u.Name
                           }).ToList();
            return writers;
        }
    }
}
