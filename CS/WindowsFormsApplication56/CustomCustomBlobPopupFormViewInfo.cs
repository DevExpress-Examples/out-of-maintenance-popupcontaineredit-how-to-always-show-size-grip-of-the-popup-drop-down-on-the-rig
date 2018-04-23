using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Popup;

namespace WindowsFormsApplication56 {
    public class CustomCustomBlobPopupFormViewInfo : CustomBlobPopupFormViewInfo {
        public CustomCustomBlobPopupFormViewInfo(PopupBaseForm form)
            : base(form) {

        }
        protected override bool IsLeftSizeGrip {
            get {
                return false;//base.IsLeftSizeGrip;
            }
        }
    }
}
