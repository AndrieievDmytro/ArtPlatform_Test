using ArtPlatform.Models;
using NUnit.Framework;

namespace ArtPlatform_Test
{
    public class ReportVerdictTest
    {
        private ReportVerdict _reportVerdict;
        private User _user;
        private Report _report;

        [SetUp]
        public void Setup()
        {
            _user = new User();
            _report = new Report();
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
            Report newReport = new Report();
            _reportVerdict.Report = newReport;
            Assert.AreEqual(_reportVerdict.Report, newReport);
        }
    }
}