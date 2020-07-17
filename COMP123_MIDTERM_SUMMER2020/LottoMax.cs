using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MIDTERM_SUMMER2020
{
    /**
   * <summary>
   * This class is a subclass of the LottoGame abstract superclass
   * </summary>
   * 
   * @class LottoMax
   */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            for (int i = 1; i <= ElementNumber; i++)
            {
                PickElements();

                Console.Write($"Ticket { i } : ");
                Console.WriteLine(ToString());

            }
        }
    }
}
