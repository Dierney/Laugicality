﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Laugicality.Items.Consumables
{
	public class ChilledMesh : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons Hypothema\n\'It's almost freezing your fingers off.\'");
        }
        public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 20;
			item.rare = 1;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
			item.shoot = mod.ProjectileType("HypothemaSpawn");
		}

        public override bool CanUseItem(Player player)
        {
            return player.ZoneSnow;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SnowBlock, 25);
            recipe.AddIngredient(ItemID.IceBlock, 25);
            recipe.AddIngredient(null, "ChilledBar", 8);
            recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}