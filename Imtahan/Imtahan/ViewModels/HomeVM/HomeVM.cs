using Imtahan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan.ViewModels.HomeVM
{
    public class HomeVM
    {
        public Hero Hero { get; set; }

        public List<Service> Services { get; set; }

        public List<Client> Clients { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
