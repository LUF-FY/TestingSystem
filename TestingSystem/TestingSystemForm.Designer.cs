namespace TestingSystem
{
    partial class TestingSystemForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonStart = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.playerNickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTests = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.questNumb = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.earlyQuestButton = new System.Windows.Forms.Button();
            this.nextQuestButton = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel1.Controls.Add(this.restartButton);
            this.splitContainer1.Panel1.Controls.Add(this.playerNickname);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxTests);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 189);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(169, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Начать тест";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(16, 415);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(165, 23);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "Перезапуск";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // playerNickname
            // 
            this.playerNickname.Location = new System.Drawing.Point(13, 61);
            this.playerNickname.Name = "playerNickname";
            this.playerNickname.Size = new System.Drawing.Size(169, 20);
            this.playerNickname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите ваше имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тест:";
            // 
            // comboBoxTests
            // 
            this.comboBoxTests.FormattingEnabled = true;
            this.comboBoxTests.Location = new System.Drawing.Point(13, 154);
            this.comboBoxTests.Name = "comboBoxTests";
            this.comboBoxTests.Size = new System.Drawing.Size(169, 21);
            this.comboBoxTests.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.questNumb);
            this.splitContainer2.Panel1.Controls.Add(this.question);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelAnswers);
            this.splitContainer2.Size = new System.Drawing.Size(596, 450);
            this.splitContainer2.SplitterDistance = 160;
            this.splitContainer2.TabIndex = 2;
            // 
            // questNumb
            // 
            this.questNumb.AutoSize = true;
            this.questNumb.Location = new System.Drawing.Point(7, 9);
            this.questNumb.Name = "questNumb";
            this.questNumb.Size = new System.Drawing.Size(89, 13);
            this.questNumb.TabIndex = 0;
            this.questNumb.Text = "Номер вопроса:";
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(7, 34);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(44, 13);
            this.question.TabIndex = 1;
            this.question.Text = "Вопрос";
            // 
            // panelAnswers
            // 
            this.panelAnswers.Controls.Add(this.earlyQuestButton);
            this.panelAnswers.Controls.Add(this.nextQuestButton);
            this.panelAnswers.Controls.Add(this.radioButton4);
            this.panelAnswers.Controls.Add(this.radioButton3);
            this.panelAnswers.Controls.Add(this.radioButton2);
            this.panelAnswers.Controls.Add(this.radioButton1);
            this.panelAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswers.Location = new System.Drawing.Point(0, 0);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(594, 284);
            this.panelAnswers.TabIndex = 3;
            // 
            // earlyQuestButton
            // 
            this.earlyQuestButton.Location = new System.Drawing.Point(318, 251);
            this.earlyQuestButton.Name = "earlyQuestButton";
            this.earlyQuestButton.Size = new System.Drawing.Size(130, 23);
            this.earlyQuestButton.TabIndex = 5;
            this.earlyQuestButton.Text = "Предыдущий вопрос";
            this.earlyQuestButton.UseVisualStyleBackColor = true;
            this.earlyQuestButton.Click += new System.EventHandler(this.earlyQuestButton_Click);
            // 
            // nextQuestButton
            // 
            this.nextQuestButton.Location = new System.Drawing.Point(454, 251);
            this.nextQuestButton.Name = "nextQuestButton";
            this.nextQuestButton.Size = new System.Drawing.Size(130, 23);
            this.nextQuestButton.TabIndex = 4;
            this.nextQuestButton.Text = "Следующий вопрос";
            this.nextQuestButton.UseVisualStyleBackColor = true;
            this.nextQuestButton.Click += new System.EventHandler(this.nextQuestButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 200);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 130);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // TestingSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestingSystemForm";
            this.Text = "Тестирующая система";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelAnswers.ResumeLayout(false);
            this.panelAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label questNumb;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTests;
        private System.Windows.Forms.TextBox playerNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextQuestButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button earlyQuestButton;
    }
}

