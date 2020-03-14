using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2p4
{

    public partial class Form2 : Form
    {
        private string text;
        public Form2(string text)
        {
            InitializeComponent();
            this.text = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (text == "Cluj")
            {
                pictureBox1.ImageLocation = "https://s.iw.ro/gateway/g/ZmlsZVNvdXJjZT1odHRwJTNBJTJGJTJG/c3RvcmFnZTA3dHJhbnNjb2Rlci5yY3Mt/cmRzLnJvJTJGc3RvcmFnZSUyRjIwMTgl/MkYxMCUyRjEwJTJGOTkwMTM3Xzk5MDEz/N19jbHVqLW5hcG9jYS12ZWRlcmUtZGUt/c3VzLnBuZyZ3PTc4MCZoPTQ0MCZoYXNo/PTdlZWM1MzkxMWMyNTcwN2RlMDcyYTgxYzM2NTNmMDIw.thumb.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            if (text == "Piatra")
            {
                pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Tower1499.jpg/1200px-Tower1499.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            if (text == "Oradea")
            {
                pictureBox1.ImageLocation = "https://www.themayor.eu/uploads/image/file/2050/medium_Oradea.jpg?1546013631";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
