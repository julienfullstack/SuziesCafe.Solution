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
    public void ItemConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }
}

  
