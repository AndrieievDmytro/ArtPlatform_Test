using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class ReportTest
    {
        private Report _report;
        private User _user;
        private Moderator _moderator;

        [SetUp]
        public void Setup()
        {
            _user = new User();
            _moderator = new Moderator(1, "jank001", "Jan", "Kowalski", "My bio desc", "jank@code.com", "12345", new DateTime(2021, 12, 18));
            _report = new Report(1, "spam", 3, 5, "comment", _user, _moderator);
        }

        //getters
        [Test]
        public void GetReportId()
        {
            Assert.AreEqual(_report.IdReport, 1);
        }

        [Test]
        public void GetReportType()
        {
            Assert.AreEqual(_report.ReportType, "spam");
        }

        [Test]
        public void GetReportedUserId()
        {
            Assert.AreEqual(_report.IdReportedUser, 3);
        }

        [Test]
        public void GetReportingUserId()
        {
            Assert.AreEqual(_report.IdReportingUser, 5);
        }

        [Test]
        public void GetReportComment()
        {
            Assert.AreEqual(_report.Comment, "comment");
        }

        [Test]
        public void GetUser()
        {
            Assert.AreEqual(_report.User, _user);
        }

        [Test]
        public void GetModerator()
        {
            Assert.AreEqual(_report.Moderator, _moderator);
        }

        //setters
        [Test]
        public void SetReportId()
        {
            _report.IdReport = 2;
            Assert.AreEqual(_report.IdReport, 2);
        }

        [Test]
        public void SetReportType()
        {
            _report.ReportType = "child abuse";
            Assert.AreEqual(_report.ReportType, "child abuse");
        }

        [Test]
        public void SetReportedUserId()
        {
            _report.IdReportedUser = 7;
            Assert.AreEqual(_report.IdReportedUser, 7);
        }

        [Test]
        public void SetReportingUserId()
        {
            _report.IdReportingUser = 10;
            Assert.AreEqual(_report.IdReportingUser, 10);
        }

        [Test]
        public void SetReportComment()
        {
            _report.Comment = "comment 1";
            Assert.AreEqual(_report.Comment, "comment 1");
        }

        [Test]
        public void SetUser()
        {
            User newUser = new User();
            _report.User = newUser;
            Assert.AreEqual(_report.User, newUser);
        }

        [Test]
        public void SetModerator()
        {
            Moderator newModerator = new Moderator(2, "annw", "Ann", "Wo", "My bio desc", "annw@code.com", "98765", new DateTime(2021, 12, 18));
            _report.Moderator = newModerator;
            Assert.AreEqual(_report.Moderator, newModerator);
        }

    }
}