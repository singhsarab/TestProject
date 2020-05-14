using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 7)]
        [InlineData(2, 2, 4)]
        [Theory]
        public void Test1(int a, int b, int c)
        {
            Assert.Equal(a + b, c);

        }
    }
}
