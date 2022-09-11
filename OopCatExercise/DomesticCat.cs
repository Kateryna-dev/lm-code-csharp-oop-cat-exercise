using System;
using System.Collections.Generic;
namespace OopCatExercise
{
    public class DomesticCat: Cat
    {
        //some domestic cats will randomly let out a dismissive "It will do I suppose"
        //comment following eating instead(?) of purring sound
        private string[] afterEatMessages = { "Purrrrrrr", "It will do I suppose"};
        public DomesticCat() 
        {
            this.IsAsleep = false;
            this.Setting = "domestic";
            this.AverageHeight = 23;
        }

        public override string Eat() 
        {
            var random = new Random();
            return afterEatMessages[random.Next(0, 2)];
        }
    }
}
