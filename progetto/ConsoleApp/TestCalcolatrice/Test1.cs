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

        //crea test per metodi di calcolatrice
        [TestMethod]
        public void TestSottrai()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Sottrai(5, 3);
            Assert.AreEqual(2, risultato);
        }
        [TestMethod]
        public void TestMoltiplica()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Moltiplica(3, 5);
            Assert.AreEqual(15, risultato);
        }
        [TestMethod]
        public void TestDividi()
        {
            var calc = new Calcolatrice();
            var risultato = calc.Dividi(10, 2);
            Assert.AreEqual(5, risultato);
        }
    }
}
