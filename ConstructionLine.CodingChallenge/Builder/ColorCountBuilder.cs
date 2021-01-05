using System.Collections.Generic;
using System.Linq;

namespace ConstructionLine.CodingChallenge.Builder
{
    internal sealed class ColorCountBuilder
    {
        public static List<ColorCount> Build(List<Shirt> shirts)
        {
            List<ColorCount> colorCount = new List<ColorCount>();

            foreach (Color color in Color.All)
            {
                colorCount.Add(new ColorCount() { Color = color, Count = shirts.Count(x => x.Color == color) });
            }

            return colorCount;
        }
    }
}
