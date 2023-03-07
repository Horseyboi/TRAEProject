using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TRAEProject.NewContent.Items.Accesories.ExtraJumps
{
    public class JetBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Jet boots");
            // Tooltip.SetDefault("Rocket boots and wings are activated by pushing UP instead of jump\nIncreases flight time by 40%\nProvides rocket boot flight(10)\nProvides a booster double jump");
        }
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ItemRarityID.Lime;
			Item.value = Item.buyPrice(0, 35);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<TRAEJumps>().advFlight = true;
            player.rocketTimeMax += 10;
            player.GetModPlayer<TRAEJumps>().boosterFlightTimeMax += 40;
            player.GetModPlayer<Mobility>().flightTimeBonus += 0.4f;
            player.rocketBoots = player.vanityRocketBoots = 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ModContent.ItemType<AdvFlightBoots>(), 1)
                .AddIngredient(ModContent.ItemType<Booster>(), 1)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}