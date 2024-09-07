namespace C1_040924_Parte_2
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
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button2 = new Button();
            button3 = new Button();
            openFileBuscar = new OpenFileDialog();
            label1 = new Label();
            button4 = new Button();
            openFileModificar = new OpenFileDialog();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 33);
            button1.Name = "button1";
            button1.Size = new Size(267, 56);
            button1.TabIndex = 0;
            button1.Text = "Seleccionar directorio de destino";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(37, 107);
            button2.Name = "button2";
            button2.Size = new Size(267, 69);
            button2.TabIndex = 1;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(37, 208);
            button3.Name = "button3";
            button3.Size = new Size(267, 69);
            button3.TabIndex = 2;
            button3.Text = "Buscar Archivo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileBuscar
            // 
            openFileBuscar.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 232);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Resultado";
            // 
            // button4
            // 
            button4.Location = new Point(47, 349);
            button4.Name = "button4";
            button4.Size = new Size(267, 69);
            button4.TabIndex = 4;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileModificar
            // 
            openFileModificar.FileName = "openFileDialog2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileBuscar;
        private Label label1;
        private Button button4;
        private OpenFileDialog openFileModificar;
        private TextBox textBox1;
    }
}
