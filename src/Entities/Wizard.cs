namespace ProjetoRPG.src.Entities
{
    public class Wizard: Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack(){
            return this.Name + " atacou com sua varinha";
        }

        public override string Attack(int bonus)
        {
            return this.Name + " atacou com sua varinha com bônus de " + bonus.ToString();
        }
    }
}