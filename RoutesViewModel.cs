using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RouteCicleRegistrationApp
{
    public class RoutesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Route> Routes { get; set; }
        public ObservableCollection<Route> vs1List { get; set; }
        public ObservableCollection<Route> vs2List { get; set; }

        private DatabaseService database = new();
        public RoutesViewModel()
        {
            vs1List = database.GetRoutesBuilding("VS1");
            vs2List = database.GetRoutesBuilding("VS2"); 
            Routes = vs1List;
            SetCommands();
        } 

        public void SetCommands() 
        {
            foreach(Route route in Routes)
            {
                route.RouteCommand = new Command(() => { database.InsertRegister(route); });
            }
        }
         
        public void UpdateRoutes(string selectedBuilding)
        {
            Routes = selectedBuilding == "VS1" ? vs1List : vs2List;
            SetCommands();
            OnPropertyChanged(nameof(Routes));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
