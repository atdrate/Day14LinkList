using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chooes Number\n1.simple Linked List \n2.by adding \n4.by inserting into two number \n5. by delete first element \n6.Delete last node \n7.Search Node \n8.insert number between number");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    CustomLinkList customlist = new CustomLinkList();
                    customlist.AddEnd(56);
                    customlist.AddEnd(30);
                    customlist.AddEnd(70);
                    break;
                case 2:
                    ByAdding byadd = new ByAdding();
                    byadd.Add(56);
                    byadd.InsertElement1(30, 2);
                    byadd.InsertElement2(70, 3);
                    byadd.Display();
                    break;
                case 4:
                    InsertBetween between = new InsertBetween();
                    between.Add(56);
                    between.Add(70);
                    between.insertBetween(30, 2);
                    between.Display();
                    break;
                case 5:
                    DeleteFirstElement delete = new DeleteFirstElement();
                    delete.Add(56);
                    delete.Add(30);
                    delete.Add(70);
                    Console.WriteLine("{0} is a deleted in the linked list ", delete.DeleteFirstNode());
                    Console.WriteLine("Element in linked list are ");
                    delete.Display();
                    break;
                case 6:
                    DeleteLastElement deletel = new DeleteLastElement();
                    deletel.Add(56);
                    deletel.Add(30);
                    deletel.Add(70);
                    Console.WriteLine("{0} is a deleted in the linked list ", deletel.DeleteLastNode());
                    Console.WriteLine("Element in linked list are ");
                    deletel.Display();
                    break;
                case 7:
                    SearchNode search = new SearchNode();
                    search.Add(56);
                    search.Add(30);
                    search.Add(70);
                    search.Searchnode(30);
                    break;
                case 8:
                    InsertNewElement insertnewelement = new InsertNewElement();
                    insertnewelement.Add(56);
                    insertnewelement.Add(30);
                    insertnewelement.Add(70);
                    insertnewelement.InsertElement(40, 3);
                    insertnewelement.Display();
                    break;

                    Console.WriteLine("Invalid Option");
                    break;

            }
        }
    }
}
