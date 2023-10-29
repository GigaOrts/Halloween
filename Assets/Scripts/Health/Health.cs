namespace Halloween.Health
{
    public sealed class Health : IHealth
    {
        private readonly IHealthView _healthView;
        
        public Health(IHealthView healthView, int value)
        {
            _healthView = healthView;
            Value = value;
        }

        public int Value { get; private set; }

        public bool IsAlive
            => Value > 0;

        public void TakeDamage(int damage)
        {
            Value -= damage;

            if (Value < 0)
                Value = 0;
            
            _healthView.Display(Value);
        } 
    }
}