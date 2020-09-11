using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookDesktopAppFacades
{
    public delegate void UpdatePrivacyStatusDelegate();
    public class PrivacyFacade
    {
        private FacadesShardData facadesShardData =
            FacadesShardData.GetFacadesShardDataInstance();
        public event UpdatePrivacyStatusDelegate UpdatingPrivacyData;
        public void FetchPrivacyData()
        {
            UpdatingPrivacyData?.Invoke();
        }
    }
}
