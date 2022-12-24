﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TRAEProject.Changes;
using TRAEProject.Common.ModPlayers;

namespace TRAEProject.NewContent.Items.Accesories.TwoFlowers
{    [AutoloadEquip(EquipType.Waist)]
    class TwoFlowers : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Two Flowers");
            Tooltip.SetDefault("Magic critical strikes deal 11% increased damage and have a chance to spawn a mana star\nAutomatically uses mana potions when needed\n");
        }
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ItemRarityID.Orange;
            Item.value = 50000;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaRose = true;
            player.GetModPlayer<CritDamage>().magicCritDamage += 0.11f;
            player.manaFlower = true;
            player.GetModPlayer<Mana>().newManaFlower = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.ObsidianRose, 1)
                .AddIngredient(ItemID.ManaFlower, 1)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}
