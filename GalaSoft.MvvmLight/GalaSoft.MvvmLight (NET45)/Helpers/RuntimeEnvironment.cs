using System;
using System.Linq;

namespace GalaSoft.MvvmLight.Helpers
{
    internal static class RuntimeEnvironment
    {
        public static bool IsDebug
        {
            get { return Environment.GetCommandLineArgs().Any(arg => arg == "/DebugMVVMLight"); }
        }
    }
}