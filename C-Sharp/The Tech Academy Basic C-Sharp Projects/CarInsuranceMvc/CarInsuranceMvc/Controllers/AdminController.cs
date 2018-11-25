using CarInsuranceMvc.Models;
using CarInsuranceMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceMvc.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var quotes = db.Quotes.ToList();
                var quoteVms = new List<QuoteVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.Id = quote.Id;
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.Quotation = quote.Quotation;
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}