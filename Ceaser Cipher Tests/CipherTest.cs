using Ceaser_Cipher_Assignment;
using System.Reflection.Emit;

namespace Ceaser_Cipher_Tests
{
    public class Tests
    {
        Cipher cipher;
        int key;
        [SetUp]
        public void Setup()
        {
            cipher = new Cipher();
     
        }

        [Test]
        public void CipherReturnsKey()
        {

            key = 2;
            var result = cipher.CeaserCipherEncrypt(key, "abc");

            Assert.That(result, Is.EqualTo("cde"));

        }

        [Test]
        public void CipherReturnsKeyBackwards()
        {

        }


    }
}
