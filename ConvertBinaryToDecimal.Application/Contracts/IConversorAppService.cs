using ConvertBinaryToDecimal.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBinaryToDecimal.Application.Contracts
{
    public interface IConversorAppService
    {
        ConversorDto Create();
    }
}
