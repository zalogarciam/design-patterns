public class Editors
{
    public void openProject(String path)
    {
        Artefact[] artefacts = {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
        };

        artefacts[0].setMain(true);
        artefacts[2].setHasError(true);

        foreach (var artefact in artefacts)
            System.Console.WriteLine(artefact.render());
    }
}
