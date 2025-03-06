using Animal;

namespace Human{
    class Student : Person2 {
        public string school;

        public Student(string name, int age, string school) : base(name, age)
        {
            this.school = school;
        }
        public void PrintSchool()
        {
            Console.WriteLine(this.school);
        }

    }

}