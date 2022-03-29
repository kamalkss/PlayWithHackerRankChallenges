using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Challenges
{
    public class MathChallenge2
    {
        public static string MathChallenge(string str)
        {
            if (str.Contains("**"))
            {
                var indexofpower = str.IndexOf("**");
                if (indexofpower == str.Length - 3)
                {
                    var newstr = str.Substring(0, indexofpower);
                    int left, right, leftOp, rightOp;
                    string calculated, signPool = "*/+-";
                    char sign;
                    for (int j = 0; j < 4; j++)
                    {
                        sign = signPool[j];
                        for (int i = newstr.IndexOf(sign); i != -1; i = newstr.IndexOf(sign))
                        {
                            for (left = i - 1; Char.IsDigit(newstr[left]); left--)
                            {
                            }

                            ;
                            left++;
                            for (right = i + 1; Char.IsDigit(newstr[right]); right++)
                            {
                            }

                            ;
                            right--;
                            leftOp = Convert.ToInt32(newstr.Substring(left, i - left));
                            rightOp = Convert.ToInt32(newstr.Substring(right, right - i));
                            switch (sign)
                            {
                                case '*':
                                    calculated = Convert.ToString(leftOp * rightOp);
                                    break;
                                case '/':
                                    calculated = Convert.ToString(leftOp / rightOp);
                                    break;
                                case '+':
                                    calculated = Convert.ToString(leftOp + rightOp);
                                    break;
                                case '-':
                                    calculated = Convert.ToString(leftOp - rightOp);
                                    break;
                            }

                            calculated = Convert.ToString(leftOp * rightOp);
                            newstr = newstr.Replace(newstr.Substring(left, right - left + 1), calculated);
                        }
                    }

                    return newstr;
                }
                




                //var indexofpower = str.IndexOf("**");
                //if (indexofpower == str.Length - 3)
                //{
                //    var newstr = str.Substring(0, indexofpower);
                //    var value = Math.Pow(Convert.ToInt32(new DataTable().Compute(newstr, null)), str[indexofpower + 2] - '0');
                //    return value.ToString();
                //}
                else
                {
                    return "no";
                }
            }






            else
            {
                //var result = new Interpreter().Eval("124+241/2*5");
                return new DataTable().Compute(str, null).ToString();

            }

        }
    }
}