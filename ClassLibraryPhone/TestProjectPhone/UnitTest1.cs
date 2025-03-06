using ClassLibrary;

namespace TestProjectPhone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Konstruktor_Dane_Poprawne_Ok()
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
        public void Konstruktor_ZaKrotkiNumerTelefonu_ArgumentException()
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
    }
}