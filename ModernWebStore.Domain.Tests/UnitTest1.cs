using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernWebStore.Domain.Entities;

namespace ModernWebStore.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new Category("Placa mãe");
            var product = new Product("Processador", "Intel 7 ", 1300, 5, 1);

        }
    }
}
