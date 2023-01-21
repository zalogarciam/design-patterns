public abstract class Task
{
    public AuditTrail AuditTrail { get; }

    public Task()
    {
        AuditTrail = new AuditTrail();
    }
    
    public Task(AuditTrail auditTrail)
    {
        AuditTrail = auditTrail;
    }

    public void Execute()
    {
        AuditTrail.Record();
        DoExecute();
    }

    protected abstract void DoExecute();
}