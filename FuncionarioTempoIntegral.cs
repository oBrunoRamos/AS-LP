public class FuncionarioTempoIntegral : Funcionario, IBonus
{
          private double salarioMensal;
          public FuncionarioTempoIntegral(string nome, int matricula,double salarioMensal):base(nome, matricula)
          {
                    this.nome = nome;
                    this.matricula = matricula;
                    this.salarioMensal = salarioMensal;
          }

          public override double CalcularSalario()
          {
                    throw new NotImplementedException();
          }
          public override void ExibirInformacoes()
          {
                    Console.WriteLine($"Nome do Funcionário: {nome} \nN° da Matricula: {matricula} \nSalario Mensal: R${salarioMensal}");
                    if(Projetos.Count > 0)
                    {
                              Console.WriteLine("Projetos:");
                              foreach (var projeto in Projetos)
                              {
                                        Console.WriteLine($"  {projeto.Trim().ToUpper()}");
                              }
                    }
                    else
                    {
                              Console.WriteLine("Projetos: Nenhum projeto registrado");
                    }                                                  
          }
          public double CalcularBonus()
          {
                    double bonus = this.salarioMensal * 0.10;
                    return bonus;
          }
}