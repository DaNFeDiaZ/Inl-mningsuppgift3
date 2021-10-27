using System;

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
            Hello();
            
            Console.WriteLine();
           
           
            Console.WriteLine("Tryck [R] för att börja spela.\nTryck [P] för att gå till Store." +
                "\nTryck [C] för att kolla dina coins.\nTryck [E] för att kolla din Character");
            string option = Console.ReadLine();

           
            if (option == "R" )
            {  
                Random random = new Random();
                int whatsNext = random.Next(1, 10);
                if(whatsNext == 1)
                {
                    Console.WriteLine("Ta det lugnt");     
                }
                else
                {
                    Console.WriteLine("Get Ready!");
                }
            
            
            
            }
            if (option == "P")
            {
                Possion posion = new Possion();
                posion.getPossion();


            }
            if (option == "C")
            {

            }
            if (option == "E")
            {
                Console.Clear();
                Hello();
                Player player = new Player();
                Console.WriteLine(player.getInfoplayer());
            }

        }

        public void Hello()
        {
            Console.WriteLine("______________________________________________");
            Console.WriteLine("|HEJ!! VÄLKOMMEN TILL LillaMonster VideoGames|");
            Console.WriteLine("``````````````````````````````````````````````");
            Console.WriteLine();
        }

        public string getNamn()
        {
            Console.WriteLine("Ange ditt characters Name");
            string playerName = Console.ReadLine();
            return playerName;
        }
    }
  
    class Player
    {

        
        private int playerLevel = 1;
        private int playerHealth = 200;
        private int playerAttack = 25;
        private int playerArmour = 20;
        private int attackPossion = 0;
        private int healthPossion = 0;
        private int playerExperience = 0;
        private int playerGold = 0;
    
        
        public Player()
        {
            playerHealth = 200;
            playerAttack = 25;
            playerArmour = 20;
        }

        public string getInfoplayer()
        {
            Menu menu = new Menu();
            

            return "Name " + menu.getNamn() + "\nGold: " + playerGold + "\nLevel: " + playerLevel + "\nHealth: " + playerHealth + "\nAttack: "
                + playerAttack + "\nArmour: " + playerArmour + "\nExperience: " + playerExperience;
        }

       
    }

    class Rnd
    {
        public int Randoms()
        {
            Random random = new Random();
            int coins = random.Next(30, 100);
            return coins;
        }
        
        
    }

    class Possion
    {
        private int attackPossion = 10;
        private int healthPossion = 20;
        private int armourPossion = 25;

        public string getPossion()
        {
            Menu hello = new Menu();


            Console.Clear();
            hello.Hello();
            Console.WriteLine("Tryck [B] för att köpa HealthPossion.\nTryck [A] för att köpa AttackPossion.\nTryck [M] för att köpa ArmourPossion ");
            string possion = Console.ReadLine();
            return possion;
        }
    }

    class Monster1
    {
        
        
        Rnd Azar = new Rnd();
        
         
        private string namn = "lilla monster";
        private int monsterHealth = 100;
        private int monsterAttack = 20;
        private int monsterArmour = 10;
        
        
    }

    class Monster2 : Monster1
    {
        
        private string namn = "mellan monster";
        private int monsterHealth = 200;
        private int monsterAttack = 35;
        private int monsterArmour = 15;
        private int coins = 100;
    }
   
    class Monster3 : Monster1
    {
        
        private string namn = "Stora monster";
        private int monsterHealth = 500;
        private int monsterAttack = 40;
        private int monsterArmour = 30;
        private int coins;
    }

    class battle
    {





    }
}
