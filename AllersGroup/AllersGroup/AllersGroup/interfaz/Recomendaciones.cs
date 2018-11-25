using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace AllersGroup.interfaz
{
    public partial class Recomendaciones : Form
    {
        private InterfazPrincipal conexion;
        public Recomendaciones(InterfazPrincipal conexion)
        {
            this.conexion = conexion;
            InitializeComponent();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(conexion, "Left", -10);
            Visible = false;
            conexion.Show();
            t.run();
        }

        private void info_Click(object sender, EventArgs e)
        {
            conexion.info_Click(sender, e);
            Visible = false;
        }

        private void graf_Click(object sender, EventArgs e)
        {
            conexion.graf_Click(sender, e);
            Visible = false;
        }

        private void Recomendaciones_Load(object sender, EventArgs e)
        {

        }

        private void butDistribuidor_Click(object sender, EventArgs e)
        {
            

            String mensaje = "";
            List<String> productosImplicados = new List<string>();
            productosImplicados = conexion.productosGenerados();
           

            for (int i = 0; i < productosImplicados.Count(); i++)
            {
                
                ControlProducto nuevo = new ControlProducto(conexion, productosImplicados[i]);
                flowArticulo.Controls.Add(nuevo);

                listBoxProductos.Items.Add(productosImplicados[i]);

            }
            


            //String mensaje = conexion.mensajeRecomenaciones();
            String confianza = conexion.darConfianza();

         

            txtConfianza.Text = confianza + "%";
            richTextBox1.Text = mensaje; 

        }

        private void butCPrivada_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void recup_Click(object sender, EventArgs e)
        {
            conexion.label1_Click(sender, e);
            Visible = false;
        }

        private void butInfoRecomendaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se aconseja ofrecer una serie de promociones según el marketing que maneje la empresa siguiendo las recomendaciones presentandas de los productos implicados por categoria de clientes");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<String> productosImplicados = new List<string>();
            productosImplicados = conexion.productosGenerados();
            
            for (int i = 0; i < productosImplicados.Count(); i++)
            {
                //listBox1.Items.Insert(i, productosImplicados[i]);
                ControlProducto nuevo = new ControlProducto (conexion,productosImplicados[i]);
                flowArticulo.Controls.Add(nuevo);

            }

        }

        

        private void flowArticulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void butBuscarMasFrecuente_Click(object sender, EventArgs e)
        {
            int valorInicio = 0;
            int valorFinal = 0;
            int aumento = 0;
            String producto = listBoxProductos.SelectedItem.ToString();
            labelProducto.Text = producto;



            //Filtrado de asociaciones

            try
            {
                List<int> mostrar = conexion.mostrarImplicados(producto);
               
                for (int i = 0; i < mostrar.Count(); i++)
                {
                    richTextBox1.Text += mostrar[i] + "";
                }

            }
            catch
            {
                MessageBox.Show("No se encuentran implicantes para este producto");
            }
            


            txtValorInicial.Text = valorInicio + "";
            txtValorFinal.Text = valorFinal + "";
            txtAumento.Text = aumento + "";


        }

        private void txtConfianza_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
