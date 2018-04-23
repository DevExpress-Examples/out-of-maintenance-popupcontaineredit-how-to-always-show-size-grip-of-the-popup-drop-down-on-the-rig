using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace WindowsFormsApplication56 {
    [UserRepositoryItem("RegisterCustomPopupContainerEdit")]
    public class RepositoryItemCustomPopupContainerEdit : RepositoryItemPopupContainerEdit {
        static RepositoryItemCustomPopupContainerEdit() {
            RegisterCustomPopupContainerEdit();
        }

        public const string CustomEditName = "CustomPopupContainerEdit";

        public RepositoryItemCustomPopupContainerEdit() {
        }

        public override string EditorTypeName {
            get {
                return CustomEditName;
            }
        }

        public static void RegisterCustomPopupContainerEdit() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomPopupContainerEdit), typeof(RepositoryItemCustomPopupContainerEdit), typeof(CustomPopupContainerEditViewInfo), new ButtonEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomPopupContainerEdit source = item as RepositoryItemCustomPopupContainerEdit;
                if(source == null)
                    return;
                //
            } finally {
                EndUpdate();
            }
        }
    }

}
