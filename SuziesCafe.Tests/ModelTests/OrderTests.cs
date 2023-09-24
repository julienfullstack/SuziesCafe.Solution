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

        [TestMethod]
    public void SetElements_SetOrderElements()
    {
      //Arrange
      string title = "result";
      string description = "test";
      int price = 0;
      string date = "";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedTitle = "result";
      string updatedDescription = "result";
      int updatedPrice = 0;
      string updatedDate = "";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;
      newOrder.Price = updatedPrice;
      newOrder.Date = updatedDate;
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      int priceResult = newOrder.Price;
      string dateResult = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedTitle, titleResult);
      Assert.AreEqual(updatedDescription, descriptionResult);
      Assert.AreEqual(updatedPrice, priceResult);
      Assert.AreEqual(updatedDate, dateResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title01 = "title01";
      string title02 = "title02";
      string description01 = "description01";
      string description02 = "description02";
      int price01 = 0;
      int price02 = 1;
      string date01 = "date01";
      string date02 = "date02";
      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "title1";
      string description = "description1";
      int price = 0;
      string date = "date1";
      Order newOrder = new Order(title, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

      [TestMethod]
  public void Find_ReturnsCorrectOrder_Order()
  {
    //Arrange
    string title01 = "title01";
    string title02 = "title02";
    string description01 = "description01";
    string description02 = "description02";
    int price01 = 0;
    int price02 = 1;
    string date01 = "date01";
    string date02 = "date02";
    Order newOrder1 = new Order(title01, description01, price01, date01);
    Order newOrder2 = new Order(title02, description02, price02, date02);

    //Act
    Order result = Order.Find(2);

    //Assert
    Assert.AreEqual(newOrder2, result);
  }

  }
}

  
