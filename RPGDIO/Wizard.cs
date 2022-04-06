namespace felip.Desktop.Sayuri.DIORPGDESAFIO
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType, string MinMaxHP, string MinMaxMP): base(Name, Level, HeroType, MinMaxHP, MinMaxMP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MinMaxHP = MinMaxHP;
            this.MinMaxMP = MinMaxMP;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
           {
            return this.Name + " lançou uma magia super efetiva com bonus de " + Bonus;
           }
           else
           {
               return this.Name + " lançou uma magia com força fraca com bonus de " + Bonus;
           }
        }
    }
}