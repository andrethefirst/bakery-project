using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PierresBakeryTests
  {
    [TestMethod]
    public void Bread_Added()
    {
     Bread addedBread = new Bread(1);
     Assert.AreEqual(typeof(Bread), addedBread.GetType());
    }

    [TestMethod]
    public void AmountOfBread()
    {
      int breadAmount =1;
      Bread addedBread = new Bread(breadAmount);
      Assert.AreEqual(1, addedBread.Amount);
    }

    [TestMethod]
    public void BreadPricingDeal()
    {
      int breadAmount = 2;
      Bread addedBread = new Bread(breadAmount);
      addedBread.BreadPrice();
      Assert.AreEqual(10, addedBread.BreadPrice());
    }

    [TestMethod]
    public void BreadPricingGetOneFree()
    {
      int breadAmount = 3;
      Bread addedBread = new Bread(breadAmount);
      addedBread.BreadPrice();
      Assert.AreEqual(10, addedBread.BreadPrice());
    }

    // [TestMethod]
    // public void Pastry_Added()
    // {
    //   Pastry addedPastry = new Pastry(1);
    //   Assert.AreEqual(typeof(Pastry), addedPastry.GetType());
    // }
  }
}