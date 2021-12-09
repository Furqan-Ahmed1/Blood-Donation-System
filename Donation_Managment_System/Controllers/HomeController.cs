using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Donation_Managment_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult donation()
        {
            return View();
        }

        public ActionResult appointment()
        {
            return View();
        }

        public ActionResult DonationFront()
        {
            return View();
        }

        public ActionResult appointment_set()
        {
            return View();
        }

        public ActionResult Error_Appoint()
        {
            return View();
        }

        public ActionResult Reci_BloodForm()
        {
            return View();
        }

        public ActionResult recipient()
        {
            return View();
        }

        public ActionResult Admin_Blockuser()
        {
            return View();
        }
        public ActionResult Admin_appointment()
        {
            return View();
        }

        public ActionResult Admin_request()
        {
            return View();
        }

        public ActionResult Admin_ManageUser()
        {
            return View();
        }

        public ActionResult Admin_ViewHistory()
        {
            return View();
        }

        public ActionResult Admin_Inventory()
        {
            return View();
        }

        public ActionResult Admin_ViewProff()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}