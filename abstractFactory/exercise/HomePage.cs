public class HomePage {
    private IWorkoutPlan workoutPlan;
    private IMealPlan mealPlan;

    public void setGoal(Goal goal) {
        if (goal == Goal.BUILD_MUSCLE) {
            workoutPlan = new BuildMuscleWorkout();
            mealPlan = new BuildMuscleMealPlan();
        }
        else if (goal == Goal.WEIGHT_LOSS) {
            workoutPlan = new WeightLossWorkout();
            mealPlan = new WeighLossMealPlan();
        }
        System.Console.WriteLine(workoutPlan);
        System.Console.WriteLine(mealPlan);

    }
}
