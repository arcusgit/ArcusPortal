using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Objects.CR;
using PX.Data.BQL;

namespace ArcusPortalCust.DAC
{
    public class CRCaseExt : PXCacheExtension<CRCase>
    {
        #region UsrRequireDocUpdate
        [PXDBBool]
        [PXUIField(DisplayName = "Require Document Update")]
        public virtual bool? UsrRequireDocUpdate { get; set; }
        public abstract class usrRequireDocUpdate : BqlBool.Field<usrRequireDocUpdate> { }
        #endregion
    }
}
