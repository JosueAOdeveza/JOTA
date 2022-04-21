using System.Data;

namespace AcessoDados
{
    public interface ICategoriasAcessoDados
    {
        void Alterar(int idCategoria, string nome, string descricao);
        bool Equals(object obj);
        void Excluir(int idCategoria);
        DataTable Listar();
        void Salvar(string nome, string descricao);
    }
}