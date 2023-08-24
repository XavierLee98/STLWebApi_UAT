namespace StarLaiPortal.Module.Controllers
{
    partial class SalesOrderControllers
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
            this.PreviewSO = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.CancelSO = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.CloseSO = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // PreviewSO
            // 
            this.PreviewSO.Caption = "Preview";
            this.PreviewSO.Category = "ObjectsCreation";
            this.PreviewSO.ConfirmationMessage = null;
            this.PreviewSO.Id = "PreviewSO";
            this.PreviewSO.ToolTip = null;
            this.PreviewSO.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PreviewSO_Execute);
            // 
            // CancelSO
            // 
            this.CancelSO.AcceptButtonCaption = null;
            this.CancelSO.CancelButtonCaption = null;
            this.CancelSO.Caption = "Cancel";
            this.CancelSO.Category = "ObjectsCreation";
            this.CancelSO.ConfirmationMessage = null;
            this.CancelSO.Id = "CancelSO";
            this.CancelSO.ToolTip = null;
            this.CancelSO.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.CancelSO_CustomizePopupWindowParams);
            this.CancelSO.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.CancelSO_Execute);
            // 
            // CloseSO
            // 
            this.CloseSO.AcceptButtonCaption = null;
            this.CloseSO.CancelButtonCaption = null;
            this.CloseSO.Caption = "Close";
            this.CloseSO.Category = "ObjectsCreation";
            this.CloseSO.ConfirmationMessage = null;
            this.CloseSO.Id = "CloseSO";
            this.CloseSO.ToolTip = null;
            this.CloseSO.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.CloseSO_CustomizePopupWindowParams);
            this.CloseSO.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.CloseSO_Execute);
            // 
            // SalesOrderControllers
            // 
            this.Actions.Add(this.PreviewSO);
            this.Actions.Add(this.CancelSO);
            this.Actions.Add(this.CloseSO);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction PreviewSO;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction CancelSO;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction CloseSO;
    }
}
