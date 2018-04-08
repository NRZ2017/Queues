using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class NickQueue<T> where T : IComparable
    {
        public Node<T> Top;
        public Node<T> Bottom;
        bool IsEmpty;
        int count;

        public NickQueue()
        {

        }

        public void Enqueue(T value)
        {
            if (Top == null)
            {
                Top = new Node<T>(value, Top, Bottom);
                Bottom = Top;
            }
            else
            {

                Node<T> TempBlock = new Node<T>(value, Top, Bottom);
                TempBlock.Next = Bottom;
                Bottom = TempBlock;

                //    Node<T> tempNode = Top;

                //   Bottom.Next = new Node<T>(value, Top, Bottom);
                //    Bottom.Next = tempNode;
                //    tempNode = Bottom;
            }
        }

        public T Dequeue()
        {
            if (Top == null)
            {
                throw new Exception("Queue was empty");
            }

            T value = Bottom.Data;

            Bottom = Bottom.Next;
            Bottom.Previous = null;

            return value;
        }

        
    }

}
