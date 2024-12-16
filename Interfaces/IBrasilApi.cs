using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumindoApiDe3_.Dtos;
using ConsumindoApiDe3_.Models;

namespace ConsumindoApiDe3_.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);

        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}