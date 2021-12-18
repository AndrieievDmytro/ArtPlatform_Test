using ArtPlatform.Models;
using NUnit.Framework;
using System;

namespace ArtPlatform_Test
{
    public class ReportVerdictTest
    {
        private ReportVerdict _reportVerdict;
        private User _user;
        private Report _report;
        private Moderator _moderator;

        [SetUp]
        public void Setup()
        {
            _user = new User();
            _moderator = new Moderator(1, "jank001", "Jan", "Kowalski", "My bio desc", "jank@code.com", "12345", new DateTime(2021, 12, 18));
            _report = new Report(1, "spam", 3, 5, "comment", _user, _moderator);
            _reportVerdict = new ReportVerdict(_user, _report);
        }

        //getters
        [Test]
        public void GetUser()
        {
            Assert.AreEqual(_reportVerdict.User, _user);
        }

        [Test]
        public void GetReport()
        {
            Assert.AreEqual(_reportVerdict.Report, _report);
        }

        //setters
        [Test]
        public void SetUser()
        {
            User newUser = new User();
            _reportVerdict.User = newUser;
            Assert.AreEqual(_reportVerdict.User, newUser);
        }

        [Test]
        public void SetReport()
        {
            Report newReport = new Report(2, "spam", 3, 5, "comment", _user, _moderator);
            _reportVerdict.Report = newReport;
            Assert.AreEqual(_reportVerdict.Report, newReport);
        }
    }
}