using AtividadePetShop.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AtividadePetShop.Repositorios;
using AtividadePetShop.Utilitarios;

namespace AtividadePetShop.Servicos
{
    internal class clienteServicos
    {
        private readonly Repositorio.RepositorioClientes _repositorio;
        public clienteServicos()
        {
            _repositorio = new Repositorio.RepositorioClientes();
        }

        public void Perguntar()
        {
            while (true)
            {
                Console.WriteLine("#####################################################");
                Console.WriteLine("################## Sistema PetShop ##################");
                Console.WriteLine("#####################################################\n\n");
                Console.WriteLine("Digite o numero da opção desejada e aperte 'Enter': \n");
                Console.WriteLine("(1) Cadastrar cliente novo.\n" +
                                  "(2) Listar clientes ja cadastrados.\n" +
                                  "(3) Buscar cliente por CPF.\n" +
                                  "(4) Listar os aniversariantes do mês.\n");
                Console.WriteLine("(6) Para fechar o programa.\n");

                char opcao = char.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case '1':
                        CadastrarCliente();
                        break;
                    case '2':
                        ListarClientes();
                        break;
                    case '3':
                        BuscarCliente();
                        break;
                    case '4':
                        BuscaAniversariantes();
                        break;
                }

                if (opcao == '6')
                {
                    break;
                }
            }
        }
        private void CadastrarCliente()
        {
            Console.WriteLine("Informe os dados do novo cliente:\n");
            Console.Write("Primeiro nome (Em maiúsculo: Exemplo; SAVIO): ");
            string nome = "";
            while (true)
            {
                nome = Console.ReadLine();
                if (utilitarios.ValidaNome(nome))
                {
                    Console.WriteLine("Nome válido\n");
                    break;

                }
                else
                {
                    Console.WriteLine("Nome inválido, verifique se você digitou corretamente e digite novamente: \n");

                }
            }
            Console.Write("CPF (so digite os numeros exemplo: 11111111111): ");
            string cpf = "";
            while (true)
            {
                cpf = Console.ReadLine();
                cpf = Regex.Replace(cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})",
                                    "$1.$2.$3-$4");
                
                    if (utilitarios.ValidaCPF(cpf))
                    {
                        Console.WriteLine("CPF válido!\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("CPF inválido, verifique se você digitou corretamente e digite novamente: \n");
                        continue;
                    }

                }
            Console.Write("Insira a data de nascimente (dd/MM/yyyy): ");
            string nascimento;
            DateTime dataNascimento;
            while (true)
            {
                nascimento = (Console.ReadLine());
                if (utilitarios.ValidaNascimento(nascimento))
                {
                    Console.WriteLine("Data de nascimento válida!\n");
                    dataNascimento = Convert.ToDateTime(nascimento);
                    break;
                }
            }
            Console.Write("Endereço (Exemplo: Rua k 111 centro Belo Horizonte): ");
            string endereco = "";
            while (true)
            {
                endereco = Console.ReadLine();
                if (utilitarios.ValidaEndereco(endereco))
                {
                    Console.WriteLine("Endereço válido\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Endereço inválido, verifique se você digitou corretamente e digite novamente: \n");
                    continue;
                }
            }

            Cliente cliente = new Cliente(nome, cpf, dataNascimento, endereco);
            _repositorio.Inserir(cliente);
        }
        private void ListarClientes()
        {
            var clientes = _repositorio.Listar();
            if (clientes.Count == 0)
            {
                Console.WriteLine("Não há clientes cadastrados.");
                return;
            }
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.CPF);
                Console.WriteLine("Data de Nascimento: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
                Console.WriteLine("Endereço: " + cliente.Endereco);
                Console.WriteLine();
            }
        }
        private void BuscarCliente()
        {
            Console.Write("Digite o CPF do cliente: ");
            string cpf = "";
            while (true)
            {
                cpf = Console.ReadLine();
                cpf = Regex.Replace(cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})",
                                         "$1.$2.$3-$4");
                if (utilitarios.ValidaCPFBusca(cpf))
                    break;
                else
                    Console.WriteLine("Digite um CPF válido! Digite novamente.");
            }
            Cliente cliente = _repositorio.Listar().Find(c => c.CPF == cpf);
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
            }
            else
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.CPF);
                Console.WriteLine("Data de Nascimento: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
                Console.WriteLine("Endereco: " + cliente.Endereco);
            }
        }
        private void BuscaAniversariantes()
        {
            List<Cliente> aniversariantesMes = _repositorio.Listar().FindAll(c => c.DataNascimento.Month == DateTime.Now.Month);
            if (aniversariantesMes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente faz aniversário este mês! \n");
            }
            else
            {
                Console.WriteLine("Os aniversáriantes deste mês são: ");
                foreach (Cliente obj in aniversariantesMes)
                {
                    Console.WriteLine($"{obj.Nome} data: {obj.DataNascimento.ToString("dd/MM")} \n");
                }
            }
        }
    }
}      