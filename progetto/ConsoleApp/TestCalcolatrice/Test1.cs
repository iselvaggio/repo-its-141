using LibCalcolatrice;

namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Somma(3, 5);
            Assert.AreEqual(7, risultato);
        }
    }
}
