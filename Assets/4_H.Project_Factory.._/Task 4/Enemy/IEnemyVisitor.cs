namespace Assets.Project4.Task4
{
    public interface IEnemyVisitor 
    {
        void Visit(Elf elf);
        void Visit(Ork ork);
        void Visit(Human human);
        void Visit(Robot robot);
    }
}