namespace pm.be
{
    public class TipoDocumentoPagoBe : BaseAuditoria
    {
        public int CodigoTipoDocumentoPago { get; set; }
        public string Descripcion { get; set; }
        public override string ToString() => Descripcion;
    }
}