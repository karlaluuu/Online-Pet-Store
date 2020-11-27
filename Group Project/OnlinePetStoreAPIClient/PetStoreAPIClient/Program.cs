using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreAPIClient
{
    class Program
    {
        static HttpClient httpClient = new HttpClient();
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            httpClient.BaseAddress = new Uri("http://onlinepetstoreinfoapi-dev.us-east-2.elasticbeanstalk.com/api/store?apikey=oM9rb985oFO537751iumLNV2l2E1kDXe");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
         //   httpClient.DefaultRequestHeaders.Add("apikey", "3J8tNRXBSSwRGuVuGWxrnwiKe1nof232");
            try
            {
                string json;
                HttpResponseMessage responseMessage;
                Console.WriteLine("Items in Database: ");
                responseMessage = await httpClient.GetAsync("");
                if(responseMessage.IsSuccessStatusCode)
                {
                    json = await responseMessage.Content.ReadAsStringAsync();
                    IEnumerable<PetStore> items = JsonConvert.DeserializeObject<IEnumerable<PetStore>>(json);
                    foreach(PetStore petStoreItems in items)
                    {
                        Console.WriteLine(petStoreItems);
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }

                //get
                Console.WriteLine("Enter Store Id: ");
                string id = Console.ReadLine();
                PetStore petStore;
                responseMessage = await httpClient.GetAsync(id);
                if(responseMessage.IsSuccessStatusCode)
                {
                    petStore = await responseMessage.Content.ReadAsAsync<PetStore>();
                    Console.WriteLine(id + " " + petStore);
                }
                else
                {
                    Console.WriteLine("Error");
                }

                //adding
                Console.WriteLine("Adding new item. Enter an id:");
                string add = Console.ReadLine();
                int a;
                int.TryParse(add, out a);

                Console.WriteLine("Store Name: ");
                string storeName = Console.ReadLine();
                Console.WriteLine("Store Description: ");
                string storeDescription = Console.ReadLine();
                Console.WriteLine("Store Address: ");
                string storeAddress = Console.ReadLine();

                PetStore newStore = new PetStore
                {
                    StoreId = a,
                    StoreName = storeName,
                    StoreDescription = storeDescription,
                    StoreAddress = storeAddress
                };

                json = JsonConvert.SerializeObject(newStore);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                responseMessage = await httpClient.PostAsync(" ", stringContent);

                Console.WriteLine($"POST: {responseMessage.StatusCode}");
                responseMessage.EnsureSuccessStatusCode();
                Console.WriteLine($"Added: {responseMessage.Headers.Location}");
                json = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine("Items added!" + json);

                //updating
                Console.WriteLine("Updating an item. Enter an id: ");
                string updating = Console.ReadLine();
                int u;
                int.TryParse(updating, out u);

                PetStore updateStore = new PetStore
                {
                    StoreId = u,
                    StoreName = "Updated",
                    StoreAddress = "Updated",
                    StoreDescription = "Updated"
                };

                json = JsonConvert.SerializeObject(updateStore);
                StringContent stringContent1 = new StringContent(json, Encoding.UTF8, "application/json");
                responseMessage = await httpClient.PutAsync(updating, stringContent1);

                responseMessage.EnsureSuccessStatusCode();
                Console.WriteLine("Update complete. Updated information below:");
                PetStore updatedPetStore;
                responseMessage = await httpClient.GetAsync(updating);
                
                if(responseMessage.IsSuccessStatusCode)
                {
                    updatedPetStore = await responseMessage.Content.ReadAsAsync<PetStore>();
                    Console.WriteLine(id + " " + updatedPetStore);
                }
                else
                {
                    Console.WriteLine("Error");
                }

                //deleting
                Console.WriteLine("Deleting item. Enter an id: ");
                string deleting = Console.ReadLine();
                int d;
                int.TryParse(deleting, out d);
                responseMessage = await httpClient.DeleteAsync(deleting);
                responseMessage.EnsureSuccessStatusCode();
                Console.WriteLine("Item " + d + "is deleted");



            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
