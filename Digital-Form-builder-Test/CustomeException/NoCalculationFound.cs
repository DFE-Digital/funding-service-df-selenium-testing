using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.CustomeException
{
    public class NoCalculationFound : Exception
    {

        public NoCalculationFound(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
