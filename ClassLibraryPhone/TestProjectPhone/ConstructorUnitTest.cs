using ClassLibrary;
using System.Security.Cryptography.X509Certificates;

namespace TestProjectPhone
{
    [TestClass]
    public class ConstructorUnitTest
    {
        [TestMethod]
        public void DaneTelefonuPoprawne()
        {
            // AAA

            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            // Assert
            Assert.AreEqual(wlasiciel, telefon.Owner);
        }

        [TestMethod]
        // Stary sposób
        [ExpectedException(typeof(ArgumentException))]
        public void ZaKrotkiNumerTelefonu_ArgumentException()
        {
            // AAA

            // Arrange
            var wlasiciel = "Jakub";
            var numer = "12345678";
            // Act
            // Stary sposób
            var telefon = new Phone(wlasiciel, numer);

            // Assert
            // Obecne rozwi¹zanie
            //Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void ZaDlugiNumerTelefonu_ArgumentException()
        {
            // AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "1234567890";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void BrakWlasciciela_ArgumentException()
        {
            // AAA
            // Arrange
            var wlasiciel = "";
            var numer = "123456789";
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void NullWlasciciel_ArgumentException()
        {
            // AAA
            // Arrange
            string wlasiciel = null;
            var numer = "123456789";
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void BrakWlascicielaINumeru_ArgumentException()
        {
            // AAA
            // Arrange
            var wlasiciel = "";
            var numer = "";
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void NullWlascicielaINumeru_ArgumentException()
        {
            // AAA
            // Arrange
            string wlasiciel = null;
            string numer = null;
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void BrakNumeru_ArgumentException()
        {
            // AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "";
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void NullNumeru_ArgumentException()
        {
            // AAA
            // Arrange
            var wlasiciel = "Jakub";
            string numer = null;
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }

        [TestMethod]
        public void BrakWlascicielaINullNumeru_ArgumentException()
        {
            // AAA
            // Arrange
            var wlasiciel = "";
            string numer = null;
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }
    }
}