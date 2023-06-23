public class HomePage {
    private IWorkoutPlan workoutPlan;
    private IMealPlan mealPlan;

    public void setGoal(IIWidgetFactory factory)
    {
        factory.createMealPlan();
        factory.createWorkoutPlan();
    }
}
