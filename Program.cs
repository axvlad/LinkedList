using System;
using System.Collections.Generic; // подключаем LinkedList<T> 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Woter
    {
        public string name;
        public int price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Woter> myList = new LinkedList<Woter>();

            Woter w1 = new Woter() { name = "Morshinska ", price = 20 };
            myList.AddFirst(w1);

            Woter w2 = new Woter() { name = "Mirgorodska ", price = 17 };
            myList.AddLast(w2);

            LinkedListNode<Woter> node2 = myList.Find(w2);

            Woter w3 = new Woter() { name = "Svoya Linia ", price = 10 };
            myList.AddBefore(node2, w3);

            LinkedListNode<Woter> node1 = myList.Find(w1);

            Woter w4 = new Woter() { name = "Evian ", price = 30 };
            myList.AddAfter(node1, w4);

            
            LinkedListNode<Woter> node3 = myList.Find(w3);

            Woter w5 = new Woter() { name = "Bon Buason ", price = 16 };
            myList.AddAfter(node3, w5);

            myList.Remove(w5);
            

            //Перебираем из начала в конец
            LinkedListNode<Woter> node = myList.First;
            while(node != null)
            {
                Console.WriteLine("Name = " + node.Value.name + "Price = " + node.Value.price);
                node = node.Next;
            }

            Console.WriteLine("\nLink by last:");
            //Перебираем с конца в начало
            node = myList.Last;
            while(node != null)
            {
                Console.WriteLine("Name = " + node.Value.name + "Price = " + node.Value.price);
                node = node.Previous;
            }
        }
    }
}