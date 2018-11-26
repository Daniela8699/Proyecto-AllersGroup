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
using System.Threading;

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
        public String folder;

        public Controlador modelo;

        private string mensaje;
        private List<string> productos;
        private double conf;

        public List<double[]> distri = new List<double[]>();
        public List<double[]> cliPriv = new List<double[]>();
        public List<double[]> cliPub = new List<double[]>();
        public List<double[]> noSalud = new List<double[]>();
        public List<double[]> almace = new List<double[]>();
        public List<double[]> belleza = new List<double[]>();
        public List<double[]> veter = new List<double[]>();
        public List<double[]> odonto = new List<double[]>();
        public List<double[]> drog = new List<double[]>();
        public List<double[]> med = new List<double[]>();
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

        public double[] TraerPrecios(string producto, List<int> der)
        {
            int itemCode = Convert.ToInt32(producto);
            List<int> product = new List<int>();
            product.Add(itemCode);
            return modelo.BuscarPrecioEnLista(product, der);
        }
        public int num;
        public void cargar(double support,double confianza, int numArticulos, int tamanhoAgrupaciones)
        {
            try
            {
                modelo = new Controlador(confianza, support, folder);
                num = numArticulos;
                modelo.CargarDatos();
                modelo.AprioriMethod(tamanhoAgrupaciones, numArticulos);
              //  MessageBox.Show("Los datos han sido analizados");
                mensaje = modelo.Promociones();
                productos = modelo.darProductos();
                conf = confianza;
                //distri = clientesCat("DISTRIBUIDORES");
                // cliPriv = clientesCat("CLINICAS PRIVADAS");
                //cliPub = clientesCat("CLINICAS PUBLICAS");
                //noSalud = clientesCat("NO DEDICADO A SALUD");
                //almace = clientesCat("ALMACENES DE CADENA");
                //belleza = clientesCat("BELLEZA Y ESTETICA");
                //veter = clientesCat("VETERINARIOS");
                //odonto = clientesCat("ODONTO CENTRO ODONTO");
                //drog = clientesCat("DROG FARMACIA Y MISC");
                //med = clientesCat("MED LAB OP AMBUL");

            }
            catch
            {
                MessageBox.Show("Error al cargar los datos");
            }

        
        }

        

        
        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {
            

        }

        public List<double[]> clientesCat(string cat)
        {
           
            List<Cliente> clientesCategoria = modelo.agruparLista(cat);

            return modelo.posicionesClientes(clientesCategoria);
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
            if (modelo != null)
            {
                Transition t = new Transition(new TransitionType_CriticalDamping(2000));
                t.add(infor, "Left", -10);
                Visible = false;
                infor.Show();
                t.run();
            }
            else MessageBox.Show("Primero especifique los parametros para analizar los datos.");

        }

        public void recom_Click(object sender, EventArgs e)
        {
            if (modelo != null)
            {
                Transition t = new Transition(new TransitionType_Bounce(2000));
                t.add(recome, "Left", 10);


                Visible = false;
                recome.Show();
                t.run();
            }
            else MessageBox.Show("Primero especifique los parametros para analizar los datos.");
        }

        public void graf_Click(object sender, EventArgs e)
        {
            if (modelo != null)
            {
                Transition t = new Transition(new TransitionType_Bounce(2000));
                t.add(grafi, "Top", -10);
                Visible = false;
                grafi.Show();
                t.run();
            }
            else MessageBox.Show("Primero especifique los parametros para analizar los datos.");
        }

    
   

        public void label1_Click(object sender, EventArgs e)
        {
            if (modelo != null)
            {
                Transition t = new Transition(new TransitionType_CriticalDamping(2000));
                t.add(infor, "Left", -10);
                Visible = false;
                prueba.Show();
                t.run();
            }
            else MessageBox.Show("Primero especifique los parametros para analizar los datos.");

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
            if (folder != null)
            {
                Parametros vent = new Parametros(this);
                vent.StartPosition = FormStartPosition.CenterParent;
                vent.ShowDialog();
            }
            else MessageBox.Show("Primero especifique la carpeta de datos");

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            var t = new Thread((ThreadStart)(() => {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.Cancel)
                    return;

                folder = fbd.SelectedPath;
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();


        }

     
    }
}
