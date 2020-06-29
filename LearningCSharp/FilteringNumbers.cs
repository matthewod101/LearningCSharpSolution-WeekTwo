using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class FilteringNumbers
    {
        [Fact] 
        public void WeCanFilterOutEvens()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> evens = numberFilter.FilterOutEvens(numbers);

            Assert.Equal(1, evens[0]);
            Assert.Equal(3, evens[1]);
            Assert.Equal(5, evens[2]);
            Assert.Equal(7, evens[3]);
        }

        [Fact]
        public void WeCanFilterOutOdds()
        {
            var numberFilter = new NumberFilter();
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> evens = numberFilter.FilterOutOdds(numbers);

            Assert.Equal(2, evens[0]);
            Assert.Equal(4, evens[1]);
            Assert.Equal(6, evens[2]);
            Assert.Equal(8, evens[3]);
        }

        [Fact]
        public void SelfServeFiltering()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var filter = new NumberFilter();
            // numbers[0] = 10;
            var result = filter.Filter(numbers, n => n > 5); //uses delegate method to call Filter
            
            Assert.Equal(6, result[0]);
            Assert.Equal(7, result[1]);

            var evensSequence = numbers.Where(n => n % 2 == 0);

            // numbers[1] = 3;

            // var evens = evensSequence.ToList();
            // Assert.Equal(2, evens[0]);
        }
    }
}
