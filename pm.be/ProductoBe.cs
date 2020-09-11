using pm.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ProductoBe : BaseAuditoria
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public int CodigoUnidadMedida { get; set; }
        public UnidadMedidaBe UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal DescuentoMaximo { get; set; }
        public string Color { get; set; }
        public decimal MetrajeTotal { get; set; }
        public int Estado { get; set; }
        public string EstadoStr
        {
            get
            {
                Enums.EstadoProducto value = (Enums.EstadoProducto)Estado;

                bool isValid = value == (Enums.EstadoProducto)Estado;

                string text = !isValid ? null : value.GetAttributeOfType<DescriptionAttribute>().Description;

                return text;
            }
        }
        public override string ToString() => Nombre;
    }
}
