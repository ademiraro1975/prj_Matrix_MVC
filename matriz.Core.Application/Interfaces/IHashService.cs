using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.Core.Application.Interfaces;

public interface IHashService
{
    string HashSHA256(int key);
    string ChaveValidacaoSeguranca(string key);
}
