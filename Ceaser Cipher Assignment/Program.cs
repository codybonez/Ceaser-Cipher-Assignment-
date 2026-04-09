namespace Ceaser_Cipher_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher = new Cipher();
           Console.WriteLine( cipher.CeaserCipherEncryptFoward(5, "Joe"));
            Console.WriteLine(cipher.CeaserCipherEncryptBackward(5, "Joe"));
        }
    }
}
