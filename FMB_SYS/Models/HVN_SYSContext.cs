using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace FMB_SYS.Models
{
    public partial class HVN_SYSContext : DbContext
    {
        public HVN_SYSContext()
        {
        }

        public HVN_SYSContext(DbContextOptions<HVN_SYSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AdmCheckTime> AdmCheckTimes { get; set; }
        public virtual DbSet<AdmDataGridInfor> AdmDataGridInfors { get; set; }
        public virtual DbSet<AdmDocument> AdmDocuments { get; set; }
        public virtual DbSet<AdmDurationControl> AdmDurationControls { get; set; }
        public virtual DbSet<AdmLogActivity> AdmLogActivities { get; set; }
        public virtual DbSet<AdmMasterListForm> AdmMasterListForms { get; set; }
        public virtual DbSet<AdmMasterListParameter> AdmMasterListParameters { get; set; }
        public virtual DbSet<AdmPersonInChargeOfProcess> AdmPersonInChargeOfProcesses { get; set; }
        public virtual DbSet<AdmToolboxOfForm> AdmToolboxOfForms { get; set; }
        public virtual DbSet<AdmToolboxPermission> AdmToolboxPermissions { get; set; }
        public virtual DbSet<HrMasterlistRestTime> HrMasterlistRestTimes { get; set; }
        public virtual DbSet<HrVrVisitorInfor> HrVrVisitorInfors { get; set; }
        public virtual DbSet<KpiActionMonitoring> KpiActionMonitorings { get; set; }
        public virtual DbSet<KpiHrAbsenteeism> KpiHrAbsenteeisms { get; set; }
        public virtual DbSet<KpiHrLaborResource> KpiHrLaborResources { get; set; }
        public virtual DbSet<KpiHrOt> KpiHrOts { get; set; }
        public virtual DbSet<KpiHrOtbyLocation> KpiHrOtbyLocations { get; set; }
        public virtual DbSet<KpiHrOtbySection> KpiHrOtbySections { get; set; }
        public virtual DbSet<KpiHrTrir> KpiHrTrirs { get; set; }
        public virtual DbSet<KpiHrTurnoverRate> KpiHrTurnoverRates { get; set; }
        public virtual DbSet<KpiIncidentMonitoring> KpiIncidentMonitorings { get; set; }
        public virtual DbSet<KpiLogExceptionFreight> KpiLogExceptionFreights { get; set; }
        public virtual DbSet<KpiLogSale> KpiLogSales { get; set; }
        public virtual DbSet<KpiMaintDiesel> KpiMaintDiesels { get; set; }
        public virtual DbSet<KpiMaintElectricity> KpiMaintElectricities { get; set; }
        public virtual DbSet<KpiMaintEnergyDetail> KpiMaintEnergyDetails { get; set; }
        public virtual DbSet<KpiMaintWater> KpiMaintWaters { get; set; }
        public virtual DbSet<KpiPdEfficiency> KpiPdEfficiencies { get; set; }
        public virtual DbSet<KpiPdQtyFg> KpiPdQtyFgs { get; set; }
        public virtual DbSet<KpiPlantDashBoard> KpiPlantDashBoards { get; set; }
        public virtual DbSet<KpiQcMtr> KpiQcMtrs { get; set; }
        public virtual DbSet<KpiQcNqc> KpiQcNqcs { get; set; }
        public virtual DbSet<KpiQcPpm> KpiQcPpms { get; set; }
        public virtual DbSet<KpiQcPpmbyCustomer> KpiQcPpmbyCustomers { get; set; }
        public virtual DbSet<KpiQcPpmcustomer> KpiQcPpmcustomers { get; set; }
        public virtual DbSet<KpiQcPpmincoming> KpiQcPpmincomings { get; set; }
        public virtual DbSet<KpiQcSupplierClaim> KpiQcSupplierClaims { get; set; }
        public virtual DbSet<LogEstimateExceptional> LogEstimateExceptionals { get; set; }
        public virtual DbSet<LogInvoice> LogInvoices { get; set; }
        public virtual DbSet<LogInvoiceDetail> LogInvoiceDetails { get; set; }
        public virtual DbSet<LogSMasterlistSupplier> LogSMasterlistSuppliers { get; set; }
        public virtual DbSet<MMonitorIssue> MMonitorIssues { get; set; }
        public virtual DbSet<PDashboardFg> PDashboardFgs { get; set; }
        public virtual DbSet<PErrorScanLog> PErrorScanLogs { get; set; }
        public virtual DbSet<PFmbLabResult> PFmbLabResults { get; set; }
        public virtual DbSet<PFmbMasterListRubber> PFmbMasterListRubbers { get; set; }
        public virtual DbSet<PFmbMasterLocationRubber> PFmbMasterLocationRubbers { get; set; }
        public virtual DbSet<PLabel> PLabels { get; set; }
        public virtual DbSet<PMasterListLine> PMasterListLines { get; set; }
        public virtual DbSet<PMasterListProduct> PMasterListProducts { get; set; }
        public virtual DbSet<PMasterListProductBom> PMasterListProductBoms { get; set; }
        public virtual DbSet<PMasterListProductSubmit> PMasterListProductSubmits { get; set; }
        public virtual DbSet<PMasterListScanner> PMasterListScanners { get; set; }
        public virtual DbSet<PMasterListShift> PMasterListShifts { get; set; }
        public virtual DbSet<PlPlanFg> PlPlanFgs { get; set; }
        public virtual DbSet<PurPr> PurPrs { get; set; }
        public virtual DbSet<PurPrdetail> PurPrdetails { get; set; }
        public virtual DbSet<QcChemicalLabel> QcChemicalLabels { get; set; }
        public virtual DbSet<QcFgNgpart> QcFgNgparts { get; set; }
        public virtual DbSet<QcMNgpart> QcMNgparts { get; set; }
        public virtual DbSet<QcMasterListChemical> QcMasterListChemicals { get; set; }
        public virtual DbSet<TempCurrentProductionFg> TempCurrentProductionFgs { get; set; }
        public virtual DbSet<TempPFgPrintNewLabel> TempPFgPrintNewLabels { get; set; }
        public virtual DbSet<TempWMIssueToQc> TempWMIssueToQcs { get; set; }
        public virtual DbSet<TempWMReceiving> TempWMReceivings { get; set; }
        public virtual DbSet<TempWShippingInfor> TempWShippingInfors { get; set; }
        public virtual DbSet<ViewKpiLogSale> ViewKpiLogSales { get; set; }
        public virtual DbSet<WCycleCount> WCycleCounts { get; set; }
        public virtual DbSet<WCycleCountInventory> WCycleCountInventories { get; set; }
        public virtual DbSet<WCycleCountListPartial> WCycleCountListPartials { get; set; }
        public virtual DbSet<WHistoryOfTransaction> WHistoryOfTransactions { get; set; }
        public virtual DbSet<WMCheckingPlan> WMCheckingPlans { get; set; }
        public virtual DbSet<WMCheckingPlanDetail> WMCheckingPlanDetails { get; set; }
        public virtual DbSet<WMHistoryOfTransaction> WMHistoryOfTransactions { get; set; }
        public virtual DbSet<WMIssueDoc> WMIssueDocs { get; set; }
        public virtual DbSet<WMIssueDocDetail> WMIssueDocDetails { get; set; }
        public virtual DbSet<WMIssueLabel> WMIssueLabels { get; set; }
        public virtual DbSet<WMReceiveDoc> WMReceiveDocs { get; set; }
        public virtual DbSet<WMReceiveDocDetail> WMReceiveDocDetails { get; set; }
        public virtual DbSet<WMReceiveLabel> WMReceiveLabels { get; set; }
        public virtual DbSet<WMasterListLocation> WMasterListLocations { get; set; }
        public virtual DbSet<WMasterListMaterial> WMasterListMaterials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                                                                .SetBasePath(Directory.GetCurrentDirectory())
                                                                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                optionsBuilder.UseSqlServer("server =172.16.180.24; database = HVN_SYS;uid=hvn;pwd=Vietnam2023;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Korean_Wansung_CI_AS");

            modelBuilder.Entity<About>(entity =>
            {
                entity.HasKey(e => e.Application);

                entity.ToTable("About");

                entity.Property(e => e.Application)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account");

                entity.Property(e => e.AdAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AD_account");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DirectManager)
                    .HasMaxLength(50)
                    .HasColumnName("Direct_manager");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Email_address");

                entity.Property(e => e.IsUpdate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isUpdate");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<AdmCheckTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADM_CheckTime");

                entity.Property(e => e.TimeApp)
                    .HasColumnType("datetime")
                    .HasColumnName("Time_APP");

                entity.Property(e => e.TimeErp)
                    .HasColumnType("datetime")
                    .HasColumnName("Time_ERP");
            });

            modelBuilder.Entity<AdmDataGridInfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADM_DataGridInfor");

                entity.Property(e => e.ColumnDes)
                    .HasMaxLength(200)
                    .HasColumnName("column_des");

                entity.Property(e => e.ColumnField)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("column_field");

                entity.Property(e => e.ColumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("column_type");

                entity.Property(e => e.DgvColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dgv_column");

                entity.Property(e => e.DgvName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dgv_name");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(50)
                    .HasColumnName("name_EN");

                entity.Property(e => e.NameVn)
                    .HasMaxLength(50)
                    .HasColumnName("name_VN");
            });

            modelBuilder.Entity<AdmDocument>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("ADM_Document");

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.DocContent)
                    .IsUnicode(false)
                    .HasColumnName("doc_content");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasColumnName("doc_date");

                entity.Property(e => e.DocKind)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doc_kind");

                entity.Property(e => e.DocLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("doc_link");

                entity.Property(e => e.DocNote)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doc_note");

                entity.Property(e => e.TimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("time_commit");
            });

            modelBuilder.Entity<AdmDurationControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADM_DurationControl");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parent_name");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.ValuesNumber).HasColumnName("values_number");

                entity.Property(e => e.ValuesString)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("values_string");
            });

            modelBuilder.Entity<AdmLogActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADM_LogActivities");

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("action");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("computer_name");

                entity.Property(e => e.LastTimeCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<AdmMasterListForm>(entity =>
            {
                entity.HasKey(e => e.FrmName);

                entity.ToTable("ADM_MasterListForm");

                entity.Property(e => e.FrmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("frm_name");

                entity.Property(e => e.FrmDesEn)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("frm_des_EN");

                entity.Property(e => e.FrmDesVn)
                    .HasMaxLength(200)
                    .HasColumnName("frm_des_VN");
            });

            modelBuilder.Entity<AdmMasterListParameter>(entity =>
            {
                entity.HasKey(e => new { e.ParentId, e.ChildId });

                entity.ToTable("ADM_MasterListParameter");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parent_id");

                entity.Property(e => e.ChildId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("child_id");

                entity.Property(e => e.ChildDes)
                    .HasMaxLength(100)
                    .HasColumnName("child_des");

                entity.Property(e => e.ChildName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("child_name");
            });

            modelBuilder.Entity<AdmPersonInChargeOfProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADM_PersonInChargeOfProcess");

                entity.Property(e => e.PicUser)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("pic_user");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("procedure_name");

                entity.Property(e => e.StepName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("step_name");

                entity.Property(e => e.StepNo).HasColumnName("step_no");
            });

            modelBuilder.Entity<AdmToolboxOfForm>(entity =>
            {
                entity.HasKey(e => new { e.ToolboxName, e.FrmName });

                entity.ToTable("ADM_ToolboxOfForm");

                entity.Property(e => e.ToolboxName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("toolbox_name");

                entity.Property(e => e.FrmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("frm_name");

                entity.Property(e => e.ToolboxDes)
                    .HasMaxLength(200)
                    .HasColumnName("toolbox_des");

                entity.Property(e => e.ToolboxGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("toolbox_group");
            });

            modelBuilder.Entity<AdmToolboxPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADM_ToolboxPermission");

                entity.Property(e => e.FrmName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("frm_name");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.ToolboxName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("toolbox_name");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<HrMasterlistRestTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_MasterlistRestTime");

                entity.Property(e => e.NumberMinRest).HasColumnName("number_min_rest");

                entity.Property(e => e.PlusMinute).HasColumnName("plus_minute");

                entity.Property(e => e.RestTime).HasColumnName("rest_time");

                entity.Property(e => e.RowId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("row_id");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("shift_name");
            });

            modelBuilder.Entity<HrVrVisitorInfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HR_VR_VisitorInfor");

                entity.Property(e => e.CarryOnItem)
                    .HasMaxLength(200)
                    .HasColumnName("carry_on_item");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.HrRegId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("hr_reg_id");

                entity.Property(e => e.IdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_no");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("is_active");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.LicPlate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lic_plate");

                entity.Property(e => e.NumberVisitor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("number_visitor");

                entity.Property(e => e.Protect)
                    .HasMaxLength(200)
                    .HasColumnName("protect");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(200)
                    .HasColumnName("purpose");

                entity.Property(e => e.RegDate)
                    .HasColumnType("date")
                    .HasColumnName("reg_date");

                entity.Property(e => e.RegLunch)
                    .HasMaxLength(50)
                    .HasColumnName("reg_lunch");

                entity.Property(e => e.RegSpecial)
                    .HasMaxLength(200)
                    .HasColumnName("reg_special");

                entity.Property(e => e.Registor)
                    .HasMaxLength(50)
                    .HasColumnName("registor");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TimeIn)
                    .HasColumnType("datetime")
                    .HasColumnName("time_in");

                entity.Property(e => e.TimeOut)
                    .HasColumnType("datetime")
                    .HasColumnName("time_out");

                entity.Property(e => e.Training)
                    .HasMaxLength(200)
                    .HasColumnName("training");

                entity.Property(e => e.UserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_commit");

                entity.Property(e => e.Visitor)
                    .HasMaxLength(200)
                    .HasColumnName("visitor");

                entity.Property(e => e.VisitorCompany)
                    .HasMaxLength(200)
                    .HasColumnName("visitor_company");
            });

            modelBuilder.Entity<KpiActionMonitoring>(entity =>
            {
                entity.HasKey(e => e.CheckId);

                entity.ToTable("KPI_ActionMonitoring");

                entity.Property(e => e.CheckId).HasColumnName("check_id");

                entity.Property(e => e.ActDes)
                    .HasMaxLength(300)
                    .HasColumnName("act_des");

                entity.Property(e => e.ActName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("act_name");

                entity.Property(e => e.AssignedUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assigned_user");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.IncName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inc_name");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.PlannedFor)
                    .HasColumnType("date")
                    .HasColumnName("planned_for");

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("priority");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Theme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theme");
            });

            modelBuilder.Entity<KpiHrAbsenteeism>(entity =>
            {
                entity.HasKey(e => e.AbsentId);

                entity.ToTable("KPI_HR_Absenteeism");

                entity.Property(e => e.AbsentId).HasColumnName("Absent_id");

                entity.Property(e => e.AbsentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Absent_type");

                entity.Property(e => e.Comment).HasMaxLength(300);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeNo).HasColumnName("Employee_no");
            });

            modelBuilder.Entity<KpiHrLaborResource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_HR_LaborResources");

                entity.Property(e => e.AbsentAbnormal).HasColumnName("Absent_abnormal");

                entity.Property(e => e.AbsentAbnormalGroup).HasColumnName("Absent_abnormal_group");

                entity.Property(e => e.AbsentAlCl).HasColumnName("Absent_al_cl");

                entity.Property(e => e.AbsentNormal).HasColumnName("Absent_normal");

                entity.Property(e => e.AbsentOff).HasColumnName("Absent_off");

                entity.Property(e => e.AbsentTarget).HasColumnName("Absent_target");

                entity.Property(e => e.CumulLabor).HasColumnName("Cumul_labor");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.HcDirect).HasColumnName("HC_Direct");

                entity.Property(e => e.HcIndirect).HasColumnName("HC_Indirect");

                entity.Property(e => e.LaborAndOt).HasColumnName("LaborAndOT");

                entity.Property(e => e.Mod).HasColumnName("MOD");

                entity.Property(e => e.Moi).HasColumnName("MOI");

                entity.Property(e => e.PltHc).HasColumnName("PLT_HC");

                entity.Property(e => e.Sop).HasColumnName("SOP");
            });

            modelBuilder.Entity<KpiHrOt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_HR_OT");

                entity.Property(e => e.CumulOt).HasColumnName("CumulOT");

                entity.Property(e => e.CumulOtAbnormal).HasColumnName("CumulOT_abnormal");

                entity.Property(e => e.CumulOtNormal).HasColumnName("CumulOT_normal");

                entity.Property(e => e.CumulTargetOt).HasColumnName("CumulTargetOT");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Ot).HasColumnName("OT");

                entity.Property(e => e.OtAbnormal).HasColumnName("OT_abnormal");

                entity.Property(e => e.OtAmountDirect).HasColumnName("OT_amount_direct");

                entity.Property(e => e.OtAmountIndirect).HasColumnName("OT_amount_indirect");

                entity.Property(e => e.OtDirect).HasColumnName("OT_direct");

                entity.Property(e => e.OtIndirect).HasColumnName("OT_indirect");

                entity.Property(e => e.OtNormal).HasColumnName("OT_normal");

                entity.Property(e => e.OtPercentDirect).HasColumnName("OT_percent_direct");

                entity.Property(e => e.OtPercentIndirect).HasColumnName("OT_percent_indirect");

                entity.Property(e => e.TargetOt).HasColumnName("TargetOT");
            });

            modelBuilder.Entity<KpiHrOtbyLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_HR_OTByLocation");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Gp12).HasColumnName("GP12");

                entity.Property(e => e.LabRoom).HasColumnName("Lab_room");

                entity.Property(e => e.PaRoom).HasColumnName("PA_room");

                entity.Property(e => e.ReworkAndCoating).HasColumnName("Rework_and_coating");
            });

            modelBuilder.Entity<KpiHrOtbySection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_HR_OTBySection");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.OtHours).HasColumnName("OT_hours");

                entity.Property(e => e.Section)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KpiHrTrir>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("KPI_HR_TRIR");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FirstAids).HasColumnName("First_aids");

                entity.Property(e => e.LostTime).HasColumnName("Lost_time");

                entity.Property(e => e.NearMisses).HasColumnName("Near_misses");

                entity.Property(e => e.NoLostTime).HasColumnName("No_lost_time");
            });

            modelBuilder.Entity<KpiHrTurnoverRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_HR_TurnoverRate");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.TurnoverRate).HasColumnName("turnover_rate");
            });

            modelBuilder.Entity<KpiIncidentMonitoring>(entity =>
            {
                entity.HasKey(e => e.CheckId);

                entity.ToTable("KPI_IncidentMonitoring");

                entity.Property(e => e.CheckId).HasColumnName("check_id");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("author");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CreatedFor)
                    .HasColumnType("datetime")
                    .HasColumnName("created_for");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.IncCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inc_customer");

                entity.Property(e => e.IncDes)
                    .HasMaxLength(300)
                    .HasColumnName("inc_des");

                entity.Property(e => e.IncLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inc_level");

                entity.Property(e => e.IncName)
                    .HasMaxLength(100)
                    .HasColumnName("inc_name");

                entity.Property(e => e.IncStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inc_status");

                entity.Property(e => e.IncTheme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inc_theme");

                entity.Property(e => e.IncType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inc_type");

                entity.Property(e => e.Is8D)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("is8D");

                entity.Property(e => e.IsAction)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("isAction");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.SortTime).HasColumnName("sort_time");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time");
            });

            modelBuilder.Entity<KpiLogExceptionFreight>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_LOG_ExceptionFreight");

                entity.Property(e => e.AbnClaim).HasColumnName("Abn_Claim");

                entity.Property(e => e.AbnMassProd).HasColumnName("Abn_Mass_Prod");

                entity.Property(e => e.AbnReseachDevelopment).HasColumnName("Abn_ReseachDevelopment");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.PreClaim).HasColumnName("Pre_Claim");

                entity.Property(e => e.PreMassProd).HasColumnName("Pre_Mass_Prod");

                entity.Property(e => e.PreReseachDevelopment).HasColumnName("Pre_ReseachDevelopment");
            });

            modelBuilder.Entity<KpiLogSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_LOG_SALE");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Project)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("project");

                entity.Property(e => e.Sale).HasColumnName("sale");

                entity.Property(e => e.SaleCumul).HasColumnName("sale_cumul");

                entity.Property(e => e.SaleTarget).HasColumnName("sale_target");
            });

            modelBuilder.Entity<KpiMaintDiesel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_Maint_Diesel");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<KpiMaintElectricity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_Maint_Electricity");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<KpiMaintEnergyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_Maint_EnergyDetail");

                entity.Property(e => e.Baecost).HasColumnName("BAECOST");

                entity.Property(e => e.Baekwh).HasColumnName("BAEKWH");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.MixingCost).HasColumnName("MixingCOST");

                entity.Property(e => e.MixingKwh).HasColumnName("MixingKWH");

                entity.Property(e => e.OffceCost).HasColumnName("OffceCOST");

                entity.Property(e => e.OfficeKwh).HasColumnName("OfficeKWH");

                entity.Property(e => e.Ovcost).HasColumnName("OVCOST");

                entity.Property(e => e.Ovkwh).HasColumnName("OVKWH");

                entity.Property(e => e.Pfcost).HasColumnName("PFCOST");

                entity.Property(e => e.Pfkwh).HasColumnName("PFKWH");

                entity.Property(e => e.Spcost).HasColumnName("SPCOST");

                entity.Property(e => e.Spkwh).HasColumnName("SPKWH");
            });

            modelBuilder.Entity<KpiMaintWater>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_Maint_Water");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<KpiPdEfficiency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_PD_Efficiency");

                entity.Property(e => e.ActualHours).HasColumnName("Actual_hours");

                entity.Property(e => e.CulmulEfficiency).HasColumnName("Culmul_efficiency");

                entity.Property(e => e.CulmulEfficiencyNew).HasColumnName("Culmul_efficiency_new");

                entity.Property(e => e.DailyEfficiency).HasColumnName("Daily_efficiency");

                entity.Property(e => e.DailyEfficiencyNew).HasColumnName("Daily_efficiency_new");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.StandardHours).HasColumnName("Standard_hours");

                entity.Property(e => e.StandardHoursNew).HasColumnName("Standard_hours_new");
            });

            modelBuilder.Entity<KpiPdQtyFg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_PD_QtyFG");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<KpiPlantDashBoard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_PlantDashBoard");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item_name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.ValueString).HasColumnName("value_string");
            });

            modelBuilder.Entity<KpiQcMtr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_QC_MTR");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.MtrCumul).HasColumnName("MTR_Cumul");

                entity.Property(e => e.MtrCumulExceptCuttingBit).HasColumnName("MTR_Cumul_Except_Cutting_bit");

                entity.Property(e => e.MtrDaily).HasColumnName("MTR_Daily");

                entity.Property(e => e.ScrapWeight).HasColumnName("Scrap_weight");

                entity.Property(e => e.TotalWeight).HasColumnName("Total_weight");
            });

            modelBuilder.Entity<KpiQcNqc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_QC_NQC");

                entity.Property(e => e.AccMtd).HasColumnName("Acc_MTD");

                entity.Property(e => e.BusinessTrip).HasColumnName("Business_trip");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExceptionalTransportation).HasColumnName("Exceptional_transportation");

                entity.Property(e => e.ReWorkRePack).HasColumnName("Re_work_re_pack");

                entity.Property(e => e.RubberScrap).HasColumnName("Rubber_scrap");

                entity.Property(e => e.SortingExternal).HasColumnName("Sorting_external");

                entity.Property(e => e.SortingInternal).HasColumnName("Sorting_internal");

                entity.Property(e => e.WarrantyCost).HasColumnName("Warranty_cost");
            });

            modelBuilder.Entity<KpiQcPpm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_QC_PPM");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Ppm).HasColumnName("PPM");

                entity.Property(e => e.PpmCumul).HasColumnName("PPM_Cumul");
            });

            modelBuilder.Entity<KpiQcPpmbyCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_QC_PPMByCustomer");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IncCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inc_customer");

                entity.Property(e => e.Ppm).HasColumnName("PPM");
            });

            modelBuilder.Entity<KpiQcPpmcustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_QC_PPMCustomer");

                entity.Property(e => e.ClaimContent)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("claim_content");

                entity.Property(e => e.ClaimQty).HasColumnName("claim_qty");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ShippingQty).HasColumnName("shipping_qty");
            });

            modelBuilder.Entity<KpiQcPpmincoming>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KPI_QC_PPMIncoming");

                entity.Property(e => e.Actual).HasColumnName("actual");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.NotOk).HasColumnName("not_ok");

                entity.Property(e => e.PartNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("part_number");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("supplier_name");
            });

            modelBuilder.Entity<KpiQcSupplierClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.ToTable("KPI_QC_SupplierClaim");

                entity.Property(e => e.ClaimId).HasColumnName("claim_id");

                entity.Property(e => e.AdminCost).HasColumnName("admin_cost");

                entity.Property(e => e.ClaimDate)
                    .HasColumnType("date")
                    .HasColumnName("claim_date");

                entity.Property(e => e.DebitAcceptDate)
                    .HasColumnType("date")
                    .HasColumnName("debit_accept_date");

                entity.Property(e => e.DebitNoteDate)
                    .HasColumnType("date")
                    .HasColumnName("debit_note_date");

                entity.Property(e => e.DebitNoteNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("debit_note_no");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DetectDate)
                    .HasColumnType("date")
                    .HasColumnName("detect_date");

                entity.Property(e => e.LotNo)
                    .HasColumnType("date")
                    .HasColumnName("lot_no");

                entity.Property(e => e.NgCompensafeCost).HasColumnName("ng_compensafe_cost");

                entity.Property(e => e.NgFgCost).HasColumnName("ng_fg_cost");

                entity.Property(e => e.NgLogisticCost).HasColumnName("ng_logistic_cost");

                entity.Property(e => e.NgMaterialCost).HasColumnName("ng_material_cost");

                entity.Property(e => e.NgQty).HasColumnName("ng_qty");

                entity.Property(e => e.NgScrapCost).HasColumnName("ng_scrap_cost");

                entity.Property(e => e.NgSortingCost).HasColumnName("ng_sorting_cost");

                entity.Property(e => e.NgTotalCost).HasColumnName("ng_total_cost");

                entity.Property(e => e.PartName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("part_name");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("part_no");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("payment_status");

                entity.Property(e => e.Ppm).HasColumnName("ppm");

                entity.Property(e => e.ReportedDate)
                    .HasColumnType("date")
                    .HasColumnName("reported_date");

                entity.Property(e => e.SentClaim)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sent_claim");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("supplier");
            });

            modelBuilder.Entity<LogEstimateExceptional>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("LOG_Estimate_Exceptional");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.AbnClaim).HasColumnName("Abn_Claim");

                entity.Property(e => e.AbnMassProd).HasColumnName("Abn_Mass_Prod");

                entity.Property(e => e.AbnRnd).HasColumnName("Abn_RND");

                entity.Property(e => e.PreClaim).HasColumnName("Pre_Claim");

                entity.Property(e => e.PreMassProd).HasColumnName("Pre_Mass_Prod");

                entity.Property(e => e.PreRnd).HasColumnName("Pre_RND");
            });

            modelBuilder.Entity<LogInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_Invoice");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.ShipDate)
                    .HasColumnType("date")
                    .HasColumnName("ship_date");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("truck_no");
            });

            modelBuilder.Entity<LogInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_InvoiceDetail");

                entity.Property(e => e.HsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hs_code");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<LogSMasterlistSupplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_S_MasterlistSupplier");

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_code");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .HasColumnName("supplier_name");
            });

            modelBuilder.Entity<MMonitorIssue>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("M_MonitorIssue");

                entity.Property(e => e.IssueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("issue_id");

                entity.Property(e => e.FinishTime)
                    .HasColumnType("datetime")
                    .HasColumnName("finish_time");

                entity.Property(e => e.IssueName)
                    .HasMaxLength(300)
                    .HasColumnName("issue_name");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<PDashboardFg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("P_DashboardFG");

                entity.Property(e => e.Info)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("info");

                entity.Property(e => e.LineName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("line_name");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<PErrorScanLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("P_ErrorScanLog");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.ErrorLog)
                    .HasMaxLength(300)
                    .HasColumnName("error_log");

                entity.Property(e => e.ScannerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("scanner_id");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("time_created");
            });

            modelBuilder.Entity<PFmbLabResult>(entity =>
            {
                entity.HasKey(e => e.MaCode);

                entity.ToTable("P_FMB_Lab_Result");

                entity.Property(e => e.MaCode).HasMaxLength(100);

                entity.Property(e => e.Cmb).HasColumnName("CMB");

                entity.Property(e => e.Fmb).HasColumnName("FMB");

                entity.Property(e => e.FmbLine).HasColumnName("fmb_line");

                entity.Property(e => e.FmbNo).HasColumnName("fmb_no");

                entity.Property(e => e.GravityCmb).HasColumnName("Gravity_CMB");

                entity.Property(e => e.IdNl).HasColumnName("ID_NL");

                entity.Property(e => e.Idca)
                    .HasMaxLength(20)
                    .HasColumnName("IDCa");

                entity.Property(e => e.IdloaiSp).HasColumnName("IDLoaiSP");

                entity.Property(e => e.IdspthongSo).HasColumnName("IDSPThongSo");

                entity.Property(e => e.InputTime)
                    .HasColumnType("datetime")
                    .HasColumnName("input_time");

                entity.Property(e => e.KhoiLuong).HasColumnName("Khoi_luong");

                entity.Property(e => e.Kq)
                    .HasMaxLength(20)
                    .HasColumnName("KQ");

                entity.Property(e => e.Labkind)
                    .HasMaxLength(50)
                    .HasColumnName("labkind");

                entity.Property(e => e.Lotruber)
                    .HasColumnType("datetime")
                    .HasColumnName("LOTRuber");

                entity.Property(e => e.MaNguyenLieu).HasMaxLength(100);

                entity.Property(e => e.MaxDuedate)
                    .HasColumnType("datetime")
                    .HasColumnName("max_duedate");

                entity.Property(e => e.MinDuedate)
                    .HasColumnType("datetime")
                    .HasColumnName("min_duedate");

                entity.Property(e => e.NgayCan).HasColumnType("datetime");

                entity.Property(e => e.PicInput)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic_input");

                entity.Property(e => e.PicRemove)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic_remove");

                entity.Property(e => e.PicReturn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic_return");

                entity.Property(e => e.PicTake)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic_take");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.RemoveReason)
                    .HasMaxLength(50)
                    .HasColumnName("remove_reason");

                entity.Property(e => e.RemoveTime)
                    .HasColumnType("datetime")
                    .HasColumnName("remove_time");

                entity.Property(e => e.ReturnTime)
                    .HasColumnType("datetime")
                    .HasColumnName("return_time");

                entity.Property(e => e.TakeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("take_time");

                entity.Property(e => e.TenlsiBelong).HasColumnName("Tenlsi_Belong");

                entity.Property(e => e.TenlsiUts).HasColumnName("Tenlsi_UTS");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");
            });

            modelBuilder.Entity<PFmbMasterListRubber>(entity =>
            {
                entity.HasKey(e => e.RubberName)
                    .HasName("PK_P_FMB_MasterListDueDate");

                entity.ToTable("P_FMB_MasterListRubber");

                entity.Property(e => e.RubberName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rubber_name");

                entity.Property(e => e.RubberType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rubber_type");

                entity.Property(e => e.VadilityMax).HasColumnName("vadility_max");

                entity.Property(e => e.VadilityMin).HasColumnName("vadility_min");
            });

            modelBuilder.Entity<PFmbMasterLocationRubber>(entity =>
            {
                entity.HasKey(e => e.FmbLine)
                    .HasName("PK_P_FMB_MasterLocationRubber1");

                entity.ToTable("P_FMB_MasterLocationRubber");

                entity.Property(e => e.FmbLine)
                    .ValueGeneratedNever()
                    .HasColumnName("fmb_line");

                entity.Property(e => e.RubberName)
                    .HasMaxLength(50)
                    .HasColumnName("rubber_name");
            });

            modelBuilder.Entity<PLabel>(entity =>
            {
                entity.HasKey(e => e.LabelCode)
                    .HasName("PK_Label");

                entity.ToTable("P_Label");

                entity.Property(e => e.LabelCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label_code");

                entity.Property(e => e.CheckType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("check_type");

                entity.Property(e => e.Comment)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.DateInputPackingZone)
                    .HasColumnType("datetime")
                    .HasColumnName("date_input_packing_zone");

                entity.Property(e => e.DateInputWh)
                    .HasColumnType("datetime")
                    .HasColumnName("date_input_wh");

                entity.Property(e => e.DateLocatePacked)
                    .HasColumnType("datetime")
                    .HasColumnName("date_locate_packed");

                entity.Property(e => e.DatePacked)
                    .HasColumnType("datetime")
                    .HasColumnName("date_packed");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_date");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.IsLock)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isLock");

                entity.Property(e => e.Line)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("line");

                entity.Property(e => e.LocationPacked)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location_packed");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lot_no");

                entity.Property(e => e.OpInputPackingZone)
                    .HasMaxLength(50)
                    .HasColumnName("op_input_packing_zone");

                entity.Property(e => e.OpInputWh)
                    .HasMaxLength(100)
                    .HasColumnName("op_input_wh");

                entity.Property(e => e.OpLocatePacked)
                    .HasMaxLength(100)
                    .HasColumnName("op_locate_packed");

                entity.Property(e => e.OpPacked)
                    .HasMaxLength(100)
                    .HasColumnName("op_packed");

                entity.Property(e => e.PalletNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pallet_no");

                entity.Property(e => e.PatrolDate)
                    .HasColumnType("datetime")
                    .HasColumnName("patrol_date");

                entity.Property(e => e.PatrolOp)
                    .HasMaxLength(100)
                    .HasColumnName("patrol_op");

                entity.Property(e => e.PatrolResult)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("patrol_result");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.PlanDate)
                    .HasColumnType("date")
                    .HasColumnName("plan_date");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("product_price");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.ProductRev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_rev");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_type");

                entity.Property(e => e.ProductWeight).HasColumnName("product_weight");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("project_name");

                entity.Property(e => e.ScannedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("scanned_date");

                entity.Property(e => e.Shift)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("shift");

                entity.Property(e => e.ShipDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ship_date");

                entity.Property(e => e.ShipOp)
                    .HasMaxLength(100)
                    .HasColumnName("ship_op");

                entity.Property(e => e.StandardTime)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("standard_time");

                entity.Property(e => e.WhLocateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("wh_locate_date");

                entity.Property(e => e.WhLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wh_location");

                entity.Property(e => e.WhOpLocate)
                    .HasMaxLength(100)
                    .HasColumnName("wh_op_locate");
            });

            modelBuilder.Entity<PMasterListLine>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("P_MasterListLine");

                entity.Property(e => e.LineId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("line_id");

                entity.Property(e => e.DesEn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("des_en");

                entity.Property(e => e.DesVn)
                    .HasMaxLength(50)
                    .HasColumnName("des_vn");

                entity.Property(e => e.LineArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("line_area");

                entity.Property(e => e.LineName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("line_name");
            });

            modelBuilder.Entity<PMasterListProduct>(entity =>
            {
                entity.HasKey(e => e.ProductCode)
                    .HasName("PK_MasterListProduct2");

                entity.ToTable("P_MasterListProduct");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.CartonType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("carton_type");

                entity.Property(e => e.CheckType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("check_type");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.HsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hs_code");

                entity.Property(e => e.LastTimeApprove)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_approve");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserApprove)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_approve");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.Note)
                    .HasMaxLength(300)
                    .HasColumnName("note");

                entity.Property(e => e.NumberOperator).HasColumnName("number_operator");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.ProductLine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_line");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("product_price");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.ProductRev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_rev");

                entity.Property(e => e.ProductWeight).HasColumnName("product_weight");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("project_name");

                entity.Property(e => e.StandardTime)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("standard_time");

                entity.Property(e => e.StandardTimeFg)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("standard_time_FG");
            });

            modelBuilder.Entity<PMasterListProductBom>(entity =>
            {
                entity.HasKey(e => new { e.ProductCustomerCode, e.MName });

                entity.ToTable("P_MasterListProduct_BOM");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.MQuantity).HasColumnName("m_quantity");
            });

            modelBuilder.Entity<PMasterListProductSubmit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("P_MasterListProductSubmit");

                entity.Property(e => e.ApprovalTime)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_time");

                entity.Property(e => e.ApprovalUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_user");

                entity.Property(e => e.IsApproval)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("is_approval");

                entity.Property(e => e.ModifiedContent)
                    .IsUnicode(false)
                    .HasColumnName("modified_content");

                entity.Property(e => e.ModifiedSqlQuery)
                    .IsUnicode(false)
                    .HasColumnName("modified_sql_query");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.RecoverSqlQuery)
                    .IsUnicode(false)
                    .HasColumnName("recover_sql_query");

                entity.Property(e => e.RequestTime)
                    .HasColumnType("datetime")
                    .HasColumnName("request_time");

                entity.Property(e => e.RequestUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("request_user");

                entity.Property(e => e.RowId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("row_id");
            });

            modelBuilder.Entity<PMasterListScanner>(entity =>
            {
                entity.HasKey(e => e.ScannerId);

                entity.ToTable("P_MasterListScanner");

                entity.Property(e => e.ScannerId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("scanner_id");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .HasColumnName("department");

                entity.Property(e => e.Des1)
                    .HasMaxLength(20)
                    .HasColumnName("des_1");

                entity.Property(e => e.Des2)
                    .HasMaxLength(20)
                    .HasColumnName("des_2");

                entity.Property(e => e.Des3)
                    .HasMaxLength(20)
                    .HasColumnName("des_3");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.ScannerName)
                    .HasMaxLength(50)
                    .HasColumnName("scanner_name");
            });

            modelBuilder.Entity<PMasterListShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("P_MasterListShift");

                entity.Property(e => e.EndTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("end_time");

                entity.Property(e => e.PlusHourEnd).HasColumnName("plus_hour_end");

                entity.Property(e => e.PlusHourStart).HasColumnName("plus_hour_start");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("shift_id");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shift_name");

                entity.Property(e => e.StartTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<PlPlanFg>(entity =>
            {
                entity.HasKey(e => e.CheckId);

                entity.ToTable("PL_PlanFG");

                entity.Property(e => e.CheckId).HasColumnName("check_id");

                entity.Property(e => e.CustomerProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_product_code");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.IsPrint)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("is_print");

                entity.Property(e => e.IssueMaterial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("issue_material");

                entity.Property(e => e.LineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("line_no");

                entity.Property(e => e.Note)
                    .HasMaxLength(300)
                    .HasColumnName("note");

                entity.Property(e => e.NumberOperator).HasColumnName("number_operator");

                entity.Property(e => e.PlanDate)
                    .HasColumnType("date")
                    .HasColumnName("plan_date");

                entity.Property(e => e.Priority)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("priority");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.Shift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shift");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.Target).HasColumnName("target");
            });

            modelBuilder.Entity<PurPr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PUR_PR");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AmountWithVat).HasColumnName("amount_with_vat");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approve_date");

                entity.Property(e => e.Approver)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approver");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("check_date");

                entity.Property(e => e.Checker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("checker");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dept");

                entity.Property(e => e.EstimateReceivedDate)
                    .HasColumnType("date")
                    .HasColumnName("estimate_received_date");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("is_active");

                entity.Property(e => e.PrContent)
                    .IsUnicode(false)
                    .HasColumnName("pr_content");

                entity.Property(e => e.PrDate)
                    .HasColumnType("date")
                    .HasColumnName("pr_date");

                entity.Property(e => e.PrNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pr_no");

                entity.Property(e => e.PrType)
                    .HasMaxLength(300)
                    .HasColumnName("pr_type");

                entity.Property(e => e.Requester)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requester");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<PurPrdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PUR_PRDetail");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(500)
                    .HasColumnName("item_name");

                entity.Property(e => e.PrNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pr_no");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .HasColumnName("unit");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");

                entity.Property(e => e.Vat).HasColumnName("vat");
            });

            modelBuilder.Entity<QcChemicalLabel>(entity =>
            {
                entity.HasKey(e => e.ChLabelCode);

                entity.ToTable("QC_ChemicalLabel");

                entity.Property(e => e.ChLabelCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ch_label_code");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item_no");

                entity.Property(e => e.LotNo)
                    .HasColumnType("date")
                    .HasColumnName("lot_no");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("datetime")
                    .HasColumnName("print_date");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<QcFgNgpart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QC_FG_NGPart");

                entity.Property(e => e.LabelCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label_code");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lot_no");

                entity.Property(e => e.NgOthers).HasColumnName("ng_others");

                entity.Property(e => e.PicQc)
                    .HasMaxLength(50)
                    .HasColumnName("pic_qc");

                entity.Property(e => e.PlanDate)
                    .HasColumnType("date")
                    .HasColumnName("plan_date");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.TimeQcCheck)
                    .HasColumnType("datetime")
                    .HasColumnName("time_qc_check");
            });

            modelBuilder.Entity<QcMNgpart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QC_M_NGPart");

                entity.Property(e => e.LotNo)
                    .HasColumnType("datetime")
                    .HasColumnName("lot_no");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.NgBurr).HasColumnName("ng_burr");

                entity.Property(e => e.NgElectricFail).HasColumnName("ng_electric_fail");

                entity.Property(e => e.NgOthers).HasColumnName("ng_others");

                entity.Property(e => e.NgRust).HasColumnName("ng_rust");

                entity.Property(e => e.NgScratch).HasColumnName("ng_scratch");

                entity.Property(e => e.NgWrongDimension).HasColumnName("ng_wrong_dimension");

                entity.Property(e => e.NgWrongShape).HasColumnName("ng_wrong_shape");

                entity.Property(e => e.PicQc)
                    .HasMaxLength(50)
                    .HasColumnName("pic_qc");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TimeQcCheck)
                    .HasColumnType("datetime")
                    .HasColumnName("time_qc_check");

                entity.Property(e => e.WhmrCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmr_code");

                entity.Property(e => e.WhmrCodeOrigin).HasColumnName("whmr_code_origin");
            });

            modelBuilder.Entity<QcMasterListChemical>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QC_MasterList_Chemical");

                entity.Property(e => e.ExpiryMonth).HasColumnName("expiry_month");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item_no");
            });

            modelBuilder.Entity<TempCurrentProductionFg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_CurrentProductionFG");

                entity.Property(e => e.CustomerProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_product_code");

                entity.Property(e => e.Efficiency).HasColumnName("efficiency");

                entity.Property(e => e.FinishTime)
                    .HasColumnType("datetime")
                    .HasColumnName("finish_time");

                entity.Property(e => e.FinishTimeEstimate)
                    .HasColumnType("datetime")
                    .HasColumnName("finish_time_estimate");

                entity.Property(e => e.LineNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("line_no");

                entity.Property(e => e.Mps).HasColumnName("mps");

                entity.Property(e => e.NumberOperator).HasColumnName("number_operator");

                entity.Property(e => e.PlanDate)
                    .HasColumnType("date")
                    .HasColumnName("plan_date");

                entity.Property(e => e.PlanTarget).HasColumnName("plan_target");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shift)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("shift");

                entity.Property(e => e.StardardTimeFg).HasColumnName("stardard_time_FG");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.StartTimeEstimate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time_estimate");

                entity.Property(e => e.Target).HasColumnName("target");
            });

            modelBuilder.Entity<TempPFgPrintNewLabel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_P_FG_PrintNewLabel");

                entity.Property(e => e.PlanDate)
                    .HasColumnType("date")
                    .HasColumnName("plan_date");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.Stt).HasColumnName("stt");
            });

            modelBuilder.Entity<TempWMIssueToQc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_W_M_IssueToQC");

                entity.Property(e => e.IsCheck)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("is_check");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.QcShift)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("qc_shift");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RmPlanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_plan_id");

                entity.Property(e => e.Transaction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transaction");

                entity.Property(e => e.WhIssueTime)
                    .HasColumnType("datetime")
                    .HasColumnName("wh_issue_time");

                entity.Property(e => e.WhOp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wh_op");

                entity.Property(e => e.WhmrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("whmr_code");
            });

            modelBuilder.Entity<TempWMReceiving>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_W_M_Receiving");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("is_active");

                entity.Property(e => e.IsCheck)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("is_check");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lot_no");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RmDocId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_id");

                entity.Property(e => e.Transaction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transaction");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("truck_no");

                entity.Property(e => e.WhOkng)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("wh_okng");

                entity.Property(e => e.WhOp)
                    .HasMaxLength(50)
                    .HasColumnName("wh_op");

                entity.Property(e => e.WhReceiveTime)
                    .HasColumnType("datetime")
                    .HasColumnName("wh_receive_time");

                entity.Property(e => e.WhmrCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmr_code");
            });

            modelBuilder.Entity<TempWShippingInfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_W_ShippingInfor");

                entity.Property(e => e.InputTime)
                    .HasColumnType("datetime")
                    .HasColumnName("input_time");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsCheck)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("is_check");

                entity.Property(e => e.LabelCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label_code");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lot_no");

                entity.Property(e => e.PalletNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pallet_no");

                entity.Property(e => e.Pic)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PIC");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.Transaction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transaction");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("truck_no");
            });

            modelBuilder.Entity<ViewKpiLogSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_KPI_LOG_SALE");

                entity.Property(e => e.DailySales)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("DAILY SALES");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SaleCumul)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("SALE CUMUL");

                entity.Property(e => e.SaleTarget)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("SALE TARGET");
            });

            modelBuilder.Entity<WCycleCount>(entity =>
            {
                entity.HasKey(e => e.CcName);

                entity.ToTable("W_CycleCount");

                entity.Property(e => e.CcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cc_name");

                entity.Property(e => e.CcDate)
                    .HasColumnType("date")
                    .HasColumnName("cc_date");

                entity.Property(e => e.CcDes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cc_des");

                entity.Property(e => e.CcType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cc_type");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsConfirm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isConfirm");

                entity.Property(e => e.IsLock)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isLock");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");
            });

            modelBuilder.Entity<WCycleCountInventory>(entity =>
            {
                entity.HasKey(e => new { e.LabelCode, e.CcName })
                    .HasName("PK_W_CCInventory");

                entity.ToTable("W_CycleCountInventory");

                entity.Property(e => e.LabelCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label_code");

                entity.Property(e => e.CcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cc_name");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.PalletNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pallet_no");

                entity.Property(e => e.Pic)
                    .HasMaxLength(100)
                    .HasColumnName("PIC");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.PlanDate)
                    .HasColumnType("date")
                    .HasColumnName("plan_date");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.WhLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wh_location");
            });

            modelBuilder.Entity<WCycleCountListPartial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_CycleCountListPartial");

                entity.Property(e => e.CcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cc_name");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");
            });

            modelBuilder.Entity<WHistoryOfTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_HistoryOfTransaction");

                entity.Property(e => e.Comment)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.InputTime)
                    .HasColumnType("datetime")
                    .HasColumnName("input_time");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.LabelCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("label_code");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lot_no");

                entity.Property(e => e.PalletNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pallet_no");

                entity.Property(e => e.Pic)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("PIC");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_code");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.Transaction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transaction");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("truck_no");
            });

            modelBuilder.Entity<WMCheckingPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_M_CheckingPlan");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("date")
                    .HasColumnName("check_date");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.RmPlanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_plan_id");
            });

            modelBuilder.Entity<WMCheckingPlanDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_M_CheckingPlanDetail");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.PShift)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("p_shift");

                entity.Property(e => e.PlanType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("plan_type");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RmPlanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_plan_id");
            });

            modelBuilder.Entity<WMHistoryOfTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_M_HistoryOfTransaction");

                entity.Property(e => e.InputTime)
                    .HasColumnType("datetime")
                    .HasColumnName("input_time");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lot_no");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.MNote)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("m_note");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PIC");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.PlanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("plan_no");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Transaction)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transaction");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("truck_no");

                entity.Property(e => e.WhmiCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmi_code");

                entity.Property(e => e.WhmrCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmr_code");
            });

            modelBuilder.Entity<WMIssueDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_M_IssueDoc");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.MDocCompleteTime)
                    .HasColumnType("datetime")
                    .HasColumnName("m_doc_complete_time");

                entity.Property(e => e.MDocId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_doc_id");

                entity.Property(e => e.MDocStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_doc_status");

                entity.Property(e => e.MDocSupplyDate)
                    .HasColumnType("date")
                    .HasColumnName("m_doc_supply_date");
            });

            modelBuilder.Entity<WMIssueDocDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_M_IssueDocDetail");

                entity.Property(e => e.MDemand).HasColumnName("m_demand");

                entity.Property(e => e.MDocId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_doc_id");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.PLine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_line");

                entity.Property(e => e.PShift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_shift");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");
            });

            modelBuilder.Entity<WMIssueLabel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_M_IssueLabel");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("issue_date");

                entity.Property(e => e.LotNo)
                    .HasColumnType("date")
                    .HasColumnName("lot_no");

                entity.Property(e => e.MDocId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_doc_id");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.PLine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_line");

                entity.Property(e => e.PShift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_shift");

                entity.Property(e => e.ProductCustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_customer_code");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SupplyDate)
                    .HasColumnType("date")
                    .HasColumnName("supply_date");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.WhmiCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmi_code");

                entity.Property(e => e.WhmrCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmr_code");
            });

            modelBuilder.Entity<WMReceiveDoc>(entity =>
            {
                entity.HasKey(e => e.RmDocId);

                entity.ToTable("W_M_ReceiveDoc");

                entity.Property(e => e.RmDocId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_id");

                entity.Property(e => e.LastTimeCommit)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_commit");

                entity.Property(e => e.LastUserCommit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_user_commit");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnType("date")
                    .HasColumnName("receive_date");

                entity.Property(e => e.RmDocLink)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_link");

                entity.Property(e => e.RmDocLink2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_link2");

                entity.Property(e => e.RmDocLink3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_link3");

                entity.Property(e => e.RmDocName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_name");

                entity.Property(e => e.RmDocName2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_name2");

                entity.Property(e => e.RmDocName3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_name3");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("supplier");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("truck_no");
            });

            modelBuilder.Entity<WMReceiveDocDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("W_M_ReceiveDocDetail");

                entity.Property(e => e.MLotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_lot_no");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.NumberCarton).HasColumnName("number_carton");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RmDocId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_id");
            });

            modelBuilder.Entity<WMReceiveLabel>(entity =>
            {
                entity.HasKey(e => e.WhmrCode);

                entity.ToTable("W_M_ReceiveLabel");

                entity.Property(e => e.WhmrCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmr_code");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.CreatedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("created_user");

                entity.Property(e => e.LocateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("locate_time");

                entity.Property(e => e.LotNo)
                    .HasColumnType("date")
                    .HasColumnName("lot_no");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.OpLocate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("op_locate");

                entity.Property(e => e.PicIssuePd)
                    .HasMaxLength(50)
                    .HasColumnName("pic_issue_pd");

                entity.Property(e => e.PicIssueQc)
                    .HasMaxLength(50)
                    .HasColumnName("pic_issue_qc");

                entity.Property(e => e.PicQc)
                    .HasMaxLength(50)
                    .HasColumnName("pic_qc");

                entity.Property(e => e.PicReturnPd)
                    .HasMaxLength(50)
                    .HasColumnName("pic_return_pd");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.QcOkng)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("qc_okng");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RmDocId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_doc_id");

                entity.Property(e => e.RmPlanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rm_plan_id");

                entity.Property(e => e.TimeIssuePd)
                    .HasColumnType("datetime")
                    .HasColumnName("time_issue_pd");

                entity.Property(e => e.TimeIssueQc)
                    .HasColumnType("datetime")
                    .HasColumnName("time_issue_qc");

                entity.Property(e => e.TimeQcCheck)
                    .HasColumnType("datetime")
                    .HasColumnName("time_qc_check");

                entity.Property(e => e.TimeReturnPd)
                    .HasColumnType("datetime")
                    .HasColumnName("time_return_pd");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("truck_no");

                entity.Property(e => e.WhLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wh_location");

                entity.Property(e => e.WhOkng)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("wh_okng");

                entity.Property(e => e.WhOp)
                    .HasMaxLength(50)
                    .HasColumnName("wh_op");

                entity.Property(e => e.WhReceiveTime)
                    .HasColumnType("datetime")
                    .HasColumnName("wh_receive_time");

                entity.Property(e => e.WhmrCodeOrigin)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("whmr_code_origin");
            });

            modelBuilder.Entity<WMasterListLocation>(entity =>
            {
                entity.HasKey(e => new { e.Place, e.LocName });

                entity.ToTable("W_MasterList_Location");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.LocName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("loc_name");

                entity.Property(e => e.LocDes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("loc_des");
            });

            modelBuilder.Entity<WMasterListMaterial>(entity =>
            {
                entity.HasKey(e => new { e.MName, e.IsActive });

                entity.ToTable("W_MasterList_Material");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(10)
                    .HasColumnName("is_active")
                    .IsFixedLength(true);

                entity.Property(e => e.MDes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("m_des");

                entity.Property(e => e.MQty).HasColumnName("m_qty");

                entity.Property(e => e.RawQty).HasColumnName("raw_qty");

                entity.Property(e => e.RawWeight).HasColumnName("raw_weight");

                entity.Property(e => e.ScaleType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("scale_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
