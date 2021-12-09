using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Donation_Managment_System
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Signup",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Signup", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "donation",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "donation", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "appointment",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "appointment", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DonationFront",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "DonationFront", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "appointment_set",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "appointment_set", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Error_Appoint",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Error_Appoint", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Reci_BloodForm",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Reci_BloodForm", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin_appointment",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Admin_appointment", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin_Blockuser",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Admin_Blockuser", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin_request",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Admin_request", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin_ManageUser",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Admin_ManageUser", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin_ViewHistory",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Admin_ManageUser", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin_Inventory",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Admin_Inventory", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Admin_ViewProff",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Admin_ViewProff", id = UrlParameter.Optional }
            );
        }
    }
}
