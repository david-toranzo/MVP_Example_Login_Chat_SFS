using Sfs2X;

namespace SmartFoxServer.Core
{
    public static class SFS
    {
        public static SmartFox Instance { get; set; }

        public static bool IsInitialized
        {
            get
            {
                return (Instance != null);
            }
        }
    }
}