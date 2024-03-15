using Inventory3.Models;

namespace Inventory3.Views;

public partial class Pantry : ContentPage
{
    public Pantry(Product product)
    {
        InitializeComponent();
        BindingContext = new ViewModels.CategoryPageViewModels(product, "All");
    }
    private async void ClickedOnGoBackToMainPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}