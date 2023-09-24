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
    
  [TestMethod]
  public void GetName_ReturnsElements_String()
  {
    //Arrange
    string name = "Test Vendor";
    string description = "Test Description";
    Vendor newVendor = new Vendor(name, description);

    //Act
    string result = newVendor.Name;

    //Assert
    Assert.AreEqual(name, result);
  }

   
  [TestMethod]
  public void GetId_ReturnsVendorId_Int()
  {
    //Arrange
    string name = "Test Vendor";
    string description = "Test Description";
    Vendor newVendor = new Vendor(name, description);

    //Act
    int result = newVendor.Id;

    //Assert
    Assert.AreEqual(1, result);
  }

  }
}
