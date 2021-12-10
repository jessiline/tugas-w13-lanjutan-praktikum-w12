using System;
using System.Collections.Generic;
namespace praktikum_w12
{
    class Program
    {
        static void cariBuku(List<string> scrolls, string cari, int input)
        {
            int ada = 0;
            for (int i = 0; i < scrolls.Count; i++)
            {
                if (cari.Equals(scrolls[i], StringComparison.OrdinalIgnoreCase) == true)
                {
                    ada = 1;
                    if (input == 3)
                    {
                        Console.WriteLine($"Book found. Queue number : {scrolls.IndexOf(scrolls[i]) + 1}");
                    }
                    if (input == 4)
                    {
                        scrolls.Remove(scrolls[i]);
                        Console.WriteLine("Book Removed!");
                    }
                }
            }
            if (ada == 0)
            {
                Console.WriteLine("Book not found");
            }
        }
        static void Main(string[] args)
        {
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            string ulang = "y";
            while (ulang == "y")
            {
                Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll \nChoose what to do: ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (input == 1)
                {
                    Console.WriteLine("Scroll to learn list: ");
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        Console.WriteLine("scroll " + (i + 1) + " : " + scrolls[i]);
                    }
                }
                if (input == 2)
                {
                    Console.Write("How many scroll to add: ");
                    int tambah = Convert.ToInt32(Console.ReadLine());
                    Console.Write("In what number of queue? ");
                    int urutan = Convert.ToInt32(Console.ReadLine());
                    if (urutan <= 0)
                    {
                        urutan = 1;
                    }
                    if (urutan > scrolls.Count)
                    {
                        urutan = scrolls.Count + 1;
                    }
                    for (int i = 1; i <= tambah; i++)
                    {
                        Console.Write("scroll " + i + " name: ");
                        string nama = Console.ReadLine();
                        scrolls.Insert(urutan - 1, nama);
                        urutan++;
                    }
                }
                string cari;
                if (input == 3)
                {
                    Console.Write("Insert scroll name: ");
                    cari = Console.ReadLine();
                    cariBuku(scrolls, cari, input);

                }
                if (input == 4)
                {
                    Console.Write("Remove from list by scroll name? Y/N: ");
                    string hapus = Console.ReadLine();
                    while (hapus != "y" && hapus != "n")
                    {
                        Console.WriteLine("\nWrong selection, Choose again:");
                        Console.Write("Remove from list by scroll name? Y/N: ");
                        hapus = Console.ReadLine();
                    }
                    if (hapus == "y")
                    {
                        Console.Write("Input scroll name : ");
                        cari = Console.ReadLine();
                        cariBuku(scrolls, cari, input);
                    }
                    if (hapus == "n")
                    {
                        Console.Write("Input scroll queue: ");
                        int queue = Convert.ToInt32(Console.ReadLine());
                        int cek = 0;
                        while (cek == 0)
                        {
                            for (int i = 1; i <= scrolls.Count; i++)
                            {
                                if (queue == i)
                                {
                                    scrolls.Remove(scrolls[i - 1]);
                                    Console.WriteLine("Book Removed!");
                                    cek = 1;
                                }
                            }
                            if (cek == 0)
                            {
                                Console.Write("Queue not found. insert scroll queue: ");
                                queue = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
