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
            new Pergunta
            {
                Id = 6,
                Enunciado = "O violoncelo é um tipo de instrumento de?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "CORDAS"},
                    new Alternativa { Correta = false, Descricao = "SOPRO"},
                    new Alternativa { Correta = false, Descricao = "PERCUSSÃO"},
                    new Alternativa { Correta = false, Descricao = "REPERCUSSÃO"},
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Quantos dias tem um ano bissexto?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "364"},
                    new Alternativa { Correta = false, Descricao = "365"},
                    new Alternativa { Correta = true, Descricao = "366"},
                    new Alternativa { Correta = false, Descricao = "367"},
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Qual cantor ficou conhecido como “o rei do rock”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FRANK SINATRA"},
                    new Alternativa { Correta = false, Descricao = "LITTLE RICHARD"},
                    new Alternativa { Correta = true, Descricao = "ELVIS PRESLEY"},
                    new Alternativa { Correta = false, Descricao = "RICHIE VALENS"},
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Qual cantor é o pai da dupla Sandy e Júnior?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ZEZÉ DI CAMARGO"},
                    new Alternativa { Correta = false, Descricao = "LEONARDO"},
                    new Alternativa { Correta = false, Descricao = "CHITÃOZINHO"},
                    new Alternativa { Correta = true, Descricao = "XORORÓ"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARANÁ"},
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa { Correta = false, Descricao = "SÃO PAULO"},
                    new Alternativa { Correta = true, Descricao = "BAHIA"},
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Capixaba é quem nasce em qual estado brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ESPÍRITO SANTO"},
                    new Alternativa { Correta = false, Descricao = "RIO GRANDE DO NORTE"},
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa { Correta = false, Descricao = "PARANÁ"},
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "O dromedário tem quantas corcovas?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "UMA"},
                    new Alternativa { Correta = false, Descricao = "DUAS"},
                    new Alternativa { Correta = false, Descricao = "TRÊS"},
                    new Alternativa { Correta = false, Descricao = "NENHUMA"},
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ROMEU"},
                    new Alternativa { Correta = false, Descricao = "ORFEU"},
                    new Alternativa { Correta = false, Descricao = "HAMLET"},
                    new Alternativa { Correta = false, Descricao = "IAGO"},
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "O churrasco é considerado uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CEARÁ"},
                    new Alternativa { Correta = true, Descricao = "RIO GRANDE DO SUL"},
                    new Alternativa { Correta = false, Descricao = "RIO DE JANEIRO"},
                    new Alternativa { Correta = false, Descricao = "MARANHÃO"},
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARK ZUCKERBERG"},
                    new Alternativa { Correta = false, Descricao = "ELON MUSK"},
                    new Alternativa { Correta = true, Descricao = "BILL GATES"},
                    new Alternativa { Correta = false, Descricao = "AKIO MORITA"},
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Quantos centavos equivalem a um real?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DEZ"},
                    new Alternativa { Correta = false, Descricao = "CINQUENTA"},
                    new Alternativa { Correta = true, Descricao = "CEM"},
                    new Alternativa { Correta = false, Descricao = "MIL"},
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Um adulto sadio tem quantos dentes na boca?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "18"},
                    new Alternativa { Correta = false, Descricao = "24"},
                    new Alternativa { Correta = true, Descricao = "32"},
                    new Alternativa { Correta = false, Descricao = "36"},
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual é a área da medicina que trata de crianças?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "GERIATRIA"},
                    new Alternativa { Correta = true, Descricao = "PEDIATRIA"},
                    new Alternativa { Correta = false, Descricao = "INFANTOLOGIA"},
                    new Alternativa { Correta = false, Descricao = "PSIQUIATRIA"},
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "O que é medido por um termômetro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LONGITUDE"},
                    new Alternativa { Correta = false, Descricao = "METRAGEM"},
                    new Alternativa { Correta = true, Descricao = "TEMPERATURA"},
                    new Alternativa { Correta = false, Descricao = "LATITUDE"},
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Qual foi o nome dado ao movimento liderado por Tiradentes?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "REVOLUÇÃO FRANCESA"},
                    new Alternativa { Correta = false, Descricao = "GUERRA DOS EMBOABAS"},
                    new Alternativa { Correta = false, Descricao = "GUERRA DE CANUDOS"},
                    new Alternativa { Correta = true, Descricao = "INCONFIDÊNCIA MINEIRA"},
                }
            },
        };

        List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Que planta era usada para fabricação de papel no antigo Egito?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "PAPIRO"},
                    new Alternativa { Correta = false, Descricao = "EUCALIPTO"},
                    new Alternativa { Correta = false, Descricao = "OLIVEIRA" },
                    new Alternativa { Correta = false, Descricao = "MILHO" },
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Quem é o parceiro de aventuras de Dom Quixote?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "LANCELOT"},
                    new Alternativa { Correta = false, Descricao = "SIGMUND FREUD"},
                    new Alternativa { Correta = true, Descricao = "SANCHO PANÇA" },
                    new Alternativa { Correta = false, Descricao = "GUILHERME TELL" },
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "ESPANHA"},
                    new Alternativa { Correta = false, Descricao = "ITÁLIA"},
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ALEMANHA" },
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Às margens de que riacho foi proclamada a Independência do Brasil?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "CAMBUCI"},
                    new Alternativa { Correta = false, Descricao = "AMAZONAS"},
                    new Alternativa { Correta = true, Descricao = "IPIRANGA" },
                    new Alternativa { Correta = false, Descricao = "SÃO FRANCISCO" },
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Em que continente se situa o rio Nilo?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "EUROPEU"},
                    new Alternativa { Correta = true, Descricao = "AFRICANO"},
                    new Alternativa { Correta = false, Descricao = "AMERICANO" },
                    new Alternativa { Correta = false, Descricao = "ASIÁTICO" },
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "O que leva o sangue do coração para o corpo?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "VEIAS"},
                    new Alternativa { Correta = false, Descricao = "MÚSCULOS"},
                    new Alternativa { Correta = true, Descricao = "ARTÉRIAS" },
                    new Alternativa { Correta = false, Descricao = "OSSOS" },
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Como é chamado o templo sagrado dos judeus?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "IGREJA"},
                    new Alternativa { Correta = false, Descricao = "CAPELA"},
                    new Alternativa { Correta = false, Descricao = "CATEDRAL" },
                    new Alternativa { Correta = true, Descricao = "SINAGOGA" },
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Qual é o dia da Padroeira do Brasil?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "12 DE OUTUBRO"},
                    new Alternativa { Correta = false, Descricao = "12 DE NOVEMBRO"},
                    new Alternativa { Correta = false, Descricao = "11 DE DEZEMBRO" },
                    new Alternativa { Correta = false, Descricao = "1 DE JANEIRO" },
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "O daltônico é deficiente em?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "SENTIR DOR"},
                    new Alternativa { Correta = false, Descricao = "SENTIR PALADAR"},
                    new Alternativa { Correta = true, Descricao = "DIFERENCIAR CORES" },
                    new Alternativa { Correta = false, Descricao = "SENTIR CHEIRO" },
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Qual foi o último imperador do Brasil?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "D.PEDRO I"},
                    new Alternativa { Correta = true, Descricao = "D.PEDRO II"},
                    new Alternativa { Correta = false, Descricao = "D.JOÃO VI" },
                    new Alternativa { Correta = false, Descricao = "DEODORO DA FONSECA" },
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Que animal é usado no jogo de pólo?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "CAMELO"},
                    new Alternativa { Correta = true, Descricao = "CAVALO"},
                    new Alternativa { Correta = false, Descricao = "MACACO" },
                    new Alternativa { Correta = false, Descricao = "CACHORRO" },
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Qual é o médico que mais utiliza o eletrocardiograma?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ORTOPEDISTA"},
                    new Alternativa { Correta = false, Descricao = "NEUROLOGISTA"},
                    new Alternativa { Correta = false, Descricao = "DERMATOLOGISTA" },
                    new Alternativa { Correta = true, Descricao = "CARDIOLOGISTA" },
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é o médico que mais utiliza o eletrocardiograma?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ORTOPEDISTA"},
                    new Alternativa { Correta = false, Descricao = "NEUROLOGISTA"},
                    new Alternativa { Correta = false, Descricao = "DERMATOLOGISTA" },
                    new Alternativa { Correta = true, Descricao = "CARDIOLOGISTA" },
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
