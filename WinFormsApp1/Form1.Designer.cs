namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            tbinputScore = new TextBox();
            tbinputNAME = new TextBox();
            button1 = new Button();
            tbinputID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            tbAVER = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tbSCORE2 = new TextBox();
            tbSCORE1 = new TextBox();
            tbNameScore2 = new TextBox();
            tbNameScore1 = new TextBox();
            tbIDScore2 = new TextBox();
            tbIDScore1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbinputScore);
            groupBox1.Controls.Add(tbinputNAME);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbinputID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(68, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 374);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกข้อมูล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 197);
            label3.Name = "label3";
            label3.Size = new Size(61, 32);
            label3.TabIndex = 6;
            label3.Text = "คะแนน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 143);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 5;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // tbinputScore
            // 
            tbinputScore.Location = new Point(159, 202);
            tbinputScore.Name = "tbinputScore";
            tbinputScore.Size = new Size(189, 27);
            tbinputScore.TabIndex = 4;
            // 
            // tbinputNAME
            // 
            tbinputNAME.Location = new Point(159, 146);
            tbinputNAME.Name = "tbinputNAME";
            tbinputNAME.Size = new Size(190, 27);
            tbinputNAME.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(207, 254);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSave_Click;
            // 
            // tbinputID
            // 
            tbinputID.Location = new Point(160, 84);
            tbinputID.Name = "tbinputID";
            tbinputID.Size = new Size(189, 27);
            tbinputID.TabIndex = 1;
            tbinputID.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 81);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 0;
            label1.Text = "รหัสนักศึกษา";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(tbAVER);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbSCORE2);
            groupBox2.Controls.Add(tbSCORE1);
            groupBox2.Controls.Add(tbNameScore2);
            groupBox2.Controls.Add(tbNameScore1);
            groupBox2.Controls.Add(tbIDScore2);
            groupBox2.Controls.Add(tbIDScore1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(479, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(720, 283);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลลัพธ์";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(390, 216);
            label10.Name = "label10";
            label10.Size = new Size(93, 32);
            label10.TabIndex = 17;
            label10.Text = "คะแนนเฉลี่ย";
            // 
            // tbAVER
            // 
            tbAVER.Location = new Point(543, 216);
            tbAVER.Name = "tbAVER";
            tbAVER.Size = new Size(125, 27);
            tbAVER.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(54, 164);
            label9.Name = "label9";
            label9.Size = new Size(97, 32);
            label9.TabIndex = 15;
            label9.Text = "คะแนนต่ำสุด";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(54, 115);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
            label8.TabIndex = 14;
            label8.Text = "คะแนนสูงสุด";
            // 
            // tbSCORE2
            // 
            tbSCORE2.Location = new Point(543, 161);
            tbSCORE2.Name = "tbSCORE2";
            tbSCORE2.Size = new Size(125, 27);
            tbSCORE2.TabIndex = 13;
            tbSCORE2.TextChanged += tbSCORE2_TextChanged;
            // 
            // tbSCORE1
            // 
            tbSCORE1.Location = new Point(543, 108);
            tbSCORE1.Name = "tbSCORE1";
            tbSCORE1.Size = new Size(125, 27);
            tbSCORE1.TabIndex = 12;
            tbSCORE1.TextChanged += tbSCORE1_TextChanged;
            // 
            // tbNameScore2
            // 
            tbNameScore2.Location = new Point(367, 161);
            tbNameScore2.Name = "tbNameScore2";
            tbNameScore2.Size = new Size(125, 27);
            tbNameScore2.TabIndex = 11;
            tbNameScore2.TextChanged += tbNameScore2_TextChanged;
            // 
            // tbNameScore1
            // 
            tbNameScore1.Location = new Point(367, 108);
            tbNameScore1.Name = "tbNameScore1";
            tbNameScore1.Size = new Size(125, 27);
            tbNameScore1.TabIndex = 10;
            tbNameScore1.TextChanged += tbNameScore1_TextChanged;
            // 
            // tbIDScore2
            // 
            tbIDScore2.Location = new Point(167, 161);
            tbIDScore2.Name = "tbIDScore2";
            tbIDScore2.Size = new Size(125, 27);
            tbIDScore2.TabIndex = 9;
            // 
            // tbIDScore1
            // 
            tbIDScore1.Location = new Point(167, 108);
            tbIDScore1.Name = "tbIDScore1";
            tbIDScore1.Size = new Size(125, 27);
            tbIDScore1.TabIndex = 8;
            tbIDScore1.TextChanged += tbIDScore1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(585, 65);
            label7.Name = "label7";
            label7.Size = new Size(61, 32);
            label7.TabIndex = 7;
            label7.Text = "คะแนน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(379, 65);
            label6.Name = "label6";
            label6.Size = new Size(93, 32);
            label6.TabIndex = 6;
            label6.Text = "ชื่อ-นามสกุล";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 177);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 65);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 1;
            label4.Text = "รหัสนักศึกษา";
            label4.Click += label4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(533, 431);
            label11.Name = "label11";
            label11.Size = new Size(258, 32);
            label11.TabIndex = 15;
            label11.Text = "นางสาวกันทิมา พิมรัตน์  663450033-9";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(533, 381);
            label12.Name = "label12";
            label12.Size = new Size(248, 32);
            label12.TabIndex = 16;
            label12.Text = "นายจตุภัทร อนุเดชากุล 663450035-5";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(822, 381);
            label13.Name = "label13";
            label13.Size = new Size(261, 32);
            label13.TabIndex = 17;
            label13.Text = "นางสาวปานวาด คารินทา 663450350-7";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Angsana New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(822, 431);
            label14.Name = "label14";
            label14.Size = new Size(276, 32);
            label14.TabIndex = 18;
            label14.Text = "นางสาวอรยมล ประชานันท์ 663450352-3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 497);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox tbinputID;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox tbinputScore;
        private TextBox tbinputNAME;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbSCORE2;
        private TextBox tbSCORE1;
        private TextBox tbNameScore2;
        private TextBox tbNameScore1;
        private TextBox tbIDScore2;
        private TextBox tbIDScore1;
        private TextBox tbAVER;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
