using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace Admiral.ImportData
{
    [XafDisplayName("Data Import")]
    [NonPersistent]
    [ImageName("ImportData")]
    public class ImportData : BaseObject
    {
        public ImportData(Session s) : base(s)
        {

        }

        public IImportOption Option { get; set; }

        private decimal _Progress;
        [XafDisplayName("Progress")][ModelDefault("AllowEdit","False")]
        [Appearance("Progress", Visibility = DevExpress.ExpressApp.Editors.ViewItemVisibility.Hide)]
        public decimal Progress
        {
            get { return _Progress; }
            set { SetPropertyValue("Progress", ref _Progress, value); }
        }
    }
}