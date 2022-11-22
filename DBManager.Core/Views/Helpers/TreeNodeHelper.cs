using DBManager.Core.Views.Engines;
using System;
using System.Windows.Forms;

namespace DBManager.Core.Views.Helpers
{
    public static class TreeNodeHelper
    {
        public static TreeNodeElements GetElements(TreeNode treeNode)
        {
            var firstNode = treeNode;
            var secondNode = firstNode?.Parent;
            var thirdNode = secondNode?.Parent;

            if (firstNode == null)
                return new TreeNodeElements
                {
                    Mode = TreeNodeMode.NotSupported
                };

            if (firstNode != null && secondNode == null)
                return new TreeNodeElements
                {
                    Mode = TreeNodeMode.ConnectionSelected,
                    Connection = firstNode
                };

            if (secondNode != null && thirdNode == null)
                return new TreeNodeElements
                {
                    Mode = TreeNodeMode.DatabaseSelected,
                    Connection = secondNode,
                    Database = firstNode
                };

            if (thirdNode != null)
                return new TreeNodeElements
                {
                    Mode = TreeNodeMode.TableSelected,
                    Connection = thirdNode,
                    Database = secondNode,
                    Table = firstNode
                };

            throw new InvalidOperationException("This TreeNode is not supported.");
        }
    }

    public class TreeNodeElements
    {
        public TreeNodeMode Mode { get; set; }
        public TreeNode Connection { get; set; }
        public TreeNode Database { get; set; }
        public TreeNode Table { get; set; }

        public ConnectionElementIdentity ToConnectionElementIdentity()
            => new()
            {
                ConnectionName = Connection?.Name,
                DatabaseName = Database?.Name,
                TableName = Table?.Name
            };
    }

    public enum TreeNodeMode
    {
        NotSupported,
        ConnectionSelected,
        DatabaseSelected,
        TableSelected
    }
}
