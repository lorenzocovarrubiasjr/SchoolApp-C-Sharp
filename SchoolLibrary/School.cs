﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string  State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure it starts with @
            get { return _twitterAddress;  }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The Twitter address must begin with @");
                }
            }
        }

        public School()
        {
            Name = "Unititled School";
            PhoneNumber = "713-123-4567";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        //Function bodied expressions
        public float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        public int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
    }
}