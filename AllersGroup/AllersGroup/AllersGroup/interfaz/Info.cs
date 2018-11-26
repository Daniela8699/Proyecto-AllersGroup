using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class Info : Form
    {
        private InterfazPrincipal a;
        private string categoria;
        public Info(InterfazPrincipal b)
        {
            a = b;
            InitializeComponent();
            
           

        }
        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_CriticalDamping(2000));
            t.add(a, "Left", -10);
            Visible = false;
            a.Show();
            t.run();
        }

        private void recom_Click(object sender, EventArgs e)
        {
            a.recom_Click(sender, e);
            Visible = false;
        }

        private void graf_Click(object sender, EventArgs e)
        {
            a.graf_Click(sender, e);
            Visible = false;
        }

        private void butDistribuidorC_Click(object sender, EventArgs e)
        {
            categoria = "DISTRIBUIDORES";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.blue);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

        
        MessageBox.Show("Productos Cargados");

        }

        private void butDrogFarmaciaMiscC_Click(object sender, EventArgs e)
        {
            categoria = "DROG FARMACIA Y MISC";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.yellow);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butAplicarControladorPF_Click(object sender, EventArgs e)
        {
            
            //a.cargar(support);
            //MessageBox.Show("Datos Cargados");
            
        }

        

        private void butCPrivadaC_Click(object sender, EventArgs e)
        {
            
            categoria = "CLINICAS PRIVADAS";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.pink);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butCPublicasC_Click(object sender, EventArgs e)
        {
            
            categoria = "CLINICAS PUBLICAS";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.red);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butNoDedicadoSaludC_Click(object sender, EventArgs e)
        {
            
            categoria = "NO DEDICADO A SALUD";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.orange);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butAlmacenCadenaC_Click(object sender, EventArgs e)
        {
          
            categoria = "ALMACENES DE CADENA";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.purple);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butBellezayEsteticaC_Click(object sender, EventArgs e)
        {
          
            categoria = "BELLEZA Y ESTETICA";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.green);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butVeterinarioC_Click(object sender, EventArgs e)
        {
         
            categoria = "VETERINARIOS";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.lightblue);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butOdontoCentroOdontoC_Click(object sender, EventArgs e)
        {
           
            categoria = "ODONTO CENTRO ODONTO";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.blue_pushpin);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1}", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void butMedAmbulC_Click(object sender, EventArgs e)
        {
            
            categoria = "MED LAB OP AMBUL";
            gMapControl1.Overlays.Clear();
            GMapOverlay overlay = new GMapOverlay();
            MessageBox.Show("Espera a que se carguen los datos");
            List<Cliente> clientes2 = a.clientesCategoria(categoria);
            List<double[]> lista = a.clientesCat(categoria);
            for (int i = 0; i < lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.yellow_pushpin);
                marker.IsVisible = (true);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("CardCode:\n {0} \n Categoria: {1} \n ", clientes2[i].CardCode, clientes2[i].GroupName);
                overlay.Markers.Add(marker);


            }

            gMapControl1.Overlays.Add(overlay);

            MessageBox.Show("Productos Cargados");
        }

        private void recup_Click(object sender, EventArgs e)
        {
            a.label1_Click(sender, e);
            Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      


        private void butInfoFrecuentes_MouseMove(object sender, MouseEventArgs e)
        {
            
        }



        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia");

            gMapControl1.Zoom = 4;
           

        }

        private void butInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se presenta las ubicaciones de los clientes segun sus categorias.");
        }
    }
}
