namespace productodb
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
            lbldescripcion = new Label();
            lblprecio = new Label();
            tbdescripcion = new TextBox();
            tbprecio = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Location = new Point(73, 140);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(128, 15);
            lbldescripcion.TabIndex = 0;
            lbldescripcion.Text = "Descripcion de articulo";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(110, 188);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(40, 15);
            lblprecio.TabIndex = 1;
            lblprecio.Text = "Precio";
            lblprecio.Click += label2_Click;
            // 
            // tbdescripcion
            // 
            tbdescripcion.Location = new Point(207, 137);
            tbdescripcion.Name = "tbdescripcion";
            tbdescripcion.Size = new Size(100, 23);
            tbdescripcion.TabIndex = 2;
            // 
            // tbprecio
            // 
            tbprecio.Location = new Point(207, 180);
            tbprecio.Name = "tbprecio";
            tbprecio.Size = new Size(100, 23);
            tbprecio.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(223, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbprecio);
            Controls.Add(tbdescripcion);
            Controls.Add(lblprecio);
            Controls.Add(lbldescripcion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldescripcion;
        private Label lblprecio;
        private TextBox tbdescripcion;
        private TextBox tbprecio;
        private Button button1;
    }
}
