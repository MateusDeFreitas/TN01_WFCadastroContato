namespace TN01_WFCadastroContato
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxSobreNome = new TextBox();
            labelSobrenome = new Label();
            panel1 = new Panel();
            textBoxTelefone = new TextBox();
            label1 = new Label();
            groupBoxTipoTel = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            textBoxEmail = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBoxTipoTel.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(43, 42);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(43, 69);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(201, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxSobreNome
            // 
            textBoxSobreNome.Location = new Point(286, 69);
            textBoxSobreNome.Name = "textBoxSobreNome";
            textBoxSobreNome.Size = new Size(317, 23);
            textBoxSobreNome.TabIndex = 3;
            // 
            // labelSobrenome
            // 
            labelSobrenome.AutoSize = true;
            labelSobrenome.Location = new Point(286, 42);
            labelSobrenome.Name = "labelSobrenome";
            labelSobrenome.Size = new Size(71, 15);
            labelSobrenome.TabIndex = 2;
            labelSobrenome.Text = "Sobrenome:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Location = new Point(43, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 2);
            panel1.TabIndex = 4;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(43, 192);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(103, 23);
            textBoxTelefone.TabIndex = 6;
            textBoxTelefone.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 165);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "DDD/Telefone";
            // 
            // groupBoxTipoTel
            // 
            groupBoxTipoTel.Controls.Add(radioButton3);
            groupBoxTipoTel.Controls.Add(radioButton2);
            groupBoxTipoTel.Controls.Add(radioButton1);
            groupBoxTipoTel.Location = new Point(200, 155);
            groupBoxTipoTel.Name = "groupBoxTipoTel";
            groupBoxTipoTel.Size = new Size(403, 65);
            groupBoxTipoTel.TabIndex = 7;
            groupBoxTipoTel.TabStop = false;
            groupBoxTipoTel.Text = "Tipo telefone";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(282, 28);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Recado";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(149, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Comercial";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pessoal";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Location = new Point(42, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 2);
            panel2.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(43, 323);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(560, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 296);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Email:";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(590, 396);
            button1.Name = "button1";
            button1.Size = new Size(87, 42);
            button1.TabIndex = 10;
            button1.Text = "Voltar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(701, 396);
            button2.Name = "button2";
            button2.Size = new Size(87, 42);
            button2.TabIndex = 11;
            button2.Text = "Salvar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(groupBoxTipoTel);
            Controls.Add(textBoxTelefone);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBoxSobreNome);
            Controls.Add(labelSobrenome);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "Form2";
            Text = "Form2";
            groupBoxTipoTel.ResumeLayout(false);
            groupBoxTipoTel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxSobreNome;
        private Label labelSobrenome;
        private Panel panel1;
        private TextBox textBoxTelefone;
        private Label label1;
        private GroupBox groupBoxTipoTel;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel2;
        private TextBox textBoxEmail;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}