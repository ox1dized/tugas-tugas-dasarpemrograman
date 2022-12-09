using System;

namespace AdventureGame
{
    class Program
    {
        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Adventure Game.");
            Console.WriteLine("Your goal is to defeat the enemy.");
            Console.WriteLine("Good luck!");
        }
        static void Main(string[] args)
        {
            do
            {
                GamePlay();
            } while (PlayAgain());
        }
        static void GamePlay()
        {
            Intro();
            Console.ReadKey();
            Console.Clear();
            Console.Write("Enter your codename: ");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Welcome to the simulation " + player.Name + "." + " Ready to play the game? [y/n]");
            string answer = Console.ReadLine();
            Console.Clear();
            if (answer == "y")
            {
                Console.WriteLine(player.Name + " is entering the world...");
                Enemy enemy1 = new Enemy("Butterfly");
                Console.WriteLine(player.Name + " is encountering " + enemy1.Name);
                Console.WriteLine(enemy1.Name + " is attacking " + player.Name);

                while (!player.IsDead && !enemy1.IsDead)
                {
                    Console.WriteLine("Choose your action:");
                    Console.WriteLine("1. Single Attack");
                    Console.WriteLine("2. Swing Attack");
                    Console.WriteLine("3. Defend");
                    Console.WriteLine("4. Run Away");
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "1":
                            Console.WriteLine(player.Name + " is doing a single attack");
                            enemy1.GetHit(player.AttackPower);
                            player.Experience += 0.3f;
                            enemy1.Attack(enemy1.AttackPower);
                            if (!enemy1.IsDead)
                            {
                                player.GetHit(enemy1.AttackPower);
                            }
                            else
                            {
                                Console.WriteLine("Enemy attack is canceled.");
                            }
                            Console.Write("Player Health: " + player.Health + " | Enemy Health: " + enemy1.Health + "\n");
                            break;
                        case "2":
                            player.Swing();
                            enemy1.GetHit(player.AttackPower);
                            enemy1.Attack(enemy1.AttackPower);
                            if (!enemy1.IsDead)
                            {
                                player.GetHit(enemy1.AttackPower);
                            }
                            else
                            {
                                Console.WriteLine("Enemy attack is canceled.");
                            }
                            player.Experience += 0.9f;
                            Console.Write("Player Health: " + player.Health + " | Enemy Health: " + enemy1.Health + "\n");
                            break;
                        case "3":
                            player.Rest();
                            enemy1.Attack(enemy1.AttackPower);
                            player.GetHit(enemy1.AttackPower);
                            Console.Write("Player Health: " + player.Health + " | Enemy Health: " + enemy1.Health + "\n");
                            break;
                        case "4":
                            Console.WriteLine(player.Name + " ran away!");
                            break;
                        default:
                            Console.WriteLine("Invalid action");
                            break;
                    }
                }
                Console.WriteLine(player.Name + " get " + player.Experience + " experience");
                if (player.IsDead)
                {
                    Console.WriteLine("Your soul is gone.");
                    Console.WriteLine("The End.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You defeated the enemy!");
                    Console.WriteLine("The End.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Goodbye...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        static public bool PlayAgain()
        {
            while (true)
            {
                Console.Write("Do you want to play again [y/n]?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                    return true;
                if (answer == "n")
                    return false;
            }
        }
    }
    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Novice()
        {
            Health = 100;
            AttackPower = 1;
            SkillSlot = 0;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }
        public void Swing()
        {
            if (SkillSlot > 0)
            {
                Console.WriteLine(Name + " is swinging his sword!");
                AttackPower = AttackPower + rnd.Next(3, 11);
                SkillSlot--;
            }
            else
            {
                Console.WriteLine("You don't have enough skill slot!");
                AttackPower = 0;
            }
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name + " is hit for " + hitValue + " damage!");
            Health -= hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
                Console.ReadKey();
            }
        }
        public void Rest()
        {
            Console.WriteLine(Name + " is resting...");
            SkillSlot = 3;
            AttackPower = 1;
        }
        public void Die()
        {
            IsDead = true;
            Console.WriteLine(Name + " is dead. Game Over!");
        }
    }

    class Enemy
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        public string Name { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;
        }
        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1, 10);
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name + " is hit for " + hitValue + " damage!");
            Health -= hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
                Console.ReadKey();
            }
        }
        public void Die()
        {
            IsDead = true;
            Console.WriteLine(Name + " has died!");
        }
    }
}