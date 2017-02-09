namespace BlackJack
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
            this.label1 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardsUserBox = new System.Windows.Forms.TextBox();
            this.pointsUserBox = new System.Windows.Forms.TextBox();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.pointsDilerBox = new System.Windows.Forms.TextBox();
            this.cardsDilerBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.maxRateBox = new System.Windows.Forms.TextBox();
            this.minRateBox = new System.Windows.Forms.TextBox();
            this.startMoneyBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.countDeckBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.countCardsLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.pasButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Деньги:";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(136, 357);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(26, 29);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Карты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Очки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ставка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(121, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вы";
            // 
            // cardsUserBox
            // 
            this.cardsUserBox.Location = new System.Drawing.Point(126, 160);
            this.cardsUserBox.Name = "cardsUserBox";
            this.cardsUserBox.ReadOnly = true;
            this.cardsUserBox.Size = new System.Drawing.Size(120, 22);
            this.cardsUserBox.TabIndex = 21;
            // 
            // pointsUserBox
            // 
            this.pointsUserBox.Location = new System.Drawing.Point(126, 189);
            this.pointsUserBox.Name = "pointsUserBox";
            this.pointsUserBox.ReadOnly = true;
            this.pointsUserBox.Size = new System.Drawing.Size(120, 22);
            this.pointsUserBox.TabIndex = 22;
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(126, 218);
            this.rateBox.Name = "rateBox";
            this.rateBox.ReadOnly = true;
            this.rateBox.Size = new System.Drawing.Size(120, 22);
            this.rateBox.TabIndex = 23;
            // 
            // pointsDilerBox
            // 
            this.pointsDilerBox.Location = new System.Drawing.Point(126, 78);
            this.pointsDilerBox.Name = "pointsDilerBox";
            this.pointsDilerBox.ReadOnly = true;
            this.pointsDilerBox.Size = new System.Drawing.Size(120, 22);
            this.pointsDilerBox.TabIndex = 40;
            // 
            // cardsDilerBox
            // 
            this.cardsDilerBox.Location = new System.Drawing.Point(126, 49);
            this.cardsDilerBox.Name = "cardsDilerBox";
            this.cardsDilerBox.ReadOnly = true;
            this.cardsDilerBox.Size = new System.Drawing.Size(120, 22);
            this.cardsDilerBox.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(121, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Дилер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(42, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 29);
            this.label10.TabIndex = 37;
            this.label10.Text = "Очки:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(30, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 29);
            this.label11.TabIndex = 36;
            this.label11.Text = "Карты:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Макс. ставка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(445, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Мин. ставка";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(454, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "Кол. денег";
            // 
            // maxRateBox
            // 
            this.maxRateBox.Location = new System.Drawing.Point(538, 23);
            this.maxRateBox.Name = "maxRateBox";
            this.maxRateBox.Size = new System.Drawing.Size(85, 22);
            this.maxRateBox.TabIndex = 45;
            // 
            // minRateBox
            // 
            this.minRateBox.Location = new System.Drawing.Point(538, 51);
            this.minRateBox.Name = "minRateBox";
            this.minRateBox.Size = new System.Drawing.Size(85, 22);
            this.minRateBox.TabIndex = 46;
            // 
            // startMoneyBox
            // 
            this.startMoneyBox.Location = new System.Drawing.Point(538, 79);
            this.startMoneyBox.Name = "startMoneyBox";
            this.startMoneyBox.Size = new System.Drawing.Size(85, 22);
            this.startMoneyBox.TabIndex = 47;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(538, 177);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(85, 29);
            this.startButton.TabIndex = 49;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countDeckBox
            // 
            this.countDeckBox.Location = new System.Drawing.Point(538, 107);
            this.countDeckBox.Name = "countDeckBox";
            this.countDeckBox.Size = new System.Drawing.Size(85, 22);
            this.countDeckBox.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(452, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 17);
            this.label16.TabIndex = 50;
            this.label16.Text = "Кол. колод";
            // 
            // countCardsLabel
            // 
            this.countCardsLabel.AutoSize = true;
            this.countCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countCardsLabel.Location = new System.Drawing.Point(594, 357);
            this.countCardsLabel.Name = "countCardsLabel";
            this.countCardsLabel.Size = new System.Drawing.Size(26, 29);
            this.countCardsLabel.TabIndex = 53;
            this.countCardsLabel.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(403, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 29);
            this.label18.TabIndex = 52;
            this.label18.Text = "Карт осталось:";
            // 
            // continueButton
            // 
            this.continueButton.Enabled = false;
            this.continueButton.Location = new System.Drawing.Point(35, 306);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(109, 30);
            this.continueButton.TabIndex = 54;
            this.continueButton.Text = "Продолжить";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueBox_Click);
            // 
            // pasButton
            // 
            this.pasButton.Enabled = false;
            this.pasButton.Location = new System.Drawing.Point(173, 306);
            this.pasButton.Name = "pasButton";
            this.pasButton.Size = new System.Drawing.Size(109, 30);
            this.pasButton.TabIndex = 55;
            this.pasButton.Text = "Пас";
            this.pasButton.UseVisualStyleBackColor = true;
            this.pasButton.Click += new System.EventHandler(this.pasButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBox.Location = new System.Drawing.Point(32, 255);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(591, 27);
            this.statusBox.TabIndex = 56;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 401);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.pasButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.countCardsLabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.countDeckBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.startMoneyBox);
            this.Controls.Add(this.minRateBox);
            this.Controls.Add(this.maxRateBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pointsDilerBox);
            this.Controls.Add(this.cardsDilerBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.pointsUserBox);
            this.Controls.Add(this.cardsUserBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cardsUserBox;
        private System.Windows.Forms.TextBox pointsUserBox;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox pointsDilerBox;
        private System.Windows.Forms.TextBox cardsDilerBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox maxRateBox;
        private System.Windows.Forms.TextBox minRateBox;
        private System.Windows.Forms.TextBox startMoneyBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox countDeckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label countCardsLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button pasButton;
        private System.Windows.Forms.TextBox statusBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

