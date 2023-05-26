using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace Model
{
    public partial class FormMantendorCliente : Form
    {
        public FormMantendorCliente()
        {
            InitializeComponent();
            listarCliente();
        }
        public void listarCliente()
        {
            dgvClientes.DataSource = logCliente.Instancia.ListarCliente();
        }
    }
}
