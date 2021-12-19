using ArtPlatform.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace ArtPlatform_Test {

    public class PostTest {

        private Post _post;
        private string _description;
        private Comment _comment;

        [SetUp]
        public void Setup() {
            _description = "some description";
            _post = new Post(1, _description);
            _comment = new Comment(1);
            _post.Comment(_comment);
        }

        // getters tests

        [Test]
        public void GetPostId() {
            Assert.AreEqual(1, _post.IdPost);
        }

        [Test]
        public void GetDescription() {
            Assert.AreEqual(_description, _post.Description);
        }

        [Test]
        public void GetComments() {
            Assert.GreaterOrEqual(1, _post.Comments.Count);
            Assert.AreEqual(_comment, _post.Comments[0]);
        }

        // setters tests

        [Test]
        public void SetPostId() {
            _post.IdPost = 2;
            Assert.AreEqual(2, _post.IdPost);
        }

        [Test]
        public void SetDescription() {
            string newDescription = "another description";
            _post.Description = newDescription;
            Assert.AreEqual(newDescription, _post.Description);
        }

        // methods tests

        [Test]
        public void Comment() {
            Comment newComment = new Comment(2);
            _post.Comment(newComment);
            Assert.AreEqual(newComment, _post.Comments[1]);
        }

    }

}