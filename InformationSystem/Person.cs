using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    class Person : IProperty
    {

        private string name;
        private string gender;
        private int age;
        public Array [] people;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void PersonList()
        {

        }
        public void GetAll()
        {
            throw new NotImplementedException();
        }


    }
}
