using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationBuilder
{
    public partial class TextDialog : Form
    {
        public String Input;
        public TextDialog()
        {
            Input = "";
            InitializeComponent();
        }

        public TextDialog(String title, String message)
        {
            InitializeComponent();
            Input = "";
            this.Text = title;
            this.MessageLabel.Text = message;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            Input = InputBox.Text;
        }

        
    }
}
