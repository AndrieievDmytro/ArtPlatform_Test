using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class ModeratorTest
    {
        private Moderator _moderator;

        [SetUp]
        public void Setup()
        {
            _moderator = new Moderator(1, "jank001", "Jan", "Kowalski", "My bio desc", "jank@code.com", "12345", new DateTime(2021, 12, 18));
        }

        //getters
        [Test]
        public void GetModeratorId()
        {
            Assert.AreEqual(_moderator.IdUser, 1);
        }

        [Test]
        public void GetModeratorNickname()
        {
            Assert.AreEqual(_moderator.Nickname, "jank001");
        }

        [Test]
        public void GetModeratorFirstName()
        {
            Assert.AreEqual(_moderator.FirstName, "Jan");
        }

        [Test]
        public void GetModeratorLastName()
        {
            Assert.AreEqual(_moderator.LastName, "Kowalski");
        }

        [Test]
        public void GetModeratorBioDesc()
        {
            Assert.AreEqual(_moderator.BioDesc, "My bio desc");
        }

        [Test]
        public void GetModeratorEmail()
        {
            Assert.AreEqual(_moderator.Email, "jank@code.com");
        }

        [Test]
        public void GetModeratorPassword()
        {
            Assert.AreEqual(_moderator.Password, "12345");
        }

        [Test]
        public void GetModeratorRegDate()
        {
            Assert.AreEqual(_moderator.RegDate, new DateTime(2021, 12, 18));
        }

        //setters
        [Test]
        public void SetModeratorId()
        {
            _moderator.IdUser = 2;
            Assert.AreEqual(_moderator.IdUser, 2);
        }

        [Test]
        public void SetModeratorNickname()
        {
            _moderator.Nickname = "annw";
            Assert.AreEqual(_moderator.Nickname, "annw");
        }

        [Test]
        public void SetModeratorFirstName()
        {
            _moderator.FirstName = "Ann";
            Assert.AreEqual(_moderator.FirstName, "Ann");
        }

        [Test]
        public void SetModeratorLastName()
        {
            _moderator.LastName = "Wo";
            Assert.AreEqual(_moderator.LastName, "Wo");
        }

        [Test]
        public void SetModeratorBioDesc()
        {
            _moderator.BioDesc = "And my bio desc";
            Assert.AreEqual(_moderator.BioDesc, "And my bio desc");
        }

        [Test]
        public void SetModeratorEmail()
        {
            _moderator.Email = "annw@code.com";
            Assert.AreEqual(_moderator.Email, "annw@code.com");
        }

        [Test]
        public void SetModeratorPassword()
        {
            _moderator.Password = "98765";
            Assert.AreEqual(_moderator.Password, "98765");
        }

        [Test]
        public void SetModeratorRegDate()
        {
            _moderator.RegDate = new DateTime(2021, 11, 18);
            Assert.AreEqual(_moderator.RegDate, new DateTime(2021, 11, 18));
        }
    }
}