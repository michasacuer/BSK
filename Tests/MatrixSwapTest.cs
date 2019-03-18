using Xunit;
using BSK.PS2;

namespace Tests
{
    public class MatrixSwapTest
    {
        [Fact]
        public void IsEncryptionWorks()
        {
            string check = "YCPRGTROHAYPAO S";
            string input = "CRYPTOGRAPHYOSA";
            Assert.Equal(check, matrixSwap.Encrypt(input));
        }

        [Fact]
        public void IsDecryptionWorks()
        {
            string check = "CRYPTOGRAPHYOSA";
            string input = "YCPRGTROHAYPAO S";
            Assert.Equal(check, matrixSwap.Decrypt(input));
        }

        [Fact]
        public void IsSystemWorks()
        {
            string input = "SUPERANCKIEZAJECIA";
            string encrypted = matrixSwap.Encrypt(input);
            Assert.Equal(input, matrixSwap.Decrypt(encrypted));
        }

        private MatrixSwap matrixSwap = new MatrixSwap(5, 3, 4, 1, 5, 2);
    }
}
