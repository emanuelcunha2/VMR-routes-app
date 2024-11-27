using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RouteCicleRegistrationApp
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public ICommand RouteCommand { get; set; }

        public Route() 
        {
                 
        }
    }
}
