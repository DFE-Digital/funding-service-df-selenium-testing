using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Digital_Form_builder_Test.Utilities
{
    public  static class RandomNameGenerator
    {
        
        private static Random random = new Random();
        public static string RandomString(int length)
        {

            const string chars = "abcdefghijklmnopqrstuvwxyz";
            string name = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return "cal-"+name+"-test";

        }
    }
}
