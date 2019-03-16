using Xunit;
using BSK.PS2;

namespace Tests
{
    public class MatrixSwapTest
    {

        [Fact]
        public void IsEncryptionWorks()
        {
            string check = "YCPRGTROHAYPAOS";
            string input = "CRYPTOGRAPHYOSA";
            MatrixSwap matrixSwap = new MatrixSwap(4, 3, 1, 4, 2);

            Assert.Equal(check, matrixSwap.Encrypt(input));
        }

        [Fact]
        public void IsDecryptionWorks()
        {
            string check = "CRYPTOGRAPHYOSA";
            string input = "YCPRGTROHAYPAOS";
            MatrixSwap matrixSwap = new MatrixSwap(4, 3, 1, 4, 2);

            Assert.Equal(check, matrixSwap.Decrypt(input));
        }
    
    }
}
