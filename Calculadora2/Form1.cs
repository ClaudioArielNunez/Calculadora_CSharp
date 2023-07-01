using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variables
        double num1 = 0;
        double num2 = 0;
        double resultado = 0;
        char operador ;
        bool op = false;
        //metodos
        private void cargarDisplay(string numero)
        {
            if (txtDisplay.Text == "0" || op == true)
            {
                txtDisplay.Clear();
                txtVisualizador.Text = "";
            }   

            txtDisplay.Text += numero;
            txtVisualizador.Text += numero;
            op = false;
        }
        private void cargarVacio(string num, char operacion)
        {
            if (num == string.Empty)
            {
                num1 = 0;
                txtDisplay.Text = num1.ToString();
                txtVisualizador.Text = num1.ToString() + operacion.ToString();
            }
            else
            {
                num1 = double.Parse(txtDisplay.Text);
                operador = operacion;
                txtDisplay.Text = "0";
                txtVisualizador.Text += operacion.ToString();
            }
        }

        private void bCero_Click(object sender, EventArgs e)
        {            
            cargarDisplay("0");
        }
        private void btnUno_Click(object sender, EventArgs e)
        {            
            cargarDisplay("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {            
            cargarDisplay("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            cargarDisplay("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            cargarDisplay("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {            
            cargarDisplay("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            cargarDisplay("6"); 
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            cargarDisplay("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            cargarDisplay("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            cargarDisplay("9");
        }

       
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = '+';
            if(txtDisplay.Text == ",")
            {
                MessageBox.Show("Debe poner el numero en formato correcto");
                txtDisplay.Text = "0";
                txtVisualizador.Text = "0";
            }
            else
            {
                cargarVacio(txtDisplay.Text, operador);
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = '-';  
            if(txtDisplay.Text == ",")
            {
                MessageBox.Show("Debe poner el numero en formato correcto");
                txtDisplay.Text = "0";
                txtVisualizador.Text = "0";
            }
            else
            {
                cargarVacio(txtDisplay.Text, operador);
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = '*';
            if (txtDisplay.Text == ",")
            {
                MessageBox.Show("Debe poner el numero en formato correcto");
                txtDisplay.Text = "0";
                txtVisualizador.Text = "0";
            }
            else
            {
                cargarVacio(txtDisplay.Text, operador);                
            }

        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operador = '/';
            if (txtDisplay.Text == ",")
            {
                MessageBox.Show("Debe poner el numero en formato correcto");
                txtDisplay.Text = "0";
                txtVisualizador.Text = "0";
            }
            else
            {
                cargarVacio(txtDisplay.Text, operador);
            }

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text != string.Empty)
            {
                num2 = Convert.ToDouble(txtDisplay.Text);

                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;

                    case '/':
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            resultado = 0;
                            txtDisplay.Text = "Error";
                            MessageBox.Show("No se puede dividir por cero");
                        }
                        break;
                    default:
                        break;
                }
                txtDisplay.Text = resultado.ToString();
                txtVisualizador.Text = num1.ToString() + operador.ToString() + num2.ToString();
            }           
            
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ",";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text != string.Empty)
            {
                num1 = Convert.ToDouble(txtDisplay.Text) * (-1);
                txtDisplay.Text = num1.ToString();
            }       
                    
            
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un numero");
                return;
            }
            num1 = Convert.ToDouble(txtDisplay.Text);
            num1 = Math.Sqrt(num1);
            op = true;
            txtDisplay.Text = num1.ToString();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un numero");
                return;
            }
            num1 = Double.Parse(txtDisplay.Text);
            num1 = Math.Pow(num1,2);
            op = true;
            txtDisplay.Text = num1.ToString();
        }

        private void btnBorrarUltimo_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 1)
            {
                int largo = txtDisplay.Text.Length;
                txtDisplay.Text = txtDisplay.Text.Substring(0,largo -1);               
            }
            else
            {
                txtDisplay.Text = "0";
            }
            
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num1 = 0;
            resultado = 0;
            operador = '\0';
            txtDisplay.Text = "0";
            txtVisualizador.Text = "0";
        }

        private void btnBorrarEntrada_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtVisualizador.Text = "0";
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un numero");
                return;
            }
            double aux = Convert.ToDouble(txtDisplay.Text);
            aux = aux / 100;
            txtDisplay.Text = aux.ToString();
            op = true;
        }
        


    }
}
