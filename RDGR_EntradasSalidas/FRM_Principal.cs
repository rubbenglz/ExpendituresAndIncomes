using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using RDGR_EntradasSalidas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDGR_EntradasSalidas
{
    public partial class FRM_Principal : XtraForm
    {
        Principal objPrincipal;
        public FRM_Principal()
        {
            objPrincipal = new Principal();
            InitializeComponent();
            clsDevexpress.MostraFormaEspera(this, "Cargando");
            InicializarValores();
            clsDevexpress.CerrarFormaEspera();

        }

        private void InicializarValores()
        {
            dtFechaInicio.DateTime = DateTime.Now;
            dtFechaFin.DateTime = DateTime.Now;
            txtGastos.Text = "0";
            txtIngresos.Text = "0";
            txtTotal.Text = "0";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                clsDevexpress.MostraFormaEspera(this, "Buscando");
                Buscar();
                clsDevexpress.CerrarFormaEspera();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al buscar registros" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Buscar()
        {
            string respuesta = string.Empty;
            decimal ingreso = 0, gasto = 0;
            try
            {
                var lstDatos = objPrincipal.GetDatos(dtFechaInicio.DateTime.Date, dtFechaFin.DateTime.Date);
                var sumatoria = lstDatos
                    .GroupBy(x => x.Tipo)
                  .Select(g => new { Id = g.Key, Sum = g.Sum(x => x.Cantidad) });
                var lstIngreso = sumatoria.Where(x => x.Id.Trim() == "Ingreso").FirstOrDefault();
                if (lstIngreso != null)
                    ingreso = lstIngreso.Sum;
                var lstGastos = sumatoria.Where(x => x.Id.Trim() == "Gasto").FirstOrDefault();
                if (lstGastos != null)
                    gasto = lstGastos.Sum;
                txtIngresos.Text = ingreso.ToString();
                txtGastos.Text = gasto.ToString();
                txtTotal.Text = (ingreso - gasto).ToString();
                grdPrincipal.DataSource = lstDatos;
                return respuesta;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_Modal frmModal = new FRM_Modal();
            frmModal.TipoVenta = RDGR_EntradasSalidas.Principal.TipoVentana.Agregar;
            if (frmModal.ShowDialog() == DialogResult.OK)
                Buscar();
        }

        private void grvPrincipal_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    if (e.Column == null)
                        return;

                    switch (e.Column.FieldName)
                    {
                        case "Tipo":
                            if (view.GetRowCellValue(e.RowHandle, colTipo).ToString().Trim() == "Ingreso")
                                e.Appearance.BackColor = Color.LightGreen;
                            else
                                e.Appearance.BackColor = Color.OrangeRed;
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                clsDevexpress.MBOK("Error al pintar los campos"+ ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
