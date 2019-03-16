using System;
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

            RailFence railFence = new RailFence(3);
            Assert.Equal(check, railFence.Encrypt(input));
        }

        [Fact]
        public void IsDecryptionWorks()
        {
            string check = "CRYPTOGRAPHY";
            string input = "CTARPORPYYGH";
            RailFence railFence = new RailFence(3);
            Assert.Equal(check, railFence.Decrypt(input));
        }
    }
}
