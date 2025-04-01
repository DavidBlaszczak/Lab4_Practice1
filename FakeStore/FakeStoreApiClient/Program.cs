//using System.Dynamic;
//using System.Text.Json;

//var httpClient = new HttpClient();
//httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");

//var response = await httpClient.GetStringAsync("products/2");

//dynamic product = JsonSerializer.Deserialize<ExpandoObject>(response);

//Console.WriteLine(product.title);

//using System.Text;

//var httpClient = new HttpClient();
//httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");
//var newProductJson = @"{
//    ""id"": 1,
//    ""title"": ""A new awesome product"",
//    ""price"": 99.99,
//    ""description"": ""A description of the awesome product"",
//    ""image"": ""https://example.com/product.jpg"",
//    ""category"": ""electronics""
//}";

//var content = new StringContent(newProductJson, Encoding.UTF8, "application/json");

//var response = await httpClient.PostAsync("products", content);
//Console.WriteLine(await response.Content.ReadAsStringAsync());

//using System.Text;
//using System.Text.Json;

//var httpClient = new HttpClient();
//httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");

//var product = new
//{
//    title = "Changed the title",
//    price = 200.12,
//    description = "Changed the description",
//    image = "fake image",
//    category = "electronics"
//};

//var json = JsonSerializer.Serialize(product);
//var content = new StringContent(json, Encoding.UTF8, "application/json");

//var response = await httpClient.PostAsync("products", content);
//Console.WriteLine(await response.Content.ReadAsStringAsync());

//using System.Text;
//using System.Text.Json;
//using FakeStoreApiClient;

//var httpClient = new HttpClient();
//httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");

//var product = new
//{
//    title = "Computer",
//    description = "A great computer",
//    category = "IT",
//    image = "fake image",
//    Price = 20
//};

//var json = JsonSerializer.Serialize(product);
//var content = new StringContent(json, Encoding.UTF8, "application/json");

//var response = await httpClient.PostAsync("products", content);

//Console.WriteLine(await response.Content.ReadAsStringAsync());

//using System.Text;
//using System.Text.Json;
//using FakeStoreApiClient;

//var httpClient = new HttpClient();
//httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");

//var json = await httpClient.GetStringAsync("products/1");
//var product = JsonSerializer.Deserialize<Product>(json);

//product.Price = 1000;

//var newJson = JsonSerializer.Serialize(product);
//var content = new StringContent(newJson, Encoding.UTF8, "application/json");
//var response = await httpClient.PutAsync("products/1", content);

//Console.WriteLine(await response.Content.ReadAsStringAsync());


using System.Net.Http.Json;
using FakeStoreApiClient;

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");

var product = await httpClient.GetFromJsonAsync<Product>("products/1");

product.Price = 1000;

var response = await httpClient.PutAsJsonAsync("products/1", product);

Console.WriteLine(await response.Content.ReadAsStringAsync());