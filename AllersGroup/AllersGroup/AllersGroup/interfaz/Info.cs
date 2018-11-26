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
           
            MessageBox.Show("Productos Cargados");

        }

        private void butDrogFarmaciaMiscC_Click(object sender, EventArgs e)
        {
            categoria = "DROG FARMACIA Y MISC";
         
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
            
            MessageBox.Show("Productos Cargados");
        }

        private void butCPublicasC_Click(object sender, EventArgs e)
        {
            
            categoria = "CLINICAS PUBLICAS";
           
            MessageBox.Show("Productos Cargados");
        }

        private void butNoDedicadoSaludC_Click(object sender, EventArgs e)
        {
            
            categoria = "NO DEDICADO A SALUD";
            
            MessageBox.Show("Productos Cargados");
        }

        private void butAlmacenCadenaC_Click(object sender, EventArgs e)
        {
          
            categoria = "ALMACENES DE CADENA";
          
            MessageBox.Show("Productos Cargados");
        }

        private void butBellezayEsteticaC_Click(object sender, EventArgs e)
        {
          
            categoria = "BELLEZA Y ESTETICA";
          
            MessageBox.Show("Productos Cargados");
        }

        private void butVeterinarioC_Click(object sender, EventArgs e)
        {
         
            categoria = "VETERINARIOS";
            
            MessageBox.Show("Productos Cargados");
        }

        private void butOdontoCentroOdontoC_Click(object sender, EventArgs e)
        {
           
            categoria = "ODONTO CENTRO ODONTO";
          
            MessageBox.Show("Productos Cargados");
        }

        private void butMedAmbulC_Click(object sender, EventArgs e)
        {
            
            categoria = "MED LAB OP AMBUL";
           
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

        private void butInfoFrecuentes_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Se presenta las ubicaciones de los clientes segun sus categorias.");
        }

        private void butInfoFrecuentes_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
      
      

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMapOverlay overlay = new GMapOverlay();
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia.");
            gMapControl1.ShowCenter = true;
            List<double[]> lista = a.distri;
            for (int i = 0; i <lista.Count(); i++)
            {

                double[] pos = lista[i];
                double x = pos[0];
                double y = pos[1];
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(x,y), GMarkerGoogleType.blue);
                    marker.IsVisible = (true);
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    //marker.ToolTipText = string.Format("Nombre:\n {0} \n Codigo: \n {1}", modelo.Grupos[i].Nombre, modelo.Grupos[i].Codigo);
                    overlay.Markers.Add(marker);
                    
                
            }

            gMapControl1.Overlays.Add(overlay);

        }
    }
}
