using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace FirstTest.NPCs
{
	public class NPCScanner : NPC
	{
        //NPC[] npcs;

        
        public static void GetInfo()
        {
            NPC np = Main.npc[50];
            bool alive = AnyNPCs(np.type);
            int numAlive;

            if (alive == true) {
                numAlive = CountNPCS(np.type);
            } else
            {
                numAlive = 0;
            }

            int bannerID = Item.NPCtoBanner(np.BannerID());

            int numKilled;

            if (bannerID != 1) {
                numKilled = killCount[bannerID];
            } else
            {
                numKilled = 0;
            }

            int hp = np.life;

            Console.WriteLine("Information: \nNumber Alive:" + numAlive + "\nNumber Killed:" + numKilled + "\nHP:" + hp);
        }

    }
}