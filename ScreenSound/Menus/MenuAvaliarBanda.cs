using ScreenSound.Modelos;
using System.Threading.Channels;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            // Banda banda = bandaRegistradas[nomeDaBanda]; Instancia a banda 
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            // banda.AdicionarNota(nota); Adiciona nota a banda instanciada 
            Console.WriteLine($"\nShow!! A nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nOps!! A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
