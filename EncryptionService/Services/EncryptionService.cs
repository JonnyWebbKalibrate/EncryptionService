namespace EncryptionService.Services
{
    public class EncryptionService : IEncryptionService
    {
        private const int keySize = 256;
        private const int ivSize = 128;
        private const int saltSize = 256;
        private const int iterations = 1000;

        public string EncryptPassword(string password)
        {
            return "JEFF";
        }
    }
}