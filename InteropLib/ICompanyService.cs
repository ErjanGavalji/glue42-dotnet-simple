using DOT.AGM.Services;
using System;

namespace InteropLib
{
    [ServiceContract(MethodNamespace = "FidelityDemo.")]
    public interface ICompanyService : IDisposable
    {
        [ServiceOperation(AsyncIfPossible = true, ExceptionSafe = true)]
        bool ShowCompany(string code);
    }
}
