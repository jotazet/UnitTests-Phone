using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectPhone
{
    [TestClass]
    public class ConstructorUnitTest
    {
        [DataTestMethod]
        [DataRow("Jakub", "123456789")]
        [DataRow("@", "123456789")]
        [DataRow("2", "123456789")]
        public void DaneTelefonuPoprawne(string wlasiciel, string numer)
        {
            // AAA

            // Arrange
            // Act
            var telefon = new Phone(wlasiciel, numer);
            // Assert
            Assert.AreEqual(wlasiciel, telefon.Owner);
        }

        [DataTestMethod]
        [DataRow("Jakub", "1234567890")]
        [DataRow("Jakub", "12345678")]
        [DataRow("Jakub", "")]
        [DataRow("Jakub", null)]
        [DataRow("", "123456789")]
        [DataRow(null, "123456789")]
        [DataRow("", "")]
        [DataRow(null, null)]
        [DataRow("", "1234567891")]
        [DataRow("", "12345678")]
        [DataRow(null, "12345678")]
        [DataRow(null, "1234567891")]
        [DataRow("Jakub", "12345678a")]
        public void DaneTelefonuNiepoprawne_ArgumentException(string wlasiciel, string numer)
        {
            // AAA
            // Arrange
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }
        [TestMethod]
        public void PobieranieNumeruTelefonu()
        {
            // AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            // Assert
            Assert.AreEqual(numer, telefon.PhoneNumber);
        }
        /*
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
        */
    }
}