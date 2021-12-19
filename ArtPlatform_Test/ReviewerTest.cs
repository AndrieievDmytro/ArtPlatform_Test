using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class ReviewerTest
    {
        Reviewer Reviewer;
        int IdUser;
        string Nickname;
        string FirstName;
        string LastName;
        string BioDesc;
        string Email;
        string Password;
        DateTime RegDate;
        int CertificateNumber;


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
            CertificateNumber = 1212332;
            Reviewer = new Reviewer(IdUser, Nickname, FirstName, LastName, BioDesc, Email, Password, RegDate, CertificateNumber);
        }

        [Test]
        public void IdUserTest()
        {
            Assert.AreEqual(1, Reviewer.IdUser);
            Reviewer.IdUser = 2;
            Assert.AreEqual(2, Reviewer.IdUser);
        }

        [Test]
        public void NicknameTest()
        {
            Assert.AreEqual("nick", Reviewer.Nickname);
            Reviewer.Nickname = "nick_test";
            Assert.AreEqual("nick_test", Reviewer.Nickname);
        }

        [Test]
        public void FirstNameTest()
        {
            Assert.AreEqual("first", Reviewer.FirstName);
            Reviewer.FirstName = "first_test";
            Assert.AreEqual("first_test", Reviewer.FirstName);
        }

        [Test]
        public void LastNameTest()
        {
            Assert.AreEqual("last", Reviewer.LastName);
            Reviewer.LastName = "last_test";
            Assert.AreEqual("last_test", Reviewer.LastName);
        }

        [Test]
        public void BioDescTest()
        {
            Assert.AreEqual("bio", Reviewer.BioDesc);
            Reviewer.BioDesc = "bio_test";
            Assert.AreEqual("bio_test", Reviewer.BioDesc);
        }

        [Test]
        public void EmailTest()
        {
            Assert.AreEqual("somemail@gmail.com", Reviewer.Email);
            Reviewer.Email = "testmail@gmail.com";
            Assert.AreEqual("testmail@gmail.com", Reviewer.Email);
        }

        [Test]
        public void PasswordTest()
        {
            Assert.AreEqual("password", Reviewer.Password);
            Reviewer.Password = "password_test";
            Assert.AreEqual("password_test", Reviewer.Password);
        }

        [Test]
        public void RegDateTest()
        {
            Assert.AreEqual(RegDate, Reviewer.RegDate);
            Reviewer.RegDate = DateTime.Now.AddDays(5);
            Assert.AreNotEqual(DateTime.Now.AddDays(5), Reviewer.RegDate);
            // you can't change the registration date
        }

        [Test]
        public void NumberOfPostsTest()
        {
            Assert.AreEqual(CertificateNumber, Reviewer.CertificateNumber);
            CertificateNumber = 1213321;
            Reviewer.CertificateNumber = CertificateNumber;
            Assert.AreEqual(CertificateNumber, Reviewer.CertificateNumber);
        }

    }
}