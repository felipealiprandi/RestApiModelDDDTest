using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interfaces.Mappers;
using RestApiModelDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModelDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                id = clienteDto.Id
                ,
                Nome = clienteDto.Nome
                ,
                Sobrenome = clienteDto.Sobrenome
                ,
                Email = clienteDto.Email
            };
            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.id
                ,
                Nome = cliente.Nome
                ,
                Sobrenome = cliente.Sobrenome
                ,
                Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto
            {
                Id = c.id
                ,
                Nome = c.Nome
                ,
                Sobrenome = c.Sobrenome
                ,
                Email = c.Email
            });
            return dto;
        }
    }
}