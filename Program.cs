//Aprendendo a usar strings

string cidade = "Itanhaém";
string estado = "SP";
string cidadeComEstado = $"Minha escola fica em {cidade} / {estado.ToUpper()}.";

Console.WriteLine(cidadeComEstado);

// \n quebra de linha
// @ desliga os comandos "ocultos"
// \\ indica que voce quer usar uma unica barra
// \"\" mostra aspas dentro da string 
// $ template de string
// f2 modifica o nome de alguma variável