using System;
using System.Collections.Specialized;

namespace Zelda
{
    class Enemy
    {
        public Enemy()
        {
        }
    }

    class Boss : Enemy
    {
        public Boss()
        {
        }
    }

    class MiniBoss : Enemy
    {
        public MiniBoss()
        {
        }
    }

    class Guardian : Enemy
    {
        public Guardian()
        {
        }
    }

    class HostileAnimal : Enemy
    {
        public HostileAnimal() 
        {
        }
    }
    class NormalEnemy : Enemy
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Reward { get; set; }
        public string Ability { get; set; }
        public string Skin { get; set; }
        public int AttackPower { get; set; }
        public int Speed { get; set; }
        public int JumpForce { get; set; }
        public string AttackMode { get; set; }

        public NormalEnemy(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
                int speed, int jumpForce, string attackMode)
        {
            Size = size;
            Name = name;
            HP = hp;
            Reward = reward;
            Ability = ability;
            Skin = skin;
            AttackPower = attackPower;
            Speed = speed;
            JumpForce = jumpForce;
            AttackMode = attackMode;
        }
    }

    class Chuchu : NormalEnemy
    {
        public Chuchu(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }

    class Kesse : NormalEnemy
    {
        public Kesse(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }

    class Octorok : NormalEnemy
    {
        public Octorok(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class Wizzrobe : NormalEnemy
    {
        public Wizzrobe(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class Pebblit : NormalEnemy
    {
        public Pebblit(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class Bokoblin : NormalEnemy
    {
        public Bokoblin(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class Moblin : NormalEnemy
    {
        public Moblin(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class Lizzalfos : NormalEnemy
    {
        public Lizzalfos(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class Lynel : NormalEnemy
    {
        public Lynel(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class YigaBladeMaster : NormalEnemy
    {
        public YigaBladeMaster(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
    
    class YigaFootSoldier : NormalEnemy
    {
        public YigaFootSoldier(int size, string name, int hp, int reward, string ability, string skin, int attackPower,
            int speed, int jumpForce, string attackMode) : base(size, name, hp, reward, ability, skin, attackPower, speed, jumpForce, attackMode)
        {
        }
    }
}