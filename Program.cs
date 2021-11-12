using System;
using System.Collections.Generic;

namespace InlämningsUppgift3
{


    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.menuGame();

        }
    }

    class Menu
    {
        public void menuGame()
        {
            try
            {
                Console.Clear();
                Hello();



                Console.WriteLine("Tryck [R] för att börja spela.\nTryck [P] för att gå till Store." +
                    "\nTryck [C] för att kolla dina coins.\nTryck [E] för att kolla din Character");
                string option = Console.ReadLine();
                option = option.ToUpper();


                if (option == "R")
                {
                    Combat combat = new Combat();
                    combat.Fight();



                }
                if (option == "P")
                {
                    Possion posion = new Possion();
                    posion.possion();


                }
                if (option == "C")
                {
                    Player player = new Player();
                    Console.WriteLine("Du har " + player.playerGold + "Coins kvar");

                }
                if (option == "E")
                {

                    Console.Clear();
                    Hello();
                    Player player = new Player();
                    Console.WriteLine(player.getInfoplayer());
                    Console.WriteLine();
                    Console.WriteLine("Tryck på en bokstav för att fortsätta");
                    Console.ReadLine();

                    menuGame();
                }
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("           Försök igen att Starta Om Spelet                   " + error.Message);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        public void Hello()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.WriteLine("-----------------------............--|VÄLKOMMEN TILL LillaMonsTers VidEoGaMes| (DFD) --.................-----------");
            Console.WriteLine("´´´´´´´´´´´´´´´´´-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`+++++++-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-`-´´´´´´´´´´´´´´´´");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string getNamn()
        {
            Console.WriteLine("Ange ditt characters Name");
            string playerName = Console.ReadLine();
            return playerName;
        }
    }

    class SaveResults
    {

        public List<int> savedPottions = new List<int>();

        public List<int> savedExperience = new List<int>();

        public List<int> savedCoins = new List<int>();
        
        public List<int> savedLife = new List<int>();

    }


    class Combat
    {
        public void Fight()
        {
            try
            {
                Menu menu = new Menu();
                Player player = new Player();
                Monster1 monster = new Monster1();
                Possion possion = new Possion();
                Randoms coins = new Randoms();
                SaveResults saveresults = new SaveResults();


                Menu hello = new Menu();


                Random random = new Random();
                int whatsNext = random.Next(1, 10);
                if (whatsNext == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Probabilities are by your side and the monsters don't dare come closer.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    menu.menuGame();
                }
                else
                {
                    Console.Clear();
                    hello.Hello();
                    Console.WriteLine("Get Ready! A monster is comming!");


                    //player.playerHealth = player.playerHealth + possion.healthPossion;
                    //player.playerAttack = player.playerAttack + possion.attackPossion;
                    //player.playerArmour = player.playerArmour + possion.armourPossion;


                    


                    Console.WriteLine("Be prepared!");
                    Console.WriteLine();
                    Console.WriteLine($"PlayerHealth: {player.playerHealth} MonsterHealth: {monster.monsterHealth}\nTryck enter eller en bokstav för att anfalla; ");
                    Console.ReadLine();


                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        int result2 = monster.monsterHealth - player.damage();
                        Console.WriteLine("Monsters Life " + result2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Oh no! The monster resisted your attack and still has " + result2 + " Life points");
                        monster.monsterHealth = result2;
                        Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        int result1 = player.playerHealth - monster.damage();
                        Console.WriteLine("Players Life: " + result1);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Be strong! You still have " + result1 + " Life points");
                        player.playerHealth = result1;
                        Console.ReadLine();


                        if (monster.monsterHealth <= 0 && player.playerHealth > 0)
                        {
                            
                            saveresults.savedLife.Add(result2);
                            

                            

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Wait... ¡GRATTIS! Du har vunnit!! ");

                            int amountCoins = coins.coinsChance();
                            saveresults.savedCoins.Add(amountCoins);
                            
                            

                            Console.WriteLine();
                            Console.WriteLine("Du får " + amountCoins + "Coins");
                            Console.WriteLine("Och " + monster.experience1 + "XP points");
                            saveresults.savedExperience.Add(monster.experience1);
                            
                           

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            int input0 = 0;
                            while (input0 != 1)
                            {
                                Console.WriteLine("Tryck [1] för att gå till huvudmenyn.");
                                input0 = Convert.ToInt32(Console.ReadLine());
                            }
                            //__________________________________________________________________________________________________________________________
                            if (input0 == 1)
                            {
                                menu.menuGame();
                            }



                        }


                    } while ((player.playerHealth >= 0 || monster.monsterHealth >= 0));
                }
            }
            catch (Exception error)
            {


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("           Försök igen att Starta Om Spelet                   " + error.Message);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.WriteLine("//");
                Console.ForegroundColor = ConsoleColor.Black;

            }
        }

    }

    class Player
    {
        Possion posion = new Possion();
        Combat combat = new Combat();
        SaveResults saveresults = new SaveResults();

        public int damage()
        {
            Randoms damageChance = new Randoms();
            return damageChance.Chance3();

        }

        public int playerLevel;
        public int playerHealth;
        public int playerAttack;
        public int playerArmour;
        public int attackPossion;
        public int healthPossion;
        public int armourPossion;
        public int playerExperience;
        public int playerGold;


        public Player()
        {
            playerLevel = 1;
            playerHealth = 100 + saveresults.savedLife[0];
            playerAttack = 0;
            playerArmour = 0;
            playerGold = 0;
            playerExperience = 0;
            healthPossion = posion.healthPossion;
            attackPossion = posion.attackPossion;
            armourPossion = posion.armourPossion;
        }

        public void getSkills(int playerLevel, int playerHealth, int playerAttack, int playerArmour,
            int playerGold, int playerExperience, int healthPossion, int attackPossion, int armourPossion)
        {
            this.playerLevel = playerLevel;
            this.playerHealth = playerHealth;
            this.playerAttack = playerAttack;
            this.playerArmour = playerArmour;
            this.playerGold = playerGold;
            this.playerExperience = playerExperience;
            this.healthPossion = healthPossion;
            this.attackPossion = attackPossion;
            this.armourPossion = armourPossion;
        }

        public string getInfoplayer()
        {
            Menu menu = new Menu();
            Possion possion = new Possion();

            return "Name " + menu.getNamn() + "\nGold: " + playerGold + "\nLevel: " + playerLevel + "\nHealth: " + playerHealth + "\nHealth Possion: " + healthPossion + "\nAttack: "
                + playerAttack + "\nArmour: " + playerArmour + "\nExperience: " + playerExperience;


        }



    }

    class Randoms
    {
        public int Chance1()
        {
            Random probabilities = new Random();
            int chance1 = probabilities.Next(5, 15);
            return chance1;
        }

        public int Chance2()
        {
            Random probabilities = new Random();
            int chance2 = probabilities.Next(10, 20);
            return chance2;
        }

        public int Chance3()
        {
            Random probabilities = new Random();
            int chance3 = probabilities.Next(15, 25);
            return chance3;
        }







        public int coinsChance()
        {
            Random random = new Random();
            int coins = random.Next(30, 100);
            return coins;
        }


    }

    //__________________________________________
    class Possion
    {
        public object[] KindOfpossion;
        private int i = 0;


        public Possion(int z)
        {
            KindOfpossion = new object[z];
        }

        public void add(object obj)
        {
            KindOfpossion[i] = obj;
            i++;
        }

        public object getpossion(int i)
        {
            return KindOfpossion[i];
        }


        public int attackPossion;
        public int healthPossion;
        public int armourPossion;

        public Possion()
        {
            attackPossion = 0;
            healthPossion = 0;
            armourPossion = 0;
        }

        //[1] Health__________________________________________________________________________//


        public int getLittleHealthPossion(int littleHealthPossion)
        {
            littleHealthPossion = littleHealthPossion + 20;
            add(littleHealthPossion);
            return littleHealthPossion;


        }

        public int getMiddleHealthPossion(int middleHealthpossion)
        {
            middleHealthpossion = middleHealthpossion + 40;
            add(middleHealthpossion);
            return middleHealthpossion;

        }

        public int getbigHealthPossion(int bigHealthpossion)
        {
            bigHealthpossion = bigHealthpossion + 80;
            add(bigHealthpossion);
            return bigHealthpossion;
        }

        //[2] Armour___________________________________________________________________________//


        public int getLittlArmourPossion(int armourPossionValue)
        {
            return armourPossion = armourPossion + 20;
        }

        public int getMiddleAlmourPossion(int armourPossionValue)
        {
            return armourPossion = armourPossion + 40;
        }

        public int getbigAlmourPossion(int armourPossionValue)
        {
            return armourPossion = armourPossion + 80;
        }


        //[3] Attack___________________________________________________________________________//


        public int getLittleAttackPossion(int attackPossionValue)
        {
            return attackPossion = attackPossion + 20;
        }

        public int getMiddleAttackPossion(int attackPossionValue)
        {
            return attackPossion = attackPossion + 40;
        }

        public int getbigAttackPossion(int attackPossionValue)
        {
            return attackPossion = attackPossion + 80;
        }

        //_____________________________________________________________________________________//



        public int possion()
        {
            Player player = new Player();

            Menu hello = new Menu();
            Console.Clear();
            hello.Hello();


            Console.WriteLine("" +
                  "Tryck[1] för att köpa HealthPossion." +
                "\nTryck[2] för att köpa AttackPossion." +
                "\nTryck[3] för att köpa ArmourPossion " +
                "\nDu har " + player.playerGold + "coins kvar");

            int input0 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (input0 == 1)
            {
                hello.Hello();



                Console.WriteLine("Välj en Healthpossion." +
                  "\n\nTryck[1] för lillaPossion: Health +20." +
                    "\nTryck[2] för mellanPossion: Health +40." +
                    "\nTryck[3] för storaPossion +80\n ");

                int input1 = Convert.ToInt32(Console.ReadLine());

                if (input1 == 1)
                {
                    getLittleHealthPossion(healthPossion);
                    hello.menuGame();
                }
                if (input1 == 2)
                {
                    getMiddleHealthPossion(healthPossion);
                    hello.menuGame();
                }
                if (input1 == 3)
                {
                    getbigHealthPossion(healthPossion);
                    hello.menuGame();
                }
            }

            else if (input0 == 2)
            {

                hello.Hello();
                Console.WriteLine("Välj en AttackPossion.\n\n" +
                      "Tryck[1] för lillaPossion: Attack +20." +
                    "\nTryck[2] för mellanPossion: Attack +40." +
                    "\nTryck[3] för storaPossion: Attack +80\n ");

                int input2 = Convert.ToInt32(Console.ReadLine());


                if (input2 == 1)
                {
                    getLittleAttackPossion(attackPossion);
                    hello.menuGame();

                }
                if (input2 == 2)
                {
                    getMiddleAttackPossion(attackPossion);
                    hello.menuGame();
                }
                if (input2 == 3)
                {
                    getbigAttackPossion(attackPossion);
                    hello.menuGame();
                }
            }

            else if (input0 == 3)
            {

                hello.Hello();
                Console.WriteLine("Välj en ArmourPossion." +
                  "\n\nTryck[1] för lillaPossion: Armour +20." +
                    "\nTryck[2] för mellanPossion: Armour +40." +
                    "\nTryck[3] för storaPossion: Armour +80\n ");
                int input3 = Convert.ToInt32(Console.ReadLine());


                if (input3 == 1)
                {
                    getLittlArmourPossion(armourPossion);
                    hello.menuGame();

                }
                if (input3 == 2)
                {
                    getMiddleAlmourPossion(armourPossion);
                    hello.menuGame();
                }
                if (input3 == 3)
                {
                    getbigAlmourPossion(armourPossion);
                    hello.menuGame();
                }

            }

            return healthPossion;

        }

    }

    class Monster1
    {
        public int damage()
        {
            Randoms damageChance = new Randoms();
            return damageChance.Chance1();

        }

        public Monster1()
        {
            namn = "Lilla Monster";
            monsterHealth = 100;
            monsterAttack = 0;
            monsterArmour = 0;
            experience1 = 25;
        }

        public string namn;
        public int monsterHealth;
        public int monsterAttack;
        public int monsterArmour;
        public int coins;
        public int experience1;


    }

    class Monster2 : Monster1
    {
        public int damage()
        {
            Randoms damageChance = new Randoms();
            return damageChance.Chance2();

        }

        public Monster2()
        {
            namn = "mellan monster";
            monsterHealth = 200;
            monsterAttack = 0;
            monsterArmour = 15;
            experience2 = 75;
        }

        public int experience2;
    }

    class Monster3 : Monster1
    {

        public int damage()
        {
            Randoms damageChance = new Randoms();
            return damageChance.Chance3();

        }


        public Monster3()
        {
            namn = "Stora monster";
            monsterHealth = 500;
            monsterAttack = 0;
            monsterArmour = 30;
            coins = 100;
            experience3 = 50;

        }

        public int experience3;
    }


}

