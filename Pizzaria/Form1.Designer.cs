namespace Pizzaria
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
            lblSabores = new Label();
            cboSabores = new ComboBox();
            grpIngredientes = new GroupBox();
            chkAzeitona = new CheckBox();
            chkCebola = new CheckBox();
            grpBorda = new GroupBox();
            rdbComBorda = new RadioButton();
            rdbSemBorda = new RadioButton();
            btnImprimir = new Button();
            btnLimpar = new Button();
            lstHistorico = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            grpIngredientes.SuspendLayout();
            grpBorda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSabores
            // 
            lblSabores.AutoSize = true;
            lblSabores.Location = new Point(21, 28);
            lblSabores.Name = "lblSabores";
            lblSabores.Size = new Size(48, 15);
            lblSabores.TabIndex = 0;
            lblSabores.Text = "Sabores";
            // 
            // cboSabores
            // 
            cboSabores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSabores.FormattingEnabled = true;
            cboSabores.Location = new Point(74, 25);
            cboSabores.Name = "cboSabores";
            cboSabores.Size = new Size(162, 23);
            cboSabores.TabIndex = 1;
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(chkAzeitona);
            grpIngredientes.Controls.Add(chkCebola);
            grpIngredientes.Location = new Point(12, 78);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(200, 100);
            grpIngredientes.TabIndex = 2;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Ingredientes Adicionais";
            // 
            // chkAzeitona
            // 
            chkAzeitona.AutoSize = true;
            chkAzeitona.Location = new Point(8, 50);
            chkAzeitona.Name = "chkAzeitona";
            chkAzeitona.Size = new Size(72, 19);
            chkAzeitona.TabIndex = 1;
            chkAzeitona.Text = "Azeitona";
            chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            chkCebola.AutoSize = true;
            chkCebola.Location = new Point(8, 29);
            chkCebola.Name = "chkCebola";
            chkCebola.Size = new Size(63, 19);
            chkCebola.TabIndex = 0;
            chkCebola.Text = "Cebola";
            chkCebola.UseVisualStyleBackColor = true;
            // 
            // grpBorda
            // 
            grpBorda.Controls.Add(rdbComBorda);
            grpBorda.Controls.Add(rdbSemBorda);
            grpBorda.Location = new Point(218, 78);
            grpBorda.Name = "grpBorda";
            grpBorda.Size = new Size(200, 100);
            grpBorda.TabIndex = 3;
            grpBorda.TabStop = false;
            grpBorda.Text = "Borda";
            // 
            // rdbComBorda
            // 
            rdbComBorda.AutoSize = true;
            rdbComBorda.Location = new Point(7, 49);
            rdbComBorda.Name = "rdbComBorda";
            rdbComBorda.Size = new Size(85, 19);
            rdbComBorda.TabIndex = 1;
            rdbComBorda.Text = "Com Borda";
            rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // rdbSemBorda
            // 
            rdbSemBorda.AutoSize = true;
            rdbSemBorda.Checked = true;
            rdbSemBorda.Location = new Point(7, 29);
            rdbSemBorda.Name = "rdbSemBorda";
            rdbSemBorda.Size = new Size(82, 19);
            rdbSemBorda.TabIndex = 0;
            rdbSemBorda.TabStop = true;
            rdbSemBorda.Text = "Sem Borda";
            rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(12, 195);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(120, 23);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir Pedido";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(138, 195);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar Pedido";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstHistorico
            // 
            lstHistorico.FormattingEnabled = true;
            lstHistorico.ItemHeight = 15;
            lstHistorico.Location = new Point(12, 258);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(642, 199);
            lstHistorico.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 7;
            label1.Text = "Histórico de Pedidos Realizados";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(424, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 225);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 469);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lstHistorico);
            Controls.Add(btnLimpar);
            Controls.Add(btnImprimir);
            Controls.Add(grpBorda);
            Controls.Add(grpIngredientes);
            Controls.Add(cboSabores);
            Controls.Add(lblSabores);
            Name = "Form1";
            Text = "Pizzaria";
            Load += Form1_Load;
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            grpBorda.ResumeLayout(false);
            grpBorda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSabores;
        private ComboBox cboSabores;
        private GroupBox grpIngredientes;
        private CheckBox chkAzeitona;
        private CheckBox chkCebola;
        private GroupBox grpBorda;
        private RadioButton rdbComBorda;
        private RadioButton rdbSemBorda;
        private Button btnImprimir;
        private Button btnLimpar;
        private ListBox lstHistorico;
        private Label label1;
        private PictureBox pictureBox1;
    }
}