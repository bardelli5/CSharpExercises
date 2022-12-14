using System;

/*namespace Course {
    class Program {
        static void Main(string[] args) {

            //DateTime:
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            //DateSpan:

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);

            
             
            Boa prática
            • Armazenar em formato UTC (texto: BD / Json / XML)
            • Instanciar e mostrar em formato Local 

            * Para converter um DateTime para Local ou Utc, você deve usar:
            • myDate.ToLocalTime()
            • myDate.ToUniversalTime()  
            
             Demo:

                DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
                DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
                DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
                Console.WriteLine("d1: " + d1);
                Console.WriteLine("d1 Kind: " + d1.Kind);
                Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
                Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
                Console.WriteLine();
                Console.WriteLine("d2: " + d2);
                Console.WriteLine("d2 Kind: " + d2.Kind);
                Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
                Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
                Console.WriteLine();
                Console.WriteLine("d3: " + d3);
                Console.WriteLine("d3 Kind: " + d3.Kind);
                Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
                Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
             
            }
        }
    }*/