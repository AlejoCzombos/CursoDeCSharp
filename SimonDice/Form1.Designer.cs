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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Azul, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Amarillo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Verde, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rojo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 89);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Azul
            // 
            this.Azul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Azul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Azul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Azul.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Azul.FlatAppearance.BorderSize = 20;
            this.Azul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Azul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Azul.Location = new System.Drawing.Point(296, 246);
            this.Azul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Azul.Name = "Azul";
            this.Azul.Size = new System.Drawing.Size(287, 240);
            this.Azul.TabIndex = 3;
            this.Azul.UseVisualStyleBackColor = false;
            this.Azul.Click += new System.EventHandler(this.OnClickAzul);
            this.Azul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickAzul);
            this.Azul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickAzul);
            // 
            // Amarillo
            // 
            this.Amarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Amarillo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Amarillo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amarillo.Location = new System.Drawing.Point(3, 246);
            this.Amarillo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Amarillo.Name = "Amarillo";
            this.Amarillo.Size = new System.Drawing.Size(287, 240);
            this.Amarillo.TabIndex = 2;
            this.Amarillo.UseVisualStyleBackColor = false;
            this.Amarillo.Click += new System.EventHandler(this.OnClickAmarillo);
            this.Amarillo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickAmarillo);
            this.Amarillo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickAmarillo);
            // 
            // Verde
            // 
            this.Verde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Verde.BackColor = System.Drawing.Color.Green;
            this.Verde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Verde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Verde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Verde.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Verde.FlatAppearance.BorderSize = 3;
            this.Verde.Location = new System.Drawing.Point(3, 2);
            this.Verde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Verde.Name = "Verde";
            this.Verde.Size = new System.Drawing.Size(287, 240);
            this.Verde.TabIndex = 1;
            this.Verde.UseVisualStyleBackColor = false;
            this.Verde.Click += new System.EventHandler(this.OnClickVerde);
            this.Verde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickVerde);
            this.Verde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickVerde);
            // 
            // Rojo
            // 
            this.Rojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rojo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rojo.Location = new System.Drawing.Point(296, 2);
            this.Rojo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rojo.Name = "Rojo";
            this.Rojo.Size = new System.Drawing.Size(287, 240);
            this.Rojo.TabIndex = 0;
            this.Rojo.UseVisualStyleBackColor = false;
            this.Rojo.Click += new System.EventHandler(this.OnClickRojo);
            this.Rojo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDownClickRojo);
            this.Rojo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUpClickRojo);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Pokemon Classic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.ClientSize = new System.Drawing.Size(726, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon Dice";
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