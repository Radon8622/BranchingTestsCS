using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BranchingTest.UIElements
{
    class WritingTaskPanel : Panel
    {
        public WritingTaskPanel(string title, string taskText, int width, bool requiredToFillField = false, string rightResponse = null)
        {
            this.Width = width;
            this.BackColor = SystemColors.Menu;
            Label explanationLabel = null;
            if (requiredToFillField)
            {
                this.BackColor = Color.FromArgb(255, 209, 212);
                explanationLabel = new Label();
                explanationLabel.Width = width;
                explanationLabel.Text = "* - Поле обязательно для заполнения";
                explanationLabel.ForeColor = Color.Red;
                explanationLabel.Font = new Font("Noto Mono", 10);
                explanationLabel.Location= new Point(0,0);
                this.Controls.Add(explanationLabel);
            }
            PictureBox pictureBox= new PictureBox();
            if (!(explanationLabel is null))
            {
                pictureBox.Location= new Point(0, explanationLabel.Height+2);
            }
            else
            {
                pictureBox.Location = new Point(0, 0);
            }
            pictureBox.Size = new Size(this.Width, 1);
            this.Controls.Add(pictureBox);
            Label titleLabel = new Label()
            {
                Width = width,
                Text = title,
                Font = new Font("Noto Mono", 18),
                TextAlign = ContentAlignment.MiddleCenter,
                Location= new Point(0, pictureBox.Location.Y+pictureBox.Height),
            };
            this.Controls.Add(titleLabel);
            TextBox textBox = new TextBox()
            {
                BorderStyle= BorderStyle.None,
                Width = this.Width-30,
                Text = taskText,
                ReadOnly= true,
                Location = new Point(10,titleLabel.Location.Y+titleLabel.Height+3),
                Font = new Font(Font.FontFamily,12)
            };
            this.Controls.Add(textBox);
        }
    }
}
