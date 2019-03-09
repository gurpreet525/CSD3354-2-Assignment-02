using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Gurpreet Gurpreet(c0712759)    Arshdeep Singh(c0716342)
//CSD3354 Section 2
//Assignment 2
//March 8,2019

namespace c0712759
{
    public delegate void MyDelegate();
    
    public class DelegateExercises
    {
        void Method3()
        {
            System.Console.WriteLine(MyDelegate.ToString());
        }
    }
}

