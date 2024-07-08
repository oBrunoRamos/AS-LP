public class Empresa
{
          public List<Funcionario> Funcionarios= new List<Funcionario>();

          public void AdicionaFuncionario(Funcionario funcionario)
          {
                    Funcionarios.Add(funcionario);
          }
          public void RemoveFuncionario(int nMatricula)
          {
                    Funcionarios.RemoveAll(func =>func.matricula == nMatricula);
          }
          public void ExibeFuncionarios()
          {
                    foreach (var funcionario in Funcionarios)
                    {
                              funcionario.ExibirInformacoes();
                    }
          }
}