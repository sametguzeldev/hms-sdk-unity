using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Game
{
    public interface IAppUpdateClient
    {
        void CheckAppUpdate(ICheckUpdateCallback checkUpdateCallback);
        void ReleaseCallback();
    }
}
