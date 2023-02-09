using System.Collections.Generic;



namespace Lesson
{
    // обобщённый List
    // подключать using System.Collections.Generic
    class Program
    {
        static void Main(string[] args)
        {
            //List<string>list = new List<string>(); // так- же в List можно хранить class and struct
            List<int> list = new List<int>(); // List - как готовый массив в котором хранится тип данных int
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list[0]);
            list[0] = 2;
        }
    }
}