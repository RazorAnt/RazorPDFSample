using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorPDF;
using RazorPDFSample.Models;

namespace RazorPDFSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to RazorPDF Sample";

            return View();
        }

        public ActionResult About()
        {
            if (Request.QueryString["format"] == "pdf")
            {
                return new PdfResult(null, "About");
            }

            return View();
        }

        public PdfResult Pdf()
        {
            // With no Model and default view name.  Pdf is always the default view name
            return new PdfResult();
        }

        public ActionResult PdfModel(string id)
        {
            // Since type is an ActionResult, we can still return an html view if something isn't right
            if (id != "yoda")
                return View("NotFound");

            // get Person
            var person = new Person();
            person.UserName = id;
            person.LuckyNumber = 7;

            // pass in Model, then View name
            var pdf = new PdfResult(person, "PdfModel");

            // Add to the view bag
            pdf.ViewBag.Title = "Title from ViewBag";

            return pdf;
        }

        public PdfResult PdfTake3(string id)
        {
            var person = new Person() { UserName = id, LuckyNumber = 17 };

            return new PdfResult(person, "PdfModel");
        }

        public ActionResult HtmlReport()
        {
            // Setup sample model
            var list = new List<Person>();
            for (int i = 1; i < 10; i++)
                list.Add(new Person() { UserName = "Person " + i, LuckyNumber = i });

            // Output to Pdf?
            if (Request.QueryString["format"] == "pdf")
                return new PdfResult(list, "HtmlReport");

            return View(list);
        }

        public ActionResult ReportSample()
        {
            var list = new List<Person>();

            for (int i = 1; i < 10; i++)
                list.Add(new Person() { UserName = "Person " + i.ToString(), LuckyNumber = i });

            var pdf = new PdfResult(list, "ReportSample");
            pdf.ViewBag.Title = "Report Title";

            return pdf;
        }
    }
}
