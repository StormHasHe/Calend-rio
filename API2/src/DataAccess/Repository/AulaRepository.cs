using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Context;
using DataAccessContracts.Interface.DataAccess;
using Entities.CalendarioOperacao;
using Exceptions.DataAccessExceptions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DataAccess.Repository
{
    public class AulaRepository : IAulaRepository
    {
        private readonly ApplicationContext _ctx;
        private readonly MongoContext _mongoCtx;

        public AulaRepository(ApplicationContext ctx, MongoContext mongoCtx)
        {
            _ctx = ctx;
            _mongoCtx = mongoCtx;
        }

        public IEnumerable<Aula> GetAll()
        {
            var aula = new Aula() {
                Data = DateTime.Now,
                Id = 1,
                Local = "Rua teste",
                ResponsavelID = 1,
                SeguidoresID = 1,
                Status = 1,
                Subtipo = "1",
                Tipo = "1",
                JSONObj = @"{
                            'ConteudoMaterial': 'CIR 05',
                            'ApostilaID': 141,
                            'HorarioAula': '14:30'
                            }"

            };

            var aula2 = new Aula()
            {
                Data = DateTime.Now,
                Id = 1,
                Local = "Rua teste 2",
                ResponsavelID = 2,
                SeguidoresID = 2,
                Status = 2,
                Subtipo = "2",
                Tipo = "2",
                JSONObj = @"{
                            'ConteudoMaterial': 'CIR 06',
                            'ApostilaID': 142,
                            'HorarioAula': '17:30'
                            }"

            };

            var aulas = new List<Aula>();
            aulas.Add(aula);
            aulas.Add(aula2);

            return aulas;
            //var aulasCollection = _mongoCtx.GetDatabase().GetCollection<IMongoCollection<BsonDocument>>("aulas");

            //var result = BsonSerializer.Deserialize<IMongoCollection<Aula>>(aulasCollection);
            //throw new Exception();
        }

        public Aula InserirAula(Aula aula)
        {
            _ctx.Aulas.Add(aula);
            if (_ctx.SaveChanges() > 0)
                return aula;
            else
                throw new ErrorSavingDataException();
        }   

        public Aula Atualizar(Aula aula)
        {
            var aulaEntity = _ctx.Aulas.Where(x => x.Id == aula.Id).FirstOrDefault();

            if (aula != null)
            {
                aulaEntity.Data = aula.Data;
                aulaEntity.JSONObj = aula.JSONObj;
                aulaEntity.Local = aula.Local;
                aulaEntity.ResponsavelID = aula.ResponsavelID;
                aulaEntity.SeguidoresID = aula.SeguidoresID;
                aulaEntity.Status = aula.Status;
                aulaEntity.Subtipo = aula.Subtipo;
                aulaEntity.Tipo = aula.Tipo;

                if (_ctx.SaveChanges() > 0)
                    return aulaEntity;
                else
                    throw new ErrorSavingDataException();
            }
            else
                throw new RecordDoesNotExistException();
        }

        public void Dispose()
        {
            _ctx.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}