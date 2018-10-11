using System;//содержит фундамент-е и базовые классы платформы .net
using System.Collections.Generic;
using System.Linq;
using System.Text;//описаны типы для обрабготки строк
using System.Threading.Tasks;
//using позволяет создать псевдоним для отдельного типа или пространства имен
namespace ConsoleApp2
{/*Int16 -- (-32,768 to +32,767)*/
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Int16 i16 = 9;//short 16bit     Int16 - тип System
            Int32 i32 = i16;//int 32 bit + неявное преобр
            Int64 i64 = num;//long 64 bit + неявное преобр
            double dl = i32;//64bit
            float f = (float)dl;//32 bit system.Single
            byte bt = (Byte)i16;
            short shrt = (short)num;
            long lng = (long)f;
            bool bools = false;
            char chr = 'd';

            int num_1 = 76;//Упаковкой (boxing) называется процесс преобразования типа в тип System.Object
            Object nam_1 = num_1; //упаковка
            int kak = (int)nam_1; //распаквка

            var neyav = "Danil";
            Console.WriteLine(neyav);
            int? x = null;
            int? x2 = x;
            Console.WriteLine(x2);

            ////////////////////string///////////////////

            string str1 = "text n1";
            string str2 = "text n22";
            if (String.CompareOrdinal(str1, str2) != 0)
                Console.WriteLine("Строки не идентичны");
            if (String.CompareOrdinal(str1, str2) == 0)
                Console.WriteLine("Строки идентичны");
            string str4 = "hello";
            string str5 = "WOrld";
            string str6 = "Zdrastvuite";

            string cout1 = String.Concat(str4, " ", str5);//сцепление
            Console.WriteLine(cout1);
            string cout2 = String.Copy(str4);//копирование
            Console.WriteLine(cout2);
            String sub = str6.Substring(1, 4);//выделение подстроки
            Console.WriteLine(sub);

            String value = "This is a short string.";//
            char delimiter = 's';
            String[] substrings = value.Split(delimiter);//Разделение строки на элементы, используя заданные разделители.Результаты помещаются в массив строк            //substrings - коллекция
            foreach (var substring in substrings)
                Console.WriteLine(substring);//foreach (тип имя_переменной_цикла in коллекция)         оператор;

            string text = "Хороший день";
            string subString = "замечательный ";

            text = text.Insert(8, subString);//в строку text вставили строку substring начиная с 8го символа
            Console.WriteLine(text);

            string text2 = text.Remove(0, 7);//удалили с 0 до 7 со строки text
            Console.WriteLine(text2);

            string nullik = "";
            string nullil = null;

            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");//Добавление в конец строки
            sb.Remove(0, 7);//Удаление подстроки из заданной позиции
            sb.Insert(0, "компьютерный ");//Вставка подстроки в заданную позицию
            sb.Insert(16, " Хогвардса ");
            Console.WriteLine(sb);

            /////////////////////array ////////////////////////
            int[,] myArr4 = new int[4, 5];

            Random ran = new Random();

            // Инициализируем данный массив
            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr4[k, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr4[k, j]);
                }
                Console.WriteLine();
            }

            string[] info = { "Фамилия", "Имя", "Отчество" };
            Console.WriteLine("length array: " + info.Length);
            for (int i = 0; i < info.Length; i++)
                Console.WriteLine(info[i]);



            int m = 0;
            // Объявляем ступенчатый массив
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];

            // Инициализируем ступенчатый массив
            Console.WriteLine("Input youhr array: ");
            for (; m < 2; m++)
            {
                int vvod = Convert.ToInt32(Console.ReadLine());
                myArr[0][m] = vvod;
            }


            for (m = 0; m < 3; m++)
            {

                int vvod = Convert.ToInt32(Console.ReadLine());
                myArr[1][m] = vvod;
            }

            for (m = 0; m < 4; m++)
            {
                int vvod = Convert.ToInt32(Console.ReadLine());
                myArr[2][m] = vvod;
            }

            for (m = 0; m < 2; m++)
            {

                Console.Write("{0}\t", myArr[0][m]);
            }

            Console.WriteLine();

            for (m = 0; m < 3; m++)
            {
                Console.Write("{0}\t", myArr[1][m]);
            }

            Console.WriteLine();

            for (m = 0; m < 4; m++)
            {
                Console.Write("{0}\t", myArr[2][m]);
            }

            Console.WriteLine();

            var vals = new[] { 1, 2, 3, 4, 5 };
            var valstr = "string";

            //////////////////////////// kortezhi /////////////
            (int yehrs, string FIO, char znak, string love, ulong kek) kartezh = (3, "NIlit", 'h', "volor", 312);

            Console.WriteLine("vash cartage: " + kartezh);
            Console.WriteLine("vash cartage: " + kartezh.yehrs + " " + kartezh.znak + " " + kartezh.love);

            Console.ReadKey();

        }
    }
}

/*
 * 
 * CLR (Common Language Runtime) – Среда
Времени Выполнения или Виртуальная
Машина. Обеспечивает выполнение
сборки 


    CLS (Common Language Specification) –
общеязыковая спецификация, предназначенная для
разработчиков компиляторов

    CTS (Common Type
Systems)- спецификацию типов, которые должны
поддерживаться всеми языками ориентированными на
CLR.
 * 
 * 
 * 
sbyte 8        System.Sbyte
short 16         System.Int16
int 32           System.Int32
long 64          System.Int64
byte 8           System.Byte
ushort 16        System.Uint16
uint 32          System.Uint32
ulong 64         System.Uint64
char 16          System.Char
bool 8           System.Boolean
float 32         System.Single
double 64        System.Double
decimal 128      System.Decimal
string -         System.String
object -         System.Object*/
