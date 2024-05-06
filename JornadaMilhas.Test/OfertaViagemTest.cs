using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaViagemValida()
        {;
            //Cenário
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 3, 1));
            double preco = 100.0;
            var validacao = true;

            //Ação
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //Validação do teste
            Assert.Equal(validacao, oferta.EhValido);
        }

        [Fact]
        public void TestandoOfertaViagemComRotaNula()
        {
           
            //Cenário
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 3, 1));
            double preco = 100.0;
         

            //Ação 
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            Assert.Contains("A oferta de viagem não possui rota ou período válidos.", oferta.Erros.Sumario);
            Assert.False(oferta.EhValido);
        }
    }
}