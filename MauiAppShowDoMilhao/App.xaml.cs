using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa { Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa { Correta = false, Descricao = "GASOSO"},
                    new Alternativa { Correta = false, Descricao = "VAPOROSO"},
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é a moeda oficial dos Estados Unidos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ESCUDO"},
                    new Alternativa { Correta = false, Descricao = "COROA"},
                    new Alternativa { Correta = true, Descricao = "DÓLAR"},
                    new Alternativa { Correta = false, Descricao = "LIBRA"},
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "21 DE ABRIL"},
                    new Alternativa { Correta = false, Descricao = "12 DE OUTUBRO"},
                    new Alternativa { Correta = true, Descricao = "7 DE SETEMBRO"},
                    new Alternativa { Correta = false, Descricao = "25 DE DEZEMBRO"},
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem foi o criador dos personagens Pedrinho, Narizinho e Emília?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAURÍCIO DE SOUSA"},
                    new Alternativa { Correta = false, Descricao = "ZIRALDO"},
                    new Alternativa { Correta = false, Descricao = "MACHADO DE ASSIS"},
                    new Alternativa { Correta = true, Descricao = "MONTEIRO LOBATO"},
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Em que ano os portugueses descobriram o Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1450"},
                    new Alternativa { Correta = true, Descricao = "1500"},
                    new Alternativa { Correta = false, Descricao = "1550"},
                    new Alternativa { Correta = false, Descricao = "1400"},
                }
            },

        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
