namespace BranchingTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainTextLabel = new System.Windows.Forms.Label();
            this.startTestButton = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Noto Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(966, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Тестирование студентов ККЭП I курса по теме \"Ветвления в C#\"";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTextLabel
            // 
            this.mainTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextLabel.Location = new System.Drawing.Point(12, 66);
            this.mainTextLabel.Name = "mainTextLabel";
            this.mainTextLabel.Size = new System.Drawing.Size(966, 429);
            this.mainTextLabel.TabIndex = 1;
            this.mainTextLabel.Text = resources.GetString("mainTextLabel.Text");
            // 
            // startTestButton
            // 
            this.startTestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startTestButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startTestButton.Font = new System.Drawing.Font("Noto Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTestButton.Location = new System.Drawing.Point(14, 495);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(964, 86);
            this.startTestButton.TabIndex = 2;
            this.startTestButton.Text = "Приступить к работе";
            this.startTestButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startTestButton.Click += new System.EventHandler(this.startTestButton_Click_1);
            // 
            // previewBox
            // 
            this.previewBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewBox.BackgroundImage")));
            this.previewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previewBox.Location = new System.Drawing.Point(16, 150);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(962, 342);
            this.previewBox.TabIndex = 3;
            this.previewBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(990, 590);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.mainTextLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1006, 629);
            this.MinimumSize = new System.Drawing.Size(1006, 629);
            this.Name = "Form1";
            this.Text = "Тестирование студентов ККЭП I курса по теме \"Ветвления в C#\"";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label mainTextLabel;
        private System.Windows.Forms.Label startTestButton;
        private System.Windows.Forms.PictureBox previewBox;
    }
}

