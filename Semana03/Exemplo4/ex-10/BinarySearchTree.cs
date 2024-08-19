using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Binnary_Trees
{
    public class BinarySearchTree
    { 
        public TreeNode Root { get; set; } = null;

        public void Insert(int key, string value){
            Root = InsertItem(Root, key, value);
        }

        public TreeNode InsertItem(TreeNode node, int key, string value){
            TreeNode newNode = new TreeNode(key, value);
        
            // 1st time create a root
            if (node == null){
                node = newNode;
                return node;
            }

            if (key < node.Key){
                node.LeftTree = InsertItem(node.LeftTree, key, value);
            }
            else{
                node.RightTree =  InsertItem(node.RightTree, key, value);
            }
            return newNode;
        }

        public string Find(int key){
            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;
        }

        private TreeNode? Find(TreeNode node, int key){
            if (node == null || node.Key == key){
                return node;
            }
            else if(key < node.Key){
                return Find(node.LeftTree, key);
            }
            else if(key > node.Key){
                return Find(node.RightTree, key);
            }
            return null;
        }
    }
}