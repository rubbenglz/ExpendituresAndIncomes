using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Linq;
//using System.Security.Cryptography;

namespace Conexion.Entities
{
    public class WalsRemisionFactura
    {
        public virtual string Compania { get; set; }
        public virtual decimal IdPedido { get; set; }
        public virtual string TipoOrden { get; set; }
        public virtual string Dias { get; set; }
        public virtual string Plazo { get; set; }
        public virtual string FormaPago { get; set; }
        public virtual string OrdenCompra { get; set; }
        public virtual string URLPDF {get; set; }

        public virtual byte[] _archivoPDF {get; set; }

        public virtual byte[] ArchivoPDF
        {
            get {
                if (string.IsNullOrEmpty(this.URLPDF))
                    return new byte[]{0};
                else
                {
                    ObtenerArchivo(this.URLPDF);
                    return _archivoPDF;
                }
            }
            set { _archivoPDF = value; }
        }

        private void ObtenerArchivo(string strFilename)
        {
            try
            {                
                byte[] bRet = new System.Net.WebClient().DownloadData(strFilename);

                if (bRet.Count() > 0)
                    this._archivoPDF = bRet.ToArray();
                else
                    this._archivoPDF = new byte[]{0};
            }
            catch (Exception)
            {
                this._archivoPDF = new byte[]{0};
            }
        }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as WalsRemisionFactura;
            if (t == null) return false;
            if (Compania == t.Compania
             && IdPedido == t.IdPedido
             && TipoOrden == t.TipoOrden)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Compania.GetHashCode();
            hash = (hash * 397) ^ IdPedido.GetHashCode();
            hash = (hash * 397) ^ TipoOrden.GetHashCode();

            return hash;
        }
        #endregion
    }
}
