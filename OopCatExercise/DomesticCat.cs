using System;

namespace OopCatExercise
{
    public class DomesticCat: Cat
    {
        //some domestic cats will randomly let out a dismissive "It will do I suppose"
        //comment following eating instead(?) of purring sound
        private string[] afterEatMessages = { "Purrrrrrr", "It will do I suppose"};
        public DomesticCat() : base(23, "domestic")
        {
        }

        public override string Eat() 
        {
            var random = new Random();
            return afterEatMessages[random.Next(0, 2)];
        }
    }
}
