using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumindoApiDe3_.Dtos;

namespace ConsumindoApiDe3_.Interfaces
{
    public interface IEnderecoService
    {
                Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}