﻿// See https://aka.ms/new-console-template for more information
using LinkedListPracticeProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();
            list.Addnote(56);
            list.Addnote(30);
            list.Addnote(30);
            list.Display();
        }
    }
}