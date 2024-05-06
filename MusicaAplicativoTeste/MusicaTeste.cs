using MusicaAplicativo;

namespace MusicaAplicativoTeste
{
    public class MusicaTeste
    {
        [Fact]
        public void MusicaTesteValidarNomeMusica()
        {

            //Given ou Arrange
            Musica musica = new Musica();

            //When ou  Action
            musica.Nome = "Jonge ben jor";

            //Assert ou Then
           Assert.Equal("Jonge ben jor", musica.Nome);


        }


        [Fact]
        public void MusicaTesteValidarFichaTecnica()
        {
            //Given ou Arrange
            string nome = "Música Teste";
            int id = 13;

            Musica musica = new Musica(nome) { Id = id };

            Assert.Equal(id, musica.Id);
        }

        [Fact]
        public void MusicaTesteValidarIdentificadorDeMusica()
        {

            //Given ou Arrange
            Musica musica = new Musica();

            //When ou  Action
            musica.Nome = "Jonge ben jor";
            musica.Id = 1;


            var musicaIdentificador = musica.ToString();
            //Assert ou Then
            Assert.Equal("Id: 1 Nome: Jonge ben jor", musicaIdentificador);


        }
    }
}