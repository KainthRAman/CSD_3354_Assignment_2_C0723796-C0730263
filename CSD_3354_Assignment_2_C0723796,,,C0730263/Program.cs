﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Student name Ramandeep kaur kainth  C0723796
//Student name Ashpreet singh   C0730263
// CSD3354 section 2
// Assigment 2
// March 6, 2019

namespace CSD_3354_Assignment_2_C0723796___C0730263
{
  
            public class DelegateExercises
        {
            public delegate void MyDelegate();
            void Method1()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        class Program
        {
            static void Main(string[] args)
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method2();
            }
        }
    }
}
    

