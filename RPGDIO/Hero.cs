namespace felip.Desktop.Sayuri.DIORPGDESAFIO
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, string MinMaxHP, string MinMaxMP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MinMaxHP = MinMaxHP;
            this.MinMaxMP = MinMaxMP;
        }
        public string Name;
        public int Level;
        public string HeroType;
        public string MinMaxHP;
        public string MinMaxMP;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada! ";
        }

    }
}