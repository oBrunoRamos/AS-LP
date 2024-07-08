bool ContemFuncionario(int matricula, Empresa empresa)
{
          foreach (var funcionario in empresa.Funcionarios)
          {
                    if(funcionario.matricula == matricula)
                    {
                              return true;
                    }
          }
          return false;     
}
bool VerificaVazio(string variavel)
{
          if(variavel == "" || variavel == null)
          {
                    Console.WriteLine("\nDesculpe, este argumento deve conter pelomenos um caractere\n\n\n");
                    return true;
          }
          else
                    return false;
}
bool VerificaZero(double numero)
{
          if (numero == 0)
          {
                    Console.WriteLine("\nDesculpe, esse argumento não aceita o número zero. Digite outro número. \n\n");
                    return true;
          }
          else
                    return false;
}

Empresa e1 = new Empresa();

int escolha;
bool acabarLoop = false;

while (true)
{         
          Console.WriteLine($"\n\nOque você deseja fazer: \n\n 1 - Adicionar um funcionário de tempo integral \n 2 - Adicionar um funcionário de meio período \n 3 - Remover um funcionário \n 4 - Exibir informações de todos os funcionários \n 5 - Adicionar projeto(s) a um funcionário \n 6 - Sair do programa\n");
          string? resp = Convert.ToString(Console.ReadLine());
          escolha = Convert.ToInt32(resp);
          if (escolha == 1 || escolha == 2 || escolha == 3 || escolha == 4 || escolha == 5 || escolha == 6){}
          else
          {
                    Console.WriteLine("\n\nNão entendi a opção escolhida. Poderia tentar novamente?\n\n");
                    continue;
          }


          switch(escolha)
          {
                    case 1:
                              string nome;
                              int matricula;
                              double salario;

                              while (true)
                              {
                                        Console.WriteLine("\nDigite o nome do novo funcionário:");
                                        nome = Console.ReadLine();
                                        if (VerificaVazio(nome) == false)
                                                  break;

                              }
                              while (true)
                              {
                                        Console.WriteLine($"Digite o número da matricula de {nome}:");
                                        matricula = Convert.ToInt32(Console.ReadLine());
                                        if (VerificaZero(Convert.ToDouble(matricula)) == false)
                                        {
                                                  if(ContemFuncionario(matricula, e1))
                                                  {
                                                            Console.WriteLine("\nUm funcionário com essa matricula já existe. Digite outro número.\n");
                                                  }
                                                  else
                                                  {
                                                            break;
                                                  }
                                        }
                                        
                              }
                              while(true)
                              {
                                        Console.WriteLine($"Digite o salário mensal de {nome}:");
                                        salario = Convert.ToDouble(Console.ReadLine());
                                        if (VerificaZero(Convert.ToDouble(salario)) == false)
                                                  break;
                                        
                              }
                              
                              e1.Funcionarios.Add(new FuncionarioTempoIntegral(nome, matricula, salario));

                              Console.WriteLine("\n\nCadastro realizado com sucesso");

                              Console.WriteLine("\n\nAperte em qualquer tecla para continuar");
                              Console.ReadKey();
                    break;
                    case 2:
                              string nomeFMP;
                              int matriculaFMP;
                              double salarioFMP;
                              double horasFMP;

                              while (true)
                              {
                                        Console.WriteLine("\nDigite o nome do novo funcionário:");
                                        nomeFMP = Console.ReadLine();
                                        if (VerificaVazio(nomeFMP) == false)
                                                  break;

                              }
                              while (true)
                              {
                                        Console.WriteLine($"Digite o número da matricula de {nomeFMP}:");
                                        matriculaFMP = Convert.ToInt32(Console.ReadLine());
                                        if (VerificaZero(Convert.ToDouble(matriculaFMP)) == false)
                                        {
                                                  if(ContemFuncionario(matriculaFMP, e1))
                                                  {
                                                            Console.WriteLine("\nUm funcionário com essa matricula já existe. Digite outro número.\n");
                                                            continue;
                                                  }
                                                  else
                                                  {
                                                            break;
                                                  }
                                        }
                              }
                              while(true)
                              {
                                        Console.WriteLine($"Digite o salário por hora de {nomeFMP}:");
                                        salarioFMP = Convert.ToDouble(Console.ReadLine());
                                        if(VerificaZero(salarioFMP) == false)
                                                  break;
                              }
                              while(true)
                              {
                                        Console.WriteLine($"Digite as horas trabalhadas de {nomeFMP}:");
                                        horasFMP = Convert.ToDouble(Console.ReadLine());
                                        if(VerificaZero(horasFMP) == false)
                                                  break;
                                        
                              }
                              
                              e1.Funcionarios.Add(new FuncionarioMeioPeriodo(nomeFMP, matriculaFMP, salarioFMP, horasFMP));

                              Console.WriteLine("Cadastro realizado com sucesso");

                              Console.WriteLine("\n\nAperte em qualquer tecla para continuar");
                              Console.ReadKey();
                    break;
                    case 3:
                              Console.WriteLine("\nDigite o nome da matricula do funcionario que deseja remover:\n");
                              int matriculaRemove = Convert.ToInt32(Console.ReadLine());

                              if(ContemFuncionario(matriculaRemove, e1))
                              {
                                        e1.RemoveFuncionario(matriculaRemove);
                                        Console.WriteLine("\nFuncionario removido com sucesso");
                              }
                              else
                              {
                                        Console.WriteLine("\nNão encontrei a matricula digitada. Verifique o número e tente novamente.");
                              }

                              Console.WriteLine("\n\nAperte em qualquer tecla para continuar");
                              Console.ReadKey();
                    break;
                    case 4:
                              Console.WriteLine("\n\nFuncionários registrados:\n");
                              if(e1.Funcionarios.Count() > 0)
                              {
                                        foreach (var funcionario in e1.Funcionarios)
                                        {
                                                  funcionario.ExibirInformacoes();
                                                  Console.WriteLine("\n");
                                        }
                              }
                              else
                              {
                                        Console.WriteLine("Nenhum funcionário registrado ainda");
                              }
                              Console.WriteLine("\n\nAperte em qualquer tecla para continuar");
                              Console.ReadKey();
                    break;
                    case 5:                           
                              Console.WriteLine("\nDigite o número da matricula:");
                              int nMatricula = Convert.ToInt32(Console.ReadLine());

                              if(ContemFuncionario(nMatricula, e1))
                              {         
                                        string projeto;
                                        while(true)
                                        {
                                                  Console.WriteLine("\nDigite o(s) projeto(s) que deseja adiconar:");
                                                  projeto = Console.ReadLine();
                                                  if(VerificaVazio(projeto) == false)
                                                  {
                                                            break;
                                                  }
                                        }
                                        foreach (var funcionario in e1.Funcionarios)
                                        {
                                                  if(funcionario.matricula == nMatricula)
                                                  {
                                                     
                                                            if (projeto.Contains(","))
                                                            {
                                                                      List<string> ListaDeProjetos = new List<string>();
                                                                      ListaDeProjetos = projeto.Split(",").ToList();
                                                                      funcionario.AdicionaProjeto(ListaDeProjetos);
                                                                      Console.WriteLine("\nProjetos adicionados com sucesso.\n");
                                                            }
                                                            else
                                                            {
                                                                      funcionario.AdicionaProjeto(projeto);
                                                                      Console.WriteLine("\nProjeto adicionado com sucesso.\n");
                                                            }
                                                  }
                                        }
                              }
                              else
                              {
                                        Console.WriteLine("Não encontrei a matricula digitada. Verifique o número e tente novamente.");
                              }

                              Console.WriteLine("\n\nAperte em qualquer tecla para continuar");
                              Console.ReadKey();         

                    break;
                    case 6:
                              acabarLoop = true;
                    break;
                    default:
                              Console.WriteLine("Não entendi a opção desejada. Tente novamente.");
                    continue;
          }
          if (acabarLoop)
                    break;
          
          Console.Clear();
}

Console.Clear();

Console.WriteLine("Obrigado por usar o sistema");