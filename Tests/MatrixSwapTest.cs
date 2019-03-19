using Xunit;
using BSK.PS2;

namespace Tests
{
    public class MatrixSwapTest
    {
        [Fact]
        public void IsEncryptionWorksINT()
        {
            string check = "YCPRGTROHAYPAO S";
            string input = "CRYPTOGRAPHYOSA";
            Assert.Equal(check, matrixSwap.Encrypt(input));
        }

        [Fact]
        public void IsDecryptionWorksINT()
        {
            string check = "CRYPTOGRAPHYOSA";
            string input = "YCPRGTROHAYPAO S";
            Assert.Equal(check, matrixSwap.Decrypt(input));
        }

        [Fact]
        public void IsSystemWorksINT()
        {
            string input = "SUPERANCKIEZAJECIA";
            string encrypted = matrixSwap.Encrypt(input);
            Assert.Equal(input, matrixSwap.Decrypt(encrypted));
        }

        [Fact]
        public void IsSystem2bWorking()
        {
            string input = "NAM STRZELAC NIE KAZANO WSTAPILEM NA DZIALO TYSIAC ARMAT GRZMIALO";
            string encrypted = matrixSwapString.Encrypt(input);
            Assert.Equal(input, matrixSwapString.Decrypt(encrypted));
        }

        private MatrixSwapInt matrixSwap = new MatrixSwapInt(4, 3, 1, 4, 2);
        private MatrixSwapString matrixSwapString = new MatrixSwapString("ROWER");
    }
}
