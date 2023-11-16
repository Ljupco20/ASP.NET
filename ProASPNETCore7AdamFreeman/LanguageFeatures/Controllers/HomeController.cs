namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var products = new[]
            {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }

            };
            //return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}

//public async Task<ViewResult> Index()
//{
//    List<string> output = new List<string>();

//    await foreach (long? len in MyAsyncMethods.GetPageLengths(output, "manning.com", "microsoft.com", "amazon.com"))
//    {
//        output.Add($"Page length: {len}");
//    }

//    return View(output);
//}

//public async Task<ViewResult> Index()
//{
//    List<string> output = new List<string>();

//    foreach (long? len in await MyAsyncMethods.GetPageLengths(output, "manning.com", "microsoft.com", "amazon.com"))
//    {
//        output.Add($"Page length: {len}");
//    }

//    return View(output);
//}

//public async Task<ViewResult> Index()
//{
//    long? length = await MyAsyncMethods.GetPageLength();
//    return View(new string[] { $"Length: {length}" });
//}


//public ViewResult Index()
//{
//    IProductSelection cart = new ShoppingCart(

//            new Product { Name = "Kayak", Price = 275M },
//            new Product { Name = "Lifejacket", Price = 48.95M },
//            new Product { Name = "Soccer ball", Price = 19.50M },
//            new Product { Name = "Corner flag", Price = 34.95M }

//        );
//    return View(cart.Names);
//}



//public ViewResult Index()
//           => View(Product.GetProducts().Select(p => p?.Name));



//public ViewResult Index()
//{
//    return View(Product.GetProducts().Select(p => p?.Name));
//}



////bool FilterByPrice(Product? p)
////{
////    return (p?.Price ?? 0) >= 20;
////}
//public ViewResult Index()
//{


//    ShoppingCart cart = new ShoppingCart
//    {
//        Products = Product.GetProducts()
//    };

//    Product[] productArray =
//    {
//        new Product
//        {
//            Name = "Kayak",
//            Price = 275M
//        },
//        new Product
//        {
//            Name = "Lifejacket",
//            Price = 48.95M
//        },
//        new Product {Name = "Soccer ball", Price = 19.50M},
//        new Product {Name = "Corner flag", Price = 34.95M}
//    };

//    //Func<Product?, bool> nameFilter = delegate (Product? prod)
//    //{
//    //    return prod?.Name?[0] == 'S';
//    //};


//    decimal priceFilterTotal = productArray
//        .Filter(p => (p?.Price ?? 0) >= 20)
//        .TotalPrices();

//    decimal nameFilterTtotal = productArray
//        .Filter(p => p?.Name[0] == 'S')
//        .TotalPrices();

//    return View("Index", new string[]
//    {
//        $"Price Total: {priceFilterTotal:C2}",
//        $"Name Total: {nameFilterTtotal:C2}"
//    });
//}























//public ViewResult Index()
//{


//    ShoppingCart cart = new ShoppingCart
//    {
//        Products = Product.GetProducts()
//    };

//    Product[] productArray =
//    {
//        new Product
//        {
//            Name = "Kayak",
//            Price = 275M
//        },
//        new Product
//        {
//            Name = "Lifejacket",
//            Price = 48.95M
//        },
//    };

//    decimal cartTotal = cart.TotalPrices();
//    decimal arrayTotal = productArray.TotalPrices();

//    return View("Index", new string[]
//    {
//        $"Cart Total: {cartTotal:C2}",
//        $"Array Total: {arrayTotal : C2}"
//    });
//}