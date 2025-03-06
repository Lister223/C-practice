using System;

namespace Human{
    class Person2{
        public string name;
        public int age;

        public Person2(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void  PrintName()
        {
            Console.WriteLine(this.name);
        }

        public void PrintAge()
        {
            Console.WriteLine(this.age);
        }
    }
}
