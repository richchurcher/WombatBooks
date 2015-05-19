using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using WombatBooks.Models;

namespace WombatBooks.Controllers
{
    public class HomeController : Controller
    {
        // Note asynchronous method/return type. Not cool to block the main thread for API stuff.
        public async Task<ViewResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.googleapis.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Likewise, note 'await' here.
                HttpResponseMessage response = await client.GetAsync("/books/v1/volumes?q=wombats");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    BookResult bookResult = new BookResult();
                    JsonConvert.PopulateObject(content, bookResult);
                    return View(bookResult);
                }

                // Handling unsuccessful responses would go here.
                return View(); 
            }
        }
    }
}