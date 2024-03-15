using Inventory3.Models;

namespace Inventory3.Views;

public partial class Freezer : ContentPage
{
    public Freezer(Product product)
    {
        InitializeComponent();
        BindingContext = new ViewModels.CategoryPageViewModels(product, "All");
    }
    private async void ClickedOnGoBackToStart(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}