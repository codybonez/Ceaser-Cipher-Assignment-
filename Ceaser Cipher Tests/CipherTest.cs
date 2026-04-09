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
        public void CipherReturnsKeyFowards()
        {

            key = 2;
            var result = cipher.CeaserCipherEncryptFoward(key, "xyz");

            Assert.That(result, Is.EqualTo("abc"));

        }

        [Test]
        public void CipherReturnsKeyBackwards()
        {
            key = 2;
            var result = cipher.CeaserCipherEncryptBackward(key, "abc");
            Assert.That(result, Is.EqualTo("xyw"));

        }


    }
}
