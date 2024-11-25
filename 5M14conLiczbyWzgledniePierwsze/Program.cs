namespace _5M14conLiczbyWzgledniePierwsze
{
    /* rozwiązanie zgodne z zadaniem na teams
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> dzielniki1;
            List<int> dzielniki2;
            int[] t1;
            int[] t2;
            int a = 0, b = 0;
            Console.Write("podaj pierwszą liczbę: ");
            if(!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("błędna liczba");
                return;
            }
            Console.Write("podaj drugą liczbę: ");
            if(!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("błędna liczba");
                return;
            }
            if(a<1 || b<1)
            {
                Console.WriteLine("błędna liczba");
                return;
            }
            dzielniki1 = obliczDzielniki(a);
            dzielniki2 = obliczDzielniki(b);
            if (sprawdzDzielniki(dzielniki1, dzielniki2))
                Console.WriteLine($"licby {a} i {b} są wzgłędnie pierwsze");
            else
                Console.WriteLine($"licby {a} i {b} nie są wzgłędnie pierwsze");

            Console.WriteLine("testy");
            // 21 i 25
            a = 21;
            b = 25;
            dzielniki1 = obliczDzielniki(a);
            dzielniki2 = obliczDzielniki(b);
            if (sprawdzDzielniki(dzielniki1, dzielniki2))
                Console.WriteLine($"licby {a} i {b} są wzgłędnie pierwsze");
            else
                Console.WriteLine($"licby {a} i {b} nie są wzgłędnie pierwsze");

            // 12 15
            a = 12;
            b = 15;
            dzielniki1 = obliczDzielniki(a);
            dzielniki2 = obliczDzielniki(b);
            if (sprawdzDzielniki(dzielniki1, dzielniki2))
                Console.WriteLine($"licby {a} i {b} są wzgłędnie pierwsze");
            else
                Console.WriteLine($"licby {a} i {b} nie są wzgłędnie pierwsze");

        }

        private static bool sprawdzDzielniki(List<int> d1, List<int> d2)
        {
            for (int i = 1; i < d1.Count; i++)
                for (int j = 1; j < d2.Count; j++)
                    if (d1[i] == d2[j])
                        return false;
            return true;
        }
        /*****************************************
         * nazwa funkcji:  obliczDzielniki()
         * opis:           funkcja zwraca listę dzielników liczby
         *                 podanej jako argument
         * parametry:      a, liczba całkowita
         * zwracana wart.: lista liczb całkowitych bedących dzielnikami 
         *                 liczby podanej jako parametr
         * autor:          mm                
         ****************************************/
        private static List<int> obliczDzielniki(int a)
        {
            Console.Write(a);
            List<int> liczby = new List<int>();
            int i = 2;
            liczby.Add(1);
            while(a >= i)
            {
                while(a%i == 0)
                {
                    liczby.Add(i);
                    a = a / i;
                }
                i++;
            }
            Console.WriteLine($" {liczby.Count}");
            return liczby;
        }

        private static int[] obliczDzielnikiTab(int a)
        {
            Console.Write(a);
            List<int> liczby = new List<int>();
            int i = 2;
            liczby.Add(1);
            while (a >= i)
            {
                while (a % i == 0)
                {
                    liczby.Add(i);
                    a = a / i;
                }
                i++;
            }
            Console.WriteLine($" {liczby.Count}");
            return liczby.ToArray();
        }

    }
}
