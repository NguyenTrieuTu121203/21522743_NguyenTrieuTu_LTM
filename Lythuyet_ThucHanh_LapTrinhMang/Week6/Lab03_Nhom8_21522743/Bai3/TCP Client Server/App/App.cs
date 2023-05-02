using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
using TCP_Client_Server;
using System.Threading;
namespace App
{

    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        Thread _thr;
        private void sv_Btn_Click(object sender, EventArgs e)
        {  
            _thr = new Thread(SpawnServer);
            _thr.IsBackground = true;
            _thr.Start();
             
        }

        private void cl_Btn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(SpawnClient);
            thread.IsBackground = true;
            thread.Start();
        }

        void Sv_toggle()
        {
            if (_thr.IsAlive)
            {
                sv_Btn.Enabled = false;
            }
            else
            {
                sv_Btn.Enabled=true;
            }
        }

        public void SpawnClient()
        {
            TCP_Client_Server.Client ClientUI = new TCP_Client_Server.Client();
            ClientUI.ShowDialog();
        }

        public void SpawnServer()
        {
            sv_Btn.Enabled = false;
            Server.Server ServerUI = new Server.Server();
            ServerUI.ShowDialog();
            if (ServerUI._Closed)
            {
                sv_Btn.Enabled = true;
            }
        }
    }
}
