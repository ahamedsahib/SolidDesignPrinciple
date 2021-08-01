﻿using DesignPrinciple.SingleResponsibilityPrinciple;
using System;
using System.IO;

namespace DesignPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!!!!");
            try
            {
               /* string path = @"C:\Users\ahamedsahib.m\source\repos\DesignPrinciple\DesignPrinciple\SingleResponsibilityPrinciple\Sample.txt";
                string fileContents = File.ReadAllText(path);
                string[] arr = fileContents.Split(",");
                Operation operation = new Operation();
                foreach (string i in arr)
                {
                    operation.list.Add(i);
                }
                operation.AddEntry("JackFruit");
                operation.RemoveItem("elephant");
                operation.SaveToFile(path);
                Console.WriteLine("Successfully Updated");*/
                
                 double salary;
                JuniorDev jd = new JuniorDev();
                salary = jd.CalculateSalary();
                Console.WriteLine($" junior dev Salary = {salary}");
                SeniorDev sd = new SeniorDev();
                salary = sd.CalculateSalary();
                Console.WriteLine($" Senior dev Salary = {salary}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
