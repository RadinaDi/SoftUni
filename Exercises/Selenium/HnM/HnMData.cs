using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Selenium.HnM
{
    public class HnMData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var products = File.ReadAllLines("HnM\\Products.txt");
            foreach (var item in products)
            {
                yield return new object[] { item };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
