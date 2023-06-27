using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Domain.Validation;

public class ValidacaoDeExcecaoDeDominio : Exception
{
    public ValidacaoDeExcecaoDeDominio(string erro) : base(erro) { }

    public static void When(bool temErro, string erro)
    {
        if (temErro)
        {
            throw new ValidacaoDeExcecaoDeDominio(erro);
        }
    }
}
