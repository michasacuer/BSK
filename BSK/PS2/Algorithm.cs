using System;

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

        /// <summary>
        /// Encrypt string that needed string key
        /// </summary>
        /// <param name="input">String to encrypt</param>
        /// <param name="key">Key used to encrypt input string</param>
        /// <returns></returns>
        public virtual string Encrypt(string input, string key)
            => throw new NotImplementedException("You need to implement this method if needed");

        /// <summary>
        /// Decrypt string that needed string key
        /// </summary>
        /// <param name="input">String to decrypt</param>
        /// <param name="key">Key used to decrypt input string</param>
        /// <returns></returns>
        public virtual string Decrypt(string input, string key)
            => throw new NotImplementedException("You need to implement this method if needed");
    }
}
