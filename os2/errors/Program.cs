using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace errors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i = 0; i < args.Length; i++)
            {
                //Проверяем на существование файла
                if (!File.Exists(args[i]))
                {
                    Console.WriteLine("File {0} don't exists", args[i]);
                }
                    //Если файл существует
                else
                {
                    //пытаемся открыть его
                    try
                    {
                        using (TextReader reader = File.OpenText(args[i]))
                        {
                            string text = reader.ReadLine();
                            string[] bits = text.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                            int result;
                            foreach (string number in bits)
                            {
                                bool x = int.TryParse(number, out result);
                                if (!x)
                                {
                                    Console.WriteLine("Something is wrong in file {0}", args[i]);
                                }
                                else
                                {
                                    list.Add(result);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Can't open file {0}", args[i]);
                    }
                }
            }

            try
            {
                using (var outfile = new FileStream(args[args.Length - 1], FileMode.Create))
                {
                    using (var w = new StreamWriter(outfile))
                    {
                        foreach (int j in list.OrderBy(l => l).Distinct())
                        {
                            w.Write(j);
                            w.Write(" ");
                        }
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Can't open file {0} for writing", args[args.Length - 1]);
            }
        }
    }
}