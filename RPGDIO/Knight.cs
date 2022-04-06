namespace felip.Desktop.Sayuri.DIORPGDESAFIO
{
    public class Knight : Hero 
    {
        public Knight(string Name, int Level, string HeroType, string MinMaxHP, string MinMaxMP): base(Name, Level, HeroType, MinMaxHP, MinMaxMP)
        
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MinMaxHP = MinMaxHP;
            this.MinMaxMP = MinMaxMP;
        }  
        
    }
}