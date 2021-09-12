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

    [TestMethod]
    public void Pastry_Added()
    {
      Pastry addedPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), addedPastry.GetType());
    }

    [TestMethod]
    public void PastryPricing()
    {
      int pastryAmount = 1;
      Pastry addedPastry = new Pastry(pastryAmount);
      Assert.AreEqual(2, addedPastry.PastryPrice());
    }

    [TestMethod]
    public void PastryDealPricing()
    {
      int pastryAmount = 3;
      Pastry addedPastry = new Pastry(pastryAmount);
      Assert.AreEqual(5, addedPastry.PastryPrice());
    }

    [TestMethod]
    public void PastryFourPrice()
    {
      int pastryAmount = 4;
      Pastry addedPastry = new Pastry(pastryAmount);
      Assert.AreEqual(7, addedPastry.PastryPrice());
    }

    [TestMethod]
    public void PastryFivePrice()
    {
      int pastryAmount = 5;
      Pastry addedPastry = new Pastry(pastryAmount);
      Assert.AreEqual(9, addedPastry.PastryPrice());
    }

    [TestMethod]
    public void PastrySixPrice()
    {
      int pastryAmount = 6;
      Pastry addedPastry = new Pastry(pastryAmount);
      Assert.AreEqual(10, addedPastry.PastryPrice());
    }
  }
}