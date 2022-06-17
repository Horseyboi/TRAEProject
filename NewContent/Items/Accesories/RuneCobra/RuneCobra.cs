﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using TRAEProject.NewContent.Items.Accesories.ShadowflameCharm;
using static Terraria.ModLoader.ModContent;
using TRAEProject.Common.ModPlayers;

namespace TRAEProject.NewContent.Items.Accesories.RuneCobra
{
    public class RuneCobra : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; 
            DisplayName.SetDefault("Rune Cobra");
            Tooltip.SetDefault("Increases your maximum number of minions by 1 and minion critical strike chance by 5%\nMinion damage is stored as Shadowflame energy, up to 3000\nWhip strikes spawn a friendly Shadowflame Apparition for every 750 damage stored");
        }
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.rare = ItemRarityID.Pink;
            Item.value = 100000;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			++player.maxMinions;
            player.GetModPlayer<ShadowflameCharmPlayer>().ShadowflameCharm += 1;
            player.GetModPlayer<SummonStats>().minionCritChance += 5;
        }
        public override void AddRecipes()
        {
            CreateRecipe().AddIngredient(ItemID.NecromanticScroll, 1)
                .AddIngredient(ItemType<ShadowflameCharmItem>(), 1)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}
