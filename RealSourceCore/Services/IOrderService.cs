using RealSourceCore.Models.ViewModels;
using System.Collections.Generic;

namespace RealSourceCore.Services
{
    public interface IOrderService
    {
        public List<CustomerVM> GetCustomerList();
        public List<WriterVM> GetWriterList();
    }
}
