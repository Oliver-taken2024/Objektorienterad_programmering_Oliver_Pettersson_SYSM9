using SlutUppgift_CookMaster.Users;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutUppgift_CookMaster.Manager
{
    public class UserManager
    {
        public ObservableCollection<User> users { get; set; } = new();


    }
}
