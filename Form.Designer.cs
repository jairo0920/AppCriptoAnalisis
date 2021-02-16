namespace AppCriptoAnalisis
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.txt_Frase = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Descodifica = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Idioma = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_idiomaBuscar = new System.Windows.Forms.TextBox();
            this.DGV_text02 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CantidadLetrasTotal = new System.Windows.Forms.TextBox();
            this.txt_idioma = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_sumaAleman = new System.Windows.Forms.TextBox();
            this.txt_sumaFrances = new System.Windows.Forms.TextBox();
            this.txt_sumaEspanol = new System.Windows.Forms.TextBox();
            this.txt_sumaIngles = new System.Windows.Forms.TextBox();
            this.DGV_Aleman = new System.Windows.Forms.DataGridView();
            this.DGV_Frances = new System.Windows.Forms.DataGridView();
            this.DGV_Espanol = new System.Windows.Forms.DataGridView();
            this.DGV_Ingles = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Aleman = new System.Windows.Forms.TextBox();
            this.txt_Frances = new System.Windows.Forms.TextBox();
            this.txt_Espanol = new System.Windows.Forms.TextBox();
            this.txt_Ingles = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV_TrigramaEspanol = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.DGV_BigramaHipotesis = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Frecuencia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGV_BigramaEspanol = new System.Windows.Forms.DataGridView();
            this.DGV_FrecuenciaAux = new System.Windows.Forms.DataGridView();
            this.DGV_text = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_text02)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Aleman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Frances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Espanol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ingles)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TrigramaEspanol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BigramaHipotesis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BigramaEspanol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FrecuenciaAux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_text)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Frase
            // 
            this.txt_Frase.Location = new System.Drawing.Point(125, 16);
            this.txt_Frase.Multiline = true;
            this.txt_Frase.Name = "txt_Frase";
            this.txt_Frase.Size = new System.Drawing.Size(526, 166);
            this.txt_Frase.TabIndex = 0;
            this.txt_Frase.Text = resources.GetString("txt_Frase.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Descodifica);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.btn_Idioma);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criptoanalisis de frase";
            // 
            // btn_Descodifica
            // 
            this.btn_Descodifica.Location = new System.Drawing.Point(879, 19);
            this.btn_Descodifica.Name = "btn_Descodifica";
            this.btn_Descodifica.Size = new System.Drawing.Size(75, 41);
            this.btn_Descodifica.TabIndex = 11;
            this.btn_Descodifica.Text = "Descodifica Idioma";
            this.btn_Descodifica.UseVisualStyleBackColor = true;
            this.btn_Descodifica.Click += new System.EventHandler(this.btn_Descodifica_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(717, 18);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 41);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Iniciar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_BuscarIdioma_Click);
            // 
            // btn_Idioma
            // 
            this.btn_Idioma.Location = new System.Drawing.Point(798, 18);
            this.btn_Idioma.Name = "btn_Idioma";
            this.btn_Idioma.Size = new System.Drawing.Size(75, 41);
            this.btn_Idioma.TabIndex = 9;
            this.btn_Idioma.Text = "Buscar Idioma";
            this.btn_Idioma.UseVisualStyleBackColor = true;
            this.btn_Idioma.Click += new System.EventHandler(this.btn_Idioma_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 434);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txt_idiomaBuscar);
            this.tabPage1.Controls.Add(this.DGV_text02);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_CantidadLetrasTotal);
            this.tabPage1.Controls.Add(this.txt_Frase);
            this.tabPage1.Controls.Add(this.txt_idioma);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Frase a descifrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 166);
            this.textBox1.TabIndex = 11;
            // 
            // txt_idiomaBuscar
            // 
            this.txt_idiomaBuscar.Location = new System.Drawing.Point(692, 368);
            this.txt_idiomaBuscar.Name = "txt_idiomaBuscar";
            this.txt_idiomaBuscar.ReadOnly = true;
            this.txt_idiomaBuscar.Size = new System.Drawing.Size(100, 20);
            this.txt_idiomaBuscar.TabIndex = 10;
            this.txt_idiomaBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV_text02
            // 
            this.DGV_text02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_text02.Location = new System.Drawing.Point(657, 16);
            this.DGV_text02.Name = "DGV_text02";
            this.DGV_text02.ReadOnly = true;
            this.DGV_text02.Size = new System.Drawing.Size(174, 346);
            this.DGV_text02.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad Letras Total";
            // 
            // txt_CantidadLetrasTotal
            // 
            this.txt_CantidadLetrasTotal.Location = new System.Drawing.Point(551, 188);
            this.txt_CantidadLetrasTotal.Name = "txt_CantidadLetrasTotal";
            this.txt_CantidadLetrasTotal.ReadOnly = true;
            this.txt_CantidadLetrasTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_CantidadLetrasTotal.TabIndex = 5;
            this.txt_CantidadLetrasTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_idioma
            // 
            this.txt_idioma.Location = new System.Drawing.Point(593, 37);
            this.txt_idioma.Multiline = true;
            this.txt_idioma.Name = "txt_idioma";
            this.txt_idioma.ReadOnly = true;
            this.txt_idioma.Size = new System.Drawing.Size(67, 30);
            this.txt_idioma.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_sumaAleman);
            this.tabPage2.Controls.Add(this.txt_sumaFrances);
            this.tabPage2.Controls.Add(this.txt_sumaEspanol);
            this.tabPage2.Controls.Add(this.txt_sumaIngles);
            this.tabPage2.Controls.Add(this.DGV_Aleman);
            this.tabPage2.Controls.Add(this.DGV_Frances);
            this.tabPage2.Controls.Add(this.DGV_Espanol);
            this.tabPage2.Controls.Add(this.DGV_Ingles);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_Aleman);
            this.tabPage2.Controls.Add(this.txt_Frances);
            this.tabPage2.Controls.Add(this.txt_Espanol);
            this.tabPage2.Controls.Add(this.txt_Ingles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Frecuencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_sumaAleman
            // 
            this.txt_sumaAleman.Location = new System.Drawing.Point(644, 375);
            this.txt_sumaAleman.Name = "txt_sumaAleman";
            this.txt_sumaAleman.Size = new System.Drawing.Size(174, 20);
            this.txt_sumaAleman.TabIndex = 17;
            this.txt_sumaAleman.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_sumaFrances
            // 
            this.txt_sumaFrances.Location = new System.Drawing.Point(464, 375);
            this.txt_sumaFrances.Name = "txt_sumaFrances";
            this.txt_sumaFrances.Size = new System.Drawing.Size(174, 20);
            this.txt_sumaFrances.TabIndex = 16;
            this.txt_sumaFrances.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_sumaEspanol
            // 
            this.txt_sumaEspanol.Location = new System.Drawing.Point(284, 375);
            this.txt_sumaEspanol.Name = "txt_sumaEspanol";
            this.txt_sumaEspanol.Size = new System.Drawing.Size(174, 20);
            this.txt_sumaEspanol.TabIndex = 15;
            this.txt_sumaEspanol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_sumaIngles
            // 
            this.txt_sumaIngles.Location = new System.Drawing.Point(104, 375);
            this.txt_sumaIngles.Name = "txt_sumaIngles";
            this.txt_sumaIngles.Size = new System.Drawing.Size(174, 20);
            this.txt_sumaIngles.TabIndex = 14;
            this.txt_sumaIngles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DGV_Aleman
            // 
            this.DGV_Aleman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Aleman.Location = new System.Drawing.Point(644, 25);
            this.DGV_Aleman.Name = "DGV_Aleman";
            this.DGV_Aleman.ReadOnly = true;
            this.DGV_Aleman.Size = new System.Drawing.Size(174, 346);
            this.DGV_Aleman.TabIndex = 13;
            // 
            // DGV_Frances
            // 
            this.DGV_Frances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Frances.Location = new System.Drawing.Point(464, 25);
            this.DGV_Frances.Name = "DGV_Frances";
            this.DGV_Frances.ReadOnly = true;
            this.DGV_Frances.Size = new System.Drawing.Size(174, 346);
            this.DGV_Frances.TabIndex = 12;
            // 
            // DGV_Espanol
            // 
            this.DGV_Espanol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Espanol.Location = new System.Drawing.Point(284, 25);
            this.DGV_Espanol.Name = "DGV_Espanol";
            this.DGV_Espanol.ReadOnly = true;
            this.DGV_Espanol.Size = new System.Drawing.Size(174, 346);
            this.DGV_Espanol.TabIndex = 11;
            // 
            // DGV_Ingles
            // 
            this.DGV_Ingles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ingles.Location = new System.Drawing.Point(104, 25);
            this.DGV_Ingles.Name = "DGV_Ingles";
            this.DGV_Ingles.ReadOnly = true;
            this.DGV_Ingles.Size = new System.Drawing.Size(174, 346);
            this.DGV_Ingles.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aleman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Frances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Espanol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingles";
            // 
            // txt_Aleman
            // 
            this.txt_Aleman.Location = new System.Drawing.Point(678, 25);
            this.txt_Aleman.Multiline = true;
            this.txt_Aleman.Name = "txt_Aleman";
            this.txt_Aleman.ReadOnly = true;
            this.txt_Aleman.Size = new System.Drawing.Size(100, 344);
            this.txt_Aleman.TabIndex = 6;
            // 
            // txt_Frances
            // 
            this.txt_Frances.Location = new System.Drawing.Point(498, 25);
            this.txt_Frances.Multiline = true;
            this.txt_Frances.Name = "txt_Frances";
            this.txt_Frances.ReadOnly = true;
            this.txt_Frances.Size = new System.Drawing.Size(100, 344);
            this.txt_Frances.TabIndex = 5;
            // 
            // txt_Espanol
            // 
            this.txt_Espanol.Location = new System.Drawing.Point(313, 25);
            this.txt_Espanol.Multiline = true;
            this.txt_Espanol.Name = "txt_Espanol";
            this.txt_Espanol.ReadOnly = true;
            this.txt_Espanol.Size = new System.Drawing.Size(100, 344);
            this.txt_Espanol.TabIndex = 4;
            // 
            // txt_Ingles
            // 
            this.txt_Ingles.Location = new System.Drawing.Point(133, 25);
            this.txt_Ingles.Multiline = true;
            this.txt_Ingles.Name = "txt_Ingles";
            this.txt_Ingles.ReadOnly = true;
            this.txt_Ingles.Size = new System.Drawing.Size(100, 344);
            this.txt_Ingles.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.DGV_TrigramaEspanol);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.DGV_BigramaHipotesis);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label_Frecuencia);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.DGV_BigramaEspanol);
            this.tabPage3.Controls.Add(this.DGV_FrecuenciaAux);
            this.tabPage3.Controls.Add(this.DGV_text);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(944, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Descodifica Texto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(787, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Trigramas Texto";
            // 
            // DGV_TrigramaEspanol
            // 
            this.DGV_TrigramaEspanol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TrigramaEspanol.Location = new System.Drawing.Point(744, 35);
            this.DGV_TrigramaEspanol.Name = "DGV_TrigramaEspanol";
            this.DGV_TrigramaEspanol.ReadOnly = true;
            this.DGV_TrigramaEspanol.Size = new System.Drawing.Size(174, 326);
            this.DGV_TrigramaEspanol.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hipotesis";
            // 
            // DGV_BigramaHipotesis
            // 
            this.DGV_BigramaHipotesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BigramaHipotesis.Location = new System.Drawing.Point(419, 35);
            this.DGV_BigramaHipotesis.Name = "DGV_BigramaHipotesis";
            this.DGV_BigramaHipotesis.ReadOnly = true;
            this.DGV_BigramaHipotesis.Size = new System.Drawing.Size(139, 326);
            this.DGV_BigramaHipotesis.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bigramas Texto";
            // 
            // label_Frecuencia
            // 
            this.label_Frecuencia.AutoSize = true;
            this.label_Frecuencia.Location = new System.Drawing.Point(230, 14);
            this.label_Frecuencia.Name = "label_Frecuencia";
            this.label_Frecuencia.Size = new System.Drawing.Size(60, 13);
            this.label_Frecuencia.TabIndex = 12;
            this.label_Frecuencia.Text = "Frecuencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Texto";
            // 
            // DGV_BigramaEspanol
            // 
            this.DGV_BigramaEspanol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BigramaEspanol.Location = new System.Drawing.Point(564, 35);
            this.DGV_BigramaEspanol.Name = "DGV_BigramaEspanol";
            this.DGV_BigramaEspanol.ReadOnly = true;
            this.DGV_BigramaEspanol.Size = new System.Drawing.Size(174, 326);
            this.DGV_BigramaEspanol.TabIndex = 9;
            // 
            // DGV_FrecuenciaAux
            // 
            this.DGV_FrecuenciaAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_FrecuenciaAux.Location = new System.Drawing.Point(204, 35);
            this.DGV_FrecuenciaAux.Name = "DGV_FrecuenciaAux";
            this.DGV_FrecuenciaAux.ReadOnly = true;
            this.DGV_FrecuenciaAux.Size = new System.Drawing.Size(174, 326);
            this.DGV_FrecuenciaAux.TabIndex = 8;
            this.DGV_FrecuenciaAux.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_FrecuenciaAux_CellClick);
            // 
            // DGV_text
            // 
            this.DGV_text.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_text.Location = new System.Drawing.Point(24, 35);
            this.DGV_text.Name = "DGV_text";
            this.DGV_text.ReadOnly = true;
            this.DGV_text.Size = new System.Drawing.Size(174, 326);
            this.DGV_text.TabIndex = 7;
            this.DGV_text.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_text_CellClick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSEG-02 Principios de criptografía - Primera Asignación";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_text02)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Aleman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Frances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Espanol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ingles)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TrigramaEspanol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BigramaHipotesis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BigramaEspanol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FrecuenciaAux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_text)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Frase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Ingles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Aleman;
        private System.Windows.Forms.TextBox txt_Frances;
        private System.Windows.Forms.TextBox txt_Espanol;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_idioma;
        private System.Windows.Forms.TextBox txt_CantidadLetrasTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_text;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGV_BigramaEspanol;
        private System.Windows.Forms.DataGridView DGV_FrecuenciaAux;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Frecuencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGV_text02;
        private System.Windows.Forms.Button btn_Idioma;
        private System.Windows.Forms.DataGridView DGV_Aleman;
        private System.Windows.Forms.DataGridView DGV_Frances;
        private System.Windows.Forms.DataGridView DGV_Espanol;
        private System.Windows.Forms.DataGridView DGV_Ingles;
        private System.Windows.Forms.TextBox txt_sumaIngles;
        private System.Windows.Forms.TextBox txt_sumaAleman;
        private System.Windows.Forms.TextBox txt_sumaFrances;
        private System.Windows.Forms.TextBox txt_sumaEspanol;
        private System.Windows.Forms.TextBox txt_idiomaBuscar;
        private System.Windows.Forms.Button btn_Descodifica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGV_BigramaHipotesis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_TrigramaEspanol;
    }
}

