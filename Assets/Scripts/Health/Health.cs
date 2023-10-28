namespace Halloween.Health
{
    public sealed class Health : IHealth
    {
        public Health(int value) 
            => Value = value;

        public int Value { get; private set; }

        public bool IsAlive
            => Value > 0;

        public void TakeDamage(int damage)
        {
            Value -= damage;

            if (Value < 0)
                Value = 0;
        } 
    }
}