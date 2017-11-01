using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Conexion;

namespace RDGR_EntradasSalidas
{
    public partial class FRM_Modal : XtraForm
    {
        Principal objPrincipal = new Principal();
        
        public FRM_Modal()
        {
            InitializeComponent();
            objPrincipal = new Principal();
            radioGroup1.Controls[0].Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {            
            switch (TipoVenta)
            {
                case Principal.TipoVentana.Agregar:
                    Guardar();
                    break;
                case Principal.TipoVentana.Modificar:
                    Modificar();
                    break;
                default:
                    break;
            }            
        }

        private void Modificar()
        {
            throw new NotImplementedException();
        }

        private void Guardar()
        {
            var Registro = new Registros()
            {
                Cantidad = Convert.ToDecimal(txtCantidad.EditValue),
                Descripcion = txtDesc.Text,
                Tipo = txtTipo.Text,
                Fecha = DateTime.Now
            };
            var a = objPrincipal.Save(Registro);
            if (!string.IsNullOrWhiteSpace(a))
                XtraMessageBox.Show("Error al guardar el registro" + a);
            else
                if (XtraMessageBox.Show("¿Desea agregar otro archivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtTipo.Text = "Ingreso";
            txtCantidad.Text = "0";
            txtDesc.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public Principal.TipoVentana TipoVenta { get; set; }
    }
}
