namespace OopCatExercise
{
    public abstract class Cat : ICat
	{
		public bool IsAsleep { get; protected set; }
		public double AverageHeight { get; protected set; }
		public string Setting { get; protected set; }

		protected Cat(double averageHeight, string setting) 
		{
			AverageHeight = averageHeight;
			Setting = setting;
			IsAsleep = false;
		}
		public abstract string Eat();
		public void GoToSleep() => IsAsleep = true;
		public void WakeUp() => IsAsleep = false;

	}
}
