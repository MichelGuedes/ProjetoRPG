namespace ProjetoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = "Ninja";
        }

        public override string Attack()
        {
            return this.Name + " atacou com sua katana!";
        }

        public override string Attack(int bonus)
        {
            return this.Name + " atacou com sua katana com o bônus de " + bonus.ToString();
        }
    }
}