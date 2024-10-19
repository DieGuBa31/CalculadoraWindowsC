namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            /*operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";*/
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"{num1} {operador} ";
            textBox1.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"{num1} {operador} ";
            textBox1.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"{num1} {operador} ";
            textBox1.Text = "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"{num1} {operador} ";
            textBox1.Text = "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        return;
                    }
                    break;
            }
            textBox1.Text = $"{resultado}";
            textBox2.Text = $"{num1} {operador} {num2} =";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Convertir el número en el cuadro de texto a un valor numérico
            num1 = Convert.ToDouble(textBox1.Text);

            if (num1 >= 0)
            {
                // Calcular la raíz cuadrada
                double resultado = Math.Sqrt(num1);

                textBox2.Text = $"{num1}";
                textBox1.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("No se puede calcular la raíz cuadrada de un número negativo!");
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            //Convertir num2 en porcentaje de num1
            num2 = Convert.ToDouble(textBox1.Text);
            num2 = (num1 * num2) / 100;
            textBox2.Text = $"{num1} {operador} {num2}%";
            textBox1.Text = num2.ToString();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            // Convertir el número en el cuadro de texto a un valor numérico 
            num1 = Convert.ToDouble(textBox1.Text);

            // Convertir grados a radianes
            double radianes = (num1 * Math.PI) / 180;

            // Calcular el seno
            double resultado = Math.Sin(radianes);

            // Mostrar el resultado
            textBox2.Text = $"sin({num1}°)";
            textBox1.Text = resultado.ToString();
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            // Convertir el número en el cuadro de texto a un valor numérico 
            num1 = Convert.ToDouble(textBox1.Text);

            // Convertir grados a radianes
            double radianes = (num1 * Math.PI) / 180;

            // Calcular el seno
            double resultado = Math.Cos(radianes);

            // Mostrar el resultado
            textBox2.Text = $"cos({num1}°)";
            textBox1.Text = resultado.ToString();
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            // Convertir el número en el cuadro de texto a un valor numérico (en grados)
            num1 = Convert.ToDouble(textBox1.Text);

            // Convertir grados a radianes
            double radianes = (num1 * Math.PI) / 180;

            // Calcular el seno
            double resultado = Math.Tan(radianes);

            // Mostrar el resultado
            textBox2.Text = $"tan({num1}°)";
            textBox1.Text = resultado.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            // Insertar el valor de ? (pi) en el textBox1
            textBox1.Text = Math.PI.ToString();
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la base y el exponente del cuadro de texto
                double baseValue = Convert.ToDouble(textBox1.Text);
                double exponent = Convert.ToDouble(textBox2.Text);

                // Calcular la potencia base^exponente
                double resultado = Math.Pow(baseValue, exponent);

                // Mostrar el resultado en formato decimal
                textBox1.Text = resultado.ToString("G"); // "G" para mostrar en formato general
                textBox2.Text = $"{baseValue}^{exponent}"; // Expresión en textBox2
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor del cuadro de texto
                double value = Convert.ToDouble(textBox1.Text);

                // Verificar que el valor sea positivo
                if (value > 0)
                {
                    // Calcular el logaritmo en base 10
                    double resultado = Math.Log10(value);

                    // Mostrar el resultado
                    textBox1.Text = resultado.ToString();
                    textBox2.Text = $"log10({value})";
                }
                else
                {
                    MessageBox.Show("El valor debe ser mayor que 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn10ALa_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor del cuadro de texto
                double value = Convert.ToDouble(textBox1.Text);

                // Calcular 10^x
                double resultado = Math.Pow(10, value);

                // Mostrar el resultado
                textBox1.Text = resultado.ToString();
                textBox2.Text = $"10^{value}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor del cuadro de texto
                double value = Convert.ToDouble(textBox1.Text);

                // Calcular la raíz cúbica de x
                double resultado = Math.Cbrt(value);

                // Mostrar el resultado
                textBox1.Text = resultado.ToString();
                textBox2.Text = $"³?{value}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la base y el exponente del cuadro de texto
                double baseValue = Convert.ToDouble(textBox1.Text);
                double exponent = Convert.ToDouble(textBox2.Text);

                // Calcular la potencia base^exponente
                double resultado = Math.Pow(baseValue, exponent);

                // Mostrar el resultado
                textBox1.Text = resultado.ToString();
                textBox2.Text = $"{baseValue}^{exponent}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor del cuadro de texto
                double value = Convert.ToDouble(textBox1.Text);

                // Calcular el cuadrado del valor
                double resultado = Math.Pow(value, 2);

                // Mostrar el resultado
                textBox1.Text = resultado.ToString();
                textBox2.Text = $"{value}^2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor del cuadro de texto
                double value = Convert.ToDouble(textBox1.Text);

                // Calcular el cuadrado del valor
                double resultado = Math.Pow(value, 3);

                // Mostrar el resultado
                textBox1.Text = resultado.ToString();
                textBox2.Text = $"{value}^3";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el índice de la raíz y el valor del cuadro de texto
                double index = Convert.ToDouble(textBox1.Text); // Índice de la raíz
                double value = Convert.ToDouble(textBox2.Text); // Valor del que se toma la raíz

                // Verificar que el índice de la raíz sea positivo y distinto de cero
                if (index > 0)
                {
                    // Calcular la raíz en base y de x usando la fórmula (x^(1/y))
                    double resultado = Math.Pow(value, 1.0 / index);

                    // Mostrar el resultado
                    textBox1.Text = resultado.ToString();
                    textBox2.Text = $"{index}?{value}";
                }
                else
                {
                    MessageBox.Show("El índice de la raíz debe ser mayor que 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
