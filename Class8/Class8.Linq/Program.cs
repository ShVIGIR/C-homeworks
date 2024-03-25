using Class8.Linq.Enum;
using Class8.Linq;
using System.Collections;
using System.Reflection;


#region List Product

List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};
#endregion
#region Methode

static void PrintProducts(List<Product> products)
{
    Console.WriteLine($"{products.Count} products:");
    foreach (Product product in products)
    {
        Console.WriteLine($"* {product.Title}");
    }
    if(products.Count == 0)
    {
        Console.WriteLine("There is not such a product.");
    }
    
    Console.WriteLine();
}
static void PrintCollectionItems(IEnumerable products)
{
    foreach (var product in products)
    {
        Console.WriteLine($"* {product} ");
    }
    Console.WriteLine();
}
#endregion
#region Tasks
//1. Retrieve all products with a price greater than $500.
List<Product> productWithPriceAbove500 = products.Where(product => product.Price > 500).ToList();
Console.Write("1) Products with a price greater than $500 - ");
//Console.WriteLine($"Number of products with price above $500: {productWithPriceAbove500.Count}");
PrintProducts(productWithPriceAbove500);

Console.ReadLine();

//2. Retrive all Skincare products.
List<Product> skinCareProducts = products.Where(product => ProductCategory.Skincare.Equals(product.Category))
    .ToList();
Console.Write("2) All Skincare produts - ");
PrintProducts(skinCareProducts);
Console.ReadLine();

//3. Retrive all products titles.
Console.Write("3) All product titles - ");
PrintProducts(products);
Console.ReadLine();

//4. Select the titles of all products in the "Laptops" category.
List<Product> titleLaptopCategory = products.Where(product => ProductCategory.Laptops.Equals(product.Category))
    .ToList();
Console.Write("4) All titles of products in \"Laptop\" category - ");
PrintProducts(titleLaptopCategory);
Console.ReadLine();


//5. Select the descriptions of all products with a stock of less than 50.
List<string> descriptionStockLessThan50 = products
    .Where(product => product.Stock < 50)
    .Select(product => $"{product.Title} {product.Description}")
    .ToList();
Console.WriteLine($"5) Descriotion of all products with a stock less then 50 - {descriptionStockLessThan50.Count} products: ");
PrintCollectionItems(descriptionStockLessThan50);
Console.ReadLine();

//6. Retrieve the titles of all products with a rating above 4.5.
List<Product> titlesOfProductRateAbove = products
    .Where(product => product.Rating > 4.5)
    .ToList();
Console.Write("6) Titles of all products with a rating above 4.5 - ");
PrintProducts(titlesOfProductRateAbove);
Console.ReadLine();

//7. Select the titles of all products with a price between 100 and 200.
List<Product> productWithPriceBetween = products
    .Where(product => product.Price > 100 && product.Price < 200)
    .ToList();
Console.Write("7) Titles of all products with a price between 100 and 200 - ");
PrintProducts(productWithPriceBetween);
Console.ReadLine();

//8. Select the titles of all products from the "Fragrances" category with a rating above 4.6.
List<Product> productFragrancesAbove = products
    .Where(product => ProductCategory.Fragrances.Equals(product.Category) && product.Rating > 4.6)
    .ToList();
Console.Write("8) Product titles from the \"Fragrances\" category with a rating above 4.6 - ");
PrintProducts(productFragrancesAbove);
Console.ReadLine();

//9. Retrieve the brands of all products with a price above 1000.
List<string> brandsPriceAbove1000 = products
    .Where(product => product.Price > 1000)
    .Select(product => product.Brand).ToList();
Console.WriteLine($"9) Brands of all products with a price above 1000 - {brandsPriceAbove1000.Count} products: ");
PrintCollectionItems(brandsPriceAbove1000);
Console.ReadLine();

//10. Select the titles of all products with the word "perfume" in the title.
List<string> titlePerfume = products.
    Where(product => product.Title.Contains("Perfume", StringComparison.OrdinalIgnoreCase))
    .Select(product => product.Title)
    .ToList();
Console.WriteLine($"10) Titles of all products with a word \"perfume\" in the title - {titlePerfume.Count} products: ");
PrintCollectionItems(titlePerfume);
Console.ReadLine();

//11. Find the last Grocery product.
List<Product> lastGrocery = products
    .Where(product => ProductCategory.Groceries.Equals(product.Category))
    .ToList();
Product lastProduct = lastGrocery.Last();
Console.WriteLine($"11) The last Grocery product is: {lastProduct.Title}.");
Console.ReadLine();

//12. Find the first product with a price above 1000.
List<Product> firstabove1000 = products
    .Where(product => product.Price > 1000)
    .ToList();
Product firstProduct = firstabove1000.First();
Console.WriteLine($"12) The first product with a price above 1000 is: {firstProduct.Title}.");
Console.ReadLine();

//13. Select the titles of all products from the "Groceries" category with a stock above 150.
List<Product> lucky13 = products
    .Where(product => product.Stock > 100 && ProductCategory.Groceries.Equals(product.Category))
    .ToList();
Console.Write("13) Titles of all products from\"Groceries\" category with a stock above 150 - ");
PrintProducts(lucky13);
Console.ReadLine();

//14. Find the first item from the brand "Hemani Tea".
List<Product> firstItemBrandTea = products
    .Where(product => product.Brand.Contains("Hemani Tea", StringComparison.OrdinalIgnoreCase))
    .ToList();
Product firstTea = firstItemBrandTea.First();
Console.WriteLine($"14) The first item from the brand \"Hemani Tea\" is: {firstTea.Title}.");
Console.ReadLine();

//15. Retrieve the ratings of all products with a stock between 30 and 50.
List<string> between30And50 = products
    .Where(product => product.Stock > 30 && product.Stock < 50)
    .Select(product => $"{product.Title} - {product.Rating}")
    .ToList();
//List<double> ratingsBetween30And50 = products.Where(product => product.Stock > 30 && product.Stock < 50).Select(product => product.Rating).ToList();
Console.WriteLine($"15) Ratings of all products with a stock between 30 and 50 - {between30And50.Count} products: ");
//PrintCollectionItems(ratingsBetween30And50);
PrintCollectionItems(between30And50);
Console.ReadLine();

//16. Find the average price of all products.
List<double> priceProductList = products
    .Select(product => product.Price)
    .ToList();
double averagePrice = priceProductList.Average();
Console.WriteLine($"16) The average price of all products is: {averagePrice}.");
Console.ReadLine();

//17. Find the total stock of all products.
List<int> totalStock = products.Select(product => product.Stock).ToList();
int total = totalStock.Sum();
Console.WriteLine($"17) Total stock of all products is: {total}.");
Console.ReadLine();

//18. Check if there is any product with price over $2000.
List<Product> chechOver2000 = products.Where(product => product.Price > 2000).ToList();
Console.Write("18) Products with price over 2000$ - ");
PrintProducts(chechOver2000);
Console.ReadLine();

//19. Find the most expensive Laptop.
List<Product> mostExpensiveLaptops = products.Where(product => ProductCategory.Laptops.Equals(product.Category)).ToList();
double maxPrice = mostExpensiveLaptops.Select(product => product.Price).Max();
var laptops = mostExpensiveLaptops.Where(product => product.Price ==  maxPrice).Select(product => product.Title).ToList();
Console.WriteLine($"19) There are {laptops.Count} laptops with max price:");
laptops.ForEach(laptop =>
Console.WriteLine($"* {laptop} - {maxPrice}"));
//foreach (var laptop in laptops)
//{
 //   Console.WriteLine($"{laptop} with a price {maxPrice}");
//}
Console.ReadLine();

//20. Retrieve the titles and descriptions of all products from the "Skincare" category.
List<Product> skincareCategoryList = products
    .Where(product => ProductCategory.Skincare.Equals(product.Category))
    .ToList();
//List<string> descriptionsOf = skincareCategoryList.Select(product => product.Description).ToList();
//List<string> titleOf = skincareCategoryList.Select(product => product.Title).ToList();
Console.WriteLine($"20) There are {skincareCategoryList.Count} products:");

skincareCategoryList
    .Select(product => $"* {product.Title}: {product.Description}") // Select title and description as a single string
    .ToList() 
    .ForEach(Console.WriteLine);
//for (int i = 0; i < skincareCategoryList.Count; i++)
//{
 //   string title = skincareCategoryList[i].Title;
 //   string description = skincareCategoryList[i].Description;
//    Console.WriteLine($"{title} {description}");
//}

Console.ReadLine();
#endregion;

