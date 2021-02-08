using System;
using System.Globalization;

namespace Tópicos_Especiais_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var original = "     abcde aFGHIJ ABCa abc DEFGaA     "; // String imutável no C#

            var textoSemEspacos = original.Trim();
            var search1 = original.IndexOf("bc");
            var search2 = original.LastIndexOf("bc");
            var recorte1 = original.Substring(10); // Índice na posição 3
            var recorte2 = original.Substring(10, 5); // Índice na posição 3 + corte apenas 5 caracteres

            var trocaCaracteresString = original.Trim().Replace('a', 'x');
            var trocaTextoString = original.Trim().Replace("abc", "WYZ");

            var testNullOrEmpty = String.IsNullOrEmpty(original);

            var testNullOrWhiteSpace = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Trabalhando com manipulação de string's");
            Console.WriteLine();
            Console.WriteLine($"String original: --{original}--");
            Console.WriteLine($"String sem espaços: --{textoSemEspacos}--");
            Console.WriteLine($"Posição de início do bc: {search1}");
            Console.WriteLine($"Última posição do bc: {search2}");
            Console.WriteLine($"Substring índice 10: {recorte1}");
            Console.WriteLine($"Substring índice 10.5: {recorte2}");
            Console.WriteLine($"Replace caracteres a por x + remoção de espaços em branco: {trocaCaracteresString}");
            Console.WriteLine($"Replace textos abc por WYZ + remoção de espaços em branco: {trocaTextoString}");
            Console.WriteLine($"Verifica se a string é nula ou vazia: {testNullOrEmpty}");
            Console.WriteLine($"Verifica se a string é nula ou apenas espaços em branco: {testNullOrWhiteSpace}");
            Console.WriteLine();

            var d1 = DateTime.Now;
            var d2 = new DateTime(2021, 02, 07);
            var d3 = new DateTime(2021, 02, 07, 23, 59, 59);
            var d4 = new DateTime(2021, 02, 07, 23, 59, 51, 500); // Com milissegundos
            var d5 = DateTime.Today;
            var d6 = DateTime.UtcNow; // Busca o horário universal GMT - Brasil é GMT - 3 horas

            var d7 = DateTime.Parse("2000-01-01"); // Converte a string para data

            var d8 = DateTime.Parse("2005-08-05 14:14:14");
            var d9 = DateTime.Parse("07/02/2021");
            var d10 = DateTime.Parse("07/02/2021 16:43");

            var d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            var d12 = DateTime.ParseExact("15/02/2021 13:05:15", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("Trabalhando com manipulação de string's e DateTime");
            Console.WriteLine();
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d12);

            var t1 = new TimeSpan(0, 1, 30);
            var t2 = new TimeSpan(900000000l); // Gera um TimeSpan com duração de 1 min e 30 seg

            var t3 = new TimeSpan(2, 10, 15, 30); // Construtor com dias

            var t4 = new TimeSpan(4, 5, 11, 21, 321); //Construtor com milissegundos

            var t5 = TimeSpan.FromDays(1.5); // Cria um TimeSpan equivalente a 1 dia e meio

            var t6 = TimeSpan.FromHours(1.5);
            var t7 = TimeSpan.FromMinutes(1.5);
            var t8 = TimeSpan.FromSeconds(1.5);
            var t9 = TimeSpan.FromMilliseconds(1.5); // 1 milissegundo e meio é equivalente a 15 mil ticks

            var t10 = TimeSpan.FromTicks(1800000000l); // l de long / 1 bi e 800 milhões = 3 minutos

            Console.WriteLine();
            Console.WriteLine("Trabalhando com TimeSpan - Duração");
            Console.WriteLine();

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);

            Console.WriteLine();
            Console.WriteLine("Trabalhando com propriedades e operações com DateTime");
            Console.WriteLine();

            var dt1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(dt1);
            Console.WriteLine("1) Date: " + dt1.Date);
            Console.WriteLine("2) Day: " + dt1.Day);
            Console.WriteLine("3) DayOfWeek: " + dt1.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + dt1.DayOfYear);
            Console.WriteLine("5) Hour: " + dt1.Hour);
            Console.WriteLine("6) Kind: " + dt1.Kind);
            Console.WriteLine("7) Millisecond: " + dt1.Millisecond);
            Console.WriteLine("8) Minute: " + dt1.Minute);
            Console.WriteLine("9) Month: " + dt1.Month);
            Console.WriteLine("10) Second: " + dt1.Second);
            Console.WriteLine("11) Ticks: " + dt1.Ticks);
            Console.WriteLine("12) TimeOfDay: " + dt1.TimeOfDay);
            Console.WriteLine("13) Year: " + dt1.Year);

            var dt2 = new DateTime(2001, 8, 15, 13, 45, 58);
            var stg1 = dt2.ToLongDateString();
            var stg2 = dt2.ToLongTimeString();
            var stg3 = dt2.ToShortDateString();
            var stg4 = dt2.ToShortTimeString();
            var stg5 = dt2.ToString();
            var stg6 = dt2.ToString("yyyy-MM-dd HH:mm:ss");
            var stg7 = dt2.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine();
            Console.WriteLine(stg1);
            Console.WriteLine(stg2);
            Console.WriteLine(stg3);
            Console.WriteLine(stg4);
            Console.WriteLine(stg5);
            Console.WriteLine(stg6);
            Console.WriteLine(stg7);

            var x = new DateTime(2001, 8, 15, 13, 45, 58);
            var x1 = new TimeSpan(5, 10, 20, 20);
            var x2 = x.Add(x1);
            var y = x.AddDays(2);
            var y1 = x.AddHours(3.0);
            var y2 = x.AddMilliseconds(100);
            var y3 = x.AddMinutes(45.0);
            var y4 = x.AddMonths(3);
            var y5= x.AddSeconds(30.0);
            var y6 = x.AddTicks(900000000l);
            var y7= x.AddYears(5);
            DateTime y8 = x.Subtract(x1);
            TimeSpan y9 = y.Subtract(x);

            Console.WriteLine();
            Console.WriteLine($"DateTime exemplo: {x}");
            Console.WriteLine($"TimeSpan x1 (dias, horas, minutos e segundos): {x1}");
            Console.WriteLine($"Adicionando x1 no x: {x2}");
            Console.WriteLine($"AddDays = 2: {y}");
            Console.WriteLine($"AddHours = 3: {y1}");
            Console.WriteLine($"AddMilissegundos = 100: {y2}");
            Console.WriteLine($"AddMinutos = 45: {y3}");
            Console.WriteLine($"AddMonths = 3: {y4}");
            Console.WriteLine($"AddSeconds = 30: {y5}");
            Console.WriteLine($"AddTicks = 1 min e 30 s: {y5}");
            Console.WriteLine($"AddYears = 5: {y7}");        
            Console.WriteLine($"Subtraindo 5 dias, 10 horas, 20 min e 20 seg de {x} = {y8}");
            Console.WriteLine($"Subtraindo x de y = {y9}");

            Console.WriteLine();
            Console.WriteLine("Trabalhando com propriedades e operações com TimeSpan");
            Console.WriteLine();

            Console.ReadLine();
        }

        void TestaSwitchAndIfCondTernaria()
        {
            string day;
            bool result = true;

            while (result == true)
            {
                Console.Write("Digite um número da semana(1-7): ");
                var dia = int.Parse(Console.ReadLine());

                switch (dia)
                {
                    case 1:
                        day = "Sunday";
                        break;

                    case 2:
                        day = "Monday";
                        break;

                    case 3:
                        day = "Tuesday";
                        break;

                    case 4:
                        day = "Wednesday";
                        break;

                    case 5:
                        day = "Thursday";
                        break;

                    case 6:
                        day = "Friday";
                        break;

                    case 7:
                        day = "Saturday";
                        break;

                    default:
                        day = "Invalid value";
                        break;
                }
                Console.WriteLine($"\nDia: {day}");

                Console.Write("\nDeseja repetir (s/n)? ");
                var repeat = char.Parse(Console.ReadLine());

                var repeticao = (repeat == 's' || repeat == 's') ? result = true : result = false;

                Console.Clear();
            }
        }
    }
}

