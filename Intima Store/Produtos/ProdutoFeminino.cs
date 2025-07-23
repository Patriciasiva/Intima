using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intima_Store.Produtos
{
    public class ProdutoFeminino
    {
        public ProdutoFeminino BuscarPorCodigoBarras(string codigo)
        {
            using(var conexao = ConexaoBD.GetConexao())
            {
                conexao.Open();
                var cmd = new MySqlCommand("SELECT FROM produtos WHERE codigo_barras=@codigo", conexao);
                cmd.Parameters.AddWithValue("@codigo",codigo);
                using (var reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        return new ProdutoFeminino();
                    }
                }
            }
        }
    }
}
