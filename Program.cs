using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void MakeSound(Dog d)
        {
            Console.WriteLine(d.MakeSound());
        }
        static void MakeSound(Horse h)
        {
            Console.WriteLine(h.MakeSound());
        }
        static void MakeSound(Poodle p)
        {
            Console.WriteLine(p.MakeSound());
        }
        static void MakeSound(Wolf w)
        {
            Console.WriteLine(w.MakeSound());
        }
        static void MakeSound(PetWolf q)
        {
            Console.WriteLine(q.MakeSound());
        }
        static void AnimalSing(Animal[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        static void Main(string[] args)
            {
                Dog d = new Dog("riki", "meat");

                Console.WriteLine(d);
                Console.WriteLine(d.MakeSound());
                Horse h = new Horse("meni", true);
                Console.WriteLine(h);
                Console.WriteLine(h.MakeSound());
                Poodle p = new Poodle("lucky", "bones", "two");
                Console.WriteLine(p);
                Console.WriteLine(p.MakeSound());
                Wolf w = new Wolf("richie", "rabbit", "moonrunners");
                Console.WriteLine(w);
                Console.WriteLine(w.MakeSound());
                PetWolf q = new PetWolf("jack", "fish", "skyyellers");
            Console.WriteLine(q);
            Console.WriteLine(q.MakeSound());
                            


        }

        }
    }


