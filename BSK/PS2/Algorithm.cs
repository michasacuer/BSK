namespace BSK
{
    public abstract class Algorithm
    {
        /// <summary>
        /// Encrypt string
        /// </summary>
        /// <param name="input">String to encrypt</param>
        /// <returns></returns>
        public abstract string Encrypt(string input);

        /// <summary>
        /// Decrypt string
        /// </summary>
        /// <param name="input">String to decrypt</param>
        /// <returns></returns>
        public abstract string Decrypt(string input);
    }
}
