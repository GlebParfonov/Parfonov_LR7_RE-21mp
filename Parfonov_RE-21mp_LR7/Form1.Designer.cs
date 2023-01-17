namespace Parfonov_RE_21mp_LR7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.text_In = new System.Windows.Forms.TextBox();
            this.text_Out = new System.Windows.Forms.TextBox();
            this.comboBox_KeySize = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_IV = new System.Windows.Forms.TextBox();
            this.b_In = new System.Windows.Forms.Button();
            this.b_Out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_InEnthropy = new System.Windows.Forms.Label();
            this.label_InSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_OutEnthropy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_OutSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.b_GenKey = new System.Windows.Forms.Button();
            this.b_GenBI = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Load = new System.Windows.Forms.Button();
            this.checkBox_IV0 = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton_AES = new System.Windows.Forms.RadioButton();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_Dechipher = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_InSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label_InEnthropy);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.b_In);
            this.groupBox2.Controls.Add(this.text_In);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввід";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_OutSize);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label_OutEnthropy);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.b_Out);
            this.groupBox3.Controls.Add(this.text_Out);
            this.groupBox3.Location = new System.Drawing.Point(6, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 89);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вивід";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.comboBox_KeySize);
            this.groupBox4.Location = new System.Drawing.Point(43, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(739, 70);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметри";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.b_Load);
            this.groupBox5.Controls.Add(this.b_Save);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(43, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(739, 197);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.b_GenKey);
            this.groupBox6.Controls.Add(this.textBox_Key);
            this.groupBox6.Location = new System.Drawing.Point(6, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(727, 64);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ключ";
            // 
            // text_In
            // 
            this.text_In.Location = new System.Drawing.Point(51, 21);
            this.text_In.Name = "text_In";
            this.text_In.Size = new System.Drawing.Size(546, 22);
            this.text_In.TabIndex = 0;
            // 
            // text_Out
            // 
            this.text_Out.Location = new System.Drawing.Point(51, 21);
            this.text_Out.Name = "text_Out";
            this.text_Out.Size = new System.Drawing.Size(546, 22);
            this.text_Out.TabIndex = 0;
            // 
            // comboBox_KeySize
            // 
            this.comboBox_KeySize.FormattingEnabled = true;
            this.comboBox_KeySize.Items.AddRange(new object[] {
            "128",
            "256"});
            this.comboBox_KeySize.Location = new System.Drawing.Point(213, 24);
            this.comboBox_KeySize.Name = "comboBox_KeySize";
            this.comboBox_KeySize.Size = new System.Drawing.Size(121, 24);
            this.comboBox_KeySize.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox_IV0);
            this.groupBox7.Controls.Add(this.b_GenBI);
            this.groupBox7.Controls.Add(this.textBox_IV);
            this.groupBox7.Location = new System.Drawing.Point(6, 91);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(727, 75);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ініціалізаційний вектор";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(51, 21);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(435, 22);
            this.textBox_Key.TabIndex = 0;
            // 
            // textBox_IV
            // 
            this.textBox_IV.Location = new System.Drawing.Point(51, 21);
            this.textBox_IV.Name = "textBox_IV";
            this.textBox_IV.Size = new System.Drawing.Size(435, 22);
            this.textBox_IV.TabIndex = 0;
            // 
            // b_In
            // 
            this.b_In.Location = new System.Drawing.Point(622, 21);
            this.b_In.Name = "b_In";
            this.b_In.Size = new System.Drawing.Size(75, 23);
            this.b_In.TabIndex = 1;
            this.b_In.Text = "...";
            this.b_In.UseVisualStyleBackColor = true;
            this.b_In.Click += new System.EventHandler(this.b_In_Click);
            // 
            // b_Out
            // 
            this.b_Out.Location = new System.Drawing.Point(626, 21);
            this.b_Out.Name = "b_Out";
            this.b_Out.Size = new System.Drawing.Size(75, 23);
            this.b_Out.TabIndex = 1;
            this.b_Out.Text = "...";
            this.b_Out.UseVisualStyleBackColor = true;
            this.b_Out.Click += new System.EventHandler(this.b_Out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ентропія";
            // 
            // label_InEnthropy
            // 
            this.label_InEnthropy.AutoSize = true;
            this.label_InEnthropy.Location = new System.Drawing.Point(129, 57);
            this.label_InEnthropy.Name = "label_InEnthropy";
            this.label_InEnthropy.Size = new System.Drawing.Size(28, 16);
            this.label_InEnthropy.TabIndex = 3;
            this.label_InEnthropy.Text = "???";
            // 
            // label_InSize
            // 
            this.label_InSize.AutoSize = true;
            this.label_InSize.Location = new System.Drawing.Point(526, 57);
            this.label_InSize.Name = "label_InSize";
            this.label_InSize.Size = new System.Drawing.Size(28, 16);
            this.label_InSize.TabIndex = 5;
            this.label_InSize.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Розмір";
            // 
            // label_OutEnthropy
            // 
            this.label_OutEnthropy.AutoSize = true;
            this.label_OutEnthropy.Location = new System.Drawing.Point(129, 58);
            this.label_OutEnthropy.Name = "label_OutEnthropy";
            this.label_OutEnthropy.Size = new System.Drawing.Size(28, 16);
            this.label_OutEnthropy.TabIndex = 5;
            this.label_OutEnthropy.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ентропія";
            // 
            // label_OutSize
            // 
            this.label_OutSize.AutoSize = true;
            this.label_OutSize.Location = new System.Drawing.Point(526, 58);
            this.label_OutSize.Name = "label_OutSize";
            this.label_OutSize.Size = new System.Drawing.Size(28, 16);
            this.label_OutSize.TabIndex = 7;
            this.label_OutSize.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Розмір";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Довжина ключа (біти)";
            // 
            // b_GenKey
            // 
            this.b_GenKey.Location = new System.Drawing.Point(514, 20);
            this.b_GenKey.Name = "b_GenKey";
            this.b_GenKey.Size = new System.Drawing.Size(143, 23);
            this.b_GenKey.TabIndex = 1;
            this.b_GenKey.Text = "Згенерувати ключ";
            this.b_GenKey.UseVisualStyleBackColor = true;
            this.b_GenKey.Click += new System.EventHandler(this.b_GenKey_Click);
            // 
            // b_GenBI
            // 
            this.b_GenBI.Location = new System.Drawing.Point(514, 20);
            this.b_GenBI.Name = "b_GenBI";
            this.b_GenBI.Size = new System.Drawing.Size(143, 23);
            this.b_GenBI.TabIndex = 1;
            this.b_GenBI.Text = "Згенерувати  BI";
            this.b_GenBI.UseVisualStyleBackColor = true;
            this.b_GenBI.Click += new System.EventHandler(this.b_GenBI_Click);
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(495, 168);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(91, 23);
            this.b_Save.TabIndex = 4;
            this.b_Save.Text = "Зберегти";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Load
            // 
            this.b_Load.Location = new System.Drawing.Point(603, 168);
            this.b_Load.Name = "b_Load";
            this.b_Load.Size = new System.Drawing.Size(104, 23);
            this.b_Load.TabIndex = 5;
            this.b_Load.Text = "Завантажити";
            this.b_Load.UseVisualStyleBackColor = true;
            this.b_Load.Click += new System.EventHandler(this.b_Load_Click);
            // 
            // checkBox_IV0
            // 
            this.checkBox_IV0.AutoSize = true;
            this.checkBox_IV0.Location = new System.Drawing.Point(666, 21);
            this.checkBox_IV0.Name = "checkBox_IV0";
            this.checkBox_IV0.Size = new System.Drawing.Size(55, 20);
            this.checkBox_IV0.TabIndex = 2;
            this.checkBox_IV0.Text = "BI=0";
            this.checkBox_IV0.UseVisualStyleBackColor = true;
            this.checkBox_IV0.CheckedChanged += new System.EventHandler(this.checkBox_IV0_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton_AES);
            this.groupBox8.Location = new System.Drawing.Point(43, 526);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(739, 60);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Алгоритм";
            // 
            // radioButton_AES
            // 
            this.radioButton_AES.AutoSize = true;
            this.radioButton_AES.Location = new System.Drawing.Point(29, 22);
            this.radioButton_AES.Name = "radioButton_AES";
            this.radioButton_AES.Size = new System.Drawing.Size(55, 20);
            this.radioButton_AES.TabIndex = 0;
            this.radioButton_AES.TabStop = true;
            this.radioButton_AES.Text = "AES";
            this.radioButton_AES.UseVisualStyleBackColor = true;
            this.radioButton_AES.CheckedChanged += new System.EventHandler(this.radioButton_AES_CheckedChanged);
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(43, 592);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(121, 23);
            this.button_Encrypt.TabIndex = 3;
            this.button_Encrypt.Text = "Зашифрувати";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // button_Dechipher
            // 
            this.button_Dechipher.Location = new System.Drawing.Point(181, 592);
            this.button_Dechipher.Name = "button_Dechipher";
            this.button_Dechipher.Size = new System.Drawing.Size(125, 23);
            this.button_Dechipher.TabIndex = 4;
            this.button_Dechipher.Text = "Розшифрувати";
            this.button_Dechipher.UseVisualStyleBackColor = true;
            this.button_Dechipher.Click += new System.EventHandler(this.button_Dechipher_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(321, 592);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 5;
            this.button_Stop.Text = "Стоп";
            this.button_Stop.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Розрахунковий час";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(672, 595);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(55, 16);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "00:00.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Dechipher);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_OutSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_OutEnthropy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_Out;
        private System.Windows.Forms.TextBox text_Out;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_InSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_InEnthropy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_In;
        private System.Windows.Forms.TextBox text_In;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_KeySize;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button b_Load;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox_IV0;
        private System.Windows.Forms.Button b_GenBI;
        private System.Windows.Forms.TextBox textBox_IV;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button b_GenKey;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButton_AES;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_Dechipher;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_time;
    }
}

