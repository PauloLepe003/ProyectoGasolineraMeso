using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace gasolinera_json
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort arduino;
        public Form1()
        {
            InitializeComponent();

            arduino = new System.IO.Ports.SerialPort();
            arduino.PortName = "COM7";
            arduino.BaudRate = 9600;
            //arduino.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear un objeto anónimo con la acción 'E'
            var data = new { action = "E" };
            // Serializar el objeto a JSON
            string jsonData = JsonConvert.SerializeObject(data);
            // Enviar el JSON al Arduino
            arduino.Write(jsonData);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(arduino.IsOpen)
            {
                arduino.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear un objeto anónimo con la acción 'F'
            var data = new { action = "F" };
            // Serializar el objeto a JSON
            string jsonData = JsonConvert.SerializeObject(data);
            // Enviar el JSON al Arduino
            arduino.Write(jsonData);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Motel1 nmotel=new Motel1();
            nmotel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Motel2 nmotel = new Motel2();
            nmotel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Motel3 nmotel = new Motel3();
            nmotel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Motel4 nmotel = new Motel4();
            nmotel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Informe nmotel = new Informe();
            nmotel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
