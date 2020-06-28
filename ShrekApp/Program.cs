using System;
using System.Collections.Generic;

namespace ShrekApp
{
    class Notebuk
    {
        public static List<Note> list= new List<Note>();
        static void Main(string[] args)
        {
            Console.WriteLine("############SHREK############");
            Console.WriteLine("Список команд:");
            Console.WriteLine("list - список заметок");
            Console.WriteLine("open [id] - открыть заметку");
            Console.WriteLine("add - добавить заметку");
            Console.WriteLine("delete [id] - удалить заметку");
            Console.WriteLine("edit [id] - редактировать заметку");

            list.Add(new Note("Shrek", "Is", "Love", 777, "Russia", DateTime.Parse("11.11.11"), "", "", ""));

            while (true)
            {
                shrek(Console.ReadLine());
            }
        }

        public static void shrek(string s)//обработка команд
        {
            string[] temp;
            try {
                if (s == "list")
            {
                for(int i=0;i<list.Count;i++)
                {
                    list[i].printshort(i);
                    Console.WriteLine();
                }
                if (list.Count == 0) Console.WriteLine("Нет записей");
            }
            else if (s == "add")
            {
                Note.add();
            }
            else if(s.Split(' ').Length==2)
            {
                temp = s.Split(' ');
                if (temp[0] == "open") list[Int32.Parse(temp[1])].printfull(Int32.Parse(temp[1]));
                else if (temp[0] == "edit") list[Int32.Parse(temp[1])].edit(Int32.Parse(temp[1]));
                else if (temp[0] == "delete")
                {
                    list.RemoveAt(Int32.Parse(temp[1])); 
                    Console.WriteLine("Удалена запись "+ temp[1]);
                }
            }
            else Console.WriteLine("Wat?");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Нет такой записи");
            }
        }
    }

    class Note
    {
        public string Surname;
        public string Name;
        public string Fathername;
        public int Number;
        public string Country;
        public DateTime Birthdate;
        public string Organization;
        public string Doljnost;
        public string Other;

        public Note(string surname, string name, string fathername, int number, string country, DateTime birthdate, string organization, string doljnost, string other)
        {
            Surname = surname;
            Name = name;
            Fathername = fathername;
            Number = number;
            Country = country;
            Birthdate = birthdate;
            Organization = organization;
            Doljnost = doljnost;
            Other = other;
        }
        public void edit(int id)
        {
            string surname;
            string name;
            string fathername;
            int number;
            string country;
            DateTime birthdate;
            string organization;
            string doljnost;
            string other;
            try
            {
                Console.Write("Фамилия: "); surname = Console.ReadLine();
                while (surname == "") { Console.WriteLine("Введите фамилию: "); surname = Console.ReadLine(); }
                Console.Write("Имя: "); name = Console.ReadLine();
                while (name == "") { Console.WriteLine("Введите имя: "); name = Console.ReadLine(); }
                Console.Write("Отчество: "); fathername = Console.ReadLine();
                Console.Write("Номер телефона: "); number = Int32.Parse(Console.ReadLine());
                while (number == 0) { Console.WriteLine("Введите номер: "); number = Int32.Parse(Console.ReadLine()); }
                Console.Write("Страна: "); country = Console.ReadLine();
                while (country == "") { Console.WriteLine("Введите страну: "); country = Console.ReadLine(); }
                Console.Write("Дата рождения: "); birthdate = DateTime.Parse(Console.ReadLine());
                Console.Write("Организация: "); organization = Console.ReadLine();
                Console.Write("Должность: "); doljnost = Console.ReadLine();
                Console.Write("Прочие заметки: "); other = Console.ReadLine();
                Note pahom = new Note(surname, name, fathername, number, country, birthdate, organization, doljnost, other);
                Notebuk.list[id] = pahom;
            }
            catch (FormatException)
            {
                Console.WriteLine("Что-то пошло не так, неверный формат");
            }
        }

        public static void add()
        {
         string surname;
         string name;
         string fathername;
         int number;
         string country;
        DateTime birthdate;
         string organization;
         string doljnost;
         string other;
            try {
                Console.Write("Фамилия: "); surname = Console.ReadLine();
                while (surname == "") { Console.WriteLine("Введите фамилию: "); surname = Console.ReadLine(); }
                Console.Write("Имя: "); name = Console.ReadLine();
                while (name == "") { Console.WriteLine("Введите имя: "); name = Console.ReadLine(); }
                Console.Write("Отчество: "); fathername = Console.ReadLine();
                Console.Write("Номер телефона: "); number = Int32.Parse(Console.ReadLine());
                while (number == 0) { Console.WriteLine("Введите номер: "); number = Int32.Parse(Console.ReadLine()); }
                Console.Write("Страна: "); country = Console.ReadLine();
                while (country == "") { Console.WriteLine("Введите страну: "); country = Console.ReadLine(); }
                Console.Write("Дата рождения: "); birthdate = DateTime.Parse(Console.ReadLine());
                Console.Write("Организация: "); organization = Console.ReadLine();
                Console.Write("Должность: "); doljnost = Console.ReadLine();
                Console.Write("Прочие заметки: "); other = Console.ReadLine();
                Notebuk.list.Add(new Note(surname, name, fathername, number, country, birthdate, organization, doljnost, other));
            }
            catch (FormatException)
            {
                Console.WriteLine("Что-то пошло не так, неверный формат");
            }
        
        }

        public void printfull(int id)
        {
            Console.WriteLine("ID: "+id);
            Console.WriteLine("Фамилия: "+Surname);
            Console.WriteLine("Имя: "+Name);
            Console.WriteLine("Отчество: "+Fathername);
            Console.WriteLine("Телефон: "+Number);
            Console.WriteLine("Страна: "+Country);
            Console.WriteLine("Дата рождения: "+Birthdate);
            Console.WriteLine("Организация: "+Organization);
            Console.WriteLine("Должность: "+Doljnost);
            Console.WriteLine("Прочие заметки: "+Other);
        }

        public void printshort(int id)
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Телефон: " + Number);
        }
    }

}
