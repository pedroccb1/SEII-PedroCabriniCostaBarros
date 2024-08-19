using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Binnary_Trees
{
    public class TreeNode
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public TreeNode LeftTree{ get; set; }
        public TreeNode RightTree { get; set; }
        public TreeNode(int key, string value){
            this.Key = key;
            this.Value = value;

        }
    }
}