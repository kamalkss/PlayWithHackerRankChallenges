using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    public class CommonAncestor
    {
        static public int Run(int index1, int index2)
        {

            if (index1 == null || index2 == null)
            {
                return -1;
            }
            int index_common_ancestor = 0;
            while (true)
            {
                if (index1 == index2)
                {
                    return index1;
                }
                if (index1 != 0) index1 = index1 / 2;
                if (index2 != 0) index2 = index2 / 2;
                index_common_ancestor++;
                while (true)
                {
                    if (index1 == index2)
                    {
                        return index1;
                    }
                    if (index1 > index2)
                    {
                        index1 = index1 / 2;
                    }
                    else
                    {
                        index2 = index2 / 2;
                    }
                }

            }


            return index_common_ancestor;
        }
    }
}