class Player
{
    public int _age;

    public Player(string name, int age)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя не может быть пустым", nameof(name));

        if (age < 0)
            throw new ArgumentOutOfRangeException(nameof(age), "Возраст не может быть отрицательным");

        _age = age;

    }

    public string Name { get; private set; }
}

class Weapon
{
    private int _damage;
    public float _cooldown { get; private set; }

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
    private float _speed;

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
