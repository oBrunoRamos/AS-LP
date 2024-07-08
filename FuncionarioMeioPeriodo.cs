public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
          private double salarioHora;
          private double horasTrabalhadas;
          public FuncionarioMeioPeriodo(string nome, int matricula,double salarioHora,double horasTrabalhadas):base(nome, matricula)
          {
                    this.nome = nome;
                    this.matricula = matricula;
                    this.salarioHora = salarioHora;
                    this.horasTrabalhadas = horasTrabalhadas;
          }

          public override double CalcularSalario()
          {
                   double salario =  salarioHora * horasTrabalhadas;
                   return salario;
          }
          public override void ExibirInformacoes()
          {
                    Console.WriteLine($"Nome do Funcionário: {nome} \nN° da Matricula: {matricula} \nSalario Mensal: R${CalcularSalario()}\nHoras trabalhadas: {horasTrabalhadas}");
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
                    double salario = CalcularSalario();
                    return salario * 0.05;
          }
}