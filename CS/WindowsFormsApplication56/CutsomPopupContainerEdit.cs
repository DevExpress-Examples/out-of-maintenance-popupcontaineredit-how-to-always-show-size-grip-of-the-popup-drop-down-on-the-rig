using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;

namespace WindowsFormsApplication56 {

    [ToolboxItem(true)]
    public class CustomPopupContainerEdit : PopupContainerEdit {
        static CustomPopupContainerEdit() {
            RepositoryItemCustomPopupContainerEdit.RegisterCustomPopupContainerEdit();
        }

        public CustomPopupContainerEdit() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomPopupContainerEdit Properties {
            get {
                return base.Properties as RepositoryItemCustomPopupContainerEdit;
            }
        }

        public override string EditorTypeName {
            get {
                return RepositoryItemCustomPopupContainerEdit.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm() {
            return new CustomPopupContainerEditPopupForm(this);
        }
    }
}
