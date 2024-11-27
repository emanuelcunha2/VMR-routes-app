using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RouteCicleRegistrationApp
{
    public partial class MainPage : ContentPage
    { 
        public MainPage()
        { 
            InitializeComponent();
            BuildingPicker.SelectedIndex = 0;
        }

        private void OnBuildingPickerSelected(object sender, EventArgs e)
        {
            if (BindingContext is RoutesViewModel viewModel && BuildingPicker.SelectedItem is string selectedBuilding)
            {
                viewModel.UpdateRoutes(selectedBuilding);
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.IsEnabled = false;
                await Task.Delay(10000);
                btn.IsEnabled = true;
            }
        }
    }
}
