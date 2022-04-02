using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    public class birthdayCakeCandles
    {
        public static int birthdayCakeCandle(List<int> candles)
        {
            //compute the count of candles that are tallest
            int tallestCandle = candles.Max();
            int tallestCandleCount = candles.Count(x => x == tallestCandle);
            return tallestCandleCount;
        }

    }
}
