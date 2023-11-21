using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Setul_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ex_1();
            ex_2();
            ex_3();
            ex_4();
            ex_5();
            ex_6();
            ex_7();
            ex_8();
            ex_9();
            ex_10();
            ex_11();
            ex_12();
            ex_13();
            ex_14();
            ex_15();
            ex_16();
            ex_17();
            ex_18();
            ex_19();
            //ex_20();
            //ex_21();
            ex_22();
            ex_23();
            ex_24();
            ex_25();
            ex_26();
            ex_27();
            ex_28();
            ex_29();
            ex_30();
            ex_31();

            Console.ReadKey();
        }


        private static void ex_1()
        {
            int n, x;
            long S = 0;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector,");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("apoi elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
                S += v[i];

            }
            Console.WriteLine("si aflati suma elementelor vectorului");
            Console.WriteLine();
            Console.WriteLine($"Suma este {S}");
            Console.WriteLine();
        }

        private static void ex_2()
        {
            int n, k, x, i;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector si un numar k");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("apoi elementele vectorului");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }
            Console.WriteLine($"si aflati prima pozitie pe care se afla {k}");
            for (i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"prima pozitie pe care se afla {k} este {i}");
                    break;
                }

            }
            Console.WriteLine();
            if (i == n)
                Console.WriteLine($"pozitia pe care se afla este -1");
            Console.WriteLine();
        }
        private static void ex_3()
        {
            int n, poz_min = 0, poz_max = 0, min, max, x;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("apoi elementele vectorului");
            x = int.Parse(Console.ReadLine());
            min = max = x;
            int[] v = new int[n];
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }
            Console.WriteLine($"si aflati prima pozitie pe care se afla minimul, respectiv maximul din vector");
            for (int i = 1; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    poz_max = i;
                }
                else
                if (v[i] < min)
                {
                    min = v[i];
                    poz_min = i;
                }

            }
            Console.WriteLine();
            if (min == max)
                Console.WriteLine($"Minimul fiind egal cu maximul, {min}, acesta se afla pe poz 0");
            else
                Console.WriteLine($"Pozitiile pe care se afla {min} si {max} sunt {poz_min}, respectiv {poz_max}");
            Console.WriteLine();
        }
        private static void ex_4()
        {
            int n, poz_min = 1, poz_max = 1, min, max, x;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("apoi elementele vectorului");
            x = int.Parse(Console.ReadLine());
            min = max = x;
            int[] v = new int[n];
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }
            Console.WriteLine($"si aflati printr o singura parcurgere a vectorului minimul, respectiv maximul precum si numarul de aparitii al acestora");
            for (int i = 1; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    poz_max = 1;
                }
                else
                    if (v[i] == max && v[i] != min)
                    poz_max++;
                else
                        if (v[i] < min)
                {
                    min = v[i];
                    poz_min = 1;
                }
                else
                            if (v[i] == min && v[i] != max)
                    poz_min++;
            }
            Console.WriteLine();
            if (min == max)
                Console.WriteLine($"Minimul fiind egal cu maximul,{min}, numarul de apartitii al acestuia este {n}");
            else
                Console.WriteLine($"Minimul si maximul sunt {min} si {max} si numarul de apartitii al acestora este {poz_min}, respectiv {poz_max}");
            Console.WriteLine();
        }
        private static void ex_5()
        {
            int n, e, k, x;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector, e un numar, si k, o pozitie din vector");
            n = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"apoi elementele vectorului si inserati elementul {e} pe pozitia {k}");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (i == k)
                    v[i] = e;
                else
                    v[i] = x;

            }
            Console.WriteLine();
            Console.WriteLine("Vectorul actualizat este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

        }

        private static void ex_6()
        {
            int n, k, x;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector si k, o pozitie din vector");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("apoi elementele vectorului");
            int?[] v = new int?[n];
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }

            Console.WriteLine($"si stergeti elementul de pe pozitia {k}");

            for (int i = k; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n - 1] = null;
            n--;
            Console.WriteLine();
            Console.WriteLine("Vectorul actualizat este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();
        }
        private static void ex_7()
        {
            int n, x, aux;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("apoi elementele vectorului");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }

            Console.WriteLine($"si inversati pozitia tuturor elementelor din vector");

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }

            Console.WriteLine();
            Console.WriteLine("Vectorul actualizat este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();
        }
        private static void ex_8()
        {
            int n, x, aux;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("apoi elementele vectorului");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }

            Console.WriteLine($"si rotiti pozitia primului elem spre stg");
            aux = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];

            v[n - 1] = aux;
            Console.WriteLine();
            Console.WriteLine("Vectorul actualizat este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

        }
        private static void ex_9()
        {
            int n, k, x, aux;
            Console.WriteLine("Cititi doua nr naturale nenule n, dimensiunea unui vector si k");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("apoi elementele vectorului");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }

            Console.WriteLine($"si rotiti pozitia primului elem spre stg de {k} ori");
            for (int j = 0; j < k; j++)
            {
                aux = v[0];
                for (int i = 0; i < n - 1; i++)
                    v[i] = v[i + 1];
                v[n - 1] = aux;
            }


            Console.WriteLine("Vectorul actualizat este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();
        }

        private static void ex_10()
        {
            int n, x, stg = 0, dr, mij, k;
            Console.WriteLine("Cititi doua nr naturale nenule n, dimensiunea unui vector si k, un posibil elem din vector");
            n = int.Parse(Console.ReadLine());
            dr = n - 1;
            k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("apoi elementele vectorului sortate crescator");
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }

            Console.WriteLine($"si aflati pozitia elementului {k} din vector folosindu va de alg de cautare binara");


            while (stg <= dr)
            {
                mij = (stg + dr) / 2;

                if (k == v[mij])
                {
                    Console.Write($"Pozitia lui {k} in vector este {mij}");
                    break;
                }
                else
                    if (k < v[mij])
                    dr = mij - 1;
                else
                    stg = mij + 1;
            }
            Console.WriteLine();
            if (stg > dr)
                Console.Write($"Pozitia lui {k} in vector este -1");
            Console.WriteLine();
        }
        private static void ex_11()
        {
            int n;
            Console.WriteLine("Cititi un numar natural nenul n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("si construiti Ciurul lui Eratostene: ");
            int[] v = new int[n + 1];

            v[1] = 0;

            for (int i = 2; i <= n; i++)///1 nu este prim
                v[i] = 1;

            for (int i = 2; i * i <= n; i++)
            {
                for (int j = i; j <= n / i; j++)
                    v[i * j] = 0;
            }
            for (int i = 1; i <= n; i++)
                Console.Write(v[i] + "  ");
            Console.WriteLine();
        }
        private static void ex_12()
        {
            ///<sortare prin selectie>
            ///
            int n, x, pivot, aux, poz;
            Console.WriteLine("Cititi un numar n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"apoi {n} elemente ale sale");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }

            for (int i = 0; i < n - 1; i++)
            {
                pivot = i;

                for (int j = i + 1; j < n; j++)
                    if (v[j] < v[pivot])
                        pivot = j;

                aux = v[pivot];
                v[pivot] = v[i];
                v[i] = aux;

            }

            Console.WriteLine("Nr sortate sunt: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
        }
        private static void ex_13()
        {
            ///<sortare prin insertie>
            ///
            int n, x;
            Console.WriteLine("Cititi un numar n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"apoi {n} elemente ale sale");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0 && v[j] < v[j - 1]; j--)
                {
                    aux = v[j];
                    v[j] = v[j - 1];
                    v[j - 1] = aux;
                }

            }
            Console.WriteLine("Nr sortate sunt: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
        }
        private static void ex_14()
        {
            int n, x, i, zero = 0, indice_nul = -1;
            Console.WriteLine("Cititi un numar n, dimensiunea unui vector,");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"apoi {n} elemente ale sale");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }
            Console.WriteLine("si mutati toate elementele nule la capatul drept al vectorului printr o singura parcurgere a sa");

            i = 0;

            while (i < n)
            {

                zero = 0;
                while (i < n && v[i] == 0)
                {
                    i++;
                    zero++;
                }
                if (zero == 0)
                {
                    if (indice_nul != -1)
                    {
                        v[indice_nul] = v[i];
                        v[i] = 0;
                        if (v[indice_nul + 1] == 0)
                            indice_nul++;
                        else
                            indice_nul = -1;
                    }
                }
                else

                    if (i < n)
                {
                    if (indice_nul != -1)
                    {
                        if (indice_nul < i - zero) ///indice_nul e deobicei < i - zero, si deci, prima pozitie ce se ea in considerare, 
                        {                           ///pt a muta elementelul nul in dreapta si elementel nenul in stanga este aceea care e cea mai mica dintre indice_nul si i - zero

                            v[indice_nul] = v[i];
                            v[i] = 0;
                            if (v[indice_nul + 1] == 0)
                                indice_nul++;
                            else
                                indice_nul = i - zero;
                        }

                        else
                        {

                            v[i - zero] = v[i];
                            v[i] = 0;
                            if (v[i - zero + 1] == 0)
                                indice_nul = i - zero + 1;
                            else
                                indice_nul = -1;
                        }
                    }
                    else
                    {
                        v[i - zero] = v[i];
                        v[i] = 0;
                        if (v[i - zero + 1] == 0)
                            indice_nul = i - zero + 1;

                    }

                }
                i++;
            }
            Console.WriteLine("Vectorul actualizat este: ");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
        }
        private static void ex_15()
        {
            int n, x;
            Console.WriteLine("Cititi un numar n, dimensiunea unui vector,");
            n = int.Parse(Console.ReadLine());
            int?[] v = new int?[n];
            Console.WriteLine("apoi cititi pe fiecare linie noua elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }
            Console.WriteLine("si stergeti elementele ce se repeta, dar fara a va folosi de alt vector");
            for (int i = 0; i < n - 1; i++)
            {

                for (int j = i + 1; j < n; j++)
                    if (v[i] == v[j])
                    {
                        for (int k = j; k < n - 1; k++)

                            v[k] = v[k + 1];

                        v[n - 1] = null;
                        n--;

                        if (v[i] == v[j])
                            j--;
                    }
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul actualizat este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

        }
        private static int cmmdc(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
        private static void ex_16()
        {
            int n, x;
            Console.WriteLine("Cititi un numar n, dimensiunea unui vector,");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("apoi cititi pe fiecare linie noua elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;

            }
            Console.WriteLine("si afisati cmmdc al elementelor din vector:");
            int elem = v[0];

            for (int i = 1; i < n; i++)
                if (elem != 1)
                    elem = cmmdc(elem, v[i]);
                else
                    break;

            Console.WriteLine(elem);

            Console.WriteLine();

        }

        private static void conversie(int n, int b)
        {
            if (n != 0)
            {
                conversie(n / b, b);
                if (n % b > 9)
                {
                    if (n % b == 10)
                        Console.Write("A");
                    else
                     if (n % b == 11)
                        Console.Write("B");
                    else
                         if (n % b == 12)
                        Console.Write("C");
                    else
                         if (n % b == 13)
                        Console.Write("D");
                    else
                        if (n % b == 14)
                        Console.Write("E");
                    else
                        Console.Write("F");
                }
                else
                    Console.Write(n % b);
            }

        }

        private static void ex_17()
        {
            Console.WriteLine("Dati un numar de la tastatura convertit in baza 10 si b, o baza de numeratie: 16<=b<=2 ");
            int n = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());

            Console.WriteLine("Numarul convertit e: ");

            conversie(n, b);

            Console.WriteLine();
        }
        private static long termen(int n, long[] v, int i, long x, int exp)
        {
            if (exp != 0)
                return x * termen(n, v, i, x, exp - 1);
            return v[i];
        }
        private static void ex_18()
        {
            int n; long Sum, x;
            Console.WriteLine("Cititi un numar natural nenul, n, dimensiunea unui vector,");
            n = int.Parse(Console.ReadLine());

            long[] v = new long[n];
            Console.WriteLine($"cititi pe fiecare linie noua, elementele din vector, ce reprezinta coeficicienti sumei polinomiale, de dimensiune {n}");
            for (int i = 0; i < n; i++)
            {
                x = long.Parse(Console.ReadLine());
                v[i] = x;
            }

            Random rnd = new Random();
            x = rnd.Next(0, 1024);
            Console.WriteLine($"apoi alegeti o valoare {x} pt a o inlocui in suma data");
            Console.WriteLine();
            Sum = v[0];
            for (int i = 1; i < n; i++)
                Sum += termen(n, v, i, x, i);
            Console.WriteLine($"Suma este: {Sum}");
            Console.WriteLine();
        }
        private static void ex_19()
        {
            int n, m, x, i = 0, i1, j, k, sir = 0;
            Console.WriteLine("Cititi doua nr n, m, n > m, dimensiunile a doi vectori");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            if (n < m)
            {
                int aux = n;
                n = m;
                m = aux;
            }
            int[] a = new int[n];
            Console.WriteLine($"Apoi cititi pe fiecare linie noua, elementele din vectorul a, de dimensiune {n}");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                a[i] = x;
            }
            int[] b = new int[m];
            Console.WriteLine($"respectiv elementele din vectorul b, de dimensiune {m}");
            for (i = 0; i < m; i++)
            {
                x = int.Parse(Console.ReadLine());
                b[i] = x;
            }
            Console.WriteLine("si aflati de cate ori se repeta al doilea vector in primul");
            while (i + m <= n)
            {
                if (b[0] == a[i])
                {
                    k = 1;
                    i1 = i + 1;
                    while (k < m)
                    {
                        if (b[k] != a[i1])
                            break;
                        else
                        {
                            k++;
                            i1++;
                        }
                    }
                    if (k == m)
                        sir++;

                    i = i1;

                }
                else
                    i++;
            }
            Console.WriteLine();
            Console.WriteLine($"numarul de aparitii al celui de al doilea vector in primul este {sir}");
            Console.WriteLine();
        }
        private static int diferente_x_y_lungime(int?[] a, int?[] b, int n, int m, int lungime)
        {
            int j;
            for (int i = 0; i < n; i++)
            {

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])
                        break;
                if (j == m)
                    lungime++;

            }
            return lungime;
        }
        private static void diferente_x_y(int?[] a, int?[] dif_a, int?[] b, int n, int m)
        {
            int j, contor = 0;
            for (int i = 0; i < n; i++)
            {

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])

                        break;

                if (j == m)
                {
                    dif_a[contor] = a[i];
                    contor++;
                }

            }
        }
        private static int diferente_x_y_lungime_0(int[] a, int[] b, int n, int m, int lungime)
        {
            int j;
            for (int i = 0; i < n; i++)
            {

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])
                        break;
                if (j == m)
                    lungime++;

            }
            return lungime;
        }
        private static void diferente_x_y_0(int[] a, int[] dif_a, int[] b, int n, int m)
        {
            int j, contor = 0;
            for (int i = 0; i < n; i++)
            {

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])

                        break;

                if (j == m)
                {
                    dif_a[contor] = a[i];
                    contor++;
                }

            }
        }
        private static int stergere_elemente_duplicate(int?[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {

                for (int j = i + 1; j < n; j++)
                    if (a[i] == a[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        a[n - 1] = null;
                        n--;
                        if (a[j] == a[i])
                            j--;
                    }
            }
            return n;
        }
        private static void ex_22()
        {
            int n, m, x, i, j;
            Console.WriteLine("Cititi doua nr n, m, dimensiunile a doi vectori");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            int?[] a = new int?[n];
            Console.WriteLine("Apoi cititi pe fiecare linie noua, elementele din primul vector");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                a[i] = x;
            }
            int?[] b = new int?[m];
            Console.WriteLine("respectiv elementele din al doilea vector");
            for (i = 0; i < m; i++)
            {
                x = int.Parse(Console.ReadLine());
                b[i] = x;
            }
            Console.WriteLine("si aflati reuniunia, intersectia si diferentele dintre cei doi vectori v1-v2 si v2 -v1");

            Console.WriteLine();
            ///<stergem elementele duplicate din fiecare vector>
            n = stergere_elemente_duplicate(a, n);
            m = stergere_elemente_duplicate(b, m);

            ///<aflam lungimea elementelor din urmatorii noi 2 vectori dif_a[], dif_b[] ce reprezinta diferentele dintre cei 2 vectori din cerinta
            int lungime_dif_a = 0, lungime_dif_b = 0, lungime_reuniune = 0;
            lungime_dif_a = diferente_x_y_lungime(a, b, n, m, lungime_dif_a);
            lungime_dif_b = diferente_x_y_lungime(b, a, m, n, lungime_dif_b);

            int?[] reuniune;
            if (lungime_dif_a == 0 && lungime_dif_b == 0)
            {
                reuniune = new int?[n];
            }
            else
                if (lungime_dif_a == 0)
            {
                reuniune = new int?[m];
            }
            else
                    if (lungime_dif_b == 0)
            {
                reuniune = new int?[n];
            }
            else
            {
                reuniune = new int?[lungime_dif_a + lungime_dif_b + (n - lungime_dif_a)];
            }

            if (lungime_dif_a != 0)
            {

                int?[] dif_a = new int?[lungime_dif_a];
                diferente_x_y(a, dif_a, b, n, m);
                int lungime_inter = n - lungime_dif_a;

                Console.WriteLine();

                if (lungime_inter > 0)
                {

                    int?[] inter = new int?[lungime_inter];
                    diferente_x_y(a, inter, dif_a, n, lungime_dif_a);

                    Console.WriteLine("v1 intersectat cu v2: ");
                    for (i = 0; i < lungime_inter; i++)
                    {
                        Console.Write(inter[i] + " ");
                        reuniune[lungime_reuniune] = inter[i];
                        lungime_reuniune++;

                    }
                }
                else
                    Console.WriteLine("v1 intersectat cu v2 este multimea vida");

                Console.WriteLine();
                Console.WriteLine("v1 - v2: ");
                for (i = 0; i < lungime_dif_a; i++)
                {
                    Console.Write(dif_a[i] + " ");
                    reuniune[lungime_reuniune] = dif_a[i];
                    lungime_reuniune++;

                }
            }
            else
                Console.WriteLine("v1 - v2 este multimea vida ");


            if (lungime_dif_b != 0)
            {
                int?[] dif_b = new int?[lungime_dif_b];

                diferente_x_y(b, dif_b, a, m, n);

                Console.WriteLine();

                if (lungime_dif_a == 0)
                {

                    Console.WriteLine("v1 intersectat cu v2: ");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write(a[i] + " ");
                        reuniune[lungime_reuniune] = a[i];
                        lungime_reuniune++;
                    }


                }
                Console.WriteLine();
                Console.WriteLine("v2 - v1: ");
                for (i = 0; i < lungime_dif_b; i++)
                {
                    Console.Write(dif_b[i] + " ");
                    reuniune[lungime_reuniune] = dif_b[i];
                    lungime_reuniune++;

                }


            }
            else
                Console.WriteLine("v2 - v1 este multimea vida ");


            if (lungime_dif_a == 0 && lungime_dif_b == 0)
            {

                Console.WriteLine("v1 intersectat cu v2: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(a[i] + " ");
                    reuniune[lungime_reuniune] = a[i];
                    lungime_reuniune++;
                }
            }
            Console.WriteLine("v1 U V2: ");
            for (i = 0; i < lungime_reuniune; i++)
                Console.Write(reuniune[i] + " ");

            Console.WriteLine();

        }
        private static void ex_23()
        {
            int n, m, x, i, j;
            Console.WriteLine("Cititi doua nr n, m, dimensiunile a doi vectori sortati strict crescator");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Apoi cititi pe fiecare linie noua, elementele din primul vector sortat");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                a[i] = x;
            }
            int[] b = new int[m];
            Console.WriteLine("respectiv elementele din al doilea vector sortat");
            for (i = 0; i < m; i++)
            {
                x = int.Parse(Console.ReadLine());
                b[i] = x;
            }
            Console.WriteLine("si aflati reuniunia, intersectia si diferentele dintre cei doi vectori v1-v2 si v2 -v1");
            Console.WriteLine();
            ///<aflam lungimea elementelor din urmatorii noi 2 vectori, dif_a[], dif_b[] ce reprezinta diferentele dintre cei 2 vectori din cerinta>

            int lungime_dif_a = 0, lungime_dif_b = 0;

            lungime_dif_a = diferente_x_y_lungime_0(a, b, n, m, lungime_dif_a);
            lungime_dif_b = diferente_x_y_lungime_0(b, a, m, n, lungime_dif_b);

            if (lungime_dif_a != 0)
            {
                int[] dif_a = new int[lungime_dif_a];
                diferente_x_y_0(a, dif_a, b, n, m);
                int lungime_inter = n - lungime_dif_a;

                if (lungime_inter != 0)
                {
                    int[] inter = new int[lungime_inter];
                    diferente_x_y_0(a, inter, dif_a, n, lungime_dif_a);

                    Console.WriteLine("v1 intersectat cu v2: ");
                    for (i = 0; i < lungime_inter; i++)

                        Console.Write(inter[i] + " ");

                }

                else
                    Console.WriteLine("v1 intersectat cu v2 este multimea vida");


                Console.WriteLine();
                Console.WriteLine("v1 - v2: ");
                for (i = 0; i < lungime_dif_a; i++)

                    Console.Write(dif_a[i] + " ");

            }
            else
                Console.WriteLine("v1 - v2 este multimea vida ");



            if (lungime_dif_b != 0)
            {
                int[] dif_b = new int[lungime_dif_b];

                diferente_x_y_0(b, dif_b, a, m, n);


                if (lungime_dif_a == 0)
                {
                    Console.WriteLine("v1 intersectat cu v2: ");
                    for (i = 0; i < n; i++)

                        Console.Write(a[i] + " ");

                }
                Console.WriteLine();
                Console.WriteLine("v2 - v1: ");
                for (i = 0; i < lungime_dif_b; i++)

                    Console.Write(dif_b[i] + " ");

            }
            else
                Console.WriteLine("v2 - v1 este multimea vida ");

            if (lungime_dif_a == 0 && lungime_dif_b == 0) ///2 multimi identice
            {
                Console.WriteLine("v1 intersectat cu v2: ");
                for (i = 0; i < n; i++)
                    Console.Write(a[i] + " ");
            }


            Console.WriteLine();
            i = 0; j = 0;
            Console.WriteLine("v1 U V2: ");
            while (i < n && j < m)
            {
                if (a[i] < b[j])
                {
                    Console.Write(a[i] + " ");
                    i++;
                }
                else
                if (a[i] > b[j])
                {
                    Console.Write(b[j] + " ");
                    j++;

                }
                else
                {
                    Console.Write(b[j] + " ");
                    i++;
                    j++;
                }
            }

            while (i < n)
            {
                Console.Write(a[i] + " ");
                i++;
            }

            while (j < m)
            {
                Console.Write(b[j] + " ");
                j++;
            }

            Console.WriteLine();

        }
        private static void ex_24()
        {
            int n, m, x, i, j;
            Console.WriteLine("Cititi doua nr n, m, n > m, dimensiunile a doi vectori");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            if (n < m)
            {
                int aux = n;
                n = m;
                m = aux;
            }
            int[] a = new int[n + 2];

            int[] b = new int[m + 2];



            Console.WriteLine("Apoi cititi pe fiecare linie noua, elementele din primul vector");
            for (i = 0; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                    a[i] = 1;
                else
                    a[i] = 0;
            }

            Console.WriteLine("respectiv elementele din al doilea vector");
            for (i = 0; i <= m; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                    b[i] = 1;
                else
                    b[i] = 0;
            }

            Console.WriteLine("si aflati reuniunia, intersectia si diferentele dintre cei doi vectori v1-v2 si v2 -v1");

            Console.WriteLine();
            Console.WriteLine("v1 U V2: ");
            for (i = 0; i <= m; i++)
                if (a[i] == 1 || b[i] == 1)
                    Console.Write(i + " ");
            for (i = m + 1; i <= n; i++)
                if (a[i] == 1)
                    Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine("v1 intersectat cu v2: ");
            for (i = 0; i <= m; i++)
                if (a[i] == 1 && b[i] == 1)
                    Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("v1 - v2: ");
            for (i = 0; i <= m; i++)
                if (a[i] == 1 && b[i] == 0)
                    Console.Write(i + " ");
            for (i = m + 1; i <= n; i++)
                if (a[i] == 1)
                    Console.Write(i + " ");

            Console.WriteLine();
            Console.WriteLine("v2 - v1 ");
            for (i = 0; i <= m; i++)
                if (b[i] == 1 && a[i] == 0)
                    Console.Write(i + " ");

            Console.WriteLine();


        }
        private static void ex_25()
        {
            int n, m, x, i, j;
            Console.WriteLine("Cititi doua nr n, m, n > m, dimensiunile a doi vectori");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            if (n < m)
            {
                int aux = n;
                n = m;
                m = aux;
            }
            int[] a = new int[n];
            Console.WriteLine($"Apoi cititi pe fiecare linie noua, elementele sortate din vectorul a, de dimensiune {n}");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                a[i] = x;
            }
            int[] b = new int[m];
            Console.WriteLine($"respectiv elementele sortate din vectorul b, de dimensiune {m}");
            for (i = 0; i < m; i++)
            {
                x = int.Parse(Console.ReadLine());
                b[i] = x;
            }
            Console.WriteLine("si interclasati cei 2 vectori: ");


            i = 0; j = 0; 
            while (i < n && j < m) ///ne folosim de unul dintre pasii algoritmului MergeSort
            {
                if (a[i] < b[j])
                {
                    Console.Write(a[i] + " ");
                    i++;
                }
                else
                {
                    Console.Write(b[j] + " ");
                    j++;
                }
               
            }

            while (j < m)
            {
                Console.Write(b[j] + " ");
                j++;
                
            }

            while (i < n)
            {
                Console.Write(a[i] + " ");
                i++;
            }


            Console.WriteLine();
        }
        private static void ex_26()
        {
            int n, m, x, i, j;
            bool neg = false;
            Console.WriteLine("Cititi doua nr n, m, dimensiunile a doi vectori");

            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            if (n < m)
            {
                neg = true;
                int aux = n;
                n = m;
                m = aux;
            }

            int[] a = new int[n];
            int[] Sum = new int[n];
            int[] Dif = new int[n];

            Console.WriteLine();
            Console.WriteLine($"apoi pe fiecare linie noua, cifrele din vectorul a, de dimensiune {n}");

            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                a[i] = x;
            }

            Console.WriteLine();
            int[] b = new int[m];
            Console.WriteLine($"respectiv cifrele din vectorul b, de dimensiune {m}");
            for (i = 0; i < m; i++)
            {
                x = int.Parse(Console.ReadLine());
                b[i] = x;

            }

            Console.WriteLine();
            Console.WriteLine("si aflati suma, diferenta si produsul nr reprezentate de cifrele din cei doi vectori");


            ///1) SUMA
            bool carry = false;
            for (i = n - 1; i > n - m - 1; i--)
            {
                if (a[i] + b[m - 1 - (n - 1 - i)] >= 10)
                {
                    if (carry)
                        Sum[i] = (a[i] + b[m - 1 - (n - 1 - i)] + 1) % 10;
                    else
                    {
                        Sum[i] = (a[i] + b[m - 1 - (n - 1 - i)]) % 10;
                        carry = true;
                    }
                }
                else
                {
                    if (carry)
                    {
                        if (a[i] + b[m - 1 - (n - 1 - i)] + 1 <= 9)
                            carry = false;
                        Sum[i] = (a[i] + b[m - 1 - (n - 1 - i)] + 1) % 10;
                    }

                    else
                        Sum[i] = a[i] + b[m - 1 - (n - 1 - i)];
                }

            }
            for (j = i; j >= 0; j--)///nu mai sunt cifre in al doilea vector
            {
                if (carry)
                {
                    if (a[j] != 9)
                    {
                        Sum[j] = a[j] + 1;
                        carry = false;
                    }
                    else
                        Sum[j] = 0;
                }
                else
                    Sum[j] = a[j];
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Suma este: ");
            if (carry)
                Console.Write(1);///prin insumarea celor 2 vectori, s a obtinut un nr cu n+1 cifre

            for (i = 0; i < n; i++)
                Console.Write(Sum[i]);



            ///2) DIFERENTA

            if (!neg && n == m)
            {
                if (a[0] == b[0])
                {
                    i = 1;
                    while (i < n && a[i] == b[i])
                        i++;
                    if (i < n && a[i] < b[i])
                        neg = true;
                }
                else
                    if (a[0] < b[0])
                    neg = true;
                if (neg)
                {
                    for (i = 0; i < n; i++)
                    {
                        int aux = a[i];
                        a[i] = b[i];
                        b[i] = aux;
                    }
                }
            }

            carry = false;
            for (i = n - 1; i > n - m - 1; i--)
            {
                if (a[i] - b[m - 1 - (n - 1 - i)] < 0)
                {
                    if (carry)

                        Dif[i] = a[i] + 10 - b[m - 1 - (n - 1 - i)] - 1;

                    else
                    {
                        Dif[i] = a[i] + 10 - b[m - 1 - (n - 1 - i)];
                        carry = true;
                    }
                }
                else
                {
                    if (carry)
                    {
                        if (a[i] - b[m - 1 - (n - 1 - i)] - 1 < 0)

                            Dif[i] = a[i] + 10 - b[m - 1 - (n - 1 - i)] - 1;

                        else
                        {
                            Dif[i] = a[i] - b[m - 1 - (n - 1 - i)] - 1;
                            carry = false;
                        }
                    }
                    else
                        Dif[i] = a[i] - b[m - 1 - (n - 1 - i)];

                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Diferenta este: ");

            if (neg)

                Console.Write("-");

            if (i == -1)// nr de cifre al primului vector, e egal cu cel de-al celui de al doilea vector
            {
                i = 0;

                while (i < n && Dif[i] == 0)
                    i++;
                if (i == n)
                    Console.Write(0);///nr identice
                else
                    for (j = i; j < n; j++)
                        Console.Write(Dif[j]);
            }
            else
            {
                for (j = i; j > 0; j--)///nu mai sunt cifre in al doilea vector
                {
                    if (carry)
                    {
                        if (a[j] != 0)
                        {
                            Dif[j] = a[j] - 1;
                            carry = false;
                        }
                        else
                            Dif[j] = 9;
                    }
                    else
                        Dif[j] = a[j];

                }

                if (carry)
                {
                    if (a[0] > 1)///in caz contrar, prin diferenta celor 2 vectori, s a obtinut un nr cu n-1 cifre
                        Console.Write(a[0] - 1);
                }
                else
                    Console.Write(a[0]);

                for (i = 1; i < n; i++)
                    Console.Write(Dif[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            ///3) PRODUSUL
            Console.WriteLine("Produsul este: ");


            int[] Produs = new int[n + m]; ///produsul dintre cei doi vectori represinta suma de (numarul de cifre ale lui m) produse
           int poz = 1;
           int[] a1 = new int[n + m];
           int[] b1 = new int[n + m];
           int contor_produs, carry_cif, k;
            

           for (i = 0; i < n + m; i++)
              b1[i] = 0;

           for (i = m - 1; i >= 0; i--)
           {
               
               carry_cif = 0;
              
                for (k = 0; k < n + m; k++)
                    a1[k] = 0;

                    for (j = n - 1; j >= 0; j--)
                    {
                    
                    
                        if (b[i] * a[j] > 9)
                        {
                            if (carry_cif != 0)
                            {
                                a1[i + j + 1] = (b[i] * a[j] + carry_cif) % 10;
                                carry_cif =(b[i] * a[j] + carry_cif) / 10;
                            }
                            else
                                {
                                    a1[i + j + 1] = (b[i] * a[j]) % 10;
                                    carry_cif = (b[i] * a[j]) / 10;
                                }
                        }
                        else
                            {
                                if (carry_cif != 0)
                                {
                                    a1[i + j + 1] =(b[i] * a[j] + carry_cif) % 10;
                                    if (b[i] * a[j] + carry_cif <= 9)
                                        carry_cif = 0;
                                    else
                                        carry_cif = (b[i] * a[j] + carry_cif) / 10; 
                                }

                               else
                                    a1[i + j + 1] = (b[i] * a[j]) % 10;
                            }   
                         
                    }


                if (carry_cif != 0)
                {

                    a1[i] = carry_cif;
                    poz = i;
                }
                else
                    poz = i + 1;

                carry = false;
               
                for (k = n + m - 1; k >= poz; k--)
                {
                   
                        if (a1[k] + b1[k] >= 10)
                        {
                            if (carry)
                                Produs[k] = (a1[k] + b1[k] + 1) % 10;
                            else
                            {
                                Produs[k] = (a1[k] + b1[k]) % 10;
                                carry = true;
                            }
                        }
                        else
                        {
                            if (carry)
                            {
                                if (a1[k] + b1[k] + 1 < 10)
                                    carry = false;
                                Produs[k] = (a1[k] + b1[k] + 1) % 10;
                            }

                            else
                                Produs[k] = a1[k] + b1[k];
                        }

                }
                if (carry)
                {
                    Produs[k] = 1;
                    poz = k;

                }
                else
                    poz = k + 1;
                  
                    for (k = poz; k < n + m; k++)
                   
                        b1[k] = Produs[k];
                

           }
         
           for (i = poz; i < n + m; i++)
               Console.Write(Produs[i]);
            Console.WriteLine();


        }
        private static void ex_27()
        {

            int n, k, x;
            Console.WriteLine("Cititi un numar n, dimensiunea unui vector si k, o pozitie din vector");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine($"apoi {n} elemente ale sale");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }
            Console.WriteLine($"si aflati ce element se afla pe poz {k}, dupa ce vectorul va fi sortat");
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j > 0 && v[j] < v[j - 1]; j--)
                {
                    aux = v[j];
                    v[j] = v[j - 1];
                    v[j - 1] = aux;
                }

            }
            Console.WriteLine($"Numarul aflat pe poz {k} este: {v[k]}");

            Console.WriteLine();
        }
        private static int partitie(int[] v, int n, int stg, int dr)
        {
            int aux, i = stg - 1, j = stg;
            while (j < dr)
            {
                if (v[j] < v[dr])
                {
                    i++;
                    aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                }
                j++;
            }
            aux = v[i + 1];
            v[i + 1] = v[dr];
            v[dr] = aux;
            return i + 1;
        }
        private static void Quicksort(int[] v, int n, int stg, int dr)
        {
            if (stg < dr)
            {
                int pivot = partitie(v, n, stg, dr);
                Quicksort(v, n, stg, pivot - 1);
                Quicksort(v, n, pivot + 1, dr);
            }
        }

        private static void ex_28()
        {
            int n, x;
            Console.WriteLine("Cititi un nr n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            Console.WriteLine("Apoi cititi pe fiecare linie noua, elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }

            Console.WriteLine("si ordonati vectorul folosindu va de algoritmul de sortare Quicksort: ");

            Quicksort(v, n, 0, n - 1);

            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

        }
        private static void merge(int[] v, int n, int stg, int mij, int dr)
        {
            int n1 = mij - stg + 1;
            int n2 = dr - mij;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j, k = stg;

            for (i = 0; i < n1; i++)
                L[i] = v[stg + i];

            for (i = 0; i < n2; i++)
                R[i] = v[mij + 1 + i];
            i = j = 0;

            while (i < n1 && j < n2)
            {
                if (L[i] < R[j])
                {
                    v[k] = L[i];
                    i++;
                }
                else
                {
                    v[k] = R[j];
                    j++;

                }
                k++;
            }
            while (i < n1)
            {
                v[k] = L[i];
                k++;
                i++;
            }
            while (j < n2)
            {
                v[k] = R[j];
                k++;
                j++;
            }
        }
        private static void sortare(int[] v, int n, int stg, int dr)
        {
            if (stg < dr)
            {
                int mij = stg + (dr - stg) / 2;
                sortare(v, n, stg, mij);
                sortare(v, n, mij + 1, dr);
                merge(v, n, stg, mij, dr);
            }
        }
        private static void ex_29()
        {
            int n, x;
            Console.WriteLine("Cititi un nr n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            Console.WriteLine("Apoi cititi pe fiecare linie noua, elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }

            Console.WriteLine("si ordonati vectorul folosindu va de algoritmul de sortare Mergesort: ");

            sortare(v, n, 0, n - 1);

            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
        }


        private static void ex_30()
        {
            int n, x, i, j, aux;
            Console.WriteLine("Cititi un numar n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());

            int[] E = new int[n];
            Console.WriteLine("Apoi cititi pe fiecare linie noua, elementele din primul vector");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                E[i] = x;
            }
            int[] W = new int[n];
            Console.WriteLine("respectiv elementele din al doilea vector, ce reprezinta ponderile primulul vector");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                W[i] = x;
            }
            Console.WriteLine("si ordonati ambii vectori, in asa fel incat doua elemente identice din primul vector vor fi sortate in functie de ponderi, cea mai mare fiind prima");
            i = 0;
            while (i < n - 1)
            {
                j = i + 1;
                while (j > 0 && E[j - 1] >= E[j])
                {
                    if (E[j - 1] > E[j] || (E[j - 1] == E[j] && W[j] > W[j - 1]))
                    {
                        aux = E[j - 1];
                        E[j - 1] = E[j];
                        E[j] = aux;
                        aux = W[j - 1];
                        W[j - 1] = W[j];
                        W[j] = aux;

                    }
                    j--;
                }
                i++;
            }

            Console.WriteLine();


            Console.WriteLine("Ponderile ordonate sunt: ");
            for (i = 0; i < n; i++)
                Console.Write(W[i] + " ");

            Console.WriteLine();
            Console.WriteLine("Elementele ordonate din primul vector sunt: ");
            for (i = 0; i < n; i++)
                Console.Write(E[i] + " ");


            Console.WriteLine();

        }
        private static void ex_31()
        {
            int n, x;
            Console.WriteLine("Cititi un nr n, dimensiunea unui vector");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            Console.WriteLine("Apoi cititi pe fiecare linie noua, elementele vectorului");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                v[i] = x;
            }

            Console.WriteLine("si aflati elementul majoritar ");


            int elem = v[0], nrap = 1, NRAP = 0;
            for (int i = 1; i < n; i++)
            {
                if (nrap == 0)
                {
                    elem = v[i];
                    nrap = 1;
                }
                else
                    if (v[i] == elem)
                    nrap++;
                else
                    nrap--;
            }

            for (int i = 0; i < n; i++)
                if (v[i] == elem)
                    NRAP++;
            if (NRAP >= n / 2)
                Console.WriteLine($"Elementul majoritar este: {elem}");
            else
                Console.WriteLine("Multimea nu are element majoritar");
            Console.WriteLine();
        }
    }

}
