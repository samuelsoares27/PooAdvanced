using PooAdvanced;

AnalistaTi analistaTi = new();
analistaTi.AdicionarNome("Teste 1", "teste 1");
analistaTi.AdicionarSalarioPadrao(1000);

Console.WriteLine($"Salário do Analista de TI: {analistaTi.Salario}");
analistaTi.Reajustar();
Console.WriteLine($"Salário do Analista de TI Reajustado: {analistaTi.Salario}");
Console.WriteLine($"___________________________________________________________");

Gerente gerente = new();
gerente.AdicionarNome("Teste 2", "teste 2");
gerente.AdicionarSalarioPadrao(2000);

Console.WriteLine($"Salário do Gerente: {gerente.Salario}");
gerente.Reajustar();
Console.WriteLine($"Salário do Gerente Reajustado: {gerente.Salario}");
Console.WriteLine($"___________________________________________________________");

GerenteDeAgencia gerenteDeAgencia = new();
gerenteDeAgencia.AdicionarNome("Teste 3", "teste 3");
gerenteDeAgencia.AdicionarSalarioPadrao(3000);

Console.WriteLine($"Salário do Gerente de Agencia: {gerenteDeAgencia.Salario}");
gerenteDeAgencia.Reajustar();
Console.WriteLine($"Salário do Gerente de Agencia Reajustado: {gerenteDeAgencia.Salario}");
Console.WriteLine($"___________________________________________________________");

GerenteDeTi gerenteDeTi = new();
gerenteDeTi.AdicionarNome("Teste 4", "teste 4");
gerenteDeTi.AdicionarSalarioPadrao(4000);

Console.WriteLine($"Salário do Gerente de TI: {gerenteDeTi.Salario}");
gerenteDeTi.Reajustar();
Console.WriteLine($"Salário do Gerente de TI Reajustado: {gerenteDeTi.Salario}");
Console.WriteLine($"___________________________________________________________");


