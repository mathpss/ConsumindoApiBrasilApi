using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumindoApiDe3_.Dtos;

namespace ConsumindoApiDe3_.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}