public class ContextMenu
{
    // public void Duplicate(IComponente component)
    // {
    //     // if (component typeof Circle){
    //     //     Circle source = (Circle)component;
    //     //     Circle target = new Circle();
    //     //     target.Radius = source.Radius;
    //     // }
    // }

    public void Duplicate(IComponente component)
    {
        IComponente newComponent = component.Clone();
        System.Console.WriteLine("Duplicated...");
    }
}