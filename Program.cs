var faturamentoAnual = Enumerable.Range(0, 366)
    .Select(i => Random.Shared.Next(0, 100000) / 100d)
    .ToArray();

var faturamentoComValores = faturamentoAnual.Where(i => i > 0).ToArray();

var menorValorFaturamento = faturamentoComValores.Min(); 
var maiorValorFaturamento = faturamentoComValores.Max();
var mediaValorFaturamento = faturamentoComValores.Average();

var numeroDiasComFaturamentoMaiorQueAMedia = faturamentoComValores.Count(i => i > mediaValorFaturamento);

Console.WriteLine("Menor faturamento do ano: {0:F2}", menorValorFaturamento);
Console.WriteLine("Maior faturamento do ano: {0:F2}", maiorValorFaturamento);
Console.WriteLine("Dias com faturamento acima da média: {0}", numeroDiasComFaturamentoMaiorQueAMedia);
