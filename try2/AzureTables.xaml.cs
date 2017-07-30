
using System.Collections.Generic;
using Xamarin.Forms;

namespace try1
{
    public partial class AzureTable : ContentPage
    {

        public AzureTable()
        {
            InitializeComponent();

        }

        async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            List<CupOfCoffeeModel> notHotDogInformation = await AzureManager.AzureManagerInstance.GetCoffeeInformation();

            CoffeeList.ItemsSource = notHotDogInformation;
        }

    }
}
