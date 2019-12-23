using System.Messaging;
using System.Windows.Forms;
using System.Net;
using System;
using System.Runtime.InteropServices;
using System.Data;

namespace MsmqOperate
{
    public partial class MsmqOperateForm : Form
    {
        public MsmqOperateForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            GetSystemPrivateQueueInfo();
        }

        private void GetSystemPrivateQueueInfo()
        {
            //获取系统上的专用队列信息
            string hostName = Dns.GetHostName();
            MessageQueue messageQueue = new MessageQueue();
            MessageQueue[] messageQueues = MessageQueue.GetPrivateQueuesByMachine(hostName);

            //初始化窗口上的专用队列树数据
            TreeNodeCollection treeNodeCollection = this.treeView_PrivatQueue.Nodes;
            foreach (TreeNode treeNode in treeNodeCollection)
            {
                if (treeNode.Text.Equals("专用队列"))
                {
                    for (int i = 0; i < messageQueues.Length; i++)
                    {
                        using (MessageQueue messageQueueInArray = messageQueues[i])
                        {
                            string queueName = messageQueueInArray.QueueName.Remove(0, 9);
                            treeNode.Nodes.Add("private", queueName, 1, 1);
                        }
                    }
                }
            }
        }

        private void treeView_PrivatQueue_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode treeNode = e.Node;
            string queuePath = ".\\" + treeNode.Name + "$\\" + treeNode.Text;
            DataGridViewBindData(queuePath);
        }

        private void DataGridViewBindData(string queuePath)
        {
            try
            {
                if (MessageQueue.Exists(queuePath))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add(new DataColumn("Label"));
                    dataTable.Columns.Add(new DataColumn("Type"));
                    dataTable.Columns.Add(new DataColumn("Size"));
                    dataTable.Columns.Add(new DataColumn("Id"));

                    MessageQueue messageQueue = new MessageQueue(queuePath);
                    System.Messaging.Message[] messages = messageQueue.GetAllMessages();
                    foreach (System.Messaging.Message message in messages)
                    {
                        string messageLabel = message.Label;
                        string messageType = message.MessageType.ToString();
                        string messageSize =  (( message.BodyStream.Length) / 1024).ToString()+"(KB)";
                        string messageId = message.Id;

                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Label"] = messageLabel;
                        dataRow["Type"] = messageType;
                        dataRow["Size"] = messageSize;
                        dataRow["Id"] = messageId;

                        dataTable.Rows.Add(dataRow);
                    }

                    this.dataGridView_QuueMessageInfo.DataSource = dataTable;
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
