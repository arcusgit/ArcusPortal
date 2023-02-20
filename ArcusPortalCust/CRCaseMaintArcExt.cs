using PX.Data;
using System;
using PX.Objects.CR;
using SP.Objects.CR;

namespace ArcusPortalCust
{
    public class CRCaseMaintArcExt : PXGraphExtension<CRCaseMaintExt, CRCaseMaint>
    {
        #region Override
        [PXOverride]
        public virtual void closeCase(Action baseMethod)
        {
            try { baseMethod(); }
            catch (PXRedirectRequiredException) { }
        }

        [PXOverride]
        public virtual void reopenCase(Action baseMethod)
        {
            try { baseMethod(); }
            catch (PXRedirectRequiredException) { }
        }
        #endregion

    }
}
