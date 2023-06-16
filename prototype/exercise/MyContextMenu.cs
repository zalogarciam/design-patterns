public class MyContextMenu
{
    private Timeline timeline;

    public MyContextMenu(Timeline timeline)
    {
        this.timeline = timeline;
    }

    public void duplicate(IIComponent component)
    {
        // if (component instanceof Text) {
        //     Text source = (Text)component;
        //     Text target = new Text(source.getContent());
        //     timeline.add(target);
        // }
        // else if (component instanceof Audio) {
        //     // Logic for duplicating an Audio object
        // }
        // else if (component instanceof Clip) {
        //     // Logic for duplicating a Clip object
        // }
        IIComponent newComponent = component.Clone();
        timeline.Add(newComponent);
        System.Console.WriteLine("Duplicate and added to timeline ...");
    }
}
