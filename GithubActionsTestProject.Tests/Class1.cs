using FluentAssertions;
using NUnit.Framework;

namespace GithubActionsTestProject.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Calculator.Plus(1, 3).Should().Be(4);
        }
    }
}