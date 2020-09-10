using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GrasshopperSyntaxBug
{
    [TestClass]
    public class SyntaxBugTests
    {
        [TestMethod]
        public void GivenHealthStatus_ReturnTrue()
        {
            Player greg = new Player();
            greg.Health = 5;
            Assert.AreEqual(true, greg.CheckAlive());
        }

        [TestMethod]
        public void GivenHealthStatus_ReturnFalse()
        {
            Player joe = new Player();
            joe.Health = 0;
            Assert.AreEqual(false, joe.CheckAlive());
        }
    }
}
