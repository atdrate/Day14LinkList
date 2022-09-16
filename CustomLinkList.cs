using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList14
{
    public class CustomLinkList
    {
        Node head;
        public void AddEnd(int dataNew)
        {
            Node NewData = new Node(dataNew);

            if (this.head == null)
            {
                this.head = NewData;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = NewData;

            }
        }
       
    }
}
