using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=TRY&q=1.0"),
                Headers =
                {
                 { "X-RapidAPI-Key", "da4c4353e1mshe701c3dc6cbccf3p12ec5djsn2346aa10286f" },
                    { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ViewBag.UsdToTry=body;

            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=TRY&q=1.0"),
                Headers =
                {
                 { "X-RapidAPI-Key", "da4c4353e1mshe701c3dc6cbccf3p12ec5djsn2346aa10286f" },
                    { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
                    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ViewBag.EurToTry = body2;

            }
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=TRY&q=1.0"),
                Headers =
                {
                 { "X-RapidAPI-Key", "da4c4353e1mshe701c3dc6cbccf3p12ec5djsn2346aa10286f" },
                    { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
                    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ViewBag.GbpToTry = body3;

            }
            return View();
        }
    }
}