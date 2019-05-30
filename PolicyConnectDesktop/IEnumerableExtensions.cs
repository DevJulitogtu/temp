using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyConnectDesktop
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var rng = new Random();
            var elements = source.ToArray();
            var count = elements.Length;

            if (count <= 0) yield break;
            // Note i > 0 to avoid final pointless iteration.
            for (var i = count - 1; i > 0; i--)
            {
                // Swap element "i" with a random earlier element it (or itself)
                int swapIndex = rng.Next(i + 1);
                yield return elements[swapIndex];
                elements[swapIndex] = elements[i];
                // We don't actually perform the swap, we can forget about the
                // swapped element because we already returned it.
            }

            // There is one item remaining that was not returned - we return it now.
            yield return elements[0];
        }
    }
}
