using System.Collections.Generic;
using System.Linq;

namespace ConstructionLine.CodingChallenge.Builder
{
    internal sealed class SizeCountBuilder
    {
        public static List<SizeCount> Build(List<Shirt> shirts)
        {
            List<SizeCount> sizeCount = new List<SizeCount>();

            foreach (Size size in Size.All)
            {
                sizeCount.Add(new SizeCount() { Size = size, Count = shirts.Count(x => x.Size == size) });
            }

            return sizeCount;
        }
    }
}
