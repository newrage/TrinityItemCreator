﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TIC19.MyClass
{
    class QueryHandler
    {
        public QueryHandler() { }

        public int column_entry { get; set; }
        public int column_class { get; set; }
        public int column_subclass { get; set; }
        public int column_SoundOverrideSubclass { get; set; }
        public string column_name { get; set; }
        public int column_displayid { get; set; }
        public int column_Quality { get; set; }
        public int column_Flags { get; set; }
        public int column_FlagsExtra { get; set; }
        public int column_BuyCount { get; set; }
        public int column_BuyPrice { get; set; }
        public int column_SellPrice { get; set; }
        public int column_InventoryType { get; set; }
        public int column_AllowableClass { get; set; }
        public static int column_AllowableRace { get; set; }
        public int column_ItemLevel { get; set; }
        public int column_RequiredLevel { get; set; }
        public int column_RequiredSkill { get; set; }
        public int column_RequiredSkillRank { get; set; }
        public int column_requiredspell { get; set; }
        public int column_requiredhonorrank { get; set; }
        public int column_RequiredCityRank { get; set; }
        public int column_RequiredReputationFaction { get; set; }
        public int column_RequiredReputationRank { get; set; }
        public int column_maxcount { get; set; }
        public int column_stackable { get; set; }
        public int column_ContainerSlots { get; set; }
        public int column_StatsCount { get; set; }
        public int column_stat_type1 { get; set; }
        public int column_stat_value1 { get; set; }
        public int column_stat_type2 { get; set; }
        public int column_stat_value2 { get; set; }
        public int column_stat_type3 { get; set; }
        public int column_stat_value3 { get; set; }
        public int column_stat_type4 { get; set; }
        public int column_stat_value4 { get; set; }
        public int column_stat_type5 { get; set; }
        public int column_stat_value5 { get; set; }
        public int column_stat_type6 { get; set; }
        public int column_stat_value6 { get; set; }
        public int column_stat_type7 { get; set; }
        public int column_stat_value7 { get; set; }
        public int column_stat_type8 { get; set; }
        public int column_stat_value8 { get; set; }
        public int column_stat_type9 { get; set; }
        public int column_stat_value9 { get; set; }
        public int column_stat_type10 { get; set; }
        public int column_stat_value10 { get; set; }
        public int column_ScalingStatDistribution { get; set; }
        public int column_ScalingStatValue { get; set; }
        public float column_dmg_min1 { get; set; }
        public float column_dmg_max1 { get; set; }
        public int column_dmg_type1 { get; set; }
        public float column_dmg_min2 { get; set; }
        public float column_dmg_max2 { get; set; }
        public int column_dmg_type2 { get; set; }
        public int column_armor { get; set; }
        public int column_holy_res { get; set; }
        public int column_fire_res { get; set; }
        public int column_nature_res { get; set; }
        public int column_frost_res { get; set; }
        public int column_shadow_res { get; set; }
        public int column_arcane_res { get; set; }
        public int column_delay { get; set; }
        public int column_ammo_type { get; set; }
        public float column_RangedModRange { get; set; }
        public int column_spellid_1 { get; set; }
        public int column_spelltrigger_1 { get; set; }
        public int column_spellcharges_1 { get; set; }
        public float column_spellppmRate_1 { get; set; }
        public int column_spellcooldown_1 { get; set; }
        public int column_spellcategory_1 { get; set; }
        public int column_spellcategorycooldown_1 { get; set; }
        public int column_spellid_2 { get; set; }
        public int column_spelltrigger_2 { get; set; }
        public int column_spellcharges_2 { get; set; }
        public float column_spellppmRate_2 { get; set; }
        public int column_spellcooldown_2 { get; set; }
        public int column_spellcategory_2 { get; set; }
        public int column_spellcategorycooldown_2 { get; set; }
        public int column_spellid_3 { get; set; }
        public int column_spelltrigger_3 { get; set; }
        public int column_spellcharges_3 { get; set; }
        public float column_spellppmRate_3 { get; set; }
        public int column_spellcooldown_3 { get; set; }
        public int column_spellcategory_3 { get; set; }
        public int column_spellcategorycooldown_3 { get; set; }
        public int column_spellid_4 { get; set; }
        public int column_spelltrigger_4 { get; set; }
        public int column_spellcharges_4 { get; set; }
        public float column_spellppmRate_4 { get; set; }
        public int column_spellcooldown_4 { get; set; }
        public int column_spellcategory_4 { get; set; }
        public int column_spellcategorycooldown_4 { get; set; }
        public int column_spellid_5 { get; set; }
        public int column_spelltrigger_5 { get; set; }
        public int column_spellcharges_5 { get; set; }
        public float column_spellppmRate_5 { get; set; }
        public int column_spellcooldown_5 { get; set; }
        public int column_spellcategory_5 { get; set; }
        public int column_spellcategorycooldown_5 { get; set; }
        public int column_bonding { get; set; }
        public string column_description { get; set; }
        public int column_PageText { get; set; }
        public int column_LanguageID { get; set; }
        public int column_PageMaterial { get; set; }
        public int column_startquest { get; set; }
        public int column_lockid { get; set; }
        public int column_Material { get; set; }
        public int column_sheath { get; set; }
        public int column_RandomProperty { get; set; }
        public int column_RandomSuffix { get; set; }
        public int column_block { get; set; }
        public int column_itemset { get; set; }
        public int column_MaxDurability { get; set; }
        public int column_area { get; set; }
        public int column_Map { get; set; }
        public int column_BagFamily { get; set; }
        public int column_TotemCategory { get; set; }
        public int column_socketColor_1 { get; set; }
        public int column_socketContent_1 { get; set; }
        public int column_socketColor_2 { get; set; }
        public int column_socketContent_2 { get; set; }
        public int column_socketColor_3 { get; set; }
        public int column_socketContent_3 { get; set; }
        public int column_socketBonus { get; set; }
        public int column_GemProperties { get; set; }
        public int column_RequiredDisenchantSkill { get; set; }
        public float column_ArmorDamageModifier { get; set; }
        public int column_duration { get; set; }
        public int column_ItemLimitCategory { get; set; }
        public int column_HolidayId { get; set; }
        public string column_ScriptName { get; set; }
        public int column_DisenchantID { get; set; }
        public int column_FoodType { get; set; }
        public int column_minMoneyLoot { get; set; }
        public int column_maxMoneyLoot { get; set; }
        public int column_flagsCustom { get; set; }
        public int column_VerifiedBuild { get; set; }
    }
}
