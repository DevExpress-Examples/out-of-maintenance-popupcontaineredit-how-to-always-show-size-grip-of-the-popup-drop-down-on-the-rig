using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication56 {
    public class CustomPopupContainerEditViewInfo : PopupContainerEditViewInfo {
        public CustomPopupContainerEditViewInfo(RepositoryItem item)
            : base(item) {
        }
    }
}
