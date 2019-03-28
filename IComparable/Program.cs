using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifoQueue
{
    class Queue
    {
        private const int DEFAULTQUEUESIZE = 100;
        private int[] data;
        private int head = 0, tail = 0;
        private int numElements = 0;

        public Queue()
        {
            this.data = new int[DEFAULTQUEUESIZE];
        }
        public Queue(int size)
        {
            if (size > 0)
            {
                this.data = new int[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size");
            }
        }
        public void Enqueue(int item)
        {
            if(this.numElements == this.data .Length)
            {
                throw new Exception("Queue full");
            }
            this.data[this.head] = item;
            this.head++;
            this.head %= this.data.Length;// if the head is [11], it will go down to [1]. It wraps around in circles.
            this.numElements++;
        }
        public int Dequeue()
        {
            if (this.numElements== 0)
            {
                throw new Exception("queue empty");
            }
            int queueItem = this.data[this.tail];
            this.tail++;
            this.tail %= this.data.Length;
            this.numElements--;
            return queueItem;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(-25);
            queue.Enqueue(33);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{queue.Dequeue()}");//Throws exception
                Console.ReadKey();
            }

        }
    }
}
