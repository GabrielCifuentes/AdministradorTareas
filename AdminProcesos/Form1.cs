using System.Diagnostics;
namespace AdminProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActualizarProcesos();
        }
        private void ActualizarProcesos()
        {
            lstprocesos.Items.Clear();
            lstide.Items.Clear();
            lstram.Items.Clear();
            lstvirtual.Items.Clear();
            lstcpu.Items.Clear();
            int id = 1;
            foreach (Process procesos in Process.GetProcesses()) 
            {
                lstprocesos.Items.Add(id + ":" + procesos.ProcessName);
                lstide.Items.Add(id + ":" + procesos.Id);
                lstram.Items.Add(id + ":" + procesos.WorkingSet64);
                lstvirtual.Items.Add(id + ":" + procesos.VirtualMemorySize64);
                lstcpu.Items.Add(id + ":" +procesos.SessionId);
                id = id + 1;
            }
            lbltotalprocesos.Text = "Total de procesos : " + lstprocesos.Items.Count.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ActualizarProcesos();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Deseas salir del programa?", "salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Process programa in Process.GetProcesses())
                {
                    string seleccion = lstprocesos.SelectedItem.ToString();
                    string[] proceso = seleccion.Split(':');
                    if (programa.ProcessName == proceso[1])
                    {
                        programa.Kill();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}