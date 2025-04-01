class Player
{
    private readonly int _age;
    private readonly Weapon _weapon;
    private readonly Mover _mover;

    public Player(string name, int age, Weapon weapon, Mover mover)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя не может быть пустым", nameof(name));

        if (age < 0)
            throw new ArgumentOutOfRangeException(nameof(age), "Возраст не может быть отрицательным");

        Name = name ?? throw new ArgumentNullException(nameof(name));
        _weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
        _mover = mover ?? throw new ArgumentNullException(nameof(name));

        _age = age;
    }

    public string Name { get; }

    private void Attack()
    {
        _weapon.Attack();
    }

    private void Walk()
    {
        _mover.Move();
    }
}

class Weapon
{
    private readonly int _damage;
    private readonly float _cooldown;

    public Weapon(int damage, float cooldown)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage), "Урон не может быть отрицательным");

        if (cooldown < 0)
            throw new ArgumentOutOfRangeException(nameof(cooldown), "Время перезарядки не может быть отрицательным");

        _damage = damage;
        _cooldown = cooldown;
    }

    public void Attack()
    {

    }

    public bool IsReloading()
    {
        throw new NotImplementedException();
    }
}

class Mover
{
    private readonly float _speed;

    public Mover(float speed)
    {
        if (speed < 0)
            throw new ArgumentOutOfRangeException(nameof(speed), "Скорость не может быть отрицательной");

        _speed = speed;
    }

    public float MovementDirectionX { get; private set; }
    public float MovementDirectionY { get; private set; }

    public void Move()
    {

    }
}
