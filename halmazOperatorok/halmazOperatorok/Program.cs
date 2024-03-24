using System.Collections.Generic;
using System.Linq;

namespace halmazOperatorok
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = new List<int>()
            {
                10, 3, 56, 67, 4, 6, 78, 44
            };

            List<int> list2 = new List<int>()
            {
                10, 5, 67, 89, 3, 22, 99
            };

            List<int> list3 = new List<int>()
            {
                1, 2, 3, 4
            };

            // képes összefűzni két lista elemeit
            IEnumerable<int> result1 = list1.Concat(list2);

            // képes összefűzni két lista elemeit, de egy elemet csak egyszer tesz át az új listába 
            IEnumerable<int> result2 = list1.Union(list2);

            // azokat az elemeket adja vissza, amelyek mindkét listában szerepelnek
            IEnumerable<int> result3 = list1.Intersect(list2); // 10, 3, 67

            // azokat az elemeket adja vissza, amelyek csak az első listában szerepelnek
            IEnumerable<int> result4 = list1.Except(list2); // 56, 4, 6, 78, 44

            // visszaadja az elemek számát
            int result5 = list1.Count(item => item > 10);

            // visszaadja az elemek számát, melyek nagyobbak mint 10
            int result6 = list1.Count(item => item > 10);

            int result7 = list1.Min();

            int result8 = list1.Max(); // 78

            // itt maximum keresést végzünk, megadunk egy kezdőértéket, melynél biztosan van nagyobb elem a listában
            int max = list3.Aggregate(-1, (result, item) => item > result ? item : result);

            int result9 = list1.Max( (item) => item % 3 ); // 2

            int result10 = list1.Sum(); // 268

            // itt a Sum operátort szimuláljuk
            int sum = list1.Aggregate((result, item) => result + item);

            double resul11 = list1.Average(); // 33.5

            int result12 = list1.Sum((item) => item * 2); // 536

            // kiszámoljuk a számok összegének egy százalékát (itt figyelni kell arra, hogy
            // double típusként lássa a fordító a kezdőértéket, hiszen tizedes törtet akarunk visszakapni
            var percent = list3.Aggregate(0.0, (result, item) => result + item, result => result / 100);

            foreach (int item in result4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"1% Aggregate: {percent}");
        }
    }
}
