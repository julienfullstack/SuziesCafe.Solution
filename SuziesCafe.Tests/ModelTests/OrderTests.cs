using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SuziesCafe.Models;
using System;

namespace SuziesCafe.Tests
{
    [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDetails_String()
    {
      //Arrange
      string title = "";
      string description = "";
      int price = 0;
      string date = "";

      //Act
      Order newOrder = new Order(title, description, price, date);
       string titleResult = newOrder.Title;
       string descriptionResult = newOrder.Description;
      int priceResult = newOrder.Price;
      string dateResult = newOrder.Date;

      //Assert
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, descriptionResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);

    }


  }
}

  
