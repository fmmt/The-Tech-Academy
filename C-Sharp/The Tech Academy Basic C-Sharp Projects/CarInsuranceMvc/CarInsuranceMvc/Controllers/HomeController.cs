using CarInsuranceMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, 
                                        int carYear, string carMake, string carModel, bool dui, int speedingTickets, bool fullCoverage)
        {
            if(carYear < 0 || carYear > DateTime.Now.Year || speedingTickets < 0)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                // Start with a base of $50 / month.
                double total = 50;

                // If the user is under 18, add $100 to the monthly total.
                // If the user is under 25, add $25 to the monthly total.
                // If the user is over 100, add $25 to the monthly total.
                int age = DateTime.Today.Year - dateOfBirth.Year;
                if(dateOfBirth > DateTime.Today.AddYears(-age)){age -= 1;}
                if (age < 18)
                {
                    total += 100;
                }
                else if(age < 25)
                {
                    total += 25;

                }
                else if(age > 100)
                {
                    total += 25;
                }

                // If the car's year is before 2000, add $25 to the monthly total.
                // If the car's year is after 2015, add $25 to the monthly total.
                if (carYear < 2000)
                {
                    total += 25;
                }
                else if(carYear >= 2015)
                {
                    total += 25;
                }

                // If the car's Make is a Porsche, add $25 to the price.
                // If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                if (carMake.ToLower() == "porsche")
                {
                    total += 25;
                    if (carModel.Replace(" ","").ToLower() == "911carrera" || carModel.Replace(" ", "").ToLower() == "carrera911")
                    {
                        total += 25;
                    }
                }

                // Add $10 to the monthly total for every speeding ticket the user has.
                total += speedingTickets * 10;

                // If the user has ever had a DUI, add 25 % to the total.
                if (dui)
                {
                    total *= 1.25;
                }

                // If it's full coverage, add 50% to the total.
                if (fullCoverage)
                {
                    total *= 1.50;
                }

                try
                {
                    using (CarInsuranceEntities db = new CarInsuranceEntities())
                    {
                        var quote = new Quote();
                        quote.FirstName = firstName;
                        quote.LastName = lastName;
                        quote.EmailAddress = emailAddress;
                        quote.DateOfBirth = dateOfBirth;
                        quote.CarYear = carYear;
                        quote.CarMake = carMake;
                        quote.CarModel = carModel;
                        quote.DUI = dui;
                        quote.SpeedingTickets = speedingTickets;
                        quote.FullCoverage = fullCoverage;
                        quote.Quotation = (decimal)total;

                        db.Quotes.Add(quote);
                        db.SaveChanges();
                    }
                }
                catch
                {
                    return View("~/Views/Shared/Error.cshtml");
                }

                return View("Success", total);
            }
        }

        public ActionResult Success(double quote)
        {
            return View(quote);
        }
    }
}
