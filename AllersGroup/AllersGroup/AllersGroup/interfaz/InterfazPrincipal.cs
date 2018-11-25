using AllersGroup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllersGroup.interfaz;
using Transitions;

namespace AllersGroup
{
    public partial class InterfazPrincipal : Form
    {
        private Form infor;
        private Form recome;
        private Form grafi;
        private Form recup;
        private Form parametro;
        public PanelRecuperar prueba;
        public Recomendaciones recomendacion;

        public Controlador modelo;

        private string mensaje;
        private List<string> productos;
        private double conf;
        public InterfazPrincipal()
        {
            prueba = new PanelRecuperar(this);
            InitializeComponent();
            infor = new Info(this);
            recome = new Recomendaciones(this);
            grafi = new Graficos(this);
            recup = new PanelRecuperar(this);
            parametro = new Parametros(this);
            recomendacion = new Recomendaciones(this);

        }

        public void productoMasFrecuente(List<string> productos)
        {
               
        }


        internal void MostrarArticulo(string codigoCliente)
        {
            Articulo encontrado = modelo.buscarArticuloEnLista(Convert.ToInt32(codigoCliente));
            PanelArticulo vent = new PanelArticulo(encontrado.ItemCode+"", encontrado.ItemName, encontrado.ItemClasification);
            vent.StartPosition = FormStartPosition.CenterParent;
            vent.ShowDialog();
        }

        internal void MostrarCliente(string codigoCliente)
        {
            Cliente encontrado= modelo.buscarClienteEnLista(codigoCliente);
            PanelCliente vent = new PanelCliente(encontrado.CardCode, encontrado.GroupName, encontrado.City, encontrado.Department, encontrado.PaymentGroup);
            vent.StartPosition = FormStartPosition.CenterParent;
            vent.ShowDialog();
        }

        internal void mostrarProducto(String codProducto)
        {
            try
            {
                //Articulo encontrado = modelo.buscarArticuloEnReglas(Convert.ToInt32(codProducto)); 
                Articulo encontrado = modelo.BuscarItem(Convert.ToInt32(codProducto));
                PanelArticulo vent = new PanelArticulo(encontrado.ItemCode + "", encontrado.ItemName, encontrado.ItemClasification);
                vent.StartPosition = FormStartPosition.CenterParent;
                vent.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No se encontro el articulo");
            }
            
        }

        internal void RecuperarCliente(string codigoCliente)
        {
            prueba.mostrarArticulos(modelo.ItemsRecuperar(codigoCliente));
        }
        
        public List<int> mostrarImplicados(String codProducto)
        {

           return modelo.mostrarProductosImplicados(codProducto);
        }


        public int num;
        public void cargar(double support,double confianza, int numArticulos, int tamanhoAgrupaciones)
        {          
            modelo = new Controlador(confianza,support);
            num = numArticulos;
            modelo.CargarDatos();
            modelo.AprioriMethod(tamanhoAgrupaciones, numArticulos);
            MessageBox.Show("Los datos han sido analizados");
            mensaje = modelo.Promociones();
            productos = modelo.darProductos();
            conf = confianza;
        
        }

        

        
        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {
            

        }
        public string[] frecuentesCategoria(string cat)
        {
            return modelo.masFrecuentesMetodo2(4, cat);
        }


        public String mensajeRecomenaciones()
        {
            return mensaje;
        }


        public List<String> productosGenerados()
        { 
            return productos;
        }


        public String darConfianza()
        {

            double porcentaje = conf * 100 ;
            String confianza = ""+porcentaje;
            return confianza;
        }
       

        public void info_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(infor, "Left", -10);
            Visible = false;
            infor.Show();
            t.run();
           
        }

        public void recom_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_Bounce(2000));
            t.add(recome, "Left", 10);


            Visible = false;
            recome.Show();
            t.run();
        }

        public void graf_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_Bounce(2000));
            t.add(grafi, "Top", -10);
            Visible = false;
            grafi.Show();
            t.run();
        }

    
   

        public void label1_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(infor, "Left", -10);
            Visible = false;
            prueba.Show();
            t.run();
        }

        private void parametros_Click(object sender, EventArgs e)
        {
            //Abrir ventana de parametros
            Parametros vent = new Parametros(this);
            vent.StartPosition = FormStartPosition.CenterParent;
            vent.ShowDialog();
        }

        private void butParametrosCargar_Click(object sender, EventArgs e)
        {

            Parametros vent = new Parametros(this);
            vent.StartPosition = FormStartPosition.CenterParent;
            vent.ShowDialog();

        }
    }
}
