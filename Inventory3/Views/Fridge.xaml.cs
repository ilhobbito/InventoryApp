using Inventory3.Models;

namespace Inventory3.Views;

public partial class Fridge : ContentPage
{
    public Fridge(Product product)
    {
        InitializeComponent();
        BindingContext = new ViewModels.CategoryPageViewModels(product, "All");
    }
    private async void ClickedOnGoBackToHome(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}