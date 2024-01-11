using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.Interfaces;
using System.Data.SqlClient;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string stringconnection = @"Server=(localdb)\\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(VeiculoCommand command)
        {
            string queryInsert = @"INSERT INTO Veiculo(Placa, AnoFabricacao,TipoVeiculoId,Estado, MontadoraId)
                                 Values(@Placa, @AnoFabricacao,@TipoVeiculoId,@Estado, @Montadora)";

            using (SqlConnection conn = new SqlConnection(stringconnection))
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculo = (int)command.TipoVeiculo,
                    Estado = command.Estado,
                    Montadora = (int)command.Montadora,

                });
                return "Veiculo cadastrado com sucesso";

            }
        }
        public void PostAsync()
        {

        }
        public void Getsync()
        {

        }

        public void GetAsync()
        {
            throw new NotImplementedException();
        }
    }
   

}