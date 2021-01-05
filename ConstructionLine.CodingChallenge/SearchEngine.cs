
using ConstructionLine.CodingChallenge.Builder;
using ConstructionLine.CodingChallenge.Validation;
using System.Collections.Generic;

namespace ConstructionLine.CodingChallenge
{
    public class SearchEngine
    {
        private readonly List<Shirt> _shirts;

        public SearchEngine(List<Shirt> shirts)
        {
            Ensure.IsNotNull(shirts, nameof(shirts));

            _shirts = shirts;
        }

        public SearchResults Search(SearchOptions options)
        {
            Ensure.IsNotNull(options, nameof(options));

            List<Shirt> shirts = ShirtBuilder.Build(_shirts, options);

            return new SearchResults
            {
                Shirts = shirts,
                SizeCounts = SizeCountBuilder.Build(shirts),
                ColorCounts = ColorCountBuilder.Build(shirts)
            };
        }       
    }
}