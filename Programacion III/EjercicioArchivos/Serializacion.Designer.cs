namespace EjercicioArchivos
{
    partial class Serializacion
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            botonSerializar = new Button();
            boronDeserializacion = new Button();
            texto = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(texto, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.8888855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1111107F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(boronDeserializacion, 1, 0);
            tableLayoutPanel2.Controls.Add(botonSerializar, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 394);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 53);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // botonSerializar
            // 
            botonSerializar.BackColor = Color.DodgerBlue;
            botonSerializar.Dock = DockStyle.Fill;
            botonSerializar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            botonSerializar.FlatAppearance.BorderSize = 3;
            botonSerializar.Location = new Point(100, 5);
            botonSerializar.Margin = new Padding(100, 5, 100, 5);
            botonSerializar.Name = "botonSerializar";
            botonSerializar.Size = new Size(197, 43);
            botonSerializar.TabIndex = 0;
            botonSerializar.Text = "Serializar";
            botonSerializar.UseVisualStyleBackColor = false;
            botonSerializar.Click += botonSerializar_Click;
            // 
            // boronDeserializacion
            // 
            boronDeserializacion.BackColor = Color.DodgerBlue;
            boronDeserializacion.Dock = DockStyle.Fill;
            boronDeserializacion.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            boronDeserializacion.FlatAppearance.BorderSize = 3;
            boronDeserializacion.Location = new Point(497, 5);
            boronDeserializacion.Margin = new Padding(100, 5, 100, 5);
            boronDeserializacion.Name = "boronDeserializacion";
            boronDeserializacion.Size = new Size(197, 43);
            boronDeserializacion.TabIndex = 1;
            boronDeserializacion.Text = "Deserializar";
            boronDeserializacion.UseVisualStyleBackColor = false;
            boronDeserializacion.Click += boronDeserializacion_Click;
            // 
            // texto
            // 
            texto.BackColor = Color.OldLace;
            texto.Dock = DockStyle.Fill;
            texto.Location = new Point(20, 20);
            texto.Margin = new Padding(20);
            texto.Name = "texto";
            texto.Size = new Size(760, 351);
            texto.TabIndex = 1;
            texto.Text = "";
            // 
            // Serializacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Serializacion";
            Text = "Serializacion";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button boronDeserializacion;
        private Button botonSerializar;
        private RichTextBox texto;
    }
}