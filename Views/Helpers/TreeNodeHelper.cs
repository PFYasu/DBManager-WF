using System;
using System.Windows.Forms;

namespace DBManager.Views.Helpers
{
    public static class TreeNodeHelper
    {
        public static TreeNodeElements GetElements(TreeNode treeNode)
        {
            if (treeNode == null)
                return new TreeNodeElements
                {
                    Connection = null,
                    Database = null,
                    Table = null
                };

            if (treeNode != null
                && treeNode.Parent == null)
                return new TreeNodeElements
                {
                    Connection = treeNode,
                    Database = null,
                    Table = null
                };

            if (treeNode.Parent != null
                && treeNode.Parent.Parent == null)
                return new TreeNodeElements
                {
                    Connection = treeNode.Parent,
                    Database = treeNode,
                    Table = null
                };

            if (treeNode.Parent.Parent != null)
                return new TreeNodeElements
                {
                    Connection = treeNode.Parent.Parent,
                    Database = treeNode.Parent,
                    Table = treeNode
                };

            throw new InvalidOperationException("This TreeNode is not supported.");
        }
    }

    public class TreeNodeElements
    {
        public TreeNode Connection { get; set; }
        public TreeNode Database { get; set; }
        public TreeNode Table { get; set; }
    }
}
