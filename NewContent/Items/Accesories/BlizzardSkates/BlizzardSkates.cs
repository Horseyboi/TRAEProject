using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TRAEProject.NewContent.Items.Accesories.BlizzardSkates
{
    public class BlizzardSkates : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blizzard Skates");
            Tooltip.SetDefault("Allows skating by double tapping on the ground\nGrants a double jump\nAllows for a powerful airborne dash that uses the double jump.");
        }
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ItemRarityID.Pink;
            Item.value = 37500;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.hasJumpOption_Blizzard = true;
            //player.GetModPlayer<PlayerChanges>().blizzardDash = true;
            player.dashType = 99;
        }

        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.IceSkates, 1)
                .AddIngredient(ItemID.BlizzardinaBottle, 1)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}
