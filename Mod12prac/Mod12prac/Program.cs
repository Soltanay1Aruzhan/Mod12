﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace Mod12prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            myObject.PropertyChanged += PropertyChangeHandler;  

            myObject.MyProperty = "New Value";

            Console.ReadLine();
        }

        
        static void PropertyChangeHandler(object sender, PropertyEventArgs e) 
        {
            Console.WriteLine($"Property '{e.PropertyName}' has been changed.");
        }
    }
}
