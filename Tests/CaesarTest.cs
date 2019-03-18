using Xunit;
using BSK.PS2;

namespace Tests
{
    public class CaesarTest
    {
        [Fact]
        public void IsSystemWorks()
        {
            string input = "CRYPTOGRAPHY";
            string encrypted = caesar.Encrypt(input);

            Assert.Equal(input, caesar.Decrypt(encrypted));
        }

        private CaesarCipher caesar = new CaesarCipher(7, 5);
    }
}
