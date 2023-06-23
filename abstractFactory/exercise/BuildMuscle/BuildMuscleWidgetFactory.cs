public class BuildMuscleWidgetFactory : IIWidgetFactory
{
    public IMealPlan createMealPlan()
    {
        return new BuildMuscleMealPlan();
    }

    public IWorkoutPlan createWorkoutPlan()
    {
        return new BuildMuscleWorkout();
    }
}
