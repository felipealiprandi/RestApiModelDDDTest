using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}