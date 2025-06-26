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
            Assert.AreEqual(8, risultato);
        }

        [TestMethod]
        public void TestSommaZero()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Somma(3, 0);
            Assert.AreEqual(3, risultato);
        }

        [TestMethod]
        public void TestSommaRelativo()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Somma(3, -1);
            Assert.AreEqual(2, risultato);
        }
    }
}
