

using ModificadorParams;

int s1 = Calculator.Sum(1, 2, 5, 9);
int s2 = Calculator.Sum(2, 5, 6, 8);

Console.WriteLine(s1 + ", " + s2);

// A ideia aqui é usar o modificador "params" no construtor de Sum, para não precisar
// instanciar o método toda vez que for usar (seria algo como:
// int s1 = Calculator.Sum(new int[] {1, 2, 4})
// Na classe original teríamos o mesmo parâmetro, porém sem o "params"
// O Params é a maneira dinâmica mais correta, torna o código mais reutilizável e menos verboso.