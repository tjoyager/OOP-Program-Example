using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasedSorter
{
    public interface ISortable
    {
        /**
         * Compares current object with other object.
         * Returns less than zero if current object is less than other object
         * Returns zero if current object equals to other object
         * Returns greater than zero if current object is greater than other object
         */
        int CompareTo(ISortable other);
    }
}
