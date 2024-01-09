using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IVeiculoRepository
    {
        Task<string> PostAsync(Veiculo command);
        void PostAsync();
        void GetAsync();
    }
}
