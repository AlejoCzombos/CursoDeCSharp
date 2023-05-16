namespace SimonDice
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Azul = new System.Windows.Forms.Button();
            this.Amarillo = new System.Windows.Forms.Button();
            this.Verde = new System.Windows.Forms.Button();
            this.Rojo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Azul, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Amarillo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Verde, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rojo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 92);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(585, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Azul
            // 
            this.Azul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Azul.Location = new System.Drawing.Point(295, 186);
            this.Azul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Azul.Name = "Azul";
            this.Azul.Size = new System.Drawing.Size(287, 179);
            this.Azul.TabIndex = 3;
            this.Azul.Text = "button4";
            this.Azul.UseVisualStyleBackColor = false;
            this.Azul.Click += new System.EventHandler(this.OnClickAzul);
            this.Azul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickAzul);
            this.Azul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickAzul);
            // 
            // Amarillo
            // 
            this.Amarillo.BackColor = System.Drawing.Color.Yellow;
            this.Amarillo.Location = new System.Drawing.Point(3, 186);
            this.Amarillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Amarillo.Name = "Amarillo";
            this.Amarillo.Size = new System.Drawing.Size(286, 179);
            this.Amarillo.TabIndex = 2;
            this.Amarillo.Text = "button3";
            this.Amarillo.UseVisualStyleBackColor = false;
            this.Amarillo.Click += new System.EventHandler(this.OnClickAmarillo);
            this.Amarillo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickAmarillo);
            this.Amarillo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickAmarillo);
            // 
            // Verde
            // 
            this.Verde.BackColor = System.Drawing.Color.Green;
            this.Verde.Location = new System.Drawing.Point(3, 2);
            this.Verde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Verde.Name = "Verde";
            this.Verde.Size = new System.Drawing.Size(286, 179);
            this.Verde.TabIndex = 1;
            this.Verde.Text = "button2";
            this.Verde.UseVisualStyleBackColor = false;
            this.Verde.Click += new System.EventHandler(this.OnClickVerde);
            this.Verde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickVerde);
            this.Verde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickVerde);
            // 
            // Rojo
            // 
            this.Rojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rojo.Location = new System.Drawing.Point(295, 2);
            this.Rojo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rojo.Name = "Rojo";
            this.Rojo.Size = new System.Drawing.Size(286, 179);
            this.Rojo.TabIndex = 0;
            this.Rojo.Text = "button1";
            this.Rojo.UseVisualStyleBackColor = false;
            this.Rojo.Click += new System.EventHandler(this.OnClickRojo);
            this.Rojo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickRojo);
            this.Rojo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickRojo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Azul;
        private Button Amarillo;
        private Button Verde;
        private Button Rojo;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}