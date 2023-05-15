namespace Typing_Fast
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelFrase = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelFrase
            // 
            this.labelFrase.AutoSize = true;
            this.labelFrase.Font = new System.Drawing.Font("Pokemon Classic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrase.Location = new System.Drawing.Point(415, 206);
            this.labelFrase.Name = "labelFrase";
            this.labelFrase.Size = new System.Drawing.Size(0, 30);
            this.labelFrase.TabIndex = 2;
            // 
            // textBoxInput
            // 
            this.textBoxInput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxInput.BackColor = System.Drawing.Color.White;
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Pokemon Classic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(20, 309);
            this.textBoxInput.Multiline = false;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBoxInput.Size = new System.Drawing.Size(897, 182);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.Text = "";
            this.textBoxInput.TextChanged += new System.EventHandler(this.inputCheck);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCheck);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Pokemon Classic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.ForeColor = System.Drawing.Color.Lime;
            this.labelTiempo.Location = new System.Drawing.Point(458, 52);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(0, 56);
            this.labelTiempo.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(929, 540);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelFrase);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelFrase;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.Label labelTiempo;
    }
}

