using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearch
{
    public partial class ListScreen : Form
    {
        public ListScreen()
        {
            InitializeComponent();
        }

        private void ListScreen_Load(object sender, EventArgs e)
        {

        }

        private void txt_FileName_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Txt_FileName.Text);
            }
            catch (Exception error)
            {
                Txt_FileName.Text = error.Message;
            }
        }

        private void btn_SearchButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\\";
            openFileDialog.Title = "Procurar arquivos";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.ShowDialog();
            Txt_FileName.Text = openFileDialog.FileName;
        }
    }
}
