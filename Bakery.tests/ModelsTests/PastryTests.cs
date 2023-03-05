using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
    // Tests will go here!
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_AddsIDCorrectly_Pastry()
    {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(1, newPastry.Id);
    }

    [TestMethod]
    public void PastryConstructor_CalculatesPriceCorrectly_Pastry()
    {
        Pastry newPastry = new Pastry(1);
        Assert.AreEqual(2, newPastry.Price);
        Pastry freePastry = new Pastry(4);
        Assert.AreEqual(0, freePastry.Price);
    }

    }
}