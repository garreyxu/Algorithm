using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class PreorderBinaryTree
    {
        public PreorderBinaryTree() { }

        // version 1: Traverse 遍历
        public List<int> PreorderTraversal(Node root)
        {
            List<int> result = new List<int>();
            traverse(root, result);
            return result;
        }

        // 把root为根的preorder加入result里面
        private void traverse(Node root, List<int> result)
        {
            if (root == null)
                return;

            result.Add(root.value);
            traverse(root.left, result);
            traverse(root.right, result);
        }

        // version 2: Divid & Conquer 分治法 - 3个步骤
        public List<int> PreorderDividConquer(Node root)
        {
            List<int> result = new List<int>();
            // null or leaf
            if (root == null)
            {
                return result;
            }

            // divid
            List<int> left = PreorderDividConquer(root.left);
            List<int> right = PreorderDividConquer(root.right);

            // conquer
            result.Add(root.value);
            //result.AddAll(left);
            //result.AddAll(right);
            return result;

            // merge
            // divid & merge

        }
    }



    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int init)
        {
            value = init;
            left = null;
            right = null;
        }
    }

    class Tree
    {
        Node root;

        public Tree()
        {
            root = null;
        }

        public Tree(int init)
        {
            root = new Node(init);
        }

        public void Add(int value)
        {
            // non-recurse add
        }

        public void AddRc(int value)
        {
            // recures add
            AddR(ref root, value);
        }

        private void AddR(ref Node N, int value)
        {
            // private recursive search for where to add the new node
        }

        public void print(ref string newstring)
        {
            // wr
        }


    }
}
