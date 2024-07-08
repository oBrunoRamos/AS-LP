public abstract class Funcionario
{
          public string? nome;
          public int matricula;
          public List<string> Projetos = new List<string>();

          public Funcionario(string nome, int matricula)
          {
                    this.nome = nome;
                    this.matricula = matricula;
          }

          public abstract double CalcularSalario();
          public abstract void ExibirInformacoes();
          public void AdicionaProjeto(string projeto)
          {
                    Projetos.Add(projeto);
          }
          public void AdicionaProjeto(List<string> projetos)
          {
                    foreach (var projeto in projetos)
                    {
                              Projetos.Add(projeto);
                    }
          }

}