using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaeriesAndTheWizard
{
    public static class TextStorage
    {
        //NarratorText
        public static string IntroText = "Welcome to your Tower, great Wizard! Before we get started, what is your name?";

        public static string PostNameIntroP1 = "Well, that is an interesting name, "; public static string PostNameIntroP2 = " but regardless of your strange name, you have much to do! Yes, much to do!\nThe faeries have escaped, and you are in great danger!\n\n\n\n";




        public static string FirstChoiceO12 = "You have several choices ahead of you! Touch an item to find out what it is! (To do this, input the number next to the possible item)";

        public static string[] three = new string[]
        {
             @"                        3333                      ",
             @"                     3333  3333                   ",
             @"                  3333        3333                ",
             @"                                 3333             ",
             @"                              3333                ",
             @"                           3333                   ",
             @"                       33333                      ",
             @"                           3333                   ",
             @"                              3333                ",
             @"                                 3333             ",
             @"                  3333        3333                ",
             @"                     3333  3333                   ",
             @"                        3333                      "
            
        };
        public static string[] thing = new string[]
       {
             @"             TTTTTTTTTTTTTTTTTTTTTTTTT            ",
             @"             Tt         Tt          Tt            ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        ",
             @"                        Tt                        "

       };
        public static string[] game = new string[]
        {
             @"                       GGGG                       ",
             @"                    GGGG  GGGG                    ",
             @"                 GGGG        GGGG                 ",
             @"               GGG              GGG               ",
             @"             GGG              GGGGGGG             ",
             @"            GG                                    ",
             @"            GG                                    ",
             @"             GGG         GGGGGGGGGGG              ",
             @"               GGG       g      GGG               ",
             @"                 GGGG        GGGG                 ",
             @"                    GGGG  GGGG                    ",
             @"                       GGGG                       ",
             @"                                                  "
        };
        public static string[] threethinggame = new string[]
        {
             @"        3333             TTTTTTTTTTTTTTTTTTTTTTTTT               gg                 ",
             @"     3333  3333          Tt         Tt          Tt              GGGG                ",
             @"  3333        3333                  Tt                       GGGG  GGGG             ",
             @"                 3333               Tt                    GGGG        GGGG          ",
             @"              3333                  Tt                  GGG              GGG        ",
             @"           3333                     Tt                GGG              GGGGGGG      ",
             @"       33333                        Tt               GG                             ",
             @"           3333                     Tt               GG                             ",
             @"              3333                  Tt                GGG         GGGGGGGGGGG       ",
             @"                 3333               Tt                  GGG       g      GGG        ",
             @"  3333        3333                  Tt                    GGGG        GGGG          ",
             @"     3333  3333                     Tt                       GGGG  GGGG             ",
             @"        3333                        Tt                          GGGG                "
        };
        public static string[] CauldronLevel = new string[]
        {
                         "|------------------<--->----------------|",
                         "|                                       |",
                         "|                               ~       |",
                         "|                             ~         |",
                         "|                           ~  ~        |",
                         "|                       ~               |",
                         "|                      ~                |",
                         "|                    ~                  |",
                         "|                  CC CC                |",
                         "|                  CC CC                |",
                         "|                  CCCCC                |",
                         "|                                       |",
                         "|                                       |",
                         "|                                       |",
                         "|                                       |",
                         "|                                       |",
                         "|                    @                  |",
                         "|------------------<--->----------------|"
        };

        public static string[] BossFloor = new string[]
        {
                         @"|------------------<--->----------------|",
                         @"|         THE  FEY  QUEEN               |",
                         @"|             | | |                     |",
                         @"|      |‾‾‾‾ \('‾') /‾‾‾‾|              |",
                         @"|      |  0   \_ニ_|/  0  |              |",
                         @"|      |    `  \|/   `   |              |",
                         @"|      | ``  ‾‾/|\‾‾  `` |              |",
                         @"|      |   `  / | \   `  |              |",
                         @"|      |  0  /  ^  \   0 |              |",
                         @"|      |____/  / \  \____|              |",
                         @"|             /   \                     |",
                         @"|                                       |",
                         @"|            ATTACKS                    |",
                         @"|                                       |",
                         @"|                                       |",
                         @"|                                       |",
                         @"|                    @                  |",
                         @"|------------------<--->----------------|"
        };

        public static string[] BossFloorHard = new string[]
        {
                         @"|------------------<--->----------------|",
                         @"|     THE  FEY  QUEEN  (HELL MODE)      |",
                         @"|             |\|/|                     |",
                         @"|      |‾‾‾‾ \('‾') /‾‾‾‾|              |",
                         @"|      |  0   \_^_|/  0  |              |",
                         @"|      |    `  \|/   `   |              |",
                         @"|      | ``  ‾‾/|\‾‾  `` |              |",
                         @"|      |   `  / | \   `  |              |",
                         @"|      |  0  /  ^  \   0 |              |",
                         @"|      |____/  / \  \____|              |",
                         @"|             /   \                     |",
                         @"|                                       |",
                         @"|     SEEKS VENGENCE FOR HER KIND       |",
                         @"|                                       |",
                         @"|                                       |",
                         @"|                                       |",
                         @"|                    @                  |",
                         @"|------------------<--->----------------|"
        };

        //Options Arrays
        public static string[] CreditRoom = new string[]
        {
                         @"|---------------------------------------|",
                         @"|                                       |",
                         @"|           A WINNER IS YOU!            |",
                         @"|                                       |",
                         @"|            CONGRATULATIONS            |",
                         @"|                                       |",
                         @"|       CREDITS:                        |",
                         @"|          ALEXANDER WILKINSON          |",
                         @"|        (SYSTEMS, ROOMS AND            |",
                         @"|          THE ITEMS)                   |",
                         @"|                                       |",
                         @"|          BRANDON LEDGER               |",
                         @"|         (ENEMY DESIGN, COMBAT,        |",
                         @"|          THE BEHIND THE AMAZING       |",
                         @"|           FEY QUEEN SPRITE)           |",
                         @"|                                       |",
                         @"|                                       |",
                         @"|---------------------------------------|"
        };



        //drawing
        // @ == you, x1 == possible enemy, i2 == possible item, <--> == door


    }
}
