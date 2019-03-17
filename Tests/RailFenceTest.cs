using BSK.PS2;
using Xunit;

namespace Tests
{
    public class RailFenceTest
    {
        [Fact]
        public void IsEncryptionWorks()
        {
            string check = "CTARPORPYYGH";
            string input = "CRYPTOGRAPHY";
            Assert.Equal(check, railFence.Encrypt(input));
        }

        [Fact]
        public void IsDecryptionWorks()
        {
            string check = "CRYPTOGRAPHY";
            string input = "CTARPORPYYGH";
            Assert.Equal(check, railFence.Decrypt(input));
        }

        [Fact]
        public void IsSystemWorks()
        {
            string input = "SUPERANCKIEZAJECIA";
            string encrypted = railFence.Encrypt(input);
            Assert.Equal(input, railFence.Decrypt(encrypted));
        }

        private RailFence railFence = new RailFence(3);
    }
}
