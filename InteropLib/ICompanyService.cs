using DOT.AGM.Services;
using System;

namespace InteropLib
{
    [ServiceContract(MethodNamespace = "DotNetDemo.")]
    public interface ICompanyService : IDisposable
    {
        [ServiceOperation(AsyncIfPossible = true, ExceptionSafe = true)]
        bool ShowCompany(string code);
    }
}
