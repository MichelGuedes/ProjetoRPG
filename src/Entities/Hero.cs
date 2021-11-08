namespace ProjetoRPG.src.Entities
{
    public abstract class Hero
    {
        public virtual string Name { get; set; }
        public virtual int Level { get; set; }
        public virtual string HeroType { get; set; }
        public Hero(){}
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string ToString()
        {
            return Name + " - " + Level + " - " + HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com sua espada";
        }

        public virtual string Attack(int bonus)
        {
            return this.Name + " atacou com sua espada com bônus de " + bonus.ToString();
        }

    }
}