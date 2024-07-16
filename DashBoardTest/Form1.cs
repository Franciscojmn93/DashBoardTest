namespace DashBoardTest
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Dashboard;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                    Dashboard = new System.IO.Ports.SerialPort();
                    Dashboard.PortName = lblCOM.Text;
                    Dashboard.BaudRate = 9600;
                    Dashboard.Open();

                    panel1.Visible = true;
                    groupBoxLuces.Visible = true;
                    groupBoxServos.Visible = true;
                    cmbPuertoCom.Visible = false;
                    btnConectar.Visible = false;
                    label2.Visible = false;
            }
            catch 
            {
               MessageBox.Show("No se encontró el puerto seleccionado, prueba con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error ); 
            }

        }

        private void cmbPuertoCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbPuertoCom.SelectedIndex;
            lblCOM.Text = cmbPuertoCom.Items[indice].ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Dashboard.IsOpen) 
            {
                Dashboard.Close();
            }
        }

        //Grupos
        private void btnEncender_Click(object sender, EventArgs e)
        {
            Dashboard.Write("1");
            panelluces.Visible = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Dashboard.Write("2");
            panelluces.Visible = true;
        }

        private void btn180_Click(object sender, EventArgs e)
        {
            Dashboard.Write("4");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Dashboard.Write("3");
        }

        //servos individuales
        private void btnServoFuel_Click(object sender, EventArgs e)
        {
            Dashboard.Write("f");
        }

        private void btnServoOil_Click(object sender, EventArgs e)
        {
            Dashboard.Write("g");
        }

        private void btnServokm_Click(object sender, EventArgs e)
        {
            Dashboard.Write("h");
        }

        private void btnServoRPM_Click(object sender, EventArgs e)
        {
            Dashboard.Write("i");
        }

        private void btnServoTemp_Click(object sender, EventArgs e)
        {
            Dashboard.Write("j");
        }

        private void btnServoAir_Click(object sender, EventArgs e)
        {
            Dashboard.Write("k");
        }
    }
}