using System.Runtime.InteropServices;

namespace ToucheServer.Server
{
    public static class TsServer
    {
        private const string ServiceDll = "Server.dll";

        [DllImport(ServiceDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EchoThread();

        [DllImport(ServiceDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EchoThreadA(IPv4 ip);

        [DllImport(ServiceDll, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ServerThread();
    }

    public struct IPv4
    {
        public byte s_b1, s_b2, s_b3, s_b4;
    };
}
