using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuthSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using AuthSystem.Data;

namespace AuthSystem.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Donation()
        {
            return View();
        }

        public IActionResult billing()
        {
            return View();
        }
        public IActionResult Challenge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Donation(Donation ur)
        {
            string connection = "Server=tpisql01.avcol.school.nz ; Database=MVCAuthDB-Shaheer; Trusted_Connection=True;  MultipleActiveResultSets=true";


               using (SqlConnection sqlconn = new SqlConnection(connection))
                {
                 string sqlquery = "insert into [dbo].[DonationTable](Owner,Amount,CardNumber,CVV,ExpirationDate) values ('" + ur.Owner + "','" + ur.Amount + "','" + ur.CardNumber + "','" + ur.CVV + "','"+ ur.ExpirationDate + "')";
                 using (SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn))
                   {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = "The New Owner " + ur.Owner + " is saved successfully..! ";
                    
                   }
                }
            return View(ur);
        }

        [HttpPost]
        public IActionResult Challenge(Challenge op)
        {
            string connection = "Server=tpisql01.avcol.school.nz ; Database=MVCAuthDB-Shaheer; Trusted_Connection=True;  MultipleActiveResultSets=true";

            

            var students = context.Students
                              .FromSql("Select * from Students where Name = 'Bill'")
                              .ToList();

            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "insert into [dbo].[ChallengeTable](Name,Program,Email,Address,Zip,City,Country) values ('" + op.Name + "','" + op.Program + "','" + op.Email + "','" + op.Address + "','" + op.Zip + "','" + op.City + "','" + op.Country + "')";
                using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = "The New Owner " + op.Name + " is saved successfully..! ";

                }
            }
            return View(op);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
