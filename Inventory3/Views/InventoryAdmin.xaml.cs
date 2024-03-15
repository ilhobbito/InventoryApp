namespace Inventory3.Views;

public partial class InventoryAdmin : ContentPage
{
    public Models.Product Product { get; set; }
    public InventoryAdmin(Models.Product product)
    {
        InitializeComponent();
        Product = product;
        BindingContext = new ViewModels.CategoryPageViewModels(product, "All");

        if (product != null)
        {
            ProductNameEntry.Text = product.ProductName;
            QuantityEntry.Text = product.Quantity.ToString();
            DescriptionEntry.Text = product.Description;
            PurchasingDateEntry.Text = product.PurchasingDate.ToString();
            BestBeforeEntry.Text = product.BestBefore.ToString();
        }
    }

    private async void ClickedOnAddFridgeProduct(object sender, EventArgs e)
    {
        if (Product == null)
        {
            Product = new Models.Product()
            {
                Id = Guid.NewGuid(),
                ProductName = ProductNameEntry.Text,
                Quantity = int.Parse(QuantityEntry.Text),
                Description = DescriptionEntry.Text,
                PurchasingDate = DateOnly.Parse(PurchasingDateEntry.Text),
                BestBefore = DateOnly.Parse(BestBeforeEntry.Text),
            };
        }
        else
        {
            Product.ProductName = ProductNameEntry.Text;
            Product.Quantity = int.Parse(QuantityEntry.Text);
            Product.Description = DescriptionEntry.Text;
            Product.PurchasingDate = DateOnly.Parse(PurchasingDateEntry.Text);
            Product.BestBefore = DateOnly.Parse(BestBeforeEntry.Text);
        }
        var product = Product as Models.Product;
        var place = Product as Models.Product;
        await DB.DataManager.ProductCollection().InsertOneAsync(product);
        await Navigation.PushAsync(new MainPage());
    }

    private async void ClickedOnAddFreezerProduct(object sender, EventArgs e)
    {
        if (Product == null)
        {
            Product = new Models.Product()
            {
                Id = Guid.NewGuid(),
                ProductName = ProductNameEntry.Text,
                Quantity = int.Parse(QuantityEntry.Text),
                Description = DescriptionEntry.Text,
                PurchasingDate = DateOnly.Parse(PurchasingDateEntry.Text),
                BestBefore = DateOnly.Parse(PurchasingDateEntry.Text)
            };
        }
        else
        {
            Product.ProductName = ProductNameEntry.Text;
            Product.Quantity = int.Parse(QuantityEntry.Text);
            Product.Description = DescriptionEntry.Text;
            Product.PurchasingDate = DateOnly.Parse(PurchasingDateEntry.Text);
            Product.BestBefore = DateOnly.Parse(PurchasingDateEntry.Text);
        }

        var product = Product as Models.Product;
        await DB.DataManager.ProductCollection().InsertOneAsync(product);
        await Navigation.PushAsync(new MainPage());
    }
    private async void ClickedOnAddPantryProduct(object sender, EventArgs e)
    {
        if (Product == null)
        {
            Product = new Models.Product()
            {
                Id = Guid.NewGuid(),
                ProductName = ProductNameEntry.Text,
                Quantity = int.Parse(QuantityEntry.Text),
                Description = DescriptionEntry.Text,
                PurchasingDate = DateOnly.Parse(PurchasingDateEntry.Text),
                BestBefore = DateOnly.Parse(PurchasingDateEntry.Text)
            };
        }
        else
        {
            Product.ProductName = ProductNameEntry.Text;
            Product.Quantity = int.Parse(QuantityEntry.Text);
            Product.Description = DescriptionEntry.Text;
            Product.PurchasingDate = DateOnly.Parse(PurchasingDateEntry.Text);
            Product.BestBefore = DateOnly.Parse(PurchasingDateEntry.Text);
        }

        var product = Product as Models.Product;
        await DB.DataManager.ProductCollection().InsertOneAsync(product);
        await Navigation.PushAsync(new MainPage());
    }
    private async void ClickedOnGoBackToMainMeny(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
}