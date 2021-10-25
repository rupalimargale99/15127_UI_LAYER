using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Type_Collection_demo
{
    class CollectionDemo
    {
      
        static void Main(String[] args)
        {
            #region Array
            //datatype[] name= new datatype[size];

            //int[] numberArray = new int[3];
            //numberArray[0] = 454;
            // numberArray[1] = 44754;
            // numberArray[2] = 23;

            //////declare and initialize
            //int[] numberArray = { 45, 67, 78, 54, 343, 899 };

            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    Console.WriteLine(numberArray[i]);
            //}
            #endregion

            #region System.Collections classes

            //ArrayList countyList = new ArrayList();
            //countyList.Add("India");
            //countyList.Add("USA");
            //countyList.Insert(1, "France");

            //countyList.Add(100);
            //countyList.Add(true);

            ////object initializer {}
            //Person person = new Person() { FirstName = "Rupali", LastName = "Margale" };

            //Console.WriteLine(person.FirstName + "  " + person.LastName);
            //Console.WriteLine("-------------------------------------------\n");

            //countyList.Add(person);

            ////from countryList collection for item No 5(person object) print only Firstname

            ////Type Conversion

            //Console.WriteLine(((Person)countyList[5]).FirstName           );

            //Console.WriteLine("-----------------------------------------\n");

            //for(int i=0;i<countyList.Count;i++)
            //{
            //    Console.WriteLine(countyList[i]);
            //}

            #endregion

            #region  Generic Collection classes

            ////generic collection is a Type safe collection

            //List<string> countryList = new List<string>();
            //countryList.Add("India");
            ////countryList.Add(100);

            //List<int> numbers = new List<int>();
            //numbers.Add(100);

            //List<Person> personList = new List<Person>();
            //personList.Add(new Person() { FirstName = "Rupali", LastName = "Maargale" });

            //Console.WriteLine(personList[0].FirstName);

            #endregion

            #region Nullable Type
            //int i=null;

            Nullable<int> x = null;
            x = 100;
            x = null;

            //datatype? -----nullable type
            int? y = null;

            #endregion
        }
    }
}
