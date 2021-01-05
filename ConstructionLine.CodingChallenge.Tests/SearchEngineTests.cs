using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConstructionLine.CodingChallenge.Tests
{
    [TestFixture]
    public class SearchEngineTests : SearchEngineTestsBase
    {
        [Test]
        public void Test()
        {
            var shirts = new List<Shirt>
            {
                new Shirt(Guid.NewGuid(), "Red - Small", Size.Small, Color.Red),
                new Shirt(Guid.NewGuid(), "Black - Medium", Size.Medium, Color.Black),
                new Shirt(Guid.NewGuid(), "Blue - Large", Size.Large, Color.Blue),
            };

            var searchEngine = new SearchEngine(shirts);

            var searchOptions = new SearchOptions
            {
                Colors = new List<Color> { Color.Red },
                Sizes = new List<Size> { Size.Small }
            };

            var results = searchEngine.Search(searchOptions);

            AssertResults(results.Shirts, searchOptions);
            Assert.AreEqual(results.Shirts.First().Name, "Red - Small");
            AssertSizeCounts(shirts, searchOptions, results.SizeCounts);
            AssertColorCounts(shirts, searchOptions, results.ColorCounts);
        }

        [Test]
        public void Ensure_SearchEngineContructor_Returns_ArgumentNullException_When_InputIsNull()
        {
            List<Shirt> shirts = null;
            var exception = Assert.Throws<ArgumentNullException>(() => new SearchEngine(shirts));
            Assert.AreEqual("Argument shirts cannot be null.", exception.Message);
        }

        [Test]
        public void Ensure_SearchMethod_Returns_ArgumentNullException_When_InputIsNull()
        {
            SearchOptions options = null;
            SearchEngine searchEngine = new SearchEngine(new List<Shirt>());
            var exception = Assert.Throws<ArgumentNullException>(() => searchEngine.Search(options));
            Assert.AreEqual("Argument options cannot be null.", exception.Message);
        }
    }
}
