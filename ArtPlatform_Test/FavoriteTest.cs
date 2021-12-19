using ArtPlatform.Models;
using NUnit.Framework;

namespace ArtPlatform_Test {

    public class FavoriteTest {

        private User _user;
        private Post _post;
        private Favorite _favorite;

        [SetUp]
        public void Setup() {
            _user = new User();
            _post = new Post(1);
            _favorite = new Favorite(_user, _post);
        }

        // getters tests

        [Test]
        public void GetUser() {
            Assert.AreEqual(_user, _favorite.User);
        }

        [Test]
        public void GetPost() {
            Assert.AreEqual(_post, _favorite.Post);
        }

        // setters tests

        [Test]
        public void SetUser() {
            User newUser = new User();
            _favorite.User = newUser;
            Assert.AreEqual(newUser, _favorite.User);
        }

        [Test]
        public void SetPost() {
            Post newPost = new Post(2);
            _favorite.Post = newPost;
            Assert.AreEqual(newPost, _favorite.Post);
        }

    }

}