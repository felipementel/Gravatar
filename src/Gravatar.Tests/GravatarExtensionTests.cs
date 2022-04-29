using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null, 200, false)]
        [DataRow("felipementel@hotmail.com", 200, true)]
        public void ShouldValidateGravatar(string email, int? size, bool status)
        {
            var imageSize = size.HasValue ? size.Value.ToString() : "80";
            var result = $"https://www.gravatar.com/avatar/e2f0c967f3932d95101115c6e3168b7c?s={imageSize}";
            Assert.AreEqual((email.ToGravatar(size ?? 80) == result), status);
        }
    }
}
