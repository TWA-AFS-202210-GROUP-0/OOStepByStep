using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Test_Console()
        {
            // given
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            // when
            new Student().Print();

            // then
            Assert.Equal("console\r\n", fakeOutput.ToString());
        }
    }
}
