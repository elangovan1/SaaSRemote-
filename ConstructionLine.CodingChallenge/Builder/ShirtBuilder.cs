using System.Collections.Generic;

namespace ConstructionLine.CodingChallenge.Builder
{
    internal sealed class ShirtBuilder
    {
        public static List<Shirt> Build(List<Shirt> shirts, SearchOptions options)
        {
            List<Shirt> result = new List<Shirt>();

            foreach (Shirt shirt in shirts)
            {
                if (options.Sizes.Contains(shirt.Size) && options.Colors.Contains(shirt.Color))
                {
                    result.Add(shirt);
                }
            }

            return result;
        }
    }
}
