namespace CalculadoraWindows
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnSuma = new Button();
            btnResta = new Button();
            btnDivision = new Button();
            btnResultado = new Button();
            btnMulti = new Button();
            btnPunto = new Button();
            btnPorcentaje = new Button();
            btnRaiz = new Button();
            btnSeno = new Button();
            btnPi = new Button();
            button15 = new Button();
            btn10ALa = new Button();
            btnCoseno = new Button();
            button18 = new Button();
            button19 = new Button();
            btnEXP = new Button();
            btnTangente = new Button();
            button22 = new Button();
            button23 = new Button();
            btnLog = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(594, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(594, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(70, 166);
            button1.Name = "button1";
            button1.Size = new Size(70, 64);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(146, 166);
            button2.Name = "button2";
            button2.Size = new Size(70, 64);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(222, 166);
            button3.Name = "button3";
            button3.Size = new Size(70, 64);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(70, 236);
            button4.Name = "button4";
            button4.Size = new Size(70, 64);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(146, 236);
            button5.Name = "button5";
            button5.Size = new Size(70, 64);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(222, 236);
            button6.Name = "button6";
            button6.Size = new Size(70, 64);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(70, 306);
            button7.Name = "button7";
            button7.Size = new Size(70, 64);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(146, 306);
            button8.Name = "button8";
            button8.Size = new Size(70, 64);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(222, 306);
            button9.Name = "button9";
            button9.Size = new Size(70, 64);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(70, 376);
            button0.Name = "button0";
            button0.Size = new Size(146, 64);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(70, 96);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(298, 64);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(372, 96);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(292, 64);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "<---";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(298, 166);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(70, 64);
            btnSuma.TabIndex = 14;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(298, 236);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(70, 64);
            btnResta.TabIndex = 15;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(298, 306);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(70, 64);
            btnDivision.TabIndex = 16;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(372, 306);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(70, 134);
            btnResultado.TabIndex = 17;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(298, 376);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(70, 64);
            btnMulti.TabIndex = 18;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(222, 376);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(70, 64);
            btnPunto.TabIndex = 19;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.Location = new Point(374, 166);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(68, 64);
            btnPorcentaje.TabIndex = 20;
            btnPorcentaje.Text = "%";
            btnPorcentaje.UseVisualStyleBackColor = true;
            btnPorcentaje.Click += btnPorcentaje_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(374, 236);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(68, 64);
            btnRaiz.TabIndex = 21;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += button10_Click;
            // 
            // btnSeno
            // 
            btnSeno.Location = new Point(448, 166);
            btnSeno.Name = "btnSeno";
            btnSeno.Size = new Size(68, 64);
            btnSeno.TabIndex = 24;
            btnSeno.Text = "sin";
            btnSeno.UseVisualStyleBackColor = true;
            btnSeno.Click += btnSeno_Click;
            // 
            // btnPi
            // 
            btnPi.Location = new Point(448, 236);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(68, 64);
            btnPi.TabIndex = 25;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // button15
            // 
            button15.Location = new Point(448, 306);
            button15.Name = "button15";
            button15.Size = new Size(68, 64);
            button15.TabIndex = 26;
            button15.Text = "x^y";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // btn10ALa
            // 
            btn10ALa.Location = new Point(448, 376);
            btn10ALa.Name = "btn10ALa";
            btn10ALa.Size = new Size(68, 64);
            btn10ALa.TabIndex = 27;
            btn10ALa.Text = "10^x";
            btn10ALa.UseVisualStyleBackColor = true;
            btn10ALa.Click += btn10ALa_Click;
            // 
            // btnCoseno
            // 
            btnCoseno.Location = new Point(522, 166);
            btnCoseno.Name = "btnCoseno";
            btnCoseno.Size = new Size(68, 64);
            btnCoseno.TabIndex = 28;
            btnCoseno.Text = "cos";
            btnCoseno.UseVisualStyleBackColor = true;
            btnCoseno.Click += btnCoseno_Click;
            // 
            // button18
            // 
            button18.Location = new Point(522, 236);
            button18.Name = "button18";
            button18.Size = new Size(68, 64);
            button18.TabIndex = 29;
            button18.Text = "3√x";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Location = new Point(522, 306);
            button19.Name = "button19";
            button19.Size = new Size(68, 64);
            button19.TabIndex = 30;
            button19.Text = "x^2";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // btnEXP
            // 
            btnEXP.Location = new Point(522, 376);
            btnEXP.Name = "btnEXP";
            btnEXP.Size = new Size(68, 64);
            btnEXP.TabIndex = 31;
            btnEXP.Text = "EXP";
            btnEXP.UseVisualStyleBackColor = true;
            btnEXP.Click += btnEXP_Click;
            // 
            // btnTangente
            // 
            btnTangente.Location = new Point(596, 166);
            btnTangente.Name = "btnTangente";
            btnTangente.Size = new Size(68, 64);
            btnTangente.TabIndex = 32;
            btnTangente.Text = "tan";
            btnTangente.UseVisualStyleBackColor = true;
            btnTangente.Click += btnTangente_Click;
            // 
            // button22
            // 
            button22.Location = new Point(596, 236);
            button22.Name = "button22";
            button22.Size = new Size(68, 64);
            button22.TabIndex = 33;
            button22.Text = "y√x";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.Location = new Point(596, 306);
            button23.Name = "button23";
            button23.Size = new Size(68, 64);
            button23.TabIndex = 34;
            button23.Text = "x^3";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(596, 376);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(68, 64);
            btnLog.TabIndex = 35;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 495);
            Controls.Add(btnLog);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(btnTangente);
            Controls.Add(btnEXP);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(btnCoseno);
            Controls.Add(btn10ALa);
            Controls.Add(button15);
            Controls.Add(btnPi);
            Controls.Add(btnSeno);
            Controls.Add(btnRaiz);
            Controls.Add(btnPorcentaje);
            Controls.Add(btnPunto);
            Controls.Add(btnMulti);
            Controls.Add(btnResultado);
            Controls.Add(btnDivision);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDivision;
        private Button btnResultado;
        private Button btnMulti;
        private Button btnPunto;
        private Button btnPorcentaje;
        private Button btnRaiz;
        private Button btnSeno;
        private Button btnPi;
        private Button button15;
        private Button btn10ALa;
        private Button btnCoseno;
        private Button button18;
        private Button button19;
        private Button btnEXP;
        private Button btnTangente;
        private Button button22;
        private Button button23;
        private Button btnLog;
    }
}
