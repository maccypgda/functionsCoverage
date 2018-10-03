Imports Resco.ResFramework
Imports Resco.ResServer
Imports System.Linq
Imports System.Object

Class Main
    Shared Sub Main()
        Try
            'check if .csv file exists, if not create new one, if exists - delete old one and create blank file
            'Dim csvPath As String
            Dim csvPath = "S:\FunctionsCoverage\ResCQueryTests" + DateTime.Now.ToString("yyyy-MM-dd_HHmm") + ".csv"
            CsvCheck.Check(csvPath)
            CQueryActivityCoverage.ActivityMain(csvPath)
            CQueryArchiveCoverage.ArchiveMain(csvPath)
            CQueryArticleCoverage.ArticleMain(csvPath)
            CQueryAuditCoverage.AuditMain(csvPath)
            CQueryBenefitCoverage.BenefitMain(csvPath)
            CQueryBookingCoverage.BookingMain(csvPath)
            CQueryCancellationCoverage.CancellationMain(csvPath)
            CQueryCategoryCoverage.CategoryMain(csvPath)
            CQueryCentreCoverage.CentreMain(csvPath)
            CQueryCompanyCoverage.CompanyMain(csvPath)
            CQueryContractCoverage.ContractMain(csvPath)
            CQueryEventCoverage.EventMain(csvPath)
            CQueryFolioCoverage.FolioMain(csvPath)
            CQueryInvoiceCoverage.InvoiceMain(csvPath)
            CQueryItemCoverage.ItemMain(csvPath)
            CQueryJournalCoverage.JournalMain(csvPath)
            CQueryMailCoverage.MailMain(csvPath)
            CQueryMaintenanceCoverage.MaintenanceMain(csvPath)
            CQueryNoteCoverage.NoteMain(csvPath)
            CQueryPackageCoverage.packageMain(csvPath)
            CQueryPaymentCoverage.PaymentMain(csvPath)
            CQueryPostingCoverage.postingMain(csvPath)
            CQueryPriceCoverage.PriceMain(csvPath)
            CQueryRemarkCoverage.RemarkMain(csvPath)
            CQueryReminderCoverage.ReminderMain(csvPath)
            CQueryReportCoverage.ReportMain(csvPath)
            CQueryRestrictionCoverage.RestrictionMain(csvPath)
            CQuerySurchargeCoverage.SurchargeMain(csvPath)
            CQuerySurveyCoverage.SurveyMain(csvPath)
            CQueryTripCoverage.TripMain(csvPath)
            CQueryTypesCoverage.TypesMain(csvPath)
            CQueryUserCoverage.UserMain(csvPath)

            'Dim openScvFile As New System.Diagnostics.Process()
            Dim openScvFile = Process.Start(csvPath, "")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
            Console.ReadKey()
        End Try
    End Sub
End Class