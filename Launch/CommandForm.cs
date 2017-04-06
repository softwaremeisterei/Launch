using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launch
{
    public partial class CommandForm : Form
    {
        public Command Command { get; set; }

        public CommandForm(Command command = null)
        {
            InitializeComponent();

            if (command != null)
            {
                Command = command;
                titleTextBox.Text = command.Title;
                applicationTextBox.Text = command.Application;
                argumentsTextBox.Text = command.Arguments;
            }
            else
            {
                Command = new Command();
            }
        }

        private void CommandForm_Load(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Command.Title = titleTextBox.Text;
            Command.Application = applicationTextBox.Text;
            Command.Arguments = argumentsTextBox.Text;
            Close();
        }
    }
}
