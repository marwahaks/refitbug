using System.Threading.Tasks;
using NUnit.Framework;
using RefitBug.RestFolder;

namespace RefitBug
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WoofTest()
        {
            Assert.IsFalse(new WoofClient().GetMyDawg().Result);

        }
    }
}