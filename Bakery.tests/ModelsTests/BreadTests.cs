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
        Bread newBread = new Bread();
        Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    }
}