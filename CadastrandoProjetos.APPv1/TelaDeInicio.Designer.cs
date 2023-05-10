namespace CadastrandoProjetos.APPv1
{
    partial class TelaDeInicio
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            Btn_cadastrar = new Button();
            BotãoExibirProjetos = new Button();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Btn_cadastrar
            // 
            Btn_cadastrar.AccessibleName = "Btn_cadastrar";
            Btn_cadastrar.BackColor = SystemColors.ActiveCaption;
            Btn_cadastrar.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_cadastrar.ForeColor = Color.Blue;
            Btn_cadastrar.Location = new Point(684, 262);
            Btn_cadastrar.Name = "Btn_cadastrar";
            Btn_cadastrar.Size = new Size(291, 164);
            Btn_cadastrar.TabIndex = 0;
            Btn_cadastrar.Text = "Cadastrar novo Projeto";
            Btn_cadastrar.UseVisualStyleBackColor = false;
            Btn_cadastrar.Click += Btn_cadastrar_Click;
            // 
            // BotãoExibirProjetos
            // 
            BotãoExibirProjetos.BackColor = SystemColors.ActiveCaption;
            BotãoExibirProjetos.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BotãoExibirProjetos.ForeColor = Color.FromArgb(0, 0, 192);
            BotãoExibirProjetos.Location = new Point(287, 262);
            BotãoExibirProjetos.Name = "BotãoExibirProjetos";
            BotãoExibirProjetos.Size = new Size(291, 164);
            BotãoExibirProjetos.TabIndex = 1;
            BotãoExibirProjetos.Text = "Exibir Projetos Cadastrados";
            BotãoExibirProjetos.UseVisualStyleBackColor = false;
            BotãoExibirProjetos.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(287, 89);
            label2.Name = "label2";
            label2.Size = new Size(771, 55);
            label2.TabIndex = 2;
            label2.Text = "Bem vindos ao ConnectProjects";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "Btn_cadastrar";
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(1016, 262);
            button1.Name = "button1";
            button1.Size = new Size(291, 164);
            button1.TabIndex = 3;
            button1.Text = "Editar Projetos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TelaDeInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpaperProjects;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(BotãoExibirProjetos);
            Controls.Add(Btn_cadastrar);
            Name = "TelaDeInicio";
            Text = "Form1";
            Load += TelaDeInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private Button Btn_cadastrar;
        private Button BotãoExibirProjetos;
        private Label label2;
        private Button button1;
    }
}