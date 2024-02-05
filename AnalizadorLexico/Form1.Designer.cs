namespace AnalizadorLexico
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
            rtbConsole = new RichTextBox();
            rtbDebug = new RichTextBox();
            button1 = new Button();
            btnGuardar = new Button();
            dgvSimbolos = new DataGridView();
            dataGridView2 = new DataGridView();
            btnSave = new Button();
            btnLoad = new Button();
            btnCargar = new Button();
            cargarCodigo = new Button();
            guardarCodigo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSimbolos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // rtbConsole
            // 
            rtbConsole.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbConsole.Location = new Point(14, 16);
            rtbConsole.Margin = new Padding(3, 4, 3, 4);
            rtbConsole.Name = "rtbConsole";
            rtbConsole.Size = new Size(550, 320);
            rtbConsole.TabIndex = 0;
            rtbConsole.Text = "";
            // 
            // rtbDebug
            // 
            rtbDebug.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            rtbDebug.Location = new Point(569, 16);
            rtbDebug.Margin = new Padding(3, 4, 3, 4);
            rtbDebug.Name = "rtbDebug";
            rtbDebug.Size = new Size(550, 320);
            rtbDebug.TabIndex = 1;
            rtbDebug.Text = "";
            rtbDebug.TextChanged += rtbDebug_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(14, 344);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 42);
            button1.TabIndex = 2;
            button1.Text = "Debug";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(861, 342);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 43);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar tokens";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvSimbolos
            // 
            dgvSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSimbolos.Location = new Point(14, 393);
            dgvSimbolos.Name = "dgvSimbolos";
            dgvSimbolos.RowHeadersWidth = 51;
            dgvSimbolos.Size = new Size(548, 213);
            dgvSimbolos.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(568, 393);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(548, 213);
            dataGridView2.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(301, 612);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 43);
            btnSave.TabIndex = 7;
            btnSave.Text = "Guardar Lexema";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(434, 612);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(126, 43);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Cargar Lexema";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(993, 343);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(126, 43);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "Cargar tokens";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // cargarCodigo
            // 
            cargarCodigo.Location = new Point(238, 345);
            cargarCodigo.Margin = new Padding(3, 4, 3, 4);
            cargarCodigo.Name = "cargarCodigo";
            cargarCodigo.Size = new Size(126, 43);
            cargarCodigo.TabIndex = 11;
            cargarCodigo.Text = "Cargar";
            cargarCodigo.UseVisualStyleBackColor = true;
            cargarCodigo.Click += cargarCodigo_Click;
            // 
            // guardarCodigo
            // 
            guardarCodigo.Location = new Point(106, 344);
            guardarCodigo.Margin = new Padding(3, 4, 3, 4);
            guardarCodigo.Name = "guardarCodigo";
            guardarCodigo.Size = new Size(126, 43);
            guardarCodigo.TabIndex = 10;
            guardarCodigo.Text = "Guardar";
            guardarCodigo.UseVisualStyleBackColor = true;
            guardarCodigo.Click += guardarCodigo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 668);
            Controls.Add(cargarCodigo);
            Controls.Add(guardarCodigo);
            Controls.Add(btnCargar);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(dataGridView2);
            Controls.Add(dgvSimbolos);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(rtbDebug);
            Controls.Add(rtbConsole);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSimbolos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbConsole;
        private RichTextBox rtbDebug;
        private Button button1;
        private Button btnGuardar;
        private DataGridView dgvSimbolos;
        private DataGridView dataGridView2;
        private Button btnSave;
        private Button btnLoad;
        private Button btnCargar;
        private Button cargarCodigo;
        private Button guardarCodigo;
    }
}
