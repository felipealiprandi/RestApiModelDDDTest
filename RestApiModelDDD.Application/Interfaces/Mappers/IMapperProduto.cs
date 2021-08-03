using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produto);

        ProdutoDto MapperEntityToDto(Produto produto);

    }
}
