using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
namespace Buisnessapplication.UI
{
    class GeneralUI
    {

        public static string ManagerMenu()
        {

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t1. Search Book");
            Console.WriteLine("\t2. Organize Library Events");//Composition==>Manager
            Console.WriteLine("\t3. Manage Library Staff");//Composition==>Manager
            Console.WriteLine("\t4. Inventory");//Composition==>Manager
            Console.WriteLine("\t5. Add Book Locations Details In Libray ");//Composition==>Manager
            Console.WriteLine("\t6. Manage Budget");//Composition==>Manager
            Console.WriteLine("\t7. Generate Reports");//Composition==>Manager
            Console.WriteLine("\t8. Dispaly Reports");
            Console.WriteLine("\t9. Remove Reports");
            Console.WriteLine("\t10.Manage Meetings");//Composition==>Manager
            Console.WriteLine("\t11.Generate Monthy Report");//Composition==>Manager
            Console.WriteLine("\t12.Exit");
            Console.Write("\tEnter Your choice: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CommonBL.mangerOption = Console.ReadLine();
            return CommonBL.mangerOption;
        }

        public static void LaibraryLogo()
        {
            Console.WriteLine("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                           / /        ( ) / __      __      ___      __");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                          / /        / / //   ) ) //  ) ) //   ) ) //     / /");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                         / /        / / //   / / //      //   / / //      ((___/ /");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                        / /____/ / / / ((___/ / //      ((___( ( //           / /");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        /|    //| |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       //|   // | |     ___       __      ___       ___      ___      _   __      ___       __   __  ___");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("      // |  //  | |   //   ) ) //   ) ) //   ) )  //___) ) // ) )  ) ) //___) ) //   ) ) / /");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("     //  | //   | |  //   / / //   / / //   / / ((___/ / //       // / /  / / //       //   / / / /");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    //   |//    | | ((___( ( //   / / ((___( (   //__   ((____   // / /  / / ((____   //   / / / /");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t   //   ) )");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t   ((                  ___   __  ___  ___      _   __");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t     \\     //   / / ((   ) ) / /   //___) ) // ) )  ) )");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t       ) ) ((___/ /   \\ \\    / /   //       // / /  / /");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t((___ / /      / / //   ) ) / /   ((____   // / /  / /");


        }




        public static void SignIn()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                            ___   ___        ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("        //   ) )                               / /           ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("       ((        ( )  ___       __           / /      __    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("         \\     / / //   ) ) //   ) )       / /    //   ) ) ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("           ) ) / / ((___/ / //   / /      / /    //   / /  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    ((___ / / / /   //__   //   / /    __/ /___ //   / /   ");
            Console.ResetColor();
            Console.WriteLine();
        }



        public static void SignUp()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                              ___             ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("        //   ) )                             / /     //          ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("       ((        ( )  ___       __          / /     //      __    ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("         \\     / / //   ) ) //   ) )       / /     //      / /   ) ) ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("           ) ) / / ((___/ / //   / /      / /     //      / /    )");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    ((___ / / / /   //__   //   / /   __/ /___   //      / /   ");
            Console.ResetColor();
            Console.WriteLine();
        }




        public static void logoBook()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    //   ) )                                      ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   //___/ /    ___      ___     / ___      ___    ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  / __  (   //   ) ) //   ) ) //\\ \\     ((   ) ) ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" //    ) ) //   / / //   / / //  \\ \\     \\ \\     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("//____/ / ((___/ / ((___/ / //    \\ \\ //   ) )  ");

        }


        public static void ManagerLogo()
        {
            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     //|   // | |     ___       __      ___      ___      ___      __        //|   // | |       ___      __");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("    // |  //  | |   //   ) ) //   ) ) //   ) ) //   ) ) //___) ) //  ) )    // |  //  | |    //___) ) //   ) )  //   / /");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   //  | //   | |  //   / / //   / / //   / / ((___/ / //       //        //  | //    | |   //       //   / /  //   / /");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  //   |//    | | ((___( ( //   / / ((___( (   //__   ((____   //        //            | |  ((____   //   / /  ((___( (");
            Console.ResetColor();

        }


        public static void BookLogo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                      -----------------:.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                    .=.                .:---:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                   --                        :--.     .:----------------:.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                 .=.                            :=----.                  .:----:.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                --                               =:                             .--+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("              .=.                              .=                                .+*.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("             -=                               --                                :=.-=");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("           .=.                               =.                                -=...+#**=*");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          --                               .=                                 =:....+#**#+");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("        .=.                               --                                :+....:****#=");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("       --                                =.                                -=....-#***#:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     .=:                               :=                                 =-....=#****.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("    -*-----------:..                  --                                .+:....+#**#+");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    +.............::-----:          .=.                                :=....:#***#=");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   =#:...................:---:     :-                                 --....=#***#:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" -#*#**********++==-:........:==: =:                                 +:....*#***#.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=++**##*************##*=-.......:==--------------:.                .+....-#*****");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      ..:-==+**##********#+:.::...................:-----:         -=....=#***#=");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                .:--=+**#**##*##*+-......................----.   =-....*****#:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                         .:-=+**#*#***####***++=-:...........-=-+....:#*****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                 .:-=+**#********##*+=-:............=#***#=");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                         .:-=+*##******#**=-:......+#***#:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                .:--=+*#****##+=--#*****.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                        .:-=+*#**#***#=");
            Console.ResetColor();

        }
        public static void LogoCustomer()
        {

            Console.WriteLine("\t\t\tWelcome To The Customer Menu\n");


        }

        public static string CustomerMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t1. Search Book");
            Console.WriteLine("\t2. View Books ");
            Console.WriteLine("\t3. Borrow Books");
            Console.WriteLine("\t4. View Notices");
            Console.WriteLine("\t5. Buy  BOOKS");
            Console.WriteLine("\t6. Return Books");
            Console.WriteLine("\t7. View Upcoming Events ");
            Console.WriteLine("\t8  Exit");
            Console.WriteLine("\tEnter The Choice:");
            Console.ForegroundColor = ConsoleColor.Cyan;


            string choice = Console.ReadLine();
            return choice;
        }



        public static string AdminMenu()
        {
            Console.Clear();
            AdminLogo();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t1.  Add Books");//Composition==>Admin
            Console.WriteLine("\t2.  View Books");
            Console.WriteLine("\t3.  Create Customer Account");//Composition==>Admin
            Console.WriteLine("\t4.  Create Manager Account");//Composition==>Admin
            Console.WriteLine("\t5.  View Customers Details");
            Console.WriteLine("\t6.  View Employees Details");
            Console.WriteLine("\t7.  Remove Customer Account");
            Console.WriteLine("\t8.  Remove Employee Account");//Composition==>Admin
            Console.WriteLine("\t9.  Update Books");
            Console.WriteLine("\t10. Delete Books");
            Console.WriteLine("\t11  Manage Notices");//Composition==>Admin
            Console.WriteLine("\t12. Exit");
            Console.ResetColor();
            Console.Write("\tEnter your choice: ");
            CommonBL.adminMenu = Console.ReadLine();
            return CommonBL.adminMenu;

        }


        public static void ShowInvalidError()
        {
            Console.WriteLine("Invalid admin option");

        }
        public static void loadedDataMsg()
        {
            Console.WriteLine("Data loaded successfully");

        }

        public static void NotLoaded()
        {
            Console.WriteLine("Data Not Loaded");

        }

        public static void AdminLogo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                         ___   ___");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    // | |     //    ) ) /|    //| |       / /    /|    / /       /|    //| |     //   / /  /|    / / //   / /");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   //__| |    //    / / //|   // | |      / /    //|   / /       //|   // | |    //____    //|   / / //   / /");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  / ___  |   //    / / // |  //  | |     / /    // |  / /       // |  //  | |   / ____    // |  / / //   / /");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" //    | |  //    / / //  | //   | |    / /    //  | / /       //  | //   | |  //        //  | / / //   / /");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("//     | | //____/ / //   |//    | | __/ /___ //   |/ /       //   |//    | | //____/ / //   |/ / ((___/ /");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}


