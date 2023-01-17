using AtividadePetShop.Modelo;
using AtividadePetShop.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePetShop.Repositorios
{
    internal class Repositorio
    {
        internal class RepositorioClientes
        {
            private readonly string arquivoClientes = "C:\\Projetos\\AtividadesCurso\\AtividadePetShop\\Repositorios";
            private List<Cliente> ListagemClientes = new();

            #region Métodos Públicos
            public RepositorioClientes()
            {
                if (!File.Exists(arquivoClientes))
                {
                    var file = File.Create(arquivoClientes);
                    file.Close();
                }
            }
            public void Inserir(Cliente cliente)
            {
                if (!(VerificaExistenciaCliente(cliente.CPF)))
                {
                    File.AppendAllText(arquivoClientes, $"{cliente.Nome};{cliente.CPF};{cliente.DataNascimento};{cliente.Endereco}\n");
                    Console.WriteLine();
                    Console.WriteLine("Cliente cadastrado com sucesso!\n");
                }
                Console.WriteLine("CPF já utilizado, cadastro cancelado.");
            }
            public List<Cliente> Listar()
            {
                CarregarClientesLista();

                return ListagemClientes;
                #endregion
            }

            #region Métodos Privados
            private Cliente LinhaTextoParaCliente(string linha)
            {
                var colunas = linha.Split(';');

                var cliente = new Cliente();
                cliente.Nome = colunas[0];
                cliente.CPF = colunas[1];
                cliente.DataNascimento = Convert.ToDateTime(colunas[2]);
                cliente.Endereco = colunas[3];

                return cliente;
            }

            private void CarregarClientesLista()
            {
                ListagemClientes.Clear();
                var sr = new StreamReader(arquivoClientes);
                while (true)
                {
                    var linha = sr.ReadLine();

                    if (linha == null)
                        break;

                    ListagemClientes.Add(LinhaTextoParaCliente(linha));
                }

                sr.Close();
            }

            private bool VerificaExistenciaCliente(string cpf)
            {
                CarregarClientesLista();
                Cliente cliente = ListagemClientes.Find(c => c.CPF == cpf);

                if (cliente == null)
                    return false;
                else
                    return true;

            }

        }
        #endregion
    }
}