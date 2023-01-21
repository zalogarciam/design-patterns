public class GenerateReportTask : Task
{
    public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
    {
        AuditTrail = auditTrail;
    }

    public AuditTrail AuditTrail { get; }

    protected override void DoExecute()
    {
        Console.WriteLine("Generate report");
    }
}