using System;
using DevExpress.ExpressApp.Model;

namespace Admiral.ImportData
{
    public interface IImportOption
    {
        IModelClass MainTypeInfo { get; set; }
        decimal Progress { get; set; }
        Action<decimal> UpdateProgress { get; set; }
        string DocNum { get; set; }
        string ConnectionString { get; set; }
        string Type { get; set; }
    }
}