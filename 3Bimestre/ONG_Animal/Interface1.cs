﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Bimestre.ONG_Animal
{
    internal interface Ferramentas
    {
        bool nenhumCampoVazio(params string[] campos);
        bool nenhumCampoVazio(List<dynamic> campos);
        void mudarFonteParaNegrito(dynamic campo);
        void fillDataGrid(string query, dynamic conexao, dynamic Datagrid, string nomeTabela);
        void executarComandoDB(string query, dynamic conexao);
        dynamic ConectarComDB();
        bool ConcordouComPopup(string texto, string titulo);

    }
}
