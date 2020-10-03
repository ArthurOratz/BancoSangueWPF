using System;
using System.Collections.Generic;
using Banco_de_Sangue.DAL;
using Banco_de_Sangue.Models;

namespace Banco_de_Sangue.Views
{
    class Program
    {
        private static object multiplicacao;
        private static object soma;

        static void Main(string[] args)
        {
            int opcao;
            Doador d = new Doador();
            Funcionario f = new Funcionario();
            Hospital h = new Hospital();
            Coleta_Sangue c = new Coleta_Sangue();
            Pedido_Sangue p = new Pedido_Sangue();
            Tipo_Sanguineo t = new Tipo_Sanguineo();
            Estoque_Sangue e = new Estoque_Sangue();

            

            do
            {
                Console.Clear();
                Console.WriteLine("----Banco de Sangue----\n");
                Console.WriteLine("1-Cadastrar doador");
                Console.WriteLine("2-Listar doador");
                Console.WriteLine("3-Alterar doador");
                Console.WriteLine("4-Apagar doador");
                Console.WriteLine("--------------------------");
                Console.WriteLine("5-Cadastrar funcionario");
                Console.WriteLine("6-Listar funcionario");
                Console.WriteLine("7-Alterar funcionario");
                Console.WriteLine("8-Apagar funcionario");
                Console.WriteLine("--------------------------");
                Console.WriteLine("9-Cadastrar hospital");
                Console.WriteLine("10.1-Listar hospital");
                Console.WriteLine("11-Alterar hospital");
                Console.WriteLine("12-Apagar hospital");
                Console.WriteLine("--------------------------");
                Console.WriteLine("13-Cadastrar coleta de sangue");
                Console.WriteLine("14-Listar coleta de sangue");
                Console.WriteLine("15-Alterar coleta de sangue");
                Console.WriteLine("16-Apagar coleta de sangue");
                Console.WriteLine("--------------------------");
                Console.WriteLine("17-Cadastrar pedido");
                Console.WriteLine("18-Listar pedido");
                Console.WriteLine("19-Alterar pedido");
                Console.WriteLine("20-Apagar pedido");
                Console.WriteLine("--------------------------");
                Console.WriteLine("21-Cadastrar tipo sanguineo");
                Console.WriteLine("22.1-Listar tipo sanguineo");
                Console.WriteLine("23-Alterar tipo sanguineo");
                Console.WriteLine("24-Apagar tipo sanguineo");
                Console.WriteLine("--------------------------");
                Console.WriteLine("25-Cadastrar estoque");
                Console.WriteLine("26-Listar estoque");
                Console.WriteLine("27-Alterar estoque");
                Console.WriteLine("28-Apagar estoque");

                Console.WriteLine("\n Digite a opcao desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        d = new Doador();
                        Console.WriteLine("1-Cadastrar doador\n");

                        Console.WriteLine("Digite o nome do doador");
                        d.Nome_doador = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do doador");
                        d.Cpf_doador = Console.ReadLine();
                        Console.WriteLine("Digite o e_mail do doador");
                        d.E_mail_doador = Console.ReadLine();
                        Console.WriteLine("Digite o telefone do doador");
                        d.Telefone_doador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o tipo_sanguineo do doador");
                        d.Tipo_sanguineo = Console.ReadLine();
                        Console.WriteLine("Digite o peso do doador");
                        d.Peso = Convert.ToInt32(Console.ReadLine());



                        //Verificação do CPF
                        if (ValidarCpf(d.Cpf_doador))
                        {

                            if (Doador.Count == 0)
                            {
                                Doador.Add(d);

                                Console.WriteLine("Cliente salvo com sucesso!!!!");
                            }
                            else
                            {
                                bool encontrado = false;
                                foreach (Doador doadorCadastrado in Doador)
                                {
                                    if (doadorCadastrado.Cpf_doador == d.Cpf_doador)
                                    {
                                        encontrado = true;
                                        //Não permitir o cadastro

                                    }
                                }
                                if (encontrado == false)
                                {
                                    ////Adicionar
                                    Doador.Add(d);
                                    //Mensagem de sucesso                        
                                    Console.WriteLine("Cliente salvo com sucesso!!!!");
                                }
                                else
                                {
                                    Console.WriteLine("Não foi possível cadastrar");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("CPF inválido");
                        }

                        break;

                    case 2:
                        Console.WriteLine("2-Listar doador\n");//NÃO FUNCIONA//
                        //Laço de repetição para mostrar todos os clientes
                        foreach (Doador doadorCadastrado in DoadorDAO.Listar())
                        {
                            Console.WriteLine(doadorCadastrado);
                        }
                        break;

                    case 3:
                        Console.WriteLine("3-Alterar doador");

                        break;

                    case 4:
                        Console.WriteLine("4-Apagar doador");

                        break;

                    case 5:
                        f = new Funcionario();
                        Console.WriteLine("5-Cadastrar funcionario\n");

                        Console.WriteLine("Digite o nome do funcionario");
                        f.Nome_funcionario = Console.ReadLine();
                        Console.WriteLine("Digite o cpf do funcionario");
                        f.Cpf_funcionario = Console.ReadLine();
                        Console.WriteLine("Digite o e_mail do funcionario");
                        f.E_mail_funcionario = Console.ReadLine();
                        Console.WriteLine("Digite o telefone do funcionario");
                        f.Telefone_funcionario = Convert.ToInt32(Console.ReadLine());

                        //Verificação do CPF
                        if (ValidarCpf(f.Cpf_funcionario))
                        {

                            if (Funcionario.Count == 0)
                            {
                                Funcionario.Add(f);

                                Console.WriteLine("Funcionario salvo com sucesso!!!!");
                            }
                            else
                            {
                                bool encontrado = false;
                                foreach (Funcionario funcionarioCadastrado in Funcionario)
                                {
                                    if (funcionarioCadastrado.Cpf_funcionario == f.Cpf_funcionario)
                                    {
                                        encontrado = true;
                                        //Não permitir o cadastro

                                    }
                                }
                                if (encontrado == false)
                                {
                                    ////Adicionar
                                    Funcionario.Add(f);
                                    //Mensagem de sucesso                        
                                    Console.WriteLine("Funcionario salvo com sucesso!!!!");
                                }
                                else
                                {
                                    Console.WriteLine("Não foi possível cadastrar");
                                }
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("6-Listar Funcionario");
                        //Laço de repetição para mostrar todos os clientes
                        foreach (Funcionario funcionarioCadastrado in Funcionario)
                        {
                            Console.WriteLine(funcionarioCadastrado);
                        }
                        break;

                    case 7:
                        Console.WriteLine("7-Alterar Funcionario");

                        break;

                    case 8:
                        Console.WriteLine("8-Apagar Funcionario");

                        break;

                    case 9:
                        h = new Hospital();
                        Console.WriteLine("3-Cadastrar hospital\n");

                        Console.WriteLine("Digite a Id");
                        h.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o nome_hospital");
                        h.Nome_hospital = Console.ReadLine();
                        Console.WriteLine("Digite o endereco");
                        h.Endereco = Console.ReadLine();
                        Console.WriteLine("Digite o telefone");
                        h.Telefone = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o nome_responsavel");
                        h.Nome_responsavel = Console.ReadLine();

                        //Verificação do Id
                        if (Hospital.Count == 0)
                        {
                            Hospital.Add(h);

                            Console.WriteLine("Hospital salvo com sucesso!!!!");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Hospital hospitalCadastrado in Hospital)
                            {
                                if (hospitalCadastrado.Id == h.Id)
                                {
                                    encontrado = true;
                                    //Não permitir o cadastro

                                }
                            }
                            if (encontrado == false)
                            {
                                ////Adicionar
                                Hospital.Add(h);
                                //Mensagem de sucesso                        
                                Console.WriteLine("Funcionario salvo com sucesso!!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível cadastrar");
                            }

                        }
                        break;

                    case 10:
                        Console.WriteLine("10-Listar Hospital");
                        //Laço de repetição para mostrar todos os clientes
                        foreach (Hospital hospitalCadastrado in Hospital)
                        {
                            Console.WriteLine(hospitalCadastrado);
                        }
                        break;

                    case 11:
                        Console.WriteLine("11-Alterar Hospital");

                        break;

                    case 12:
                        Console.WriteLine("12-Apagar Hospital");

                        break;

                    case 13:
                        c = new Coleta_Sangue();
                        Console.WriteLine("13-Cadastrar coleta de sangue\n");

                        Console.WriteLine("Digite a Id");
                        c.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o nome_doador");
                        c.Nome_doador = Console.ReadLine();
                        Console.WriteLine("Digite o funcionario");
                        c.funcionario = Console.ReadLine();
                        Console.WriteLine("Digite o data");
                        c.Data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o tipo_sanguineo");
                        c.Tipo_sanguineo = Console.ReadLine();
                        Console.WriteLine("Digite o quantidade_doada");
                        c.Quantidade_doada = Convert.ToInt32(Console.ReadLine());

                        //Verificação do CPF
                        if (Coleta_Sangue.Count == 0)
                        {
                            Coleta_Sangue.Add(c);

                            Console.WriteLine("Funcionario salvo com sucesso!!!!");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Coleta_Sangue coleta_sangueCadastrado in Coleta_Sangue)
                            {
                                if (coleta_sangueCadastrado.Id == c.Id)
                                {
                                    encontrado = true;
                                    //Não permitir o cadastro

                                }
                            }
                            if (encontrado == false)
                            {
                                ////Adicionar
                                Coleta_Sangue.Add(c);
                                //Mensagem de sucesso                        
                                Console.WriteLine("Coleta_Sangue salvo com sucesso!!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível cadastrar");
                            }

                        }
                        break;

                    case 14:
                        Console.WriteLine("14-Listar Coleta_Sangue");
                        //Laço de repetição para mostrar todos os clientes
                        foreach (Coleta_Sangue coleta_sangueCadastrado in Coleta_Sangue)
                        {
                            Console.WriteLine(coleta_sangueCadastrado);
                        }
                        break;

                    case 15:
                        Console.WriteLine("15-Alterar Coleta_Sangue");

                        break;

                    case 16:
                        Console.WriteLine("16-Apagar Coleta_Sangue");

                        break;

                    case 17:
                        p = new Pedido_Sangue();
                        Console.WriteLine("17-Cadastrar pedido\n");

                        Console.WriteLine("Digite a Id");
                        p.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o nome_hospital");
                        p.Nome_hospital = Console.ReadLine();
                        Console.WriteLine("Digite o data");
                        p.Data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o tipo_sanguineo");
                        p.Tipo_sanguineo = Console.ReadLine();
                        Console.WriteLine("Digite o quantidade_doada");
                        p.Quantidade_doada = Convert.ToInt32(Console.ReadLine());

                        //Verificação do CPF
                        if (Pedido_Sangue.Count == 0)
                        {
                            Pedido_Sangue.Add(p);

                            Console.WriteLine("Pedido_Sangue salvo com sucesso!!!!");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Pedido_Sangue pedido_sangueCadastrado in Pedido_Sangue)
                            {
                                if (pedido_sangueCadastrado.Id == p.Id)
                                {
                                    encontrado = true;
                                    //Não permitir o cadastro

                                }
                            }
                            if (encontrado == false)
                            {
                                ////Adicionar
                                Pedido_Sangue.Add(p);
                                //Mensagem de sucesso                        
                                Console.WriteLine("Pedido_Sangue salvo com sucesso!!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível cadastrar");
                            }

                        }
                        break;

                    case 18:
                        Console.WriteLine("18-Listar Pedido_Sangue");
                        //Laço de repetição para mostrar todos os clientes
                        foreach (Pedido_Sangue pedido_sangueCadastrado in Pedido_Sangue)
                        {
                            Console.WriteLine(pedido_sangueCadastrado);
                        }
                        break;

                    case 19:
                        Console.WriteLine("19-Alterar Pedido_Sangue");

                        break;

                    case 20:
                        Console.WriteLine("20-Apagar Pedido_Sangue");

                        break;

                    case 21:
                        t = new Tipo_Sanguineo();
                        Console.WriteLine("21-Cadastrar tipo sanguineo\n");

                        Console.WriteLine("Digite a Id");
                        t.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o Fator_RH");
                        t.Fator_RH = Console.ReadLine();
                        Console.WriteLine("Digite o tipo_sanguineo");
                        t.Tipo_sanguineo = Console.ReadLine();

                        //Verificação do CPF
                        if (Tipo_Sanguineo.Count == 0)
                        {
                            Tipo_Sanguineo.Add(t);

                            Console.WriteLine("Tipo_Sanguineo salvo com sucesso!!!!");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Tipo_Sanguineo tipo_sanguineoCadastrado in Tipo_Sanguineo)
                            {
                                if (tipo_sanguineoCadastrado.Id == t.Id)
                                {
                                    encontrado = true;
                                    //Não permitir o cadastro

                                }
                            }
                            if (encontrado == false)
                            {
                                ////Adicionar
                                Tipo_Sanguineo.Add(t);
                                //Mensagem de sucesso                        
                                Console.WriteLine("Tipo_Sanguineo salvo com sucesso!!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível cadastrar");
                            }

                        }
                        break;

                    case 22:
                        Console.WriteLine("22-Listar Tipo_Sanguineo");
                        //Laço de repetição para mostrar todos os clientes
                        foreach (Tipo_Sanguineo tipo_sanguineoCadastrado in Tipo_Sanguineo)
                        {
                            Console.WriteLine(tipo_sanguineoCadastrado);
                        }
                        break;

                    case 23:
                        Console.WriteLine("23-Alterar Tipo_Sanguineo");

                        break;

                    case 24:
                        Console.WriteLine("24-Apagar Tipo_Sanguineo");

                        break;

                    case 25:
                        e = new Estoque_Sangue();
                        Console.WriteLine("25-Cadastrar estoque_sangue\n");

                        //Tipo_Sanguineo A
                        Console.WriteLine("Digite o quantidade_A_positivo");
                        e.Quantidade_A_positivo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quantidade_A_negativo");
                        e.Quantidade_A_negativo = Convert.ToInt32(Console.ReadLine());

                        //Tipo_Sanguineo B
                        Console.WriteLine("Digite o quantidade_B_positivo");
                        e.Quantidade_B_positivo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quantidade_B_negativo");
                        e.Quantidade_B_negativo = Convert.ToInt32(Console.ReadLine());

                        //Tipo_Sanguineo AB
                        Console.WriteLine("Digite o quantidade_AB_positivo");
                        e.Quantidade_AB_positivo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quantidade_AB_negativo");
                        e.Quantidade_AB_negativo = Convert.ToInt32(Console.ReadLine());

                        //Tipo_Sanguineo O
                        Console.WriteLine("Digite o quantidade_O_positivo");
                        e.Quantidade_O_positivo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quantidade_O_negativo");
                        e.Quantidade_O_negativo = Convert.ToInt32(Console.ReadLine());

                        //Verificação do CPF
                        if (Estoque_Sangue.Count == 0)
                        {
                            Estoque_Sangue.Add(e);

                            Console.WriteLine("Estoque_Sangue salvo com sucesso!!!!");
                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Estoque_Sangue estoque_sangueCadastrado in Estoque_Sangue)
                            {
                                if (estoque_sangueCadastrado.Quantidade_A_positivo == e.Quantidade_A_positivo)
                                {
                                    encontrado = true;
                                    //Não permitir o cadastro

                                }

                            }
                            if (encontrado == false)
                            {
                                ////Adicionar
                                Estoque_Sangue.Add(e);
                                //Mensagem de sucesso                        
                                Console.WriteLine("Estoque_Sangue salvo com sucesso!!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível cadastrar");
                            }

                        }
                        break;

                    case 26:
                        Console.WriteLine("26-Listar Estoque_Sangue");
                        //Laço de repetição para mostrar todos os clientes
                        foreach (Estoque_Sangue estoque_sangueCadastrado in Estoque_Sangue)
                        {
                            Console.WriteLine(estoque_sangueCadastrado);
                        }
                        break;

                    case 27:
                        Console.WriteLine("27-Alterar Estoque_Sangue");

                        break;

                    case 28:
                        Console.WriteLine("28-Apagar Estoque_Sangue");

                        break;

                    default:
                        Console.WriteLine("---Opcao Invalida---\n");
                        break;
                }
                Console.ReadKey();
            } while (opcao != 0);

        }

        private static bool ValidarCpf(string cpf)
        {
            int peso = 10, soma = 0, resto, digito1, digito2;
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }

            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }
            //Primeiro digito
            for (int i = 0; i < 9; i++)
            {

                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }
            //Segundo digito
            peso = 11;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {

                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[9].ToString()) != digito2)
            {
                return false;
            }
            return true;
        }
    }
}

