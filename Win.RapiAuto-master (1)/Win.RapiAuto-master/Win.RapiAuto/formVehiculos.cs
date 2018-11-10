using BL.RapiAuto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.RapiAuto
{
    public partial class formVehiculos : Form
    {
        VehiculosBL _vehiculos;
        public formVehiculos()
        {
            InitializeComponent();
            _vehiculos = new VehiculosBL();
            listaVehiculosBindingSource.DataSource = _vehiculos.ObtenerVehiculos();
        }

        private void listaVehiculosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listaVehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaVehiculosBindingSource.EndEdit();
            var vehiculo = (Vehiculo)listaVehiculosBindingSource.Current;

            if(fotoPictureBox.Image != null)
            {
                vehiculo.Foto = Program.ImageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                vehiculo.Foto = null;
            }

            var resultado = _vehiculos.GuardarVehiculo(vehiculo);

            if (resultado.Exitoso==true)
            {
                listaVehiculosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _vehiculos.AgregarVehiculo();
            listaVehiculosBindingSource.MoveNext();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            Cancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {

            var resultado = _vehiculos.EliminarVehiculo(id);
            if (resultado == true)
            {
                listaVehiculosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el vehiculo");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void btAgregarFoto_Click(object sender, EventArgs e)
        {
            var vehiculo = (Vehiculo)listaVehiculosBindingSource.Current;

            if (vehiculo != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un vehiculo antes de asignarle una imagen");
            }
            
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btRemoverFoto_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
