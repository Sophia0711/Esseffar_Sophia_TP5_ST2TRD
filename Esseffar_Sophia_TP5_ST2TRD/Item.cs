namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }  

        public virtual void NextDay()
        {
            if(this.Quality > 0)
            {
                if (this.SellIn > 0)
                {
                    this.Quality--;
                }
                else
                {
                    this.Quality -= 2;
                }
            }
            this.SellIn--;
            this.CheckMaxQlty();
            this.CheckMinQlty();

        }

        public void CheckMaxQlty()
        {
            if( this.Quality > 50 )
            {
                this.Quality = 50;
            }
        }

        public void CheckMinQlty()
        {
            if ( this.Quality < 0 )
            {
                this.Quality = 0;
            }
        }

    }

    public class AgedBrie : Item
    {
        public override void NextDay()
        {
            this.Quality++;
            this.SellIn--;
            this.CheckMaxQlty();
            this.CheckMinQlty();
        }
    }

    public class Sulfuras : Item
    {
        public override void NextDay()
        {
            this.SellIn--;
            this.CheckMinQlty();
        }

    }

    public class Backstage : Item
    {
        public override void NextDay()
        {

            if (this.SellIn <= 10 && this.SellIn > 5)
            {
                this.Quality += 2;
            }
            else if (this.SellIn <= 5 && this.SellIn > 0)
            {
                this.Quality += 3;
            }
            else if (this.SellIn > 10)
            {
                this.Quality++;
            }
            else
            {
                this.Quality = 0;
            }
            this.SellIn--;
            this.CheckMaxQlty();
            this.CheckMinQlty();
        }

    }

    public class Conjured : Item
    {
        public override void NextDay()
        {
            if (this.Quality > 0)
            {
                if (this.SellIn > 0)
                {
                    this.Quality-=2;
                }
                else
                {
                    this.Quality -= 4;
                }
            }
            this.SellIn--;
            this.CheckMaxQlty();
            this.CheckMinQlty();
        }
    }
}
