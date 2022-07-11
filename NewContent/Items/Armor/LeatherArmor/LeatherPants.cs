﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.GameContent.Creative;
using TRAEProject.NewContent.Items.Materials;
namespace TRAEProject.NewContent.Items.Armor.LeatherArmor
{
    [AutoloadEquip(EquipType.Legs)]
    public class LeatherPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leather Pants");
            Tooltip.SetDefault("5% increased summon damage");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(0, 0, 0, 35);
            Item.rare = ItemRarityID.Blue;
            Item.width = 26;
            Item.height = 14;
            Item.defense = 3;
        }
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemID.Leather, 2)
                .AddIngredient(ItemID.WormTooth, 7)
                .AddTile(TileID.Anvils)
                .Register();
        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage<SummonDamageClass>() += 0.05f;
        }
    }
}
