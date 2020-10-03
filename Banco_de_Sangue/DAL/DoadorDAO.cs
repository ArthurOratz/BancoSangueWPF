using Banco_de_Sangue.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_de_Sangue.DAL
{
    class DoadorDAO
    {
        private static List<Doador> Doador = new List<Doador>();
        //private static List<Funcionario> Funcionario = new List<Funcionario>();
        //private static List<Hospital> Hospital = new List<Hospital>();
        //private static List<Coleta_Sangue> Coleta_Sangue = new List<Coleta_Sangue>();
        //private static List<Pedido_Sangue> Pedido_Sangue = new List<Pedido_Sangue>();
        //private static List<Tipo_Sanguineo> Tipo_Sanguineo = new List<Tipo_Sanguineo>();
        //private static List<Estoque_Sangue> Estoque_Sangue = new List<Estoque_Sangue>();

        public static List<Doador> Listar() => Doador;
        
        //cadastrar
        public static bool Cadastrar(Doador d)
        {
            if(BuscarDoador(d.Cpf_doador) == null)
            {
                Doador.Add(d);
                return true;
            }
            return false;
        }

        public static Doador BuscarDoador(string cpf)
        {
            foreach (Doador doadorCadastrado in Doador)
            {
                if (doadorCadastrado.Cpf_doador == cpf)
                {
                    return doadorCadastrado;
                    
                }
            }
            return null;
        } 



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

        //listar
    }
}
