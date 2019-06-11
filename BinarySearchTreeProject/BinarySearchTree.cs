using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        //Member variables
        public Node root;

        //Constructor
        public BinarySearchTree()
        {
            root = null;
            


        }

        //Member methods
        public void Add(int data)
        {
            Node newNode = new Node();
            newNode.data = data;            
            if (root == null)
            {
                root = newNode;      
            }
            else
            {
                Node currentNode = root;
                while (newNode != currentNode)
                {
                    if (newNode.data > currentNode.data)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = newNode;
                            newNode = currentNode;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                            if (data > currentNode.data)
                            {
                                if (currentNode.right == null)
                                {
                                    currentNode.right = newNode;
                                    newNode = currentNode;
                                }
                            }
                            else
                            {
                                if (currentNode.left == null)
                                {
                                    currentNode.left = newNode;
                                    newNode = currentNode;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = newNode;
                            newNode = currentNode;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                            if (data > currentNode.data)
                            {
                                if (currentNode.right == null)
                                {
                                    currentNode.right = newNode;
                                    newNode = currentNode;
                                }
                            }
                            else
                            {
                                if (currentNode.left == null)
                                {
                                    currentNode.left = newNode;
                                    newNode = currentNode;
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool Search(int data)
        {
            if (root.data == data)
            {
                return true;
            }
            else
            {
                Node currentNode = root;
                while (true)
                {
                    if (data > currentNode.data)
                    {
                        if (currentNode.right == null)
                        {
                            return false;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                            if (currentNode.data == data)
                            {
                                return true;
                            }
                            if (data > currentNode.data)
                            {
                                if (currentNode.right == null)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if (currentNode.left == null)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (currentNode.left == null)
                        {
                            return false;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                            if (currentNode.data == data)
                            {
                                return true;
                            }
                            if (data > currentNode.data)
                            {
                                if (currentNode.right == null)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if (currentNode.left == null)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }










        }






    }
}
