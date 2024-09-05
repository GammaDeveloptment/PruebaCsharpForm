using Clases.ApiRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://rickandmortyapi.com/api/character");
            pictureBox1.ImageLocation = respuesta.results[0].image.ToString();
            txtNombreGET.Text = respuesta.results[0].name.ToString();
            txtApellidoGET.Text = respuesta.results[0].status.ToString();
            txtEmail.Text = respuesta.results[0].gender.ToString();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Token token = new Token
            {
                access_token = txtCodaereo.Text,
                token_type = txtReserva.Text
            };

            string json = JsonConvert.SerializeObject(token);

            dynamic respuesta = dBApi.Post("https://apigroup.loges.net.pe/ws1-test/token", json);
            respuesta.access_token.ToString();
            MessageBox.Show(respuesta.ToString());
            string apicliente = "https://apigroup.loges.net.pe/ws1-test/operativocarga/consultaprealerta?token=" + respuesta.access_token.ToString();
            //MessageBox.Show(apicliente);
            
            dynamic respuestacliente = dBApi.Get(apicliente);
            txtReserva.Text = respuestacliente[0].reserva.ToString();
            txtCodaereo.Text = respuestacliente[0].codigoaerolinea.ToString();
            RefIntHija.Text = respuestacliente[0].referenciainternoguiaaerea.ToString();
            ShipperM.Text = respuestacliente[0].shipper_master.ToString();
            Consignee.Text = respuestacliente[0].consignee.ToString();
            Numguia.Text = respuestacliente[0].numeroguia.ToString();
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

    public class Token
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string scope { get; set; }
        public string token_type { get; set; }
    }
}

