namespace OopCatExercise
{
    public class CheetahCat: Cat
    {
        public CheetahCat() 
        {
            this.IsAsleep = false;
            this.Setting = "wild";
        }
        public override string Eat() => "Zzzzzzz";
    }
}
