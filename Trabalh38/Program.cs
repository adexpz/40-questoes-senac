int nasc, atual, idadeanos, idademes, idadedia, idadesema;

Console.Write("Digite o ano do nascimento: ");
nasc = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o ano atual: ");
atual = Convert.ToInt32(Console.ReadLine());

idadeanos = atual - nasc;
idademes = idadeanos * 12;
idadedia = idadeanos * 365;
idadesema = idadedia / 7;

Console.Write($"A idade em anos {idadeanos}, A idade em Dias é {idadedia}, A idade em meses {idademes}, A idade em semanas {idadesema}.");
