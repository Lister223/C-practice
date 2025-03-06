//namespace練習
using System;

namespace Animal{
    class Person
        {
            public double height;
            public int age;
            public string name;

            public Person(double h,int a,string n)
            {
                height = h;
                age = a;
                name = n;
            }

            public void SayHi()
            {Console.WriteLine("Hi, 我是"+name);}
            
            public string isAdult()
            {
                if(age>=18)
                {return("已成年");}
                else
                {return("未成年");}
            }
            public int Add(int a, int b)
            {return a+b;}
        }
}