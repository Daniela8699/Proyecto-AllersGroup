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
            butSeleccionarProducto.Visible = false;
            butInfoRecomendaciones.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            txtConfianza.Visible = false;
            listBoxProductos.Visible = false;
            label9.Visible = false;
            labelProducto.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            richTextBox1.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            richTextAsociacionesCompletas.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label12.Visible = false;
            label4.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            txtAumento.Visible = false;
            txtValorFinal.Visible = false;
            txtValorInicial.Visible = false;
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
        public bool selec = false;
        private void butDistribuidor_Click(object sender, EventArgs e)
        {
            butSeleccionarProducto.Visible = true;
            butInfoRecomendaciones.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtConfianza.Visible = true;
            listBoxProductos.Visible = true;
            label9.Visible = true;
            labelProducto.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            richTextBox1.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            richTextAsociacionesCompletas.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label12.Visible = true;
            label4.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            txtAumento.Visible = true;
            txtValorFinal.Visible = true;
            txtValorInicial.Visible = true;
            String mensaje = "";
                List<String> productosImplicados = new List<string>();
                productosImplicados = conexion.productosGenerados();


                for (int i = 0; i < productosImplicados.Count(); i++)
                {

                    ControlProducto nuevo = new ControlProducto(conexion, productosImplicados[i]);
                    flowArticulo.Controls.Add(nuevo);

                    listBoxProductos.Items.Add(productosImplicados[i]);

                }



                mensaje = conexion.mensajeRecomenaciones();
                String confianza = conexion.darConfianza();


                selec = true;
                txtConfianza.Text = confianza + "%";
                richTextAsociacionesCompletas.Text = mensaje;


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
            richTextBox1.Clear();
            if( selec==true)
            {
                double valorInicio = 0;
                double valorFinal = 0;
                double aumento = 0;
                if (listBoxProductos.SelectedItem != null)
                {
                    String producto = listBoxProductos.SelectedItem.ToString();
                    labelProducto.Text = producto;



                    //Filtrado de asociaciones

                    try
                    {
                        List<int> mostrar = conexion.mostrarImplicados(producto);
                        double[] precios = conexion.TraerPrecios(producto, mostrar);
                        valorInicio = precios[0];
                        valorFinal = valorInicio + precios[1];
                        aumento = precios[2]*100;

                        for (int i = 0; i < mostrar.Count(); i++)
                        {
                            richTextBox1.Text += mostrar[i] + "\n";
                        }

                    }
                    catch
                    {
                        MessageBox.Show("No se encuentran implicantes para este producto");
                    }

                 

                    txtValorInicial.Text = valorInicio + "";
                    txtValorFinal.Text = valorFinal + "";
                    txtAumento.Text = aumento + "%";
                }
                else MessageBox.Show("Primero seleccione algo de la lista.");
            }
            else MessageBox.Show("Primero genere las asociaciones."); 

        }

        private void txtConfianza_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
