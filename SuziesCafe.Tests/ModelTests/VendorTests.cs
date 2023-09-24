using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuziesCafe.Models;
using System.Collections.Generic;
using System;

namespace SuziesCafe.Tests
{
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    
  }
}
