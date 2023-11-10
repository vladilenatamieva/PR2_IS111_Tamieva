namespace зад3
{
    public class Encrypter
    {
        public static string Encrypt(string text)
        {
            char[] encryptedText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                encryptedText[i] = (char)(text[i] + 1);
            }

            return new string(encryptedText);
        }

        public static string Decrypt(string encryptedText)
        {
            char[] decryptedText = new char[encryptedText.Length];

            for (int i = 0; i < encryptedText.Length; i++)
            {
                decryptedText[i] = (char)(encryptedText[i] - 1);
            }

            return new string(decryptedText);
        }

            internal class Class1
        {
            public static void Main(string[] args)
            {
                string originalText = "Hello";
                string encryptedText = Encrypter.Encrypt(originalText);
                string decryptedText = Encrypter.Decrypt(encryptedText);

                Console.WriteLine($"Original Text: {originalText}");           // Output: Original Text: Hello
                Console.WriteLine($"Encrypted Text: {encryptedText}");         // Output: Encrypted Text: Ifmmp
                Console.WriteLine($"Decrypted Text: {decryptedText}");         // Output: Decrypted Text: Hello
            }
        }
    }
}

