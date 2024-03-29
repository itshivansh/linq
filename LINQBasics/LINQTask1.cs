﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQBasics
{
    public class LINQTask1
    {
        public string SendSelectedNameofEmployee()
        {
            string sendSelectedName = null;
            // Employee Names
            string[] listofnames = { "Vikram", "Mukesh", "Nandita", "Nishanth" };

            // LINQ Logic to get name contains V i.e Vikram here

            // Write foreach loop to send SelectedEmployee name
            var containing_V = from names in listofnames
                               where names.Contains("V")
                               select (names);
            foreach (var name in containing_V)
            {
                sendSelectedName += name;
            }

            return sendSelectedName;
        }
        public List<string> SendSelectedCourses()
        {
            List<string> SendSelectedCourses = new List<string>();
            List<string> listofCourses = new List<string>()
            {
            "Full Stack .Net",
            "Full Stack Java",
            "Full Stack Mean",
            "C#",
            "Python3"
            };
            //use Query Comprehension Syntax to get courses contains Full Stack
            //var stackRouteCourses = from
            //                        select
            //                        where
            //Use foreach loop of stackRouteCourses and sendit to SendSelectedCourses
            var stackRouteCourses = from courses in listofCourses
                                    where courses.Contains("Full Stack")
                                    select (courses);
                                    
            foreach(var course in stackRouteCourses)
            {
                SendSelectedCourses.Add(course);
            }
            return SendSelectedCourses;
        }
    }
}
