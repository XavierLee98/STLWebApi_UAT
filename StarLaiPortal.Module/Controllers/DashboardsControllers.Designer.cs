namespace StarLaiPortal.Module.Controllers
{
    partial class DashboardsControllers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DashboardWarehouse = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            this.ViewDoc = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ViewDashboardDoc = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ViewDashboardDocSales = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ViewDocSales = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ViewDashboardDocPurchase = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ViewDocPurchase = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.ViewDashboardDocWhs = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ViewDocWhs = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // DashboardWarehouse
            // 
            this.DashboardWarehouse.Caption = "Warehouse";
            this.DashboardWarehouse.Category = "ObjectsCreation";
            this.DashboardWarehouse.ConfirmationMessage = null;
            this.DashboardWarehouse.Id = "DashboardWarehouse";
            this.DashboardWarehouse.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.CaptionAndImage;
            this.DashboardWarehouse.ToolTip = null;
            this.DashboardWarehouse.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.DashboardWarehouse_Execute);
            // 
            // ViewDoc
            // 
            this.ViewDoc.Caption = "View";
            this.ViewDoc.Category = "ListView";
            this.ViewDoc.ConfirmationMessage = null;
            this.ViewDoc.Id = "ViewDoc";
            this.ViewDoc.ToolTip = null;
            this.ViewDoc.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ViewDoc_Execute);
            // 
            // ViewDashboardDoc
            // 
            this.ViewDashboardDoc.AcceptButtonCaption = null;
            this.ViewDashboardDoc.CancelButtonCaption = null;
            this.ViewDashboardDoc.Caption = "View";
            this.ViewDashboardDoc.Category = "ListView";
            this.ViewDashboardDoc.ConfirmationMessage = null;
            this.ViewDashboardDoc.Id = "ViewDashboardDoc";
            this.ViewDashboardDoc.ToolTip = null;
            this.ViewDashboardDoc.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ViewDashboardDoc_CustomizePopupWindowParams);
            this.ViewDashboardDoc.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ViewDashboardDoc_Execute);
            // 
            // ViewDashboardDocSales
            // 
            this.ViewDashboardDocSales.AcceptButtonCaption = null;
            this.ViewDashboardDocSales.CancelButtonCaption = null;
            this.ViewDashboardDocSales.Caption = "View";
            this.ViewDashboardDocSales.Category = "ListView";
            this.ViewDashboardDocSales.ConfirmationMessage = null;
            this.ViewDashboardDocSales.Id = "ViewDashboardDocSales";
            this.ViewDashboardDocSales.ToolTip = null;
            this.ViewDashboardDocSales.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ViewDashboardDocSales_CustomizePopupWindowParams);
            this.ViewDashboardDocSales.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ViewDashboardDocSales_Execute);
            // 
            // ViewDocSales
            // 
            this.ViewDocSales.Caption = "View";
            this.ViewDocSales.Category = "ListView";
            this.ViewDocSales.ConfirmationMessage = null;
            this.ViewDocSales.Id = "ViewDocSales";
            this.ViewDocSales.ToolTip = null;
            this.ViewDocSales.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ViewDocSales_Execute);
            // 
            // ViewDashboardDocPurchase
            // 
            this.ViewDashboardDocPurchase.AcceptButtonCaption = null;
            this.ViewDashboardDocPurchase.CancelButtonCaption = null;
            this.ViewDashboardDocPurchase.Caption = "View";
            this.ViewDashboardDocPurchase.Category = "ListView";
            this.ViewDashboardDocPurchase.ConfirmationMessage = null;
            this.ViewDashboardDocPurchase.Id = "ViewDashboardDocPurchase";
            this.ViewDashboardDocPurchase.ToolTip = null;
            this.ViewDashboardDocPurchase.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ViewDashboardDocPurchase_CustomizePopupWindowParams);
            this.ViewDashboardDocPurchase.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ViewDashboardDocPurchase_Execute);
            // 
            // ViewDocPurchase
            // 
            this.ViewDocPurchase.Caption = "View";
            this.ViewDocPurchase.Category = "ListView";
            this.ViewDocPurchase.ConfirmationMessage = null;
            this.ViewDocPurchase.Id = "ViewDocPurchase";
            this.ViewDocPurchase.ToolTip = null;
            this.ViewDocPurchase.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ViewDocPurchase_Execute);
            // 
            // ViewDashboardDocWhs
            // 
            this.ViewDashboardDocWhs.AcceptButtonCaption = null;
            this.ViewDashboardDocWhs.CancelButtonCaption = null;
            this.ViewDashboardDocWhs.Caption = "View";
            this.ViewDashboardDocWhs.Category = "ListView";
            this.ViewDashboardDocWhs.ConfirmationMessage = null;
            this.ViewDashboardDocWhs.Id = "ViewDashboardDocWhs";
            this.ViewDashboardDocWhs.ToolTip = null;
            this.ViewDashboardDocWhs.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ViewDashboardDocWhs_CustomizePopupWindowParams);
            this.ViewDashboardDocWhs.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ViewDashboardDocWhs_Execute);
            // 
            // ViewDocWhs
            // 
            this.ViewDocWhs.Caption = "View";
            this.ViewDocWhs.Category = "ListView";
            this.ViewDocWhs.ConfirmationMessage = null;
            this.ViewDocWhs.Id = "ViewDocWhs";
            this.ViewDocWhs.ToolTip = null;
            this.ViewDocWhs.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ViewDocWhs_Execute);
            // 
            // DashboardsControllers
            // 
            this.Actions.Add(this.DashboardWarehouse);
            this.Actions.Add(this.ViewDoc);
            this.Actions.Add(this.ViewDashboardDoc);
            this.Actions.Add(this.ViewDashboardDocSales);
            this.Actions.Add(this.ViewDocSales);
            this.Actions.Add(this.ViewDashboardDocPurchase);
            this.Actions.Add(this.ViewDocPurchase);
            this.Actions.Add(this.ViewDashboardDocWhs);
            this.Actions.Add(this.ViewDocWhs);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SingleChoiceAction DashboardWarehouse;
        private DevExpress.ExpressApp.Actions.SimpleAction ViewDoc;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ViewDashboardDoc;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ViewDashboardDocSales;
        private DevExpress.ExpressApp.Actions.SimpleAction ViewDocSales;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ViewDashboardDocPurchase;
        private DevExpress.ExpressApp.Actions.SimpleAction ViewDocPurchase;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ViewDashboardDocWhs;
        private DevExpress.ExpressApp.Actions.SimpleAction ViewDocWhs;
    }
}
