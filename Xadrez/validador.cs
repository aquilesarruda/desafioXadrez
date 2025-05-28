using System;

public static class ValidadorDeMovimento
{
    public static bool Validar(string peca, string de, string para)
    {
        var (x1, y1) = ConverterPosicao(de);
        var (x2, y2) = ConverterPosicao(para);

        int dx = Math.Abs(x2 - x1);
        int dy = Math.Abs(y2 - y1);

        return peca switch
        {
            "torre" => dx == 0 || dy == 0,
            "bispo" => dx == dy,
            "cavalo" => (dx == 2 && dy == 1) || (dx == 1 && dy == 2),
            _ => false
        };
    }

    private static (int, int) ConverterPosicao(string pos)
    {
        int x = pos[0] - 'a';     // a = 0, b = 1, ...
        int y = int.Parse(pos[1].ToString()) - 1; // 1 = 0, 2 = 1, ...
        return (x, y);
    }
}
