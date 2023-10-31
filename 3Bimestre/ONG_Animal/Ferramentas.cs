using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Bimestre.ONG_Animal

namespace _3Bimestre.ONG_Animal
{
    internal interface Ferramentas {
        bool nenhumCampoVazio(params string[] campos);
        bool nenhumCampoVazio(List<dynamic> campos);
        void mudarFonteParaNegrito(dynamic campo);
        void fillDataGrid(string query, dynamic conexao, dynamic Datagrid, string nomeTabela);
        void executarComandoDB(string query, dynamic conexao);
        dynamic ConectarComDB();
    }

}
