using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
    // Tests will go here!
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
        Bread newBread = new Bread(1);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AddsIDCorrectly_Bread()
    {
        Bread newBread = new Bread(3);
        Assert.AreEqual(3, newBread.Id);
    }

    [TestMethod]
    public void BreadConstructor_CalculatesPriceCorrectly_Bread()
    {
        Bread newBread = new Bread(1);
        Assert.AreEqual(5, newBread.Price);
        Bread freeBread = new Bread(3);
        Assert.AreEqual(0, freeBread.Price);
    }

    }
}