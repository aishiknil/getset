﻿using System;
namespace Application
{
    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(2000,10,13));
            System.Console.WriteLine(person.GetBirthdate());
            
        }
    }
}