using ControleDgn.Models.Enums;

namespace ControleDgn.Models
{
    public class Padrao
    {
        public int PadraoId { get; set; }
        public string Tag { get; set; }
        public string Certificado { get; set; }
        public DateTime DataCal { get; set; }
        public TimeSpan Frequencia { get; set; }
        public DateTime ProxCal => DataCal.Add(Frequencia);
        public double ValorNominal { get; set; }
        public StatusPadrao Status { get; set; }



    }
}
