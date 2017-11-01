namespace RDGR_EntradasSalidas
{
    partial class FRM_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.grdPrincipal = new DevExpress.XtraGrid.GridControl();
            this.registrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.principalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBotones = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGastos = new DevExpress.XtraEditors.TextEdit();
            this.lblGastos = new DevExpress.XtraEditors.LabelControl();
            this.txtIngresos = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalIngresos = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaFin = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaini = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.principalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBotones)).BeginInit();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGastos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngresos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPrincipal
            // 
            this.grdPrincipal.DataSource = this.registrosBindingSource;
            this.grdPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPrincipal.Location = new System.Drawing.Point(0, 77);
            this.grdPrincipal.MainView = this.grvPrincipal;
            this.grdPrincipal.Name = "grdPrincipal";
            this.grdPrincipal.Size = new System.Drawing.Size(705, 364);
            this.grdPrincipal.TabIndex = 2;
            this.grdPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPrincipal});
            // 
            // registrosBindingSource
            // 
            this.registrosBindingSource.DataSource = typeof(Conexion.Registros);
            // 
            // grvPrincipal
            // 
            this.grvPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colTipo,
            this.colDescripcion,
            this.colFecha,
            this.colCantidad});
            this.grvPrincipal.GridControl = this.grdPrincipal;
            this.grvPrincipal.Name = "grvPrincipal";
            this.grvPrincipal.OptionsBehavior.Editable = false;
            this.grvPrincipal.OptionsCustomization.AllowColumnMoving = false;
            this.grvPrincipal.OptionsCustomization.AllowQuickHideColumns = false;
            this.grvPrincipal.OptionsFilter.AllowColumnMRUFilterList = false;
            this.grvPrincipal.OptionsFilter.AllowFilterEditor = false;
            this.grvPrincipal.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.grvPrincipal.OptionsFilter.AllowMRUFilterList = false;
            this.grvPrincipal.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.grvPrincipal.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.grvPrincipal.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.grvPrincipal.OptionsMenu.EnableColumnMenu = false;
            this.grvPrincipal.OptionsMenu.EnableFooterMenu = false;
            this.grvPrincipal.OptionsMenu.EnableGroupPanelMenu = false;
            this.grvPrincipal.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.grvPrincipal.OptionsMenu.ShowAutoFilterRowItem = false;
            this.grvPrincipal.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grvPrincipal.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grvPrincipal.OptionsMenu.ShowSplitItem = false;
            this.grvPrincipal.OptionsView.ColumnAutoWidth = false;
            this.grvPrincipal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.grvPrincipal.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grvPrincipal.OptionsView.ShowGroupPanel = false;
            this.grvPrincipal.OptionsView.ShowIndicator = false;
            this.grvPrincipal.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grvPrincipal_RowCellStyle);
            // 
            // colCheck
            // 
            this.colCheck.Caption = " ";
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.DisplayFormat.FormatString = "d";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.DisplayFormat.FormatString = "C2";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnSearch);
            this.pnlBotones.Controls.Add(this.txtTotal);
            this.pnlBotones.Controls.Add(this.labelControl2);
            this.pnlBotones.Controls.Add(this.txtGastos);
            this.pnlBotones.Controls.Add(this.lblGastos);
            this.pnlBotones.Controls.Add(this.txtIngresos);
            this.pnlBotones.Controls.Add(this.lblTotalIngresos);
            this.pnlBotones.Controls.Add(this.lblFechaFin);
            this.pnlBotones.Controls.Add(this.dtFechaFin);
            this.pnlBotones.Controls.Add(this.lblFechaini);
            this.pnlBotones.Controls.Add(this.dtFechaInicio);
            this.pnlBotones.Controls.Add(this.btnDelete);
            this.pnlBotones.Controls.Add(this.btnAdd);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(705, 77);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(368, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 31);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(453, 43);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Mask.EditMask = "C2";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(376, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Total ganancia:";
            // 
            // txtGastos
            // 
            this.txtGastos.Location = new System.Drawing.Point(262, 43);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.Properties.Mask.EditMask = "C2";
            this.txtGastos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGastos.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtGastos.Properties.ReadOnly = true;
            this.txtGastos.Size = new System.Drawing.Size(100, 20);
            this.txtGastos.TabIndex = 11;
            // 
            // lblGastos
            // 
            this.lblGastos.Location = new System.Drawing.Point(193, 46);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(63, 13);
            this.lblGastos.TabIndex = 10;
            this.lblGastos.Text = "Total gastos:";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(87, 43);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Properties.Mask.EditMask = "C2";
            this.txtIngresos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIngresos.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIngresos.Properties.ReadOnly = true;
            this.txtIngresos.Size = new System.Drawing.Size(100, 20);
            this.txtIngresos.TabIndex = 9;
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.Location = new System.Drawing.Point(10, 44);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(71, 13);
            this.lblTotalIngresos.TabIndex = 6;
            this.lblTotalIngresos.Text = "Total ingresos:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Location = new System.Drawing.Point(208, 14);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(48, 13);
            this.lblFechaFin.TabIndex = 5;
            this.lblFechaFin.Text = "Fecha fin:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.EditValue = null;
            this.dtFechaFin.Location = new System.Drawing.Point(262, 11);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtFechaFin.TabIndex = 4;
            // 
            // lblFechaini
            // 
            this.lblFechaini.Location = new System.Drawing.Point(10, 14);
            this.lblFechaini.Name = "lblFechaini";
            this.lblFechaini.Size = new System.Drawing.Size(59, 13);
            this.lblFechaini.TabIndex = 3;
            this.lblFechaini.Text = "Fecha inicio:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.EditValue = null;
            this.dtFechaInicio.Location = new System.Drawing.Point(87, 11);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtFechaInicio.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(636, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 65);
            this.btnDelete.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(567, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 65);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 441);
            this.Controls.Add(this.grdPrincipal);
            this.Controls.Add(this.pnlBotones);
            this.Name = "FRM_Principal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBotones)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGastos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngresos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPrincipal;
        private DevExpress.XtraEditors.PanelControl pnlBotones;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.DateEdit dtFechaInicio;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGastos;
        private DevExpress.XtraEditors.LabelControl lblGastos;
        private DevExpress.XtraEditors.TextEdit txtIngresos;
        private DevExpress.XtraEditors.LabelControl lblTotalIngresos;
        private DevExpress.XtraEditors.LabelControl lblFechaFin;
        private DevExpress.XtraEditors.DateEdit dtFechaFin;
        private DevExpress.XtraEditors.LabelControl lblFechaini;
        private System.Windows.Forms.BindingSource principalBindingSource1;
        private System.Windows.Forms.BindingSource principalBindingSource;
        private System.Windows.Forms.BindingSource registrosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;

    }
}

