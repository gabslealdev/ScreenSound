using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Obrigado por acessar a ScreenSound!!");
    }
}
