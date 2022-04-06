namespace felip.Desktop.Sayuri.DIORPGDESAFIO
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, string MinMaxHP, string MinMaxMP): base(Name, Level, HeroType, MinMaxHP, MinMaxMP)
        
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MinMaxHP = MinMaxHP;
            this.MinMaxMP = MinMaxMP;
        }  

        public override string Attack()
           {
            return this.Name + " atacou com sua shuriken!";
           }
        
    }

}