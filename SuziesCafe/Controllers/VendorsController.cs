using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using SuziesCafe.Models;

namespace SuziesCafe.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string VendorName, string VendorDescription)
    {
      Vendor newVendor = new Vendor(VendorName, VendorDescription);
      return RedirectToAction("Index");
    }
  }

  }
