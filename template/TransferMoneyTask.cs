public class TransferMoneyTask : Task
{
    public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
    {
        AuditTrail = auditTrail;
    }

    public AuditTrail AuditTrail { get; }

    protected override void DoExecute()
    {
        Console.WriteLine("Transfor money");
    }
}


