using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonDataManagement
{
    public class DataManagement
    {
        public void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("203456876", "John", "12 Main street", 15));
            listPersonsInCity.Add(new Person("203456877", "Sam", "12 Main street", 25));
            listPersonsInCity.Add(new Person("203456878", "Elan", "12 Main street", 35));
            listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main street", 45));
            listPersonsInCity.Add(new Person("203456880", "Sam", "12 Main street", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "12 Main street+", 65));
            listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork,NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave,Baltimore,NY", 85));
            listPersonsInCity.Add(new Person("203456884", "Sam", "126 Province Ave,Baltimore,NY", 95));
        }
        public void RetreivingTopTwoRecords_ForAgeIs_LessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            Console.WriteLine("The Teenagers Persons in the list are : ");
            foreach (Person person in listPersonsInCity.FindAll(x => (x.Age >= 13 && x.Age < 19)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public void RetrieveAverageAge(List<Person> listPersonsInCity)
        {
            double averageAge = listPersonsInCity.Average(x => x.Age);
            Console.WriteLine("The Average age of all Persons in the list are : " + averageAge);
        }
        public void CheckingForSpecificName(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Enter the name you want to check in the list : ");
            string search = Console.ReadLine();
            if (listPersonsInCity.Exists(e => e.Name == search))
            {
                Console.WriteLine("Yes, The Name {0} is Present in the list", search);
            }
            else
            {
                Console.WriteLine("No, The Name {0} is not Present in the list", search);
            }
        }
    }
}