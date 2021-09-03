using System;
using System.IO;
using Xunit;

namespace helloworld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Program_writes_helloworld_to_console()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Hello, World!", output);
        }

        [Fact]
        public void Program_writes_something_else() {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("somethingelse", output);
        }
    }
}
