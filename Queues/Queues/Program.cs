using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            NickQueue<int> queue = new NickQueue<int>();

            queue.Enqueue(23);
            queue.Enqueue(33);
            queue.Enqueue(3344);
            queue.Dequeue();
            queue.Dequeue();
        }
    }
}
