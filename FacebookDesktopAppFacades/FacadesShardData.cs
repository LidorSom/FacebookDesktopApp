using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using Microsoft.Win32;

namespace FacebookDesktopAppFacades
{
    internal class FacadesShardData
    {
        private static FacadesShardData m_FacadesShardData;
        private static readonly object  r_ObjectToLock = new object();
        public User FacebookUser { get; set; }

        private FacadesShardData()
        {

        }

        public static FacadesShardData GetFacadesShardDataInstance()
        {
            if (m_FacadesShardData == null)
            {
                lock (r_ObjectToLock)
                {
                    if (m_FacadesShardData == null)
                    {
                        m_FacadesShardData = new FacadesShardData();
                    }
                }
            }

            return m_FacadesShardData;
        }

    }
}
