namespace Practica_Itinerario3
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnVerPartidos_Click(object sender, EventArgs e)
      {
         dGVPartidos.DataSource = null;
         dGVPartidos.DataSource = GestorPartido.getAllPartido();
      }
   }
}