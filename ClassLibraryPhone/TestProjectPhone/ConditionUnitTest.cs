using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectPhone
{
    [TestClass]
    public class ConditionUnitTest
    {
        [TestMethod]
        public void DodajPoprawnyKontakt()
        {
            //AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            // Assert
            Assert.IsTrue(telefon.AddContact("Test", "123456789"));
        }
        [TestMethod]
        public void LimitNumerowTelefonuPoprawny()
        {
            //AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            for (int i = 0; i < telefon.PhoneBookCapacity; i++)
            {
                telefon.AddContact(i.ToString(), i.ToString());
            }
            // Assert
            Assert.AreEqual(telefon.PhoneBookCapacity, telefon.Count);
        }
        [TestMethod]
        public void LimitNumerowTelefonuPrzekroczony_ArgumentException()
        {
            //AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            for (int i = 0; i < telefon.PhoneBookCapacity; i++)
            {
                telefon.AddContact(i.ToString(), i.ToString());
            }
            // Assert
            Assert.ThrowsException<InvalidOperationException>(() => telefon.AddContact("101", "101"));
        }
        [TestMethod]
        public void KontaktJuzIstnieje()
        {
            //AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            telefon.AddContact("Kontakt", "123456789");
            // Assert
            Assert.IsFalse(telefon.AddContact("Kontakt", "123456789"));
        }
        [TestMethod]
        public void DzwonienieOk()
        {
            //AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            telefon.AddContact("Test", "123456789");
            // Assert
            Assert.AreEqual($"Calling 123456789 (Test) ...", telefon.Call("Test"));
        }
        [TestMethod]
        public void DzwonienieBlad_ArgumentException()
        {
            //AAA
            // Arrange
            var wlasiciel = "Jakub";
            var numer = "123456789";
            // Act
            var telefon = new Phone(wlasiciel, numer);
            // Assert
            Assert.ThrowsException<InvalidOperationException>(() => telefon.Call("Test"));
        }
    }
}