using NUnit.Framework;
using EncryptionService.Services;

namespace Tests
{
    [TestFixture]
    public class EncryptionServiceTests
    {
        IEncryptionService _encryptionService;

        [SetUp]
        public void Setup()
        {
            _encryptionService = new EncryptionService.Services.EncryptionService();
        }

        [Test]
        public void EncryptPassword_ReturnsEncryptedPassword()
        {
            var password = "letmein123";
            var encryptedPassword = _encryptionService.EncryptPassword(password);
            Assert.AreEqual("JEFF", encryptedPassword);
        }
    }
}