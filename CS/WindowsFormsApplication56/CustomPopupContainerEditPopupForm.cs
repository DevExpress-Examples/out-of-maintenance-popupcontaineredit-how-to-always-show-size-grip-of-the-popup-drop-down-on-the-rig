using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Popup;

namespace WindowsFormsApplication56 {
    public class CustomPopupContainerEditPopupForm : PopupContainerForm {
        public CustomPopupContainerEditPopupForm(CustomPopupContainerEdit ownerEdit)
            : base(ownerEdit) {
        }

        protected override PopupBaseFormViewInfo CreateViewInfo() {
            //return base.CreateViewInfo();
            return new CustomCustomBlobPopupFormViewInfo(this);
        }
    }
}
