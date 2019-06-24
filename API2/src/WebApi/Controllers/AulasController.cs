using Contracts.DTO;
using Contracts.Interface.Service;
using Exceptions.DataAccessExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/Aulas")]
    public class AulasController : ApiController
    {
        IAulaService _aulaService;

        public AulasController(IAulaService aulaService)
        {
            _aulaService = aulaService;
        }

        [Route("")]
        [AllowAnonymous]
        public IHttpActionResult GetAulas()
        {
            var response = new ResponseDTO<List<AulaDTO>>();

            try
            {
                var calendario = _aulaService.GetTodasAsAulas();

                if (calendario != null)
                {
                    response.Success = true;
                    response.Value = calendario;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Nenhum calendario cadastrado no sistema";
                }
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Exception = e;
                response.Message = "Ocorreu um erro ao executar consulta";
            }

            return Ok(response);
        }

        [Route("")]
        public IHttpActionResult PostAulas(AulaDTO aula)
        {
            var response = new ResponseDTO<AulaDTO>();

            try
            {
                var calendario = _aulaService.InserirAula(aula);

                if (calendario != null)
                {
                    response.Success = true;
                    response.Value = calendario;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Nenhum calendario cadastrado no sistema";
                }
            }
            catch (ErrorSavingDataException e)
            {
                response.Success = false;
                response.Exception = e;
                response.Message = e.Message;
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Exception = e;
                response.Message = "Ocorreu um erro ao executar consulta";
            }

            return Ok(response);
        }

        [Route("")]
        public IHttpActionResult PutAulas(AulaDTO aula)
        {
            var response = new ResponseDTO<AulaDTO>();

            try
            {
                var calendario = _aulaService.AtualizarAula(aula);

                if (calendario != null)
                {
                    response.Success = true;
                    response.Value = calendario;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Nenhum calendario cadastrado no sistema";
                }
            }
            catch (ErrorSavingDataException e)
            {
                response.Success = false;
                response.Exception = e;
                response.Message = e.Message;
            }
            catch (RecordDoesNotExistException e)
            {
                response.Success = false;
                response.Exception = e;
                response.Message = e.Message;
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Exception = e;
                response.Message = "Ocorreu um erro ao executar consulta";
            }

            return Ok(response);
        }
    }
}
