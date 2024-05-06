using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaViagemValida()
        {;
            //Cen�rio
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 3, 1));
            double preco = 100.0;
            var validacao = true;

            //A��o
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //Valida��o do teste
            Assert.Equal(validacao, oferta.EhValido);
        }

        [Fact]
        public void TestandoOfertaViagemComRotaNula()
        {
           
            //Cen�rio
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 3, 1));
            double preco = 100.0;
         

            //A��o 
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            Assert.Contains("A oferta de viagem n�o possui rota ou per�odo v�lidos.", oferta.Erros.Sumario);
            Assert.False(oferta.EhValido);
        }
    }
}