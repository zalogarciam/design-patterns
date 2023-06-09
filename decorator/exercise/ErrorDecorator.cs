public class ErrorDecorator : IArtefact
{
    private IArtefact artefact;

    public ErrorDecorator(IArtefact artefact)
    {
        this.artefact = artefact;
    }

    public string render()
    {
        return artefact.render() + "[Error]";
    }
}
