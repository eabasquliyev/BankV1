﻿using System;
using _090221Task.Entities;

namespace _090221Task
{
    static class Program
    {
        static void Main(string[] args)
        {
            var client = new Client()
            {
                Name = "Robert",
                Surname = "Perez",
                Age = 58,
                LiveAddress = "Chenoweth Drive, Nashville",
                WorkAddress = "Chenoweth Drive, Nashville",
                Salary = 1500
            };

            var worker = new Worker()
            {
                Name = "Herbert ",
                Surname = "Young",
                Age = 38,
                Salary = 750,
                Position = "Operator",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(8)
            };

            var worker1 = new Worker()
            {
                Name = "Nita",
                Surname = "McKnight",
                Age = 25,
                Salary = 800,
                Position = "Operator",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(8)
            };


            var workers = new Worker[]
            {
                worker, worker1
            };

            var manager = new Manager()
            {
                Name = "Erin",
                Surname = "Wynn",
                Age = 30,
                Salary = 900,
                Position = "Operator",
            };

            var ceo =  new Ceo()
            {
                Name = "Debra",
                Surname = "Hayes",
                Age = 36,
                Salary = 2000,
                Position = "Operator"
            };

            //Console.WriteLine(client);
            //Console.WriteLine();
            //Console.WriteLine(worker);
            //Console.WriteLine();
            //Console.WriteLine(manager);
            //Console.WriteLine();
            //Console.WriteLine(ceo);

            var operation1 = new Operation()
            {
                ProcessName = "Credit",
                DateTime = DateTime.Now
            };

            var operation2 = new Operation()
            {
                ProcessName = "Credit",
                DateTime = DateTime.Now.AddHours(1)
            };

            var operation3 = new Operation()
            {
                ProcessName = "Credit",
                DateTime = DateTime.Now.AddHours(2)
            };

            var operation4 = new Operation()
            {
                ProcessName = "Credit",
                DateTime = DateTime.Now.AddHours(3)
            };

            worker.Operations.Add(operation1);
            worker.Operations.Add(operation2);

            //worker.ShowOperations();

            //worker.Operations.Delete(1);

            //Console.WriteLine();

            //worker.ShowOperations();

            try
            {
                //ceo.Control(workers);
                //ceo.MakeMeeting(workers);
                //ceo.Organize(workers);
                //manager.Organize(workers);

                Console.WriteLine(manager.CalculateSalaries(workers));
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
