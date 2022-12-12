using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchingTest
{
    public partial class TestForm : Form
    {
        List<WritingTaskPanelContainer> writingTasksPanel = new List<WritingTaskPanelContainer>();
        List<TestingTaskPanelContainer> testingTasksPanel = new List<TestingTaskPanelContainer>();
        public TestForm()
        {
            InitializeComponent();
            writingTasksPanel = new List<WritingTaskPanelContainer>()
            {
                new WritingTaskPanelContainer(greetingPanel, usernameTextBox, ""),
            };
            testingTasksPanel = new List<TestingTaskPanelContainer>()
            {
                new TestingTaskPanelContainer(taskFirstPanel, taskFirstButtonFirst.Text),
                new TestingTaskPanelContainer(taskSecondPanel, taskSecondButtonThird.Text),
                new TestingTaskPanelContainer(taskThirdPanel, taskThirdButtonFifth.Text),
                new TestingTaskPanelContainer(taskFourthPanel, taskFourthButtonFourth.Text),
                new TestingTaskPanelContainer(taskFifthPanel, taskFifthButtonFourth.Text),
                new TestingTaskPanelContainer(taskSixthPanel, taskSixthButtonSecond.Text),
            };
        }

        private void finishTestButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }
            if (MessageBox.Show("Вы точно хотите завершить тестирование?","",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                return;
            }
            int allQuetionsCounter = 0;
            int rightAnswersCounter = 0;
            foreach (var item in writingTasksPanel)
            {
                if (item.RightAnswer != string.Empty)
                {
                    allQuetionsCounter++;
                    if (item.AnswerTextBox.Text == item.RightAnswer)
                    {
                        rightAnswersCounter++;
                    }
                }
            }
            foreach (var item in testingTasksPanel)
            {
                allQuetionsCounter++;
                if (item.SelectedAnswer == item.RightAnswer)
                {
                    rightAnswersCounter++;
                }
            }
            new System.Media.SoundPlayer().Play();
            int ratio = (rightAnswersCounter * 100 / allQuetionsCounter);
            int mark;
            if (ratio < 50) { mark = 2; }
            else if (ratio < 65) { mark = 3; }
            else if (ratio < 85) { mark = 4; }
            else { mark = 5; }
            if (mark >= 4)
            {
                MessageBox.Show($"{usernameTextBox.Text}, поздравляем! Вы получили {mark}! Правильно выполненно {rightAnswersCounter} из {allQuetionsCounter} заданий.");
            }
            else
            {
                MessageBox.Show($"{usernameTextBox.Text}, вы получили {mark}. Правильно выполненно {rightAnswersCounter} из {allQuetionsCounter} заданий.");
            }
            this.Close();
        }
    }
    public abstract class TaskPanelContainer
    {
        public Panel Panel { get; private set; }
        public string RightAnswer { get; private set; }
        public TaskPanelContainer(Panel panel, string rightAnswer)
        {
            this.Panel = panel;
            this.RightAnswer = rightAnswer;
        }
    }
    public class WritingTaskPanelContainer : TaskPanelContainer
    {
        public TextBox AnswerTextBox { get; private set; }

        public WritingTaskPanelContainer(Panel panel, TextBox answerTextBox, string rightAnswer) : base(panel, rightAnswer)
        {
            this.AnswerTextBox = answerTextBox;
        }
    }
    public class TestingTaskPanelContainer : TaskPanelContainer
    {
        public string SelectedAnswer { get; private set; }

        public TestingTaskPanelContainer(Panel panel, string rightAnswer) : base(panel, rightAnswer)
        {
            foreach (var elem in panel.Controls)
            {
                if (elem is Button)
                {
                    ((Button)elem).Click += TestButton_Click;
                }
                if (elem is PictureBox)
                {
                    ((PictureBox)elem).Click += TestPicture_Click;
                }
            }
        }
        private void TestButton_Click(object sender, EventArgs e)
        {
            foreach (var button in Panel.Controls)
            {
                if (button is Button)
                {
                    ((Button)button).BackColor = SystemColors.ControlLightLight;
                }
            }
            ((Button)sender).BackColor = Color.FromArgb(211, 233, 242);
            this.SelectedAnswer = ((Button)sender).Text;
        }

        private void TestPicture_Click(object sender, EventArgs e)
        {
            new Form() { BackgroundImage = ((PictureBox)sender).BackgroundImage, BackgroundImageLayout = ImageLayout.Stretch}.Show();
        }
    }
}
