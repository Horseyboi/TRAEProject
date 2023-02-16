﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TRAEProject.NewContent.Items.DreadItems.RedPearl;

namespace TRAEProject.Changes.NPCs
{
    public class SpawnRate : GlobalNPC
    {
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if(NPC.AnyNPCs(NPCID.BloodNautilus))
            {
                spawnRate = 0;
                maxSpawns = 0;
            }

            else if(player.GetModPlayer<PearlEffects>().spawnUp)
            {
                spawnRate = (int)((double)spawnRate * 0.5);
                maxSpawns = (int)((float)maxSpawns * 2f);
            }
        }

        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Player.ZoneJungle && spawnInfo.SpawnTileY <= Main.maxTilesY - 200 && spawnInfo.SpawnTileY > Main.rockLayer)
                pool.Add(NPCID.JungleCreeper, 0.2f);
            if (spawnInfo.Player.ZoneCorrupt)
            {
                float spawnrate = Main.hardMode ? 0.05f : 0.15f;
                pool.Remove(NPCID.DevourerHead);            
                pool.Add(NPCID.DevourerHead, spawnrate);
            }
            if (spawnInfo.Player.ZoneUnderworldHeight && NPC.downedPlantBoss)
            {
                pool.Remove(NPCID.RedDevil);
                pool.Add(NPCID.RedDevil, 0.25f);
            }
            if (spawnInfo.Player.ZoneUnderworldHeight && NPC.downedPlantBoss)
            {
                int[] lowerTheseSpawnRates = new int[] { NPCID.LavaSlime, NPCID.FireImp, NPCID.Hellbat};
                for (int k = 0; k < lowerTheseSpawnRates.Length; k++)
                {
                    pool.Remove(lowerTheseSpawnRates[k]);
                    pool.Add(lowerTheseSpawnRates[k], 0.02f);
                }
                       
            }

        }
    }
}
