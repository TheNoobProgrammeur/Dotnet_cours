using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace Fibonacci.Tests
{
    public class FibonacciUnitTest
    {
        [Fact]
        public void Execute44ShouldRetrun701408733()
        {
            var result = Fibonacci.Fib("44");
            Assert.Equal(701408733, result);
        }
            
        [Fact]
        public void Execute44And33SouldReturn701408733And3524578()
        {
            var resulte = Fibonacci.ListFib(new[] {"44", "33"});
            Assert.Equal(new List<int>{701408733,3524578},resulte);
        }
    }
}
