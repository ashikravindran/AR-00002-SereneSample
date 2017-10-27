
namespace AR_00002_SereneSample.BasicSamples.Forms
{
    using Serenity.ComponentModel;
    using Serenity.Web;
    using System;

    [FormScript("BasicSamples.ProductExcelImport")]
    public class ProductExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}
