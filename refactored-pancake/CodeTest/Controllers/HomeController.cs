using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using PruebaIngreso.ExternalServices;
using PruebaIngreso.ExternalServices.Component;
using PruebaIngreso.ExternalServices.ExternalServices.Client;
using Quote.Contracts;
using Quote.Models;

namespace PruebaIngreso.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuoteEngine quote;

        /// <summary>
        /// Dependica de cliente de consumo de api para obtener magernes
        /// </summary>
        private readonly MarginApiProvider _marginApiClient;
        public HomeController(IQuoteEngine quote)
        {
            this.quote = quote;
            _marginApiClient = new MarginApiProvider();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            var request = new TourQuoteRequest
            {
                adults = 1,
                ArrivalDate = DateTime.Now.AddDays(1),
                DepartingDate = DateTime.Now.AddDays(2),
                getAllRates = true,
                GetQuotes = true,
                RetrieveOptions = new TourQuoteRequestOptions
                {
                    GetContracts = true,
                    GetCalculatedQuote = true,
                },
                TourCode = "E-U10-PRVPARKTRF",
                Language = Language.Spanish
            };

            var result = this.quote.Quote(request);
            var tour = result.Tours.FirstOrDefault();
            ViewBag.Message = "Test 1 Correcto";
            return View(tour);
        }

        public ActionResult Test2()
        {
            ViewBag.Message = "Test 2 Correcto";
            return View();
        }

        public async Task<ActionResult> Test3()
        {
            var result = 0.0m;
            var marginResult = await _marginApiClient.GetMarginAsync("E-U10-PRVPARKTRF");
            if (marginResult.Status == HttpStatusCode.OK)
            {
                result = marginResult.Margin;
            }
            return View(result);
        }

        public async Task<ActionResult> Test4()
        {
            var request = new TourQuoteRequest
            {
                adults = 1,
                ArrivalDate = DateTime.Now.AddDays(1),
                DepartingDate = DateTime.Now.AddDays(2),
                getAllRates = true,
                GetQuotes = true,
                RetrieveOptions = new TourQuoteRequestOptions
                {
                    GetContracts = true,
                    GetCalculatedQuote = true,
                },
                Language = Language.Spanish
            };

            var marginProviderDecaratorPlus = new MarginProviderDecaratorPlus(_marginApiClient);
            var marginResult = await marginProviderDecaratorPlus.GetMarginAsync("E-U10-PRVPARKTRF", 0);
            var result = this.quote.Quote(request);
            return View(result.TourQuotes);
        }
    }
}