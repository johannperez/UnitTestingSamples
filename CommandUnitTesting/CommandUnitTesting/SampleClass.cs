using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleLibrary
{
    public class SamlpeClass
    {
        public ICommand SampleCommand => new Command(HandleAction);
        private readonly INavigationService navigationService;

        public SamlpeClass(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        void HandleAction(object obj)
        {
            var param = new NavigationParameter()
            {
                Prop1 = "value1",
                Prop2 = "value2"
            };

            navigationService.Navigate(param);
        }

    }
}
