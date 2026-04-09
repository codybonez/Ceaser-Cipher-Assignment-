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

          
            var result = cipher.CeaserCipherEncryptFoward(3, "xyz");

            Assert.That(result, Is.EqualTo("abc"));

        }

        [Test]
        public void CipherReturnsKeyBackwards()
        {
            
            var result = cipher.CeaserCipherEncryptBackward(3, "abc");
            Assert.That(result, Is.EqualTo("xyz"));

        }

        [Test]

        public void CipherReturnsKeyFowardLong()
        {

            var result = cipher.CeaserCipherEncryptFoward(6, "The quick brown fox jumped over the lazy dog.");
            Assert.That(result, Is.EqualTo("Znk waoiq hxuct lud pasvkj ubkx znk rgfe jum."));
        }


    }
}
