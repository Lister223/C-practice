// 用來計算兩數相加的程式
// System.Console.Write("請輸入你要相加的數字：");
// double num1 = System.Convert.ToDouble(System.Console.ReadLine());
// double num2 = System.Convert.ToDouble(System.Console.ReadLine());
// double sum = num1 + num2;
// System.Console.WriteLine("兩數相加的結果是：" + sum);


//陣列
// int[] score = { 90, 80, 70, 60, 50 };
// string[] phones = new string[3];
// phones[0] = "HTC";  // 第一個元素
// phones[1] = "Samsung";  // 第二個元素        
// phones[2] = "Sony";  // 第三個元素
// System.Console.WriteLine("陣列的第一個元素是：" + phones[0]);
// System.Console.WriteLine("陣列的第二個元素是：" + phones[1]);


//if else 練習
// int score = 50;

// if (score >= 80)
// {
//     System.Console.WriteLine("我給你500元");
// }
// else if (score >= 60)
// {
//     System.Console.WriteLine("我給你200元");
// }
// else
// {
//     System.Console.WriteLine("你給我300元");
// }

// int score2 = 100;
// bool rainy = true;

// if (score2>=80 && rainy==false)
// {
//     System.Console.WriteLine("我給你500元");
// }
// else
// {
//     System.Console.WriteLine("你給我300元");
// }

// if (score2>=80 || !rainy)
// {
//     System.Console.WriteLine("我給你500元");
// }
// else
// {
//     System.Console.WriteLine("你給我300元");
// }


//進階計算機
// System.Console.Write("請輸入第一個數字：");
// double num1 = System.Convert.ToDouble(System.Console.ReadLine());
// System.Console.Write("請輸入要做的運算：");
// string oper = System.Console.ReadLine();
// System.Console.Write("請輸入第二個數字：");
// double num2 = System.Convert.ToDouble(System.Console.ReadLine());

// if (oper== "+")
// {
//     double sum = num1 + num2;
//     System.Console.WriteLine("相加的結果是：" + sum);
// }
// else if (oper== "-")
// {
//     double sum = num1 - num2;
//     System.Console.WriteLine("相減的結果是：" + sum);
// }
// else if (oper== "*")
// {
//     double sum = num1 * num2;
//     System.Console.WriteLine("相乘的結果是：" + sum);
// }
// else if (oper== "/")
// {
//     double sum = num1 / num2;
//     System.Console.WriteLine("相除的結果是：" + sum);
// }
// else
// {
//     System.Console.WriteLine("輸入錯誤，不合法的運算符號");
// }

//while 迴圈練習
// int num1 = 1;
// while (num1<=10)
// {
//     System.Console.WriteLine(num1);
//     num1++;
// }
// do
// {
//     System.Console.WriteLine(num1);
//     num1++;
// }
// while (num1<=100);

//猜數字遊戲
// int answer = 77;
// int count = 0;
// int guess = 1;
// int upernum = 100;
// int lowernum = 1;
// System.Console.WriteLine("歡迎來到猜數字遊戲");

// while (guess != answer)
// {      
//     System.Console.WriteLine("請輸入"+lowernum+"到"+upernum+"的數字：");
//     guess = System.Convert.ToInt32(System.Console.ReadLine());
//     count++;

//     if (guess > answer)
//     {
//         upernum = guess;
//         System.Console.WriteLine("猜小一點！");
//     }
//     else if (guess < answer)
//     {
//         lowernum = guess;
//         System.Console.WriteLine("猜大一點！");
//     }
//     else
//     {
//         System.Console.WriteLine("恭喜你猜對了，答案是"+answer);
//         break;
//     }

//     if (count < 5)
//     {
//         System.Console.WriteLine("你已經猜了"+count+"次了，還有"+(5-count)+"次機會");
//     }
//     else
//     {
//         System.Console.WriteLine("你已經沒有機會了，答案是"+answer);
//         break;
//     }
// }


//for 迴圈練習
// for(int i =1; i <=5; i+=2)
// {
//     System.Console.WriteLine(i);
// }
// int[] nums = {1,3,5,7,9};
// for(int i =0; i < nums.Length; i++)
// {
//     System.Console.WriteLine(nums[i]);
// }

//foreach 迴圈練習
// string [] names = {"John","Mary","Tom","David"};
// foreach (string name in names)
// {
//     System.Console.WriteLine("這位是" + name);
// }

//二維陣列
// int [,] scores = {
//     {90,80,70},
//     {60,50,40}
// };
// System.Console.WriteLine(scores[1,2]);

// int[,] nums= new int[2,3];
// nums[0,0] = 1;  
// nums[0,1] = 2;
// nums[0,2] = 3;
// nums[1,0] = 4;
// nums[1,1] = 5;
// nums[1,2] = 6;
// System.Console.WriteLine(scores[1,2]);


//class、object
// using Animal;
// using System;

// Person person1 =  new Person();

// person1.height = 175.5;
// person1.age = 15;  
// person1.name = "John";
// person1.SayHi();
// Console.WriteLine(person1.isAdult());
// Console.WriteLine(person1.height);
// Console.WriteLine(person1.Add(5,3));


// Person person2 = new Person();
// person2.height = 160.5;
// person2.age = 20;
// person2.name = "Mary";
// person2.SayHi();
// Console.WriteLine(person2.isAdult());
// Console.WriteLine(person2.height);

//Main練習
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

//constructor 練習
// using System;
// using Animal;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main()
//         {      
//             Person person1 =  new Person(170.5, 15, "John");
//             Person person2 = new Person(160.5, 20, "Mary");
//             Console.WriteLine(person1.name);
//             Console.WriteLine(person2.name);
//         }
//     }
// }


//getter、setter 練習
// using System;
// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main()
//         {
//             Video video1 = new Video("影片1", "作者1", "哈哈");
//             Video video2 = new Video("影片2", "作者2", "娛樂");
//             video1.Type = "教育";
//             video1.Type = "SKSKK";
//             Console.WriteLine(video1.Type);

//         }
//     }
// }


//靜態static 練習
// using System;
// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main()
//         {
//             Video video1 = new Video("影片1", "作者1", "教育");
//             Video video2 = new Video("影片2", "作者2", "娛樂");

//             Console.WriteLine(video1.Type);
//             Console.WriteLine(video2.Type);
//             Console.WriteLine(Video.video_count);
//             Console.WriteLine(video1.get_Video_count());

//         }
//     }
// }


//static method & static class練習
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main()
//         {
//             Tool.SayHi();
//             Console.WriteLine(Math.Sqrt(25));
//        }
//     }
// }


//繼承練習
using System;
using Human;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("John", 15, "高雄高工");
            student1.PrintName();
            student1.PrintAge();
            student1.PrintSchool();
            
       }
    }
}

