namespace CadastrandoProjetos.APPv1
{
    partial class Editar_projeto
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
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            monthCalendar1 = new MonthCalendar();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            monthCalendar2 = new MonthCalendar();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(851, 457);
            button2.Name = "button2";
            button2.Size = new Size(103, 45);
            button2.TabIndex = 23;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(851, 363);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 22;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(380, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(380, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(555, 236);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(399, 96);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(367, 344);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.TabIndex = 18;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Em andamento", "Concluido", "Cancelado" });
            comboBox1.Location = new Point(555, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 320);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 16;
            label5.Text = "Data de Finalização";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 209);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 15;
            label4.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 151);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 14;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 209);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 13;
            label2.Text = "Gerente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 151);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome do Projeto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(535, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 24;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 9);
            label6.Name = "label6";
            label6.Size = new Size(162, 15);
            label6.TabIndex = 25;
            label6.Text = "Buque o projeto para edita-lo";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 0, 192);
            button3.Location = new Point(514, 73);
            button3.Name = "button3";
            button3.Size = new Size(141, 50);
            button3.TabIndex = 26;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(634, 514);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.ShowTodayCircle = false;
            monthCalendar2.TabIndex = 27;
            monthCalendar2.Visible = false;
            // 
            // Editar_projeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaperProjects;
            ClientSize = new Size(1904, 1041);
            Controls.Add(monthCalendar2);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Editar_projeto";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label6;
        private Button button3;
        private MonthCalendar monthCalendar2;
    }
}