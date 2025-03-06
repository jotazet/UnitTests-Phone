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
        // Stary spos�b
        [ExpectedException(typeof(ArgumentException))]
        public void Konstruktor_ZaKrotkiNumerTelefonu_ArgumentException()
        {
            // AAA

            // Arrange
            var wlasiciel = "Jakub";
            var numer = "12345678";
            // Act
            // Stary spos�b
            var telefon = new Phone(wlasiciel, numer);

            // Assert
            // Obecne rozwi�zanie
            //Assert.ThrowsException<ArgumentException>(() => new Phone(wlasiciel, numer));
        }
    }
}