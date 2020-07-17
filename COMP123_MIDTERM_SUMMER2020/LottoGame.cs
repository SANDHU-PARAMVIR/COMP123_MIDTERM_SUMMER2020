using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MIDTERM_SUMMER2020
{
    /**
    * <summary>
    * This abstract class is a blueprint for all Lotto Games
    * </summary>
    * 
    * @class LottoGame
    * @property {int} ElementNum;
    * @property {int} SetSize;
    */
    public abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private List<int> m_elementList;

        private int m_elementNumber;

        private List<int> m_numberList;

        private Random m_random;

        private int m_setSize;
        // CREATE private fields here --------------------------------------------

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------
        public List<int> ElementList
        {
            get
            {
                return m_elementList;
            }
        }
        public int ElementNumber
        {
            get
            {
                return m_elementNumber;
            }
            set
            {
                m_elementNumber = value;
            }
        }
        public List<int> NumberList
        {
            get
            {
                return m_numberList;
            }
        }
        public Random random
        {
            get
            {
                return m_random;

            }
        }
        public int SetSize
        {
            get
            {
                return m_setSize;
            }
            set
            {
                m_setSize = value;
            }
        }
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this.m_initialize();

            // call the _build method
            this.m_build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _initialize method here -----------------------------
        private void m_initialize()
        {
            m_numberList = new List<int>();
            m_elementList = new List<int>();
            m_random = new Random();

        }
        // CREATE the private _build method here -----------------------------------
        private void m_build()
        {
            for (int i = 1; i <= SetSize; i++)
            {
                NumberList.Add(i);
            }

        }
        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;


            foreach (int lottoNumber in ElementList)
            {
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
        public void PickElements()
        {
            int currentRandom;
            bool ElementListempty = !ElementList.Any();
            bool NumberListempty = !NumberList.Any();
            //Checks if both elements assigned with boolean are empty or not

            if (ElementListempty != true || NumberListempty != true)
            {
                //ElementList.Clear() = Empty
                ElementList.Clear();
                NumberList.Clear();
                m_build();// will fill the numberList
                for (int j = 1; j <= ElementNumber; j++)
                {
                    currentRandom = m_random.Next(1, NumberList.Count);
                    NumberList.Remove(currentRandom);
                    ElementList.Add(currentRandom);

                }

                ElementList.Sort();//Sort

            }
        }
    }
}
