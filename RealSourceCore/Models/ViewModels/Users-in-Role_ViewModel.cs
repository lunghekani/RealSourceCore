using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace RealSourceCore.Models.ViewModels
{
    public class Users_in_Role_ViewModel
    {
        public IQueryable UsersList { get; set; }
        public IQueryable UsersRoles { get; set; }
       
    }
}
