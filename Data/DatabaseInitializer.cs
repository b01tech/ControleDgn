using ControleDgn.Models;
using ControleDgn.Models.Enums;

namespace ControleDgn.Data
{
    internal class DatabaseInitializer
    {
        public void InitDb(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Padrao.Any()) 
            {
                return;
            }

            var data = new[]
            {
                new Padrao{
                    Tag="MP-01", Certificado="123-2020", DataCal=DateTime.Parse("01/02/2020"), Frequencia=TimeSpan.FromDays(730), Status=StatusPadrao.Vigente, ValorNominal=500.00},
                new Padrao{
                    Tag="MP-02", Certificado="123-2020", DataCal=DateTime.Parse("01/02/2020"), Frequencia=TimeSpan.FromDays(730), Status=StatusPadrao.Vigente, ValorNominal=500.01},
                new Padrao{
                    Tag="MP-03", Certificado="123-2020", DataCal=DateTime.Parse("01/02/2020"), Frequencia=TimeSpan.FromDays(730), Status=StatusPadrao.ForaUso, ValorNominal=500.05},
                new Padrao{
                    Tag="MP-04", Certificado="456-2022", DataCal=DateTime.Parse("15/07/2022"), Frequencia=TimeSpan.FromDays(730), Status=StatusPadrao.Vigente, ValorNominal=100.02},
                 new Padrao{
                    Tag="MP-05", Certificado="456-2022", DataCal=DateTime.Parse("15/07/2022"), Frequencia=TimeSpan.FromDays(730), Status=StatusPadrao.Vigente, ValorNominal=100.04}

            };


            context.AddRange(data);
            context.SaveChanges();
        
        }
    }
}
