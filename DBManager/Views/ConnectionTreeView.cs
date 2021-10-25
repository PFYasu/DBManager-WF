using DBManager.Views.Helpers;
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

        public event EventHandler<TreeNodeElements> OnSelectedNodeChanged;
        public TreeNodeElements LastSelectedNode { get; private set; }

        private void connectionTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            LastSelectedNode = TreeNodeHelper.GetElements(e.Node);

            OnSelectedNodeChanged?.Invoke(this, LastSelectedNode);
        }

        public void InitializeView(ImageList imageList)
        {
            connectionTree.ImageList = imageList;
        }

        public void LoadConnections(List<string> connectionNames)
        {
            foreach (var name in connectionNames)
            {
                var node = connectionTree
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }
        }

        public void LoadDatabases(string connectionName, List<string> databaseNames)
        {
            connectionTree
                .Nodes[connectionName]
                .Nodes.Clear();

            foreach (var name in databaseNames)
            {
                var node = connectionTree
                    .Nodes[connectionName]
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
        }

        public void LoadTables(string connectionName, string databaseName, List<string> tableNames)
        {
            connectionTree
                .Nodes[connectionName]
                .Nodes[databaseName]
                .Nodes.Clear();

            foreach (var name in tableNames)
            {
                var node = connectionTree
                    .Nodes[connectionName]
                    .Nodes[databaseName]
                    .Nodes.Add(name);

                node.Name = name.ToString();
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
        }
    }
}
