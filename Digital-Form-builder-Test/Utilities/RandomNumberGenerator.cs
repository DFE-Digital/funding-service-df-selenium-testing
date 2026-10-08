using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.Utilities
{
    public  static class RandomNumberGenerator
    {


        private static Random random = new Random();
        public static int RandomNumber()
        {


            return random.Next(1,100);
        }


    }
}
