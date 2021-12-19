using ArtPlatform.Models;
using NUnit.Framework;

namespace ArtPlatform_Test {

    public class ReviewTest {

        private Reviewer _reviewer;
        private Post _post;
        private Review _review;

        [SetUp]
        public void Setup() {
            _reviewer = new Reviewer();
            _post = new Post(1);
            _review = new Review(_reviewer, _post);
        }

        // getters tests

        [Test]
        public void GetReviewer() {
            Assert.AreEqual(_reviewer, _review.Reviewer);
        }

        [Test]
        public void GetPost() {
            Assert.AreEqual(_post, _review.Post);
        }

        // setters tests

        [Test]
        public void SetReviewer() {
            Reviewer newReviewer = new Reviewer();
            _review.Reviewer = newReviewer;
            Assert.AreEqual(newReviewer, _review.Reviewer);
        }

        [Test]
        public void SetPost() {
            Post newPost = new Post(2);
            _review.Post = newPost;
            Assert.AreEqual(newPost, _review.Post);
        }

    }

}