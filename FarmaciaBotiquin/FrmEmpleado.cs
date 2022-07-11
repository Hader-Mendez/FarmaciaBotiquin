using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaciaBotiquin.Clases;

namespace FarmaciaBotiquin
{
    public partial class FrmEmpleado : Form
    {
        Empleado empleado = new Empleado();
        Puesto puesto = new Puesto();
        Estado estado = new Estado();
        public FrmEmpleado()
        {
            InitializeComponent();
            puesto.CargarComboboxPuesto(cmbPuesto, 1);
            estado.CargarComboboxEstado(cmbEstado);
            inicializarDatagrid();


        }
        private void inicializarDatagrid()
        {
            empleado.MostrarEmpleados(dgvEmpleados);
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            empleado.BuscarEmpleados(dgvEmpleados, txtBuscar.Text);
        }
    }
}
