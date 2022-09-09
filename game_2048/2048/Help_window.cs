using System;
using System.Windows.Forms;

namespace _2048
{
    public partial class Help_window : Form
    {
        Form1 form;

        public Help_window()
        {
            InitializeComponent();
        }

        private void Help_window_Load(object sender, EventArgs e)
        {
            form = (Form1)this.Owner; //задание владельца формы
        }

        private void Help_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.helpWindow_closed = true; //передача в основную форму информации, что справка закрыта
        }
    }
}
