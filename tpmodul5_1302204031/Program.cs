﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204031
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Dewa");
                video.IncreasePlayCount(20);
                video.PrintVideoDetails();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}