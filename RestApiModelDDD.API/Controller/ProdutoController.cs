using Microsoft.AspNetCore.Mvc;
using RestApiModelDDD.Application.Dtos;
using RestApiModelDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModelDDD.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto ApplicationServiceProduto)
        {
            _applicationServiceProduto = ApplicationServiceProduto;
        }

        //Get api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        //Get api/values
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        // POST
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _applicationServiceProduto.Add(produtoDTO);
                return Ok("Produto Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _applicationServiceProduto.Update(produtoDTO);
                return Ok("Produto Atualizado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Remove api/value/2
        [HttpPut]
        public ActionResult Delete([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _applicationServiceProduto.Remove(produtoDTO);
                return Ok("Produto Removido com sucesso");
                return Ok("Produto Removido com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
