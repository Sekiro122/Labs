using System;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee() { Name = "Неизвестно"; Age = 0; }
        public Employee(string name) { Name = name; Age = 0; }
        public Employee(string name, int age) { Name = name; Age = age; }

        public void DisplayInfo() => Console.WriteLine($"Сотрудник: {Name}, {Age} лет");
    }

    class Box<T>
    {
        private T content;
        public void Put(T item) { content = item; Console.WriteLine($"Положили: {item}"); }
        public T Get() { Console.WriteLine($"Достали: {content}"); return content; }
        public void ShowType() => Console.WriteLine($"Тип: {typeof(T).Name}");
    }

    delegate void SimpleDelegate();
    delegate int MathDelegate(int a, int b);
    delegate void StringDelegate(string s);

    class Program
    {
        static void Hello() => Console.WriteLine("Привет!");
        static void Bye() => Console.WriteLine("Пока!");
        static int Sum(int a, int b) { Console.WriteLine($"{a}+{b}={a + b}"); return a + b; }
        static int Mult(int a, int b) { Console.WriteLine($"{a}*{b}={a * b}"); return a * b; }

        static void Main(string[] args)
        {

            SimpleDelegate del = Hello;
            del += Bye;  
            del();      
            Console.WriteLine();

            MathDelegate math = Sum;
            Console.WriteLine($"Результат: {math(5, 3)}");

            math = Mult;
            Console.WriteLine($"Результат: {math(5, 3)}");
            Console.WriteLine();

            Employee emp = new Employee("Вова", 16);
            SimpleDelegate empDel = emp.DisplayInfo;
            empDel();
            Console.WriteLine();

            MathDelegate lambda = (x, y) => x * x + y * y;
            Console.WriteLine($"5^2 + 3^2 = {lambda(5, 3)}");
            Console.WriteLine();

            Employee employee = new Employee("Вова", 16);
            Box<string> box = new Box<string>();
            box.Put("burger");
            box.Get();
            box.ShowType();

        }
    }
}