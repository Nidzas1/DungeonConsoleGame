public interface Enemy
{
    int Health { get; }
    int Damage { get; }
    public void TakeDamage(int damage);
}