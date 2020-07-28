using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstTest.Items
{
	public class TestSpear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cipher's Spear"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a modded spear for testing (created by Cipher). Rendition of Mushroom Spear"); //image of Mushroom Spear used as well. Following naming rules based on tMod's instructions.
        }

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 700000;
            //item.maxStack = 99;
            item.rare = 7;
            //item.scale = 1.2;
            item.stack = 1;
            item.crit = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = 130;
            item.shootSpeed = 5;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useStyle = ItemUseStyleID.HoldingOut;

        }

        // copied from ExampleSpear.cs from ExampleMod project
        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 17);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}