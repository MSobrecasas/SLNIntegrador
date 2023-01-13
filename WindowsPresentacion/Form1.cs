using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }

        private void CargarDatos()
        {
            dgvMedicos.DataSource = AdmMedico.Listar();
            dgvPacientes.DataSource = AdmPaciente.Listar();
            CargarMedicosClinicos();
            CargarHabitacion();
        }

        private void CargarMedicosClinicos()
        {
            List<Medico> list = AdmMedico.Listar("Clinico");
            foreach (Medico m in list)
            {
                listBoxMedicos.Items.Add(m.Nombre + " " + m.Apellido);
            }
            lblCantidadMedicos.Text = "Cantidad de Medicos Clinicos: " + list.Count.ToString();
        }

        private void CargarHabitacion()
        {
            List<Habitacion> list = AdmHabitacion.Listar();
            foreach (Habitacion h in list)
            {
                listBoxHabitaciones.Items.Add("Habitacion N° " + h.Numero.ToString() + " " + (h.Estado ? "Ocupado" : "Libre"));
            }
        }

    }
}
