namespace ZOVReminder
{
    partial class frmCalendar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendar));
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.mainSchedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.zOVAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalbaseDataSet = new ZOVReminder.GlobalbaseDataSet();
            this.zOVResourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.globalbaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zOVResourcesTableAdapter = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVResourcesTableAdapter();
            this.zOVAppointmentsTableAdapter = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVAppointmentsTableAdapter();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.openScheduleItem1 = new DevExpress.XtraScheduler.UI.OpenScheduleItem();
            this.saveScheduleItem1 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.printPreviewItem1 = new DevExpress.XtraScheduler.UI.PrintPreviewItem();
            this.printItem1 = new DevExpress.XtraScheduler.UI.PrintItem();
            this.printPageSetupItem1 = new DevExpress.XtraScheduler.UI.PrintPageSetupItem();
            this.newAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewAppointmentItem();
            this.newRecurringAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem();
            this.navigateViewBackwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewBackwardItem();
            this.navigateViewForwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewForwardItem();
            this.gotoTodayItem1 = new DevExpress.XtraScheduler.UI.GotoTodayItem();
            this.viewZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewZoomInItem();
            this.viewZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewZoomOutItem();
            this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
            this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
            this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
            this.switchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
            this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
            this.switchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
            this.switchToGanttViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToGanttViewItem();
            this.groupByNoneItem1 = new DevExpress.XtraScheduler.UI.GroupByNoneItem();
            this.groupByDateItem1 = new DevExpress.XtraScheduler.UI.GroupByDateItem();
            this.groupByResourceItem1 = new DevExpress.XtraScheduler.UI.GroupByResourceItem();
            this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
            this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
            this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
            this.switchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
            this.switchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
            this.changeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
            this.editAppointmentQueryItem1 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
            this.editOccurrenceUICommandItem1 = new DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem();
            this.editSeriesUICommandItem1 = new DevExpress.XtraScheduler.UI.EditSeriesUICommandItem();
            this.deleteAppointmentsItem1 = new DevExpress.XtraScheduler.UI.DeleteAppointmentsItem();
            this.deleteOccurrenceItem1 = new DevExpress.XtraScheduler.UI.DeleteOccurrenceItem();
            this.deleteSeriesItem1 = new DevExpress.XtraScheduler.UI.DeleteSeriesItem();
            this.splitAppointmentItem1 = new DevExpress.XtraScheduler.UI.SplitAppointmentItem();
            this.changeAppointmentStatusItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem();
            this.changeAppointmentLabelItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem();
            this.toggleRecurrenceItem1 = new DevExpress.XtraScheduler.UI.ToggleRecurrenceItem();
            this.changeAppointmentReminderItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.barButtonItemPasswords = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.calendarToolsRibbonPageCategory1 = new DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory();
            this.mainSchedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            this.appointmentRibbonPage1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPage();
            this.actionsRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup();
            this.optionsRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraScheduler.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.CommonRibbonPageGroup();
            this.printRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.PrintRibbonPageGroup();
            this.ribbonPageSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraScheduler.UI.HomeRibbonPage();
            this.appointmentRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup();
            this.navigatorRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup();
            this.arrangeRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup();
            this.groupByRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup();
            this.viewRibbonPage1 = new DevExpress.XtraScheduler.UI.ViewRibbonPage();
            this.activeViewRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup();
            this.timeScaleRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup();
            this.layoutRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup();
            this.schedulerBarController = new DevExpress.XtraScheduler.UI.SchedulerBarController();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSchedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVAppointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVResourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSchedulerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Location = new System.Drawing.Point(0, 1004);
            this.panelControlBottom.Size = new System.Drawing.Size(1862, 51);
            // 
            // simpleButtonApply
            // 
            this.simpleButtonApply.Location = new System.Drawing.Point(2078, 9);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(2290, 9);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.mainSchedulerControl);
            this.panelControlMain.Location = new System.Drawing.Point(0, 181);
            this.panelControlMain.Size = new System.Drawing.Size(1862, 823);
            // 
            // mainSchedulerStorage
            // 
            this.mainSchedulerStorage.AppointmentDependencies.DataSource = this.zOVAppointmentsBindingSource;
            this.mainSchedulerStorage.AppointmentDependencies.Mappings.DependentId = "StartDate";
            this.mainSchedulerStorage.AppointmentDependencies.Mappings.ParentId = "UniqueID";
            this.mainSchedulerStorage.AppointmentDependencies.Mappings.Type = "Type";
            this.mainSchedulerStorage.Appointments.DataSource = this.zOVAppointmentsBindingSource;
            this.mainSchedulerStorage.Appointments.Mappings.AllDay = "AllDay";
            this.mainSchedulerStorage.Appointments.Mappings.Description = "Description";
            this.mainSchedulerStorage.Appointments.Mappings.End = "EndDate";
            this.mainSchedulerStorage.Appointments.Mappings.Label = "Label";
            this.mainSchedulerStorage.Appointments.Mappings.Location = "Location";
            this.mainSchedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.mainSchedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.mainSchedulerStorage.Appointments.Mappings.ResourceId = "ResourceID";
            this.mainSchedulerStorage.Appointments.Mappings.Start = "StartDate";
            this.mainSchedulerStorage.Appointments.Mappings.Status = "Status";
            this.mainSchedulerStorage.Appointments.Mappings.Subject = "Subject";
            this.mainSchedulerStorage.Appointments.Mappings.TimeZoneId = "CustomField1";
            this.mainSchedulerStorage.Appointments.Mappings.Type = "Type";
            this.mainSchedulerStorage.RemindersCheckInterval = 1000;
            this.mainSchedulerStorage.Resources.DataSource = this.zOVResourcesBindingSource;
            this.mainSchedulerStorage.Resources.Mappings.Caption = "ResourceName";
            this.mainSchedulerStorage.Resources.Mappings.Color = "Color";
            this.mainSchedulerStorage.Resources.Mappings.Id = "ResourceID";
            this.mainSchedulerStorage.Resources.Mappings.Image = "Image";
            this.mainSchedulerStorage.Resources.Mappings.ParentId = "UniqueID";
            // 
            // zOVAppointmentsBindingSource
            // 
            this.zOVAppointmentsBindingSource.DataMember = "ZOVAppointments";
            this.zOVAppointmentsBindingSource.DataSource = this.globalbaseDataSet;
            // 
            // globalbaseDataSet
            // 
            this.globalbaseDataSet.DataSetName = "GlobalbaseDataSet";
            this.globalbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zOVResourcesBindingSource
            // 
            this.zOVResourcesBindingSource.DataMember = "ZOVResources";
            this.zOVResourcesBindingSource.DataSource = this.globalbaseDataSet;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 5000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // zOVResourcesTableAdapter
            // 
            this.zOVResourcesTableAdapter.ClearBeforeFill = true;
            // 
            // zOVAppointmentsTableAdapter
            // 
            this.zOVAppointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.openScheduleItem1,
            this.saveScheduleItem1,
            this.printPreviewItem1,
            this.printItem1,
            this.printPageSetupItem1,
            this.newAppointmentItem1,
            this.newRecurringAppointmentItem1,
            this.navigateViewBackwardItem1,
            this.navigateViewForwardItem1,
            this.gotoTodayItem1,
            this.viewZoomInItem1,
            this.viewZoomOutItem1,
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToFullWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchToTimelineViewItem1,
            this.switchToGanttViewItem1,
            this.groupByNoneItem1,
            this.groupByDateItem1,
            this.groupByResourceItem1,
            this.switchTimeScalesItem1,
            this.changeScaleWidthItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.switchShowWorkTimeOnlyItem1,
            this.switchCellsAutoHeightItem1,
            this.changeSnapToCellsUIItem1,
            this.editAppointmentQueryItem1,
            this.editOccurrenceUICommandItem1,
            this.editSeriesUICommandItem1,
            this.deleteAppointmentsItem1,
            this.deleteOccurrenceItem1,
            this.deleteSeriesItem1,
            this.splitAppointmentItem1,
            this.changeAppointmentStatusItem1,
            this.changeAppointmentLabelItem1,
            this.toggleRecurrenceItem1,
            this.changeAppointmentReminderItem1,
            this.barButtonItemPasswords});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.MiniToolbars.Add(this.ribbonMiniToolbar);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.calendarToolsRibbonPageCategory1});
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.ribbonPageSettings,
            this.homeRibbonPage1,
            this.viewRibbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemDuration1});
            this.ribbonControl.Size = new System.Drawing.Size(1862, 181);
            // 
            // openScheduleItem1
            // 
            this.openScheduleItem1.Id = 1;
            this.openScheduleItem1.Name = "openScheduleItem1";
            // 
            // saveScheduleItem1
            // 
            this.saveScheduleItem1.Id = 2;
            this.saveScheduleItem1.Name = "saveScheduleItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 3;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 4;
            this.printItem1.Name = "printItem1";
            // 
            // printPageSetupItem1
            // 
            this.printPageSetupItem1.Id = 5;
            this.printPageSetupItem1.Name = "printPageSetupItem1";
            // 
            // newAppointmentItem1
            // 
            this.newAppointmentItem1.Id = 6;
            this.newAppointmentItem1.Name = "newAppointmentItem1";
            // 
            // newRecurringAppointmentItem1
            // 
            this.newRecurringAppointmentItem1.Id = 7;
            this.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1";
            // 
            // navigateViewBackwardItem1
            // 
            this.navigateViewBackwardItem1.Id = 8;
            this.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1";
            // 
            // navigateViewForwardItem1
            // 
            this.navigateViewForwardItem1.Id = 9;
            this.navigateViewForwardItem1.Name = "navigateViewForwardItem1";
            // 
            // gotoTodayItem1
            // 
            this.gotoTodayItem1.Id = 10;
            this.gotoTodayItem1.Name = "gotoTodayItem1";
            // 
            // viewZoomInItem1
            // 
            this.viewZoomInItem1.Id = 11;
            this.viewZoomInItem1.Name = "viewZoomInItem1";
            // 
            // viewZoomOutItem1
            // 
            this.viewZoomOutItem1.Id = 12;
            this.viewZoomOutItem1.Name = "viewZoomOutItem1";
            // 
            // switchToDayViewItem1
            // 
            this.switchToDayViewItem1.Id = 13;
            this.switchToDayViewItem1.Name = "switchToDayViewItem1";
            // 
            // switchToWorkWeekViewItem1
            // 
            this.switchToWorkWeekViewItem1.Id = 14;
            this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
            // 
            // switchToWeekViewItem1
            // 
            this.switchToWeekViewItem1.Id = 15;
            this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
            // 
            // switchToFullWeekViewItem1
            // 
            this.switchToFullWeekViewItem1.Id = 16;
            this.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1";
            // 
            // switchToMonthViewItem1
            // 
            this.switchToMonthViewItem1.Id = 17;
            this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
            // 
            // switchToTimelineViewItem1
            // 
            this.switchToTimelineViewItem1.Id = 18;
            this.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1";
            // 
            // switchToGanttViewItem1
            // 
            this.switchToGanttViewItem1.Id = 19;
            this.switchToGanttViewItem1.Name = "switchToGanttViewItem1";
            // 
            // groupByNoneItem1
            // 
            this.groupByNoneItem1.Id = 20;
            this.groupByNoneItem1.Name = "groupByNoneItem1";
            // 
            // groupByDateItem1
            // 
            this.groupByDateItem1.Id = 21;
            this.groupByDateItem1.Name = "groupByDateItem1";
            // 
            // groupByResourceItem1
            // 
            this.groupByResourceItem1.Id = 22;
            this.groupByResourceItem1.Name = "groupByResourceItem1";
            // 
            // switchTimeScalesItem1
            // 
            this.switchTimeScalesItem1.Id = 23;
            this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
            // 
            // changeScaleWidthItem1
            // 
            this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
            this.changeScaleWidthItem1.Id = 24;
            this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
            this.changeScaleWidthItem1.UseCommandCaption = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // switchTimeScalesCaptionItem1
            // 
            this.switchTimeScalesCaptionItem1.Id = 25;
            this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
            // 
            // switchCompressWeekendItem1
            // 
            this.switchCompressWeekendItem1.Id = 26;
            this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
            // 
            // switchShowWorkTimeOnlyItem1
            // 
            this.switchShowWorkTimeOnlyItem1.BindableChecked = true;
            this.switchShowWorkTimeOnlyItem1.Checked = true;
            this.switchShowWorkTimeOnlyItem1.Id = 27;
            this.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1";
            // 
            // switchCellsAutoHeightItem1
            // 
            this.switchCellsAutoHeightItem1.Id = 28;
            this.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1";
            // 
            // changeSnapToCellsUIItem1
            // 
            this.changeSnapToCellsUIItem1.Id = 29;
            this.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1";
            // 
            // editAppointmentQueryItem1
            // 
            this.editAppointmentQueryItem1.Id = 30;
            this.editAppointmentQueryItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.editOccurrenceUICommandItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.editSeriesUICommandItem1)});
            this.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1";
            this.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // editOccurrenceUICommandItem1
            // 
            this.editOccurrenceUICommandItem1.Id = 31;
            this.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1";
            // 
            // editSeriesUICommandItem1
            // 
            this.editSeriesUICommandItem1.Id = 32;
            this.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1";
            // 
            // deleteAppointmentsItem1
            // 
            this.deleteAppointmentsItem1.Id = 33;
            this.deleteAppointmentsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteOccurrenceItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteSeriesItem1)});
            this.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1";
            this.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // deleteOccurrenceItem1
            // 
            this.deleteOccurrenceItem1.Id = 34;
            this.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1";
            // 
            // deleteSeriesItem1
            // 
            this.deleteSeriesItem1.Id = 35;
            this.deleteSeriesItem1.Name = "deleteSeriesItem1";
            // 
            // splitAppointmentItem1
            // 
            this.splitAppointmentItem1.Id = 36;
            this.splitAppointmentItem1.Name = "splitAppointmentItem1";
            // 
            // changeAppointmentStatusItem1
            // 
            this.changeAppointmentStatusItem1.Id = 37;
            this.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1";
            // 
            // changeAppointmentLabelItem1
            // 
            this.changeAppointmentLabelItem1.Id = 38;
            this.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1";
            // 
            // toggleRecurrenceItem1
            // 
            this.toggleRecurrenceItem1.Id = 39;
            this.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1";
            // 
            // changeAppointmentReminderItem1
            // 
            this.changeAppointmentReminderItem1.Edit = this.repositoryItemDuration1;
            this.changeAppointmentReminderItem1.Id = 40;
            this.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1";
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.DisabledStateText = null;
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // barButtonItemPasswords
            // 
            this.barButtonItemPasswords.Caption = "Пароли";
            this.barButtonItemPasswords.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemPasswords.Glyph")));
            this.barButtonItemPasswords.Id = 2;
            this.barButtonItemPasswords.Name = "barButtonItemPasswords";
            this.barButtonItemPasswords.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemPasswords.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPasswords_ItemClick);
            // 
            // calendarToolsRibbonPageCategory1
            // 
            this.calendarToolsRibbonPageCategory1.Control = this.mainSchedulerControl;
            this.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1";
            this.calendarToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.appointmentRibbonPage1});
            this.calendarToolsRibbonPageCategory1.Visible = false;
            // 
            // mainSchedulerControl
            // 
            this.mainSchedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSchedulerControl.Location = new System.Drawing.Point(2, 2);
            this.mainSchedulerControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainSchedulerControl.MenuManager = this.ribbonControl;
            this.mainSchedulerControl.Name = "mainSchedulerControl";
            this.mainSchedulerControl.Size = new System.Drawing.Size(1858, 819);
            this.mainSchedulerControl.Start = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.mainSchedulerControl.Storage = this.mainSchedulerStorage;
            this.mainSchedulerControl.TabIndex = 4;
            this.mainSchedulerControl.Text = "mainShedulerControl";
            this.mainSchedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            this.mainSchedulerControl.Views.FullWeekView.Enabled = true;
            this.mainSchedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.mainSchedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // appointmentRibbonPage1
            // 
            this.appointmentRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.actionsRibbonPageGroup1,
            this.optionsRibbonPageGroup1});
            this.appointmentRibbonPage1.Name = "appointmentRibbonPage1";
            this.appointmentRibbonPage1.Visible = false;
            // 
            // actionsRibbonPageGroup1
            // 
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.editAppointmentQueryItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.deleteAppointmentsItem1);
            this.actionsRibbonPageGroup1.ItemLinks.Add(this.splitAppointmentItem1);
            this.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1";
            // 
            // optionsRibbonPageGroup1
            // 
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentStatusItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentLabelItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.toggleRecurrenceItem1);
            this.optionsRibbonPageGroup1.ItemLinks.Add(this.changeAppointmentReminderItem1);
            this.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.printRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.Group = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            this.fileRibbonPage1.ReduceOperations.Add(reduceOperation1);
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.openScheduleItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.saveScheduleItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // printRibbonPageGroup1
            // 
            this.printRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.printRibbonPageGroup1.ItemLinks.Add(this.printItem1);
            this.printRibbonPageGroup1.ItemLinks.Add(this.printPageSetupItem1);
            this.printRibbonPageGroup1.Name = "printRibbonPageGroup1";
            // 
            // ribbonPageSettings
            // 
            this.ribbonPageSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSettings});
            this.ribbonPageSettings.Name = "ribbonPageSettings";
            this.ribbonPageSettings.Text = "Настройки";
            // 
            // ribbonPageGroupSettings
            // 
            this.ribbonPageGroupSettings.ItemLinks.Add(this.barButtonItemPasswords);
            this.ribbonPageGroupSettings.Name = "ribbonPageGroupSettings";
            this.ribbonPageGroupSettings.Text = "Настройки";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.appointmentRibbonPageGroup1,
            this.navigatorRibbonPageGroup1,
            this.arrangeRibbonPageGroup1,
            this.groupByRibbonPageGroup1});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            // 
            // appointmentRibbonPageGroup1
            // 
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newAppointmentItem1);
            this.appointmentRibbonPageGroup1.ItemLinks.Add(this.newRecurringAppointmentItem1);
            this.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1";
            // 
            // navigatorRibbonPageGroup1
            // 
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewBackwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.navigateViewForwardItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.gotoTodayItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomInItem1);
            this.navigatorRibbonPageGroup1.ItemLinks.Add(this.viewZoomOutItem1);
            this.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1";
            // 
            // arrangeRibbonPageGroup1
            // 
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.arrangeRibbonPageGroup1.ItemLinks.Add(this.switchToGanttViewItem1);
            this.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1";
            // 
            // groupByRibbonPageGroup1
            // 
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByNoneItem1);
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByDateItem1);
            this.groupByRibbonPageGroup1.ItemLinks.Add(this.groupByResourceItem1);
            this.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.activeViewRibbonPageGroup1,
            this.timeScaleRibbonPageGroup1,
            this.layoutRibbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // activeViewRibbonPageGroup1
            // 
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToDayViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWorkWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToFullWeekViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToMonthViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToTimelineViewItem1);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.switchToGanttViewItem1);
            this.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1";
            // 
            // timeScaleRibbonPageGroup1
            // 
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.switchTimeScalesItem1);
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.changeScaleWidthItem1);
            this.timeScaleRibbonPageGroup1.ItemLinks.Add(this.switchTimeScalesCaptionItem1);
            this.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1";
            // 
            // layoutRibbonPageGroup1
            // 
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchCompressWeekendItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchShowWorkTimeOnlyItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.switchCellsAutoHeightItem1);
            this.layoutRibbonPageGroup1.ItemLinks.Add(this.changeSnapToCellsUIItem1);
            this.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1";
            // 
            // schedulerBarController
            // 
            this.schedulerBarController.BarItems.Add(this.openScheduleItem1);
            this.schedulerBarController.BarItems.Add(this.saveScheduleItem1);
            this.schedulerBarController.BarItems.Add(this.printPreviewItem1);
            this.schedulerBarController.BarItems.Add(this.printItem1);
            this.schedulerBarController.BarItems.Add(this.printPageSetupItem1);
            this.schedulerBarController.BarItems.Add(this.newAppointmentItem1);
            this.schedulerBarController.BarItems.Add(this.newRecurringAppointmentItem1);
            this.schedulerBarController.BarItems.Add(this.navigateViewBackwardItem1);
            this.schedulerBarController.BarItems.Add(this.navigateViewForwardItem1);
            this.schedulerBarController.BarItems.Add(this.gotoTodayItem1);
            this.schedulerBarController.BarItems.Add(this.viewZoomInItem1);
            this.schedulerBarController.BarItems.Add(this.viewZoomOutItem1);
            this.schedulerBarController.BarItems.Add(this.switchToDayViewItem1);
            this.schedulerBarController.BarItems.Add(this.switchToWorkWeekViewItem1);
            this.schedulerBarController.BarItems.Add(this.switchToWeekViewItem1);
            this.schedulerBarController.BarItems.Add(this.switchToFullWeekViewItem1);
            this.schedulerBarController.BarItems.Add(this.switchToMonthViewItem1);
            this.schedulerBarController.BarItems.Add(this.switchToTimelineViewItem1);
            this.schedulerBarController.BarItems.Add(this.switchToGanttViewItem1);
            this.schedulerBarController.BarItems.Add(this.groupByNoneItem1);
            this.schedulerBarController.BarItems.Add(this.groupByDateItem1);
            this.schedulerBarController.BarItems.Add(this.groupByResourceItem1);
            this.schedulerBarController.BarItems.Add(this.switchTimeScalesItem1);
            this.schedulerBarController.BarItems.Add(this.changeScaleWidthItem1);
            this.schedulerBarController.BarItems.Add(this.switchTimeScalesCaptionItem1);
            this.schedulerBarController.BarItems.Add(this.switchCompressWeekendItem1);
            this.schedulerBarController.BarItems.Add(this.switchShowWorkTimeOnlyItem1);
            this.schedulerBarController.BarItems.Add(this.switchCellsAutoHeightItem1);
            this.schedulerBarController.BarItems.Add(this.changeSnapToCellsUIItem1);
            this.schedulerBarController.BarItems.Add(this.editAppointmentQueryItem1);
            this.schedulerBarController.BarItems.Add(this.editOccurrenceUICommandItem1);
            this.schedulerBarController.BarItems.Add(this.editSeriesUICommandItem1);
            this.schedulerBarController.BarItems.Add(this.deleteAppointmentsItem1);
            this.schedulerBarController.BarItems.Add(this.deleteOccurrenceItem1);
            this.schedulerBarController.BarItems.Add(this.deleteSeriesItem1);
            this.schedulerBarController.BarItems.Add(this.splitAppointmentItem1);
            this.schedulerBarController.BarItems.Add(this.changeAppointmentStatusItem1);
            this.schedulerBarController.BarItems.Add(this.changeAppointmentLabelItem1);
            this.schedulerBarController.BarItems.Add(this.toggleRecurrenceItem1);
            this.schedulerBarController.BarItems.Add(this.changeAppointmentReminderItem1);
            this.schedulerBarController.Control = this.mainSchedulerControl;
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1862, 1055);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmCalendar";
            this.Text = "ЗОВ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.panelControlBottom, 0);
            this.Controls.SetChildIndex(this.panelControlMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSchedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVAppointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVResourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSchedulerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage mainSchedulerStorage;
        private System.Windows.Forms.BindingSource globalbaseDataSetBindingSource;
        private GlobalbaseDataSet globalbaseDataSet;
        private System.Windows.Forms.BindingSource zOVResourcesBindingSource;
        private GlobalbaseDataSetTableAdapters.ZOVResourcesTableAdapter zOVResourcesTableAdapter;
        private System.Windows.Forms.BindingSource zOVAppointmentsBindingSource;
        private GlobalbaseDataSetTableAdapters.ZOVAppointmentsTableAdapter zOVAppointmentsTableAdapter;
        private System.Windows.Forms.Timer timerMain;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraScheduler.UI.OpenScheduleItem openScheduleItem1;
        private DevExpress.XtraScheduler.UI.SaveScheduleItem saveScheduleItem1;
        private DevExpress.XtraScheduler.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraScheduler.UI.PrintItem printItem1;
        private DevExpress.XtraScheduler.UI.PrintPageSetupItem printPageSetupItem1;
        private DevExpress.XtraScheduler.UI.NewAppointmentItem newAppointmentItem1;
        private DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem newRecurringAppointmentItem1;
        private DevExpress.XtraScheduler.UI.NavigateViewBackwardItem navigateViewBackwardItem1;
        private DevExpress.XtraScheduler.UI.NavigateViewForwardItem navigateViewForwardItem1;
        private DevExpress.XtraScheduler.UI.GotoTodayItem gotoTodayItem1;
        private DevExpress.XtraScheduler.UI.ViewZoomInItem viewZoomInItem1;
        private DevExpress.XtraScheduler.UI.ViewZoomOutItem viewZoomOutItem1;
        private DevExpress.XtraScheduler.UI.SwitchToDayViewItem switchToDayViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToWeekViewItem switchToWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem switchToFullWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToMonthViewItem switchToMonthViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem switchToTimelineViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToGanttViewItem switchToGanttViewItem1;
        private DevExpress.XtraScheduler.UI.GroupByNoneItem groupByNoneItem1;
        private DevExpress.XtraScheduler.UI.GroupByDateItem groupByDateItem1;
        private DevExpress.XtraScheduler.UI.GroupByResourceItem groupByResourceItem1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesItem switchTimeScalesItem1;
        private DevExpress.XtraScheduler.UI.ChangeScaleWidthItem changeScaleWidthItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
        private DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem switchCompressWeekendItem1;
        private DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem switchShowWorkTimeOnlyItem1;
        private DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem switchCellsAutoHeightItem1;
        private DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem changeSnapToCellsUIItem1;
        private DevExpress.XtraScheduler.UI.EditAppointmentQueryItem editAppointmentQueryItem1;
        private DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem editOccurrenceUICommandItem1;
        private DevExpress.XtraScheduler.UI.EditSeriesUICommandItem editSeriesUICommandItem1;
        private DevExpress.XtraScheduler.UI.DeleteAppointmentsItem deleteAppointmentsItem1;
        private DevExpress.XtraScheduler.UI.DeleteOccurrenceItem deleteOccurrenceItem1;
        private DevExpress.XtraScheduler.UI.DeleteSeriesItem deleteSeriesItem1;
        private DevExpress.XtraScheduler.UI.SplitAppointmentItem splitAppointmentItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem changeAppointmentStatusItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem changeAppointmentLabelItem1;
        private DevExpress.XtraScheduler.UI.ToggleRecurrenceItem toggleRecurrenceItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem changeAppointmentReminderItem1;
        private DevExpress.XtraScheduler.UI.RepositoryItemDuration repositoryItemDuration1;
        private DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory calendarToolsRibbonPageCategory1;
        private DevExpress.XtraScheduler.UI.AppointmentRibbonPage appointmentRibbonPage1;
        private DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup actionsRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup optionsRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraScheduler.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.PrintRibbonPageGroup printRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.HomeRibbonPage homeRibbonPage1;
        private DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup appointmentRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup navigatorRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup arrangeRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup groupByRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.ViewRibbonPage viewRibbonPage1;
        private DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup activeViewRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup timeScaleRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup layoutRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.SchedulerBarController schedulerBarController;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPasswords;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSettings;
        private DevExpress.XtraScheduler.SchedulerControl mainSchedulerControl;
    }
}

