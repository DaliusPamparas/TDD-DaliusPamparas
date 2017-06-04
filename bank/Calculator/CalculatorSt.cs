using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorSt
    {
        public static int Add(string v)
        {
          if(v == "")
            {
                return 0;
            }
          else
            {
                var summa = 0;
                Array.ForEach(v.Split(',','\n'),
                    x => {

                        if (int.Parse(x) > 0)
                            summa += int.Parse(x);
                        else
                        {
                            throw new Exception("Negative number hittad");
                        }
                     }
                    );
                return summa;
            }
        }
    }
}
