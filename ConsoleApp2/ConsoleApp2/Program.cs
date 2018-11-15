using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct Train
    {
        public string Destination;
        public int Number;
        public DateTime Departure;
        public Train(string destination, int number, DateTime departure)
        {
            this.Destination = destination;
            this.Number = number;
            this.Departure = departure;

        }

        public override string ToString()
        {
            return string.Format("Пункт призначення: {0}, № потягу: {1}, Відправлення в: {2}", Destination, Number, Departure);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[2];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("_____Введiть iнформацiю про потяг_____ ");

                Console.WriteLine("Назва пункту призначення:  ");
                string destination = Console.ReadLine();

                Console.WriteLine("Номер поїзду: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Дата вiдправки: ");
                DateTime departure = DateTime.Parse(Console.ReadLine());

               

                trains[i] = new Train(destination, number, departure);
            }

            Console.WriteLine("Введiть назву пункту призначення для пошуку з введеного списку або 'вийти' для виходу.");
            string input;
            while ((input = Console.ReadLine()) != "вийти")
            {
                bool trainFound = false;
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].Destination == input)
                    {
                        Console.WriteLine(trains[i]);
                        trainFound = true;
                    }
                }

                if (!trainFound)
                    Console.WriteLine("Нічого не знайдено,повторіть спробу.");
            }
        }
    }
}



