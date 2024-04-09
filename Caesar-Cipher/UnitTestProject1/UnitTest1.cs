using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string noncrypt_word = "боб";
            string crypted_word = "впв";
            string decrypted_word = "боб";

            int key = 1;

            Practicum.Form1 f = new Practicum.Form1();

            string result_crypt = f.Crypt(key, noncrypt_word); //боб -> впв, сравниваем впв с тем что должно быть

            Assert.AreEqual(result_crypt, crypted_word);//  тест шифрования
        }
        [TestMethod]
        public void TestMethod2()
        {
            string noncrypt_word = "боб";
            string crypted_word = "впв";
            string decrypted_word = "боб";

            int key = 1;

            Practicum.Form1 f = new Practicum.Form1();
  
            string result_decrypt = f.Decrypt(key, crypted_word);//впв -> боб, сравниваем с тем что должно быть
   
            Assert.AreEqual(result_decrypt, decrypted_word);// тест дешифрования
        }
        [TestMethod]
        public void TestMethod3()
        {
            string noncrypt_word = "ракета";
            string crypted_word = "угнихг";
            string decrypted_word = "ракета";

            int key = 3;

            Practicum.Form1 f = new Practicum.Form1();

            string result_decrypt = f.Decrypt(key, crypted_word);

            Assert.AreEqual(result_decrypt, decrypted_word);// тест дешифрования
        }
        [TestMethod]
        public void TestMethod4()
        {
            string noncrypt_word = "программа";

            int key = 5;
            string crypted_word = "фхуихессе";//с ключом 5 будет

            int key_2 = 4;
            string decrypted_word = "рспдсбннб";//с ключом 4

            

            Practicum.Form1 f = new Practicum.Form1();

            string result_crypt = f.Crypt(key, noncrypt_word); 
            string result_decrypt = f.Decrypt(key_2, crypted_word);

            Assert.AreEqual(result_crypt, crypted_word);//  тест шифрования
            Assert.AreEqual(result_decrypt, decrypted_word);// тест дешифрования
        }
        [TestMethod]
        public void TestMethod5()
        {
            string noncrypt_word = "программа";

            int key = 5;
            string crypted_word = "фхуихессе";//с ключом 5 будет

            int key_2 = 4;
            string decrypted_word = "рспдсбннб";//с ключом 4



            Practicum.Form1 f = new Practicum.Form1();

            string result_crypt = f.Crypt(key, noncrypt_word);
            string result_decrypt = f.Decrypt(key, crypted_word); //о нееет здесь ошибка и отправили не ключ = 4 а ключ = 5, поэтому этот тест провален

            Assert.AreEqual(result_crypt, crypted_word);//  тест шифрования
            Assert.AreEqual(result_decrypt, decrypted_word);// тест дешифрования
        }
    }
}
