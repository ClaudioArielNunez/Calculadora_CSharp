namespace Calculadora2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSigno = new System.Windows.Forms.Button();
            this.bCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnBorrarUltimo = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrarEntrada = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtVisualizador = new System.Windows.Forms.TextBox();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSigno
            // 
            this.btnSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigno.Location = new System.Drawing.Point(40, 555);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(95, 70);
            this.btnSigno.TabIndex = 0;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // bCero
            // 
            this.bCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCero.Location = new System.Drawing.Point(154, 555);
            this.bCero.Name = "bCero";
            this.bCero.Size = new System.Drawing.Size(95, 70);
            this.bCero.TabIndex = 1;
            this.bCero.Text = "0";
            this.bCero.UseVisualStyleBackColor = true;
            this.bCero.Click += new System.EventHandler(this.bCero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(259, 555);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(95, 70);
            this.btnPunto.TabIndex = 2;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResultado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResultado.Location = new System.Drawing.Point(367, 482);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(95, 143);
            this.btnResultado.TabIndex = 0;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(367, 409);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(95, 70);
            this.btnSuma.TabIndex = 7;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(259, 482);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(95, 70);
            this.btnTres.TabIndex = 6;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(154, 482);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(95, 70);
            this.btnDos.TabIndex = 5;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(40, 482);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(95, 70);
            this.btnUno.TabIndex = 4;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(367, 338);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(95, 70);
            this.btnResta.TabIndex = 11;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(259, 409);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(95, 70);
            this.btnSeis.TabIndex = 10;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(154, 409);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(95, 70);
            this.btnCinco.TabIndex = 9;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(40, 409);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(95, 70);
            this.btnCuatro.TabIndex = 8;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(367, 266);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(95, 70);
            this.btnMulti.TabIndex = 15;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(259, 336);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(95, 70);
            this.btnNueve.TabIndex = 14;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(154, 336);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(95, 70);
            this.btnOcho.TabIndex = 13;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(40, 336);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(95, 70);
            this.btnSiete.TabIndex = 12;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivi.Location = new System.Drawing.Point(367, 190);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(95, 70);
            this.btnDivi.TabIndex = 19;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // btnBorrarUltimo
            // 
            this.btnBorrarUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUltimo.Location = new System.Drawing.Point(259, 190);
            this.btnBorrarUltimo.Name = "btnBorrarUltimo";
            this.btnBorrarUltimo.Size = new System.Drawing.Size(95, 70);
            this.btnBorrarUltimo.TabIndex = 18;
            this.btnBorrarUltimo.Text = "«";
            this.btnBorrarUltimo.UseVisualStyleBackColor = true;
            this.btnBorrarUltimo.Click += new System.EventHandler(this.btnBorrarUltimo_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(154, 190);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(95, 70);
            this.btnBorrarTodo.TabIndex = 17;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrarEntrada
            // 
            this.btnBorrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEntrada.Location = new System.Drawing.Point(40, 190);
            this.btnBorrarEntrada.Name = "btnBorrarEntrada";
            this.btnBorrarEntrada.Size = new System.Drawing.Size(95, 70);
            this.btnBorrarEntrada.TabIndex = 16;
            this.btnBorrarEntrada.Text = "CE";
            this.btnBorrarEntrada.UseVisualStyleBackColor = true;
            this.btnBorrarEntrada.Click += new System.EventHandler(this.btnBorrarEntrada_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 80);
            this.txtDisplay.MaxLength = 10;
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(469, 94);
            this.txtDisplay.TabIndex = 20;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVisualizador
            // 
            this.txtVisualizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisualizador.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVisualizador.Location = new System.Drawing.Point(12, 16);
            this.txtVisualizador.MaxLength = 12;
            this.txtVisualizador.Name = "txtVisualizador";
            this.txtVisualizador.Size = new System.Drawing.Size(469, 41);
            this.txtVisualizador.TabIndex = 21;
            this.txtVisualizador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(154, 263);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(95, 70);
            this.btnRaiz.TabIndex = 22;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(259, 263);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(95, 70);
            this.btnPotencia.TabIndex = 23;
            this.btnPotencia.Text = "x²";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(40, 263);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(95, 70);
            this.btnPorcentaje.TabIndex = 24;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(493, 630);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.txtVisualizador);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnBorrarUltimo);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnBorrarEntrada);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.bCero);
            this.Controls.Add(this.btnSigno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 686);
            this.MinimumSize = new System.Drawing.Size(515, 686);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button bCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnBorrarUltimo;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrarEntrada;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtVisualizador;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnPorcentaje;
    }
}

