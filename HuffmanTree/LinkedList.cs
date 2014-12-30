using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12253021HW3
{
    class LinkedList : IComparable
    {
        Node head;

        public Node createNode(string val)
        {
            return new Node(val);
        }
        public bool search(string val)
        {
            Node iterator = head;
            while (iterator != null)
            {
                if (iterator.Value.CompareTo(val) == 0)
                    return true;
                iterator = iterator.Next;
            }
            return false;

        }

        public void addSorted(string val)
        {
            Node newNode = createNode(val);
            if (head == null)
                head = newNode;
            else if (head.Value.CompareTo(val) >= 0)
            {
                newNode.Next = head;
                head = newNode;
                //addToFront(val);

            }
            else
            {
                Node iterator = head.Next;
                Node previous = head;
                while (iterator != null)
                {
                    if (iterator.Value.CompareTo(val) >= 0)
                    {
                        previous.Next = newNode;
                        newNode.Next = iterator;
                        break;
                    }
                    previous = iterator;
                    iterator = iterator.Next;
                }
                if (iterator == null)
                    previous.Next = newNode;



            }



        }
        public void addToEnd(string val,int val2)
        {
            if (head == null)
            {
                head = createNode(val);//new Node<T>(val);
                head.Value2 = val2;//Frekans
            }
            else
            {
                Node iterator = head;
                while (iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = createNode(val);
                iterator.Value2 = val2;//Frekans
            }
        }
        public void addToFront(string val)
        {
            Node temp = createNode(val);
            temp.Next = head;
            head = temp;
        }
        public void display()
        {
            Node iterator = head;

            while (iterator != null)
            {

                Console.WriteLine(iterator.ToString());
                iterator = iterator.Next;
            }
        }

        public void addAfterHead(string val)
        {
            if (head == null)
                head = createNode(val);
            else
            {
                Node temp = createNode(val);
                temp.Next = head.Next;
                head.Next = temp;
            }
        }
        private Node findPrev(Node current)
        {
            Node iterator = head;
            while (iterator.Next != current)
            {
                iterator = iterator.Next;
            }
            return iterator;
        }
        public void reverse()
        {
            Node tempHead, iterator;
            iterator = head;
            while (iterator.Next != null)
                iterator = iterator.Next;
            tempHead = iterator;
            while (iterator != head)
            {
                iterator.Next = findPrev(iterator);
                iterator = iterator.Next;
            }
            iterator.Next = null;//head.next=null;
            head = tempHead;
        }
        public void delete(string val)
        {
            //Silinecek eleman listede yoksa çöker
            if (head != null)//hiç eleman yoksa
            {
                while (head.Value.CompareTo(val) == 0)//İlk eleman silinecekse
                {
                    head = head.Next;
                }
                if (head != null)
                {

                    Node iterator = head.Next;
                    Node prev = head;
                    while (iterator != null)
                    {

                        if (iterator.Value.CompareTo(val) == 0)
                        {
                            prev.Next = iterator.Next;
                            //break;
                        }
                        prev = iterator;
                        iterator = iterator.Next;
                    }
                }

            }

        }

        public int Length()
        {
            Node iterator = head;
            int counter = 0;
            while (iterator != null)
            {
                counter++;
                iterator = iterator.Next;
            }
            return counter;
        }
        public string findSmallest()
        {
            if (head == null)
                throw new Exception("list is empty");

            string min = head.Value;
            Node iterator = head.Next;
            while (iterator != null)
            {
                if (iterator.Value.CompareTo(min) == -1)
                    min = iterator.Value;
                iterator = iterator.Next;
            }
            return min;
        }

        public void addToEndRecursively(string val)
        {
            head = addToEndRecursively(head, val);
        }

        public Node addToEndRecursively(Node myHead, string val)
        {
            if (myHead == null)
                return createNode(val);
            else
                myHead.Next = addToEndRecursively(myHead.Next, val);
            return myHead;
        }

        public void addToEndRecursivelyNoReturn(string val)
        {


            addToEndRecursivelyNoReturn(head, val);
        }

        public void addToEndRecursivelyNoReturn(Node myHead, string val)
        {
            if (head == null)
                head = createNode(val);
            else if (myHead.Next == null)
                myHead.Next = createNode(val);
            else
                addToEndRecursivelyNoReturn(myHead.Next, val);
        }
        public void SwapFirstAndLastNode()
        {
            if (head == null || head.Next == null)
                return;
            Node iterator = head.Next, prev = head;
            //son ve sondan bir oncekini bulur
            while (iterator.Next != null)
            {
                prev = iterator;
                iterator = iterator.Next;
            }
            prev.Next = head;//sondan bir onceki head'a baglanır
            iterator.Next = head.Next;//iterator headin bir sonrasına baglanır
            head.Next = null;//eski head sonda oldugu icin nexti null olur
            head = iterator;//yeni head iterator olacaktır

        }


    }
}
