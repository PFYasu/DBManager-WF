using DBManager.Core.Views.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBManager.Views
{
    [ToolboxItem(true)]
    public partial class ConnectionTreeView : UserControl
    {
        public ConnectionTreeView()
        {
            InitializeComponent();
        }

        public void InitializeView(ImageList imageList)
        {
            ConnectionTree_TreeView.ImageList = imageList;
        }

        public event EventHandler<TreeNodeElements> OnNodeSelected;
        public event EventHandler<TreeNodeElements> OnNodeBeforeExpanding;
        public event EventHandler<TreeNodeElements> OnNodeBeforeCollapsing;
        public TreeNodeElements LastSelectedNode { get; private set; }

        private bool IsGraphicActionExecuting = false;

        private void ConnectionTree_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (IsGraphicActionExecuting)
            {
                IsGraphicActionExecuting = false;
                return;
            }

            LastSelectedNode = TreeNodeHelper.GetElements(e.Node);
            OnNodeSelected?.Invoke(this, LastSelectedNode);
        }

        private void ConnectionTree_TreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            IsGraphicActionExecuting = true;

            LastSelectedNode = TreeNodeHelper.GetElements(e.Node);
            OnNodeBeforeCollapsing?.Invoke(this, LastSelectedNode);
        }

        private void ConnectionTree_TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            IsGraphicActionExecuting = true;

            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0] is EmptyTreeNode)
            {
                LastSelectedNode = TreeNodeHelper.GetElements(e.Node);
                OnNodeBeforeExpanding?.Invoke(this, LastSelectedNode);
            }
        }

        public void LoadConnections(List<string> connectionNames)
        {
            ConnectionTree_TreeView
                .Nodes.Clear();

            foreach (var name in connectionNames)
            {
                var node = ConnectionTree_TreeView
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;

                node.Nodes.Add(new EmptyTreeNode());
            }
        }

        public void LoadDatabases(string connectionName, List<string> databaseNames)
        {
            ConnectionTree_TreeView
                .Nodes[connectionName]
                .Nodes.Clear();

            foreach (var name in databaseNames)
            {
                var node = ConnectionTree_TreeView
                    .Nodes[connectionName]
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;

                node.Nodes.Add(new EmptyTreeNode());
            }
        }

        public void LoadTables(string connectionName, string databaseName, List<string> tableNames)
        {
            ConnectionTree_TreeView
                .Nodes[connectionName]
                .Nodes[databaseName]
                .Nodes.Clear();

            foreach (var name in tableNames)
            {
                var node = ConnectionTree_TreeView
                    .Nodes[connectionName]
                    .Nodes[databaseName]
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
        }

        private class EmptyTreeNode : TreeNode
        {
        }
    }
}
