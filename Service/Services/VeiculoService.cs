using Domain.Commands;
using Domain.Enums;
using Domain.Interfaces;
using Infrastructure.Repository;

namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            if (command == null)
                return "Todos os Campos são obrigatórios";
            //Todo
            int anoAtual = DateTime.Now.Year;
            if ((anoAtual - command.AnoFabricacao) > 5)
                return "O ano do veiculo é menor que o permitido!";
            // Incluir validação, só podem cadastrar veículos com
            //até 5 anos de uso

            //To do
            //Incluir Somente carros do tipo SUV, Sedan e Hatch 
            if (command.TipoVeiculo != ETipoVeiculo.SUV
            && command.TipoVeiculo != ETipoVeiculo.RET
            && command.TipoVeiculo != ETipoVeiculo.SEDAN
            )
                return "o tipo de veiculo não é permitido";



            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
