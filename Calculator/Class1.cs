using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Class1
    {
        public int numOne
        {
            get
            {
                return this.numOne;
            }

            set
            {
                this.numOne = value;
            }
        }

        public int numTwo
        {
            get
            {
                return this.numTwo;
            }
            set
            {
                this.numOne = value;
            }

        }

        void Numbers()
        {
            this.numOne = Convert.ToInt32(Console.ReadLine());
            this.numTwo = Convert.ToInt32(Console.ReadLine());
        }
    }
}
