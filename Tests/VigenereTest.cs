using Xunit;
using BSK.PS2;

namespace Tests
{
    public class VigenereTest
    {
        [Fact]
        public void IsSystemWork()
        {
            string input = "SUPERZAJECIA";
            string encrypted = vigenere.Encrypt(input);
            Assert.Equal(input, vigenere.Decrypt(encrypted));
        }

        private Vigenere vigenere = new Vigenere("super");
    }
}
