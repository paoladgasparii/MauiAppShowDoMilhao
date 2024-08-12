﻿using MauiAppShowDoMilhao.Models;

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
                Enunciado = "O FBI é a polícia federal de qual país?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "INGLATERRA"},
                    new Alternativa { Correta = true, Descricao = "ESTADOS UNIDOS"},
                    new Alternativa { Correta = false, Descricao = "CANADÁ" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "PARIS"},
                    new Alternativa { Correta = false, Descricao = "COPENHAGUE"},
                    new Alternativa { Correta = true, Descricao = "ROMA" },
                    new Alternativa { Correta = false, Descricao = "LONDRES" },
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Qual é o ponto mais alto da Terra?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "MONTE EVEREST"},
                    new Alternativa { Correta = false, Descricao = "MONTE SINAI"},
                    new Alternativa { Correta = false, Descricao = "MONTE CASTELO" },
                    new Alternativa { Correta = false, Descricao = "MONT BLANC" },
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Qual é a raça do personagem principal do filme “Beethoven”?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "FILA"},
                    new Alternativa { Correta = false, Descricao = "PASTOR ALEMÃO"},
                    new Alternativa { Correta = false, Descricao = "POODLE" },
                    new Alternativa { Correta = true, Descricao = "SÃO BERNARDO" },
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Qual é a sigla da Organização das Nações Unidas?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "ONU"},
                    new Alternativa { Correta = false, Descricao = "FMI"},
                    new Alternativa { Correta = false, Descricao = "CIA" },
                    new Alternativa { Correta = false, Descricao = "OTAN" },
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Como é chamada a doença que causa perda desigual da melanina?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ASTIGMATISMO"},
                    new Alternativa { Correta = false, Descricao = "TENDINITE"},
                    new Alternativa { Correta = true, Descricao = "VITILIGO" },
                    new Alternativa { Correta = false, Descricao = "DALTONISMO" },
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "BILL"},
                    new Alternativa { Correta = true, Descricao = "CLYDE"},
                    new Alternativa { Correta = false, Descricao = "JAMES" },
                    new Alternativa { Correta = false, Descricao = "BUTCH" },
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Qual dessas cobras não é venenosa?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "URUTU"},
                    new Alternativa { Correta = false, Descricao = "CASCAVEL"},
                    new Alternativa { Correta = false, Descricao = "JARARACA" },
                    new Alternativa { Correta = true, Descricao = "PÍTON" },
                }
            },
        };
        List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "POLÔNIA"},
                    new Alternativa { Correta = false, Descricao = "FRANÇA"},
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = true, Descricao = "HOLANDA" },
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual desses países não fica na Ásia?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "PAQUISTÃO"},
                    new Alternativa { Correta = false, Descricao = "JAPÃO"},
                    new Alternativa { Correta = false, Descricao = "TAILÂNDIA" },
                    new Alternativa { Correta = true, Descricao = "EGITO" },
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual é a primeira letra do alfabeto grego?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "DELTA"},
                    new Alternativa { Correta = false, Descricao = "BETA"},
                    new Alternativa { Correta = true, Descricao = "ALFA" },
                    new Alternativa { Correta = false, Descricao = "GAMA" },
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "BERLIM"},
                    new Alternativa { Correta = true, Descricao = "NUREMBERGUE"},
                    new Alternativa { Correta = false, Descricao = "MUNIQUE" },
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Que ramo da pecuária ocupase de bodes e cabras?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ASININO"},
                    new Alternativa { Correta = true, Descricao = "CAPRINO"},
                    new Alternativa { Correta = false, Descricao = "BUFALINO" },
                    new Alternativa { Correta = false, Descricao = "MUAR" },
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Que conflito ideológico envolveu os EUA e a União Soviética?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "GUERRA FRIA"},
                    new Alternativa { Correta = false, Descricao = "GUERRA DO VIETNÃ"},
                    new Alternativa { Correta = false, Descricao = "GUERRA NAS ESTRELAS" },
                    new Alternativa { Correta = false, Descricao = "GUERRA DA CORÉIA" },
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Qual produto gerou guerras e conflitos no século XX?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ÁLCOOL"},
                    new Alternativa { Correta = true, Descricao = "PETRÓLEO"},
                    new Alternativa { Correta = false, Descricao = "OURO" },
                    new Alternativa { Correta = false, Descricao = "ALUMÍNIO" },
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Como é chamada a bola de gelo e poeira que orbita em torno do sol?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "METEORITO"},
                    new Alternativa { Correta = false, Descricao = "ESTRELA D’ALVA"},
                    new Alternativa { Correta = false, Descricao = "CAMADA DE OZÔNIO" },
                    new Alternativa { Correta = true, Descricao = "COMETA" },
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Que figura mitológica é conhecida por sua força extraordinária?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ÁTILA"},
                    new Alternativa { Correta = false, Descricao = "MINOTAURO"},
                    new Alternativa { Correta = false, Descricao = "PERSEU" },
                    new Alternativa { Correta = true, Descricao = "HÉRCULES" },
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Que símbolo está desenhado no centro da bandeira Argentina?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "SOL"},
                    new Alternativa { Correta = false, Descricao = "LUA"},
                    new Alternativa { Correta = false, Descricao = "ESTRELA" },
                    new Alternativa { Correta = false, Descricao = "FOICE E MARTELO" },
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Quem construiu o primeiro telescópio astronômico completo?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "CYRUS MCCORMICK"},
                    new Alternativa { Correta = false, Descricao = "THOMAS EDISON"},
                    new Alternativa { Correta = false, Descricao = "MICHELANGELO" },
                    new Alternativa { Correta = true, Descricao = "GALILEU GALILEI" },
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Em que ano foi inaugurada a estátua do Cristo Redentor no Rio de Janeiro?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "1921"},
                    new Alternativa { Correta = true, Descricao = "1931"},
                    new Alternativa { Correta = false, Descricao = "1941" },
                    new Alternativa { Correta = false, Descricao = "1951" },
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é o exame que emite ondas sonoras para visualizar os órgãos?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "XEROGRAFIA"},
                    new Alternativa { Correta = false, Descricao = "RADIOGRAFIA"},
                    new Alternativa { Correta = true, Descricao = "ULTRA-SONOGRAFIA" },
                    new Alternativa { Correta = false, Descricao = "FOTOGRAFIA" },
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Quem escreveu “Dom Quixote”?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ESPINOZA"},
                    new Alternativa { Correta = true, Descricao = "MIGUEL DE CERVANTES"},
                    new Alternativa { Correta = false, Descricao = "CARLOS CONTE" },
                    new Alternativa { Correta = false, Descricao = "ANGEL MORITA" },
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Qual é o quarto planeta do sistema solar?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "JÚPITER"},
                    new Alternativa { Correta = false, Descricao = "VÊNUS"},
                    new Alternativa { Correta = false, Descricao = "TERRA" },
                    new Alternativa { Correta = true, Descricao = "MARTE" },
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "A que país pertence a Groenlândia?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = true, Descricao = "DINAMARCA"},
                    new Alternativa { Correta = false, Descricao = "INGLATERRA"},
                    new Alternativa { Correta = false, Descricao = "NORUEGA" },
                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS" },
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Pablo Picasso foi um dos criadores do:",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "SURREALISMO"},
                    new Alternativa { Correta = false, Descricao = "REALISMO"},
                    new Alternativa { Correta = true, Descricao = "CUBISMO" },
                    new Alternativa { Correta = false, Descricao = "IMPRESSIONISMO" },
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual foi o primeiro presidente do Brasil eleito pelo povo?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "GETÚLIO VARGAS"},
                    new Alternativa { Correta = true, Descricao = "PRUDENTE DE MORAES"},
                    new Alternativa { Correta = false, Descricao = "WASHINGTON LUÍS" },
                    new Alternativa { Correta = false, Descricao = "TANCREDO NEVES" },
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Como o rei francês Luis XVI e sua esposa Maria Antonieta morreram?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "ENFORCADOS"},
                    new Alternativa { Correta = false, Descricao = "FUZILADOS"},
                    new Alternativa { Correta = true, Descricao = "GUILHOTINADOS" },
                    new Alternativa { Correta = false, Descricao = "QUEIMADOS" },
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Como é chamada a gravura impressa sobre pranchas de madeira?",
                Alternativas = new ()
                {
                    new Alternativa { Correta = false, Descricao = "MATEROGRAFIA"},
                    new Alternativa { Correta = false, Descricao = "LITOGRAFIA"},
                    new Alternativa { Correta = true, Descricao = "XILOGRAFIA" },
                    new Alternativa { Correta = false, Descricao = "SERIGRAFIA" },
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
