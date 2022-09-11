namespace OopCatExercise
{
    public class LionCat:Cat
    {
        public LionCat() 
        {
            this.IsAsleep = false;
            this.Setting = "wild";
            this.AverageHeight = 1100;
        }
        public override string Eat() => "Roar!!!!";
    }
}
