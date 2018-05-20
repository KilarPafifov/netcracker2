using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using netckracker2;

namespace netckacker2
{
    class TreeNodeTest
    {
        public static bool TestGetRoot()
        {
            ITreeNode node_4 = new TreeNode();
            node_4.SetData("node_4");

            ITreeNode node_3 = new TreeNode();
            node_3.SetData("node_3");
            node_3.AddChild(node_4);

            ITreeNode node_2 = new TreeNode();
            node_2.SetData("node_2");

            ITreeNode node_1 = new TreeNode();
            node_1.SetData("node_1");
            node_1.AddChild(node_2);
            node_1.AddChild(node_3);

            ITreeNode node_0 = new TreeNode();
            node_0.SetData("node_0");
            node_0.AddChild(node_1);
            
            if (node_0.GetRoot() != node_0)
            {
                return false;
            }
              
            if (node_4.GetRoot() != node_0)
            {
                return false;
            }

            return true;
        }

        public static bool TestGetTreePath()
        {
            ITreeNode node_4 = new TreeNode();
            node_4.SetData("node_4");

            ITreeNode node_3 = new TreeNode();
            node_3.SetData("node_3");
            node_3.AddChild(node_4);

            ITreeNode node_2 = new TreeNode();
            node_2.SetData("node_2");

            ITreeNode node_1 = new TreeNode();
            node_1.SetData("node_1");
            node_1.AddChild(node_2);
            node_1.AddChild(node_3);

            ITreeNode node_0 = new TreeNode();
            node_0.SetData("node_0");
            node_0.AddChild(node_1);

            string treePath = "empty" + "<-" + Convert.ToString(node_3.GetData())
                            + "<-" + Convert.ToString(node_1.GetData()) 
                            + "<-" + Convert.ToString(node_0.GetData());
            
            if (node_3.GetTreePath() != treePath)
            {
                return false;
            }

            return true;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestGetTreePath());
            Console.ReadLine();
        }
    }
}
