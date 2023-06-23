public class WeighLossWidgetFactory : IIWidgetFactory
{
    public IMealPlan createMealPlan()
    {
        return new WeighLossMealPlan();
    }

    public IWorkoutPlan createWorkoutPlan()
    {
        return new WeightLossWorkout();
    }
}
