using DOT.AGM.Services;
using System;

namespace ManipulateBrowserWindows
{
    [ServiceContract(MethodNamespace = "T42.Demo.")]
    public interface IDemoWindowOpening : IDisposable
    {
        [ServiceOperation(AsyncIfPossible = true, ExceptionSafe = true)]
        void OpenReusableWindow(string url);
    }
}
