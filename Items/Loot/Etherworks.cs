using Terraria;
using Terraria.ModLoader;

namespace Laugicality.Items.Loot
{
    public class Etherworks : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("+30% Throwing damage and +50% Throwing Velocity while in the Etherial");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 100;
            item.rare = 2;
            item.accessory = true;
            item.expert = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            var modPlayer = player.GetModPlayer<LaugicalityPlayer>(mod);
            if (modPlayer.etherial || modPlayer.etherable)
            {
                player.thrownDamage += .30f;
                player.thrownVelocity += .5f;
            }
        }
        /*
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2328, 4);
            recipe.AddTile(null, "AlchemicalInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}