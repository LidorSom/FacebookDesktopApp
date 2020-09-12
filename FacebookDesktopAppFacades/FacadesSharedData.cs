using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppFacades
{
    internal class FacadesSharedData
    {
        private static FacadesSharedData s_FacadesSharedData;

        private static readonly object  sr_ObjectToLock = new object();

        public User FacebookUser { get; set; }

        private FacadesSharedData()
        {

        }

        public static FacadesSharedData GetFacadesSharedDataInstance()
        {
            if (s_FacadesSharedData == null)
            {
                lock (sr_ObjectToLock)
                {
                    if (s_FacadesSharedData == null)
                    {
                        s_FacadesSharedData = new FacadesSharedData();
                    }
                }
            }

            return s_FacadesSharedData;
        }
    }
}
