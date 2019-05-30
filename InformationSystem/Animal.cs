using System;
using System.Collections.Generic;
using System.Text;

namespace InformationSystem
{
    class Animal : IProperty
    {


        private string name;
        private string gender;
        private int age;
        private int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void GetAll()
        {
            throw new NotImplementedException();
        }


    }
}
