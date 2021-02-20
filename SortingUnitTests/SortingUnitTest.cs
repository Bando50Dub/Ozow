using NUnit.Framework;
using SortEngine;

namespace SortingUnitTests
{
    [TestFixture]
    public class SortingUnitTest
    {
        [Test]
        public void Should_Pass_CorrectInput()
        {
            var sort = new Sort();
            var input = "Contrary to popular belief, the pink unicorn flies east.";
            var result = sort.SortText(input);

            Assert.AreEqual("aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy", result);
        }

        [Test]
        public void Should_Fail_InCorrectInput()
        {
            var sort = new Sort();
            var input = "Contrary to popular belief, the pink unicorn flies east.";
            var result = sort.SortText(input);

            Assert.AreNotEqual("Contrary to popular belief, the pink unicorn flies east.", result);
        }

        [Test]
        public void Should_ReturnMessage_When_NoInput()
        {
            var sort = new Sort();
            var input = "";
            var result = sort.SortText(input);

            Assert.AreEqual("Please enter the text to sort", result);
        }
    }
}
