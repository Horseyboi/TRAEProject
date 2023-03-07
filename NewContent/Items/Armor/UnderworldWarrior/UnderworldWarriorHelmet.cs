﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.GameContent.Creative;
using TRAEProject.NewContent.Items.Materials;

namespace TRAEProject.NewContent.Items.Armor.UnderworldWarrior
{
    [AutoloadEquip(EquipType.Head)]
    public class UnderworldWarriorHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Underworld Warrior Helmet");
            ////Tooltip.SetDefault("15% increased damage\n25% reduced mana costs");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.value = Item.sellPrice(0, 6, 6, 6);
            Item.rare = ItemRarityID.Cyan;
            Item.width = 22;
            Item.height = 16;
            Item.defense = 15;
        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.15f;       

            player.manaCost -= 0.25f;
        }
    }
}

