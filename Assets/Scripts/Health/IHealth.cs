namespace Halloween.Health
{
    public interface IHealth
    {
        int Value { get; }
        bool IsAlive { get; }
        
        void TakeDamage(int damage);
    }
}