using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class ArtistTest
    {
        Artist Artist;
        int IdUser;
        string Nickname;
        string FirstName;
        string LastName;
        string BioDesc;
        string Email;
        string Password;
        DateTime RegDate;
        int NumberOfPosts;


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
            NumberOfPosts = 0;
            Artist = new Artist(IdUser, Nickname, FirstName, LastName, BioDesc, Email, Password, RegDate);
        }

        [Test]
        public void IdUserTest()
        {
            Assert.AreEqual(1, Artist.IdUser);
            Artist.IdUser = 2;
            Assert.AreEqual(2, Artist.IdUser);
        }

        [Test]
        public void NicknameTest()
        {
            Assert.AreEqual("nick", Artist.Nickname);
            Artist.Nickname = "nick_test";
            Assert.AreEqual("nick_test", Artist.Nickname);
        }

        [Test]
        public void FirstNameTest()
        {
            Assert.AreEqual("first", Artist.FirstName);
            Artist.FirstName = "first_test";
            Assert.AreEqual("first_test", Artist.FirstName);
        }

        [Test]
        public void LastNameTest()
        {
            Assert.AreEqual("last", Artist.LastName);
            Artist.LastName = "last_test";
            Assert.AreEqual("last_test", Artist.LastName);
        }

        [Test]
        public void BioDescTest()
        {
            Assert.AreEqual("bio", Artist.BioDesc);
            Artist.BioDesc = "bio_test";
            Assert.AreEqual("bio_test", Artist.BioDesc);
        }

        [Test]
        public void EmailTest()
        {
            Assert.AreEqual("somemail@gmail.com", Artist.Email);
            Artist.Email = "testmail@gmail.com";
            Assert.AreEqual("testmail@gmail.com", Artist.Email);
        }

        [Test]
        public void PasswordTest()
        {
            Assert.AreEqual("password", Artist.Password);
            Artist.Password = "password_test";
            Assert.AreEqual("password_test", Artist.Password);
        }

        [Test]
        public void RegDateTest()
        {
            Assert.AreEqual(RegDate, Artist.RegDate);
            Artist.RegDate = DateTime.Now.AddDays(5);
            Assert.AreNotEqual(DateTime.Now.AddDays(5), Artist.RegDate);
            // you can't change the registration date
        }

        [Test]
        public void NumberOfPostsTest()
        {
            Assert.AreEqual(NumberOfPosts, Artist.NumberOfPosts);
            NumberOfPosts = 1;
            Artist.NumberOfPosts = NumberOfPosts;
            Assert.AreEqual(NumberOfPosts, Artist.NumberOfPosts);
        }
    }
}