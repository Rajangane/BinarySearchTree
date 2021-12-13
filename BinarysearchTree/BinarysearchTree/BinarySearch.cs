using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarysearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public T Data { get; set; }
        public BinaryTree<T> LTree { get; set; }
        public BinaryTree<T> RTree { get; set; }
        public BinaryTree(T data) //constructor
        {
            this.Data = data;
            this.RTree = null; //RightTree
            this.LTree = null; //LeftTree
        }

        /// <summary>
        /// 
        /// ADD Method
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            T currentNodeValue = this.Data;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LTree == null)
                    this.LTree = new BinaryTree<T>(item);
                else
                    this.LTree.Add(item);
            }
            else
            {
                if (this.RTree == null)
                    this.RTree = new BinaryTree<T>(item);
                else
                    this.RTree.Add(item);
            }

        }
        private int LCount = 0, RCount = 0; //LeftCount, RightCount
        /// <summary>
        /// Display Method
        /// </summary>
        public void Display()
        {
            if (this.LTree != null)
            {
                this.LCount++;
                this.LTree.Display();

            }
            Console.WriteLine(this.Data.ToString());
            if (this.RTree != null)
            {
                this.RCount++;
                this.RTree.Display();
            }
        }
    }
}
