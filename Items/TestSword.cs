using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstTest.Items
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cipher's Blade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a modded sword for testing (created by Cipher). Rendition of Titanium Sword"); //image of Blood Butcherer. Following naming rules based on tMod's instructions.
		}

		public override void SetDefaults() 
		{
			item.damage = 52;
			item.melee = true;
			//item.width = 40;
			//item.height = 40;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 161000;
            //item.maxStack = 99;
            item.rare = 4;
            //item.scale = 1.2;
            item.stack = 1;
            //item.crit = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}