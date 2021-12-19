using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class UserTest
    {

        User User;
        int IdUser;
        string Nickname;
        string FirstName;
        string LastName;
        string BioDesc;
        string Email;
        string Password;
        DateTime RegDate;


        [SetUp]
        public void Setup()
        {
            IdUser = 1;
            Nickname = "nick";
            FirstName = "first";
            LastName = "last";
            BioDesc = "bio";
            Email = "somemail@gmail.com";
            Password = "password";
            RegDate = DateTime.Now;
            User = new User(IdUser, Nickname, FirstName, LastName, BioDesc, Email, Password, RegDate);
        }

        [Test]
        public void IdUserTest()
        {
            Assert.AreEqual(1, User.IdUser);
            User.IdUser = 2;
            Assert.AreEqual(2, User.IdUser);
        }

        [Test]
        public void NicknameTest()
        {
            Assert.AreEqual("nick", User.Nickname);
            User.Nickname = "nick_test";
            Assert.AreEqual("nick_test", User.Nickname);
        }

        [Test]
        public void FirstNameTest()
        {
            Assert.AreEqual("first", User.FirstName);
            User.FirstName = "first_test";
            Assert.AreEqual("first_test", User.FirstName);
        }

        [Test]
        public void LastNameTest()
        {
            Assert.AreEqual("last", User.LastName);
            User.LastName = "last_test";
            Assert.AreEqual("last_test", User.LastName);
        }

        [Test]
        public void BioDescTest()
        {
            Assert.AreEqual("bio", User.BioDesc);
            User.BioDesc = "bio_test";
            Assert.AreEqual("bio_test", User.BioDesc);
        }

        [Test]
        public void EmailTest()
        {
            Assert.AreEqual("somemail@gmail.com", User.Email);
            User.Email = "testmail@gmail.com";
            Assert.AreEqual("testmail@gmail.com", User.Email);
        }

        [Test]
        public void PasswordTest()
        {
            Assert.AreEqual("password", User.Password);
            User.Password = "password_test";
            Assert.AreEqual("password_test", User.Password);
        }

        [Test]
        public void RegDateTest()
        {
            Assert.AreEqual(RegDate, User.RegDate);
            User.RegDate = DateTime.Now.AddDays(5);
            Assert.AreNotEqual(DateTime.Now.AddDays(5), User.RegDate);
        }

    }
}