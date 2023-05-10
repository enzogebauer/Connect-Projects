namespace CadastrandoProjetos.APPv1
{
    partial class CadastrarProjeto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            label6 = new Label();
            monthCalendar2 = new MonthCalendar();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(992, 173);
            button1.Name = "button1";
            button1.Size = new Size(141, 50);
            button1.TabIndex = 0;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 0, 192);
            button2.Location = new Point(992, 68);
            button2.Name = "button2";
            button2.Size = new Size(141, 50);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar Projeto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(371, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 6;
            label1.Text = "Projeto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "Gerente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 134);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 15);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Descrição";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(535, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(268, 109);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 212);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 11;
            label5.Text = "Data de Inicio";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(371, 236);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(695, 212);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 13;
            label6.Text = "Data de Finalização";
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(641, 236);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.ShowTodayCircle = false;
            monthCalendar2.TabIndex = 14;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Em andamento", "Concluido", "Cancelado" });
            comboBox1.Location = new Point(371, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CadastrarProjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaperProjects;
            ClientSize = new Size(1904, 1041);
            Controls.Add(comboBox1);
            Controls.Add(monthCalendar2);
            Controls.Add(label6);
            Controls.Add(monthCalendar1);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CadastrarProjeto";
            Text = "Form1";
            FormClosing += CadastrarProjeto_FormClosing;
            RightToLeftChanged += s;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private Label label6;
        private MonthCalendar monthCalendar2;
        private ComboBox comboBox1;
    }
}