/// 📖 O QUE É RECURSIVIDADE?   /// ========================   /// Recursividade é uma técnica de programação onde uma função/método   /// chama a si mesma para resolver um problema.   ///   /// 🧠 CONCEITOS FUNDAMENTAIS:   /// 1. CASO BASE (Condição de parada): É a condição que interrompe as   ///    chamadas recursivas, evitando loop infinito.   ///   /// 2. CASO RECURSIVO: É onde a função chama a si mesma com um   ///    parâmetro modificado (geralmente menor).   ///   /// 3. PILHA DE CHAMADAS (Call Stack): Cada chamada recursiva é   ///    empilhada na memória até atingir o caso base.   ///   /// 💡 Analogia da vida real:   /// Imagine uma boneca russa (Matryoshka) - para chegar na boneca   /// menor, você precisa abrir a maior, depois a média, até chegar   /// na mais interna. Para voltar, você vai fechando cada uma.   ///   /// ⚠️ CUIDADOS:   /// - Sem caso base = loop infinito (StackOverflow)   /// - Muitas chamadas recursivas = estouro de pilha   /// - Recursão é mais intuitiva mas pode ser mais lenta que iteração

namespace ExercicioAula3
{
  /// <summary>
  /// 🔄 EXERCÍCIOS DE RECURSIVIDADE
  /// ===============================
  ///
  /// Exercício 1: Fatorial Simulado (Recursivo)
  /// Exercício 2: Sequência de Fibonacci (Recursivo)
  /// Exercício 3: Verificador de Palíndromo (Recursivo)
  /// </summary>
  public class Exercicio3
  {
    public void Executar()
    {
      Console.WriteLine("\n\n🔄 1. EXERCÍCIOS DE RECURSIVIDADE");
      Console.WriteLine("==================================\n");

      Console.WriteLine("📝 Exercício 2: Fatorial Recursivo");

      static long Fatorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Fatorial(n - 1);
    }

        Console.Write("Digite um número inteiro positivo: \n");
        int numero = 5;

        if (numero < 0)
        {
            Console.WriteLine("Erro: número negativo não possui fatorial.\n");
        }
        else
        {
            long resultado = Fatorial(numero);
            Console.WriteLine($"Fatorial de {numero} é: {resultado}");
        }

      Console.WriteLine();

      Console.WriteLine("\n📝 Exercício 6: Sequência de Fibonacci (Recursivo)");

      Console.Write("Digite um número inteiro positivo: \n");
        int posicao = 7;

      static long Fibonacci(int n)
      {
        if (n == 0) return 0;
        if (n == 1) return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
      }

      if (posicao < 0)
        {
            Console.WriteLine("Erro: posição negativa não é permitida.");
            return;
        }

        
        long valor = Fibonacci(posicao);
        Console.WriteLine($"\nValor na posição {posicao}: {valor}");

        
        Console.WriteLine("\nSequência até essa posição:");
        for (int i = 0; i <= posicao; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
     
      Console.WriteLine();

      // ===================================================
      // EXERCÍCIO 4: Verificador de Palíndromo (Recursivo)
      // ===================================================
      // 👉 O QUE FAZER:
      // 1. Solicitar ao usuário que digite uma palavra ou frase
      // 2. Remover espaços e converter para minúsculo (ou maiúsculo)
      // 3. Criar um método recursivo que verifica se a string é um palíndromo
      // 4. Palíndromo: palavra/frase que se lê igual de trás pra frente
      // 5. Caso base: se string tem 0 ou 1 caractere, retornar true
      // 6. Caso base: se primeiro e último caracteres são diferentes, retornar false
      // 7. Caso recursivo: verificar substring sem primeiro e último caracteres
      // 8. Exibir se a palavra/frase é ou não um palíndromo
      // 9. Ignorar acentos e caracteres especiais (opcional)
      //
      // 💡 Exemplos: "radar", "reviver", "socorram me subi no onibus em marrocos"
      // 💡 "A man, a plan, a canal: panama"

      Console.WriteLine("\n📝 Exercício 7: Verificador de Palíndromo (Recursivo)");

      // ESCREVA SEU CÓDIGO AQUI
      // Saída esperada:
      /**📝 Exercício 4: Verificador de Palíndromo (Recursivo)
      Digite uma palavra ou frase: radar
      "radar" É um palíndromo!
     
      Digite uma palavra ou frase: programa
      "programa" NÃO é um palíndromo!
     
      Digite uma palavra ou frase: Socorram me subi no onibus em marrocos
      "socorram me subi no onibus em marrocos" É um palíndromo!
      */
      Console.WriteLine();


    }
  }
}