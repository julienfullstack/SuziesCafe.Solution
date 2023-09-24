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

    [TestMethod]
  public void Find_ReturnsCorrectVendor_Vendor()
  {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    string description01 = "Test Description";
    string description02 = "Test Description";
    Vendor newVendor1 = new Vendor(name01, description01);
    Vendor newVendor2 = new Vendor(name02, description02);

    //Act
    Vendor result = Vendor.Find(2);

    //Assert
    Assert.AreEqual(newVendor2, result);
  }

  }
}
