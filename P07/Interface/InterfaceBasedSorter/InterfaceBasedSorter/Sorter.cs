using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasedSorter
{
    public class Sorter
    {
        public static void Sort(ISortable[] items)
        {
            int n = items.Length;

            for (int i = 0; i < n - 1; i++) 
            { 
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (items[j].CompareTo(items[j + 1]) > 0)
                    {
                        // swap
                        ISortable temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }
    }
}
