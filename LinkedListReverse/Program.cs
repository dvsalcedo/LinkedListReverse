using System;

namespace LinkedListReverse
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList l = new LinkedList();
            l.Append(1);
            l.Append(2);
            l.Append(3);
            l.Preappend(0);
            l.Print();
            Console.WriteLine("======");
            Reverse(l.First());
        }

        static void Reverse (Node head) {
            Node currently = head;
            Node previous = null, next = null;
            while (currently != null) {
              next = currently.next;
              currently.next = previous;
              previous = currently;
              currently = next;
            }

            while (previous != null) {
              Console.WriteLine(previous.value);
              previous = previous.next;
            }
        }

    }

    public class Node{
        public Node next {get; set; }
        public int value {get; set; }

        public Node(int value){
          this.value = value;
        }
    }
    public class LinkedList{
        Node head {get; set;}

        public LinkedList(){}

        public void Preappend (int value) {
          Node newNode = new Node(value);
          
          if (head == null) {
              head = newNode;
              return;
          }

          newNode.next = head;
          head = newNode;
        }

        public void Append (int value) {
          Node newNode = new Node(value);

          if (head == null) {
              head = newNode;
              return;
          } 

          Node node = head;

          while (node.next != null) {
            node = node.next;
          }

          node.next = newNode;
        }

        public void Print(){
            Node node = head;
            while (node != null){
                Console.WriteLine(node.value);
                node = node.next;
            }
        }

        public Node First(){
            return head;
        }
    }
}
