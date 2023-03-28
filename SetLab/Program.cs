using System;

namespace SetLab
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Добро пожаловать в программу 'Множества 1.0'!");
            //try
            //{
            //    Console.WriteLine("Введите максимальное число множества:");
            //    string n;
            //    int maxValue;
            //    while (true)
            //    {
            //        n = Console.ReadLine();
            //        if (int.TryParse(n, out maxValue))
            //        {
            //            if (maxValue <= 0)
            //            {
            //                Console.WriteLine("Вы ввели некорректное значение. Попробуйте ещё раз.");
            //                continue;
            //            }
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Вы ввели непонятно что. Попробуйте ещё раз.");
            //        }
            //    }
            //    Console.WriteLine("Выберите множество, с которым вы хотите работать:");
            //    Console.WriteLine("Напишите SimpleSet - для работы с логическим множеством");
            //    Console.WriteLine("Напишите BitSet - для работы с битовым множеством");
            //    Console.WriteLine("Напишите MultiSet - для работы с мультимножеством");
            //    string set_name;
            //    Set set;
            //    while (true)
            //    {
            //        set_name = Console.ReadLine();
            //        set_name = set_name.ToLower();
            //        if (set_name == "simpleset")
            //        {
            //            set = new SimpleSet(maxValue);
            //            break;
            //        }  
            //        else if (set_name == "bitset")
            //        {
            //            set = new BitSet(maxValue);
            //            break;
            //        }
            //        else if (set_name == "multiset")
            //        {
            //            set = new MultiSet(maxValue);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Вы некорректно ввели тип множества. Попробуйте ещё раз.");
            //        }
            //    }
            //    Console.WriteLine("Введите исходное множество в виде строки с пробелами или введите множество со строки - для этого воспользуйтесь командой file.");
            //    string setNumbers = Console.ReadLine();
            //    if (setNumbers == "file")
            //    {
            //        Console.WriteLine("Введите путь до файла, с которого необходимо считать массив чисел:");
            //        string fileName = Console.ReadLine();
            //        try
            //        {
            //            StreamReader sFile = new StreamReader(fileName);
            //            setNumbers = sFile.ReadLine();
            //            while (setNumbers != null)
            //            {
            //                set.Add(Convert.ToInt32(setNumbers));
            //                setNumbers = sFile.ReadLine();
            //            }
            //            sFile.Close();
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine("Ошибка:" + e.Message);
                        
            //        }
            //    }
            //    set.Fill(setNumbers);
            //    Console.WriteLine("1 - операции добавления, удаления и проверки в множестве.");
            //    Console.WriteLine("2 - вывод множества на экран.");
            //    Console.WriteLine("Для выхода из программы напишите exit");
            //    while (true)
            //    {
            //        Console.WriteLine("Выберите операцию, которую вы хотите совершить: ");
            //        string command = Console.ReadLine();
            //        if (command == "1")
            //        {
            //            Console.WriteLine("Напишите число, с которым вы хотите работать: ");
            //            string number;
            //            int intNumber;
            //            while(true)
            //            {
            //                number = Console.ReadLine();
            //                if (int.TryParse(number, out intNumber))
            //                {
            //                    if (intNumber <= 0)
            //                    {
            //                        Console.WriteLine("Вы ввели некорректное число, попробуйте ещё раз.");
            //                    }
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Вы ввели непонятно что. Попробуйте ещё раз.");
            //                }
            //            }
            //            Console.WriteLine("Напишите Add - добавить элемент в множество.");
            //            Console.WriteLine("Напишите Remove - удалить элемент из множества.");
            //            Console.WriteLine("Напишите Contains - проверить элемент в множестве");
            //            while(true)
            //            {
            //                command= Console.ReadLine();
            //                if (command == "Add")
            //                {
            //                    set.Add(intNumber);
            //                    break;
            //                }
            //                else if (command == "Remove") {
            //                    set.Remove(intNumber);
            //                    break;
            //                }
            //                else if (command == "Contains")
            //                {
            //                    if(set.Contains(intNumber))
            //                    {
            //                        Console.WriteLine("Элемент присутствует в множестве.");
            //                        break;
            //                    }
            //                    Console.WriteLine("Элемент не присутствует в множестве.");
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Вы некорректно ввели операцию. Попробуйте ещё раз.");
            //                }
            //            }
            //        }
            //        else if (command == "2")
            //        {
            //            set.Print();
            //        }
            //        else if (command == "exit")
            //        {
            //            Console.WriteLine("Программа завершена. Спасибо за использование!");
            //            Environment.Exit(0);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            // Операторные тесты.
            SimpleSet set1= new SimpleSet(12);
            SimpleSet set2 = new SimpleSet(25);

            set1.Fill("1 3 4 7 9 10 11");
            set2.Fill("1 3 4 8 12 13 14 15 25");

            SimpleSet set3 = set1 + set2;
            SimpleSet set4 = set1 * set2;

            set3.Print();
            set4.Print();
        }
    }
}