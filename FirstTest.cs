using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using FirstTest.NPCs;

namespace FirstTest
{
	public class FirstTest : Mod
	{
        public FirstTest()
        {
        }

        static void Main(string[] args)
        {
            NPCScanner.GetInfo();
        }
    }

}