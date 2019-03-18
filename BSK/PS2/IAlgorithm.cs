namespace BSK
{
    public interface IAlgorithm
    {
        /// <summary>
        /// Encrypt string
        /// </summary>
        /// <param name="input">String to encrypt</param>
        /// <returns></returns>
        string Encrypt(string input);

        /// <summary>
        /// Decrypt string
        /// </summary>
        /// <param name="input">String to decrypt</param>
        /// <returns></returns>
        string Decrypt(string input);
    }
}
