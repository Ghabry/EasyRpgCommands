using System;
using System.Windows.Forms;

namespace EasyRpgCommands
{
    public class TextInputDialog : Form
    {
        private TextBox textBox;
        private Button returnButton;

        public string UserInput { get; private set; }

        public TextInputDialog(String text)
        {
            textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            textBox.Text = text;

            returnButton = new Button();
            returnButton.Text = "Return";
            returnButton.Dock = DockStyle.Bottom;
            returnButton.Click += new EventHandler(ReturnButton_Click);

            Controls.Add(textBox);
            Controls.Add(returnButton);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            UserInput = textBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}