using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Card
    {
        public object Inst;
        public static Type Type;

        public Card(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public string dbfId
        {
            get
            {
                return (string)Type.GetField("dbfId", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("dbfId", AllFlags).SetValue(Inst, value);
            }
        }

        public cardNameEN nameEN
        {
            get
            {
                return (cardNameEN)Type.GetField("nameEN", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nameEN", AllFlags).SetValue(Inst, value);
            }
        }

        public cardNameCN nameCN
        {
            get
            {
                return (cardNameCN)Type.GetField("nameCN", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nameCN", AllFlags).SetValue(Inst, value);
            }
        }

        public Race race
        {
            get
            {
                return (Race)Type.GetField("race", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("race", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 rarity
        {
            get
            {
                return (System.Int32)Type.GetField("rarity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("rarity", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 cost
        {
            get
            {
                return (System.Int32)Type.GetField("cost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 Class
        {
            get
            {
                return (System.Int32)Type.GetField("Class", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Class", AllFlags).SetValue(Inst, value);
            }
        }

        public cardtype type
        {
            get
            {
                return (cardtype)Type.GetField("type", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("type", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 Attack
        {
            get
            {
                return (System.Int32)Type.GetField("Attack", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Attack", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 Health
        {
            get
            {
                return (System.Int32)Type.GetField("Health", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Health", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 Durability
        {
            get
            {
                return (System.Int32)Type.GetField("Durability", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Durability", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean tank
        {
            get
            {
                return (System.Boolean)Type.GetField("tank", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("tank", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Silence
        {
            get
            {
                return (System.Boolean)Type.GetField("Silence", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Silence", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean choice
        {
            get
            {
                return (System.Boolean)Type.GetField("choice", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("choice", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean windfury
        {
            get
            {
                return (System.Boolean)Type.GetField("windfury", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("windfury", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean poisonous
        {
            get
            {
                return (System.Boolean)Type.GetField("poisonous", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("poisonous", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean lifesteal
        {
            get
            {
                return (System.Boolean)Type.GetField("lifesteal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lifesteal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 dormant
        {
            get
            {
                return (System.Int32)Type.GetField("dormant", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("dormant", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean reborn
        {
            get
            {
                return (System.Boolean)Type.GetField("reborn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("reborn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean deathrattle
        {
            get
            {
                return (System.Boolean)Type.GetField("deathrattle", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("deathrattle", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean battlecry
        {
            get
            {
                return (System.Boolean)Type.GetField("battlecry", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("battlecry", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean discover
        {
            get
            {
                return (System.Boolean)Type.GetField("discover", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("discover", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean oneTurnEffect
        {
            get
            {
                return (System.Boolean)Type.GetField("oneTurnEffect", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("oneTurnEffect", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Enrage
        {
            get
            {
                return (System.Boolean)Type.GetField("Enrage", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Enrage", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Aura
        {
            get
            {
                return (System.Boolean)Type.GetField("Aura", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Aura", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Elite
        {
            get
            {
                return (System.Boolean)Type.GetField("Elite", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Elite", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Combo
        {
            get
            {
                return (System.Boolean)Type.GetField("Combo", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Combo", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 overload
        {
            get
            {
                return (System.Int32)Type.GetField("overload", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("overload", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean immuneWhileAttacking
        {
            get
            {
                return (System.Boolean)Type.GetField("immuneWhileAttacking", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("immuneWhileAttacking", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean untouchable
        {
            get
            {
                return (System.Boolean)Type.GetField("untouchable", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("untouchable", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Stealth
        {
            get
            {
                return (System.Boolean)Type.GetField("Stealth", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Stealth", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Freeze
        {
            get
            {
                return (System.Boolean)Type.GetField("Freeze", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Freeze", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean AdjacentBuff
        {
            get
            {
                return (System.Boolean)Type.GetField("AdjacentBuff", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("AdjacentBuff", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Shield
        {
            get
            {
                return (System.Boolean)Type.GetField("Shield", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Shield", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Charge
        {
            get
            {
                return (System.Boolean)Type.GetField("Charge", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Charge", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Rush
        {
            get
            {
                return (System.Boolean)Type.GetField("Rush", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Rush", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Secret
        {
            get
            {
                return (System.Boolean)Type.GetField("Secret", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Secret", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Nature
        {
            get
            {
                return (System.Boolean)Type.GetField("Nature", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Nature", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Quest
        {
            get
            {
                return (System.Boolean)Type.GetField("Quest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Quest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Questline
        {
            get
            {
                return (System.Boolean)Type.GetField("Questline", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Questline", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Morph
        {
            get
            {
                return (System.Boolean)Type.GetField("Morph", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Morph", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Spellpower
        {
            get
            {
                return (System.Boolean)Type.GetField("Spellpower", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Spellpower", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Inspire
        {
            get
            {
                return (System.Boolean)Type.GetField("Inspire", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Inspire", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Outcast
        {
            get
            {
                return (System.Boolean)Type.GetField("Outcast", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Outcast", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Corrupted
        {
            get
            {
                return (System.Boolean)Type.GetField("Corrupted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Corrupted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Corrupt
        {
            get
            {
                return (System.Boolean)Type.GetField("Corrupt", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Corrupt", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean CantAttack
        {
            get
            {
                return (System.Boolean)Type.GetField("CantAttack", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("CantAttack", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Collectable
        {
            get
            {
                return (System.Boolean)Type.GetField("Collectable", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Collectable", AllFlags).SetValue(Inst, value);
            }
        }

        public SpellSchool SpellSchool
        {
            get
            {
                return (SpellSchool)Type.GetField("SpellSchool", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("SpellSchool", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Tradeable
        {
            get
            {
                return (System.Boolean)Type.GetField("Tradeable", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Tradeable", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 TradeCost
        {
            get
            {
                return (System.Int32)Type.GetField("TradeCost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TradeCost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needEmptyPlacesForPlaying
        {
            get
            {
                return (System.Int32)Type.GetField("needEmptyPlacesForPlaying", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needEmptyPlacesForPlaying", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needWithMinAttackValueOf
        {
            get
            {
                return (System.Int32)Type.GetField("needWithMinAttackValueOf", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needWithMinAttackValueOf", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needWithMaxAttackValueOf
        {
            get
            {
                return (System.Int32)Type.GetField("needWithMaxAttackValueOf", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needWithMaxAttackValueOf", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needRaceForPlaying
        {
            get
            {
                return (System.Int32)Type.GetField("needRaceForPlaying", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needRaceForPlaying", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needMinNumberOfEnemy
        {
            get
            {
                return (System.Int32)Type.GetField("needMinNumberOfEnemy", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needMinNumberOfEnemy", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needMinTotalMinions
        {
            get
            {
                return (System.Int32)Type.GetField("needMinTotalMinions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needMinTotalMinions", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needMinOwnMinions
        {
            get
            {
                return (System.Int32)Type.GetField("needMinOwnMinions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needMinOwnMinions", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needMinionsCapIfAvailable
        {
            get
            {
                return (System.Int32)Type.GetField("needMinionsCapIfAvailable", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needMinionsCapIfAvailable", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 needControlaSecret
        {
            get
            {
                return (System.Int32)Type.GetField("needControlaSecret", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needControlaSecret", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean isToken
        {
            get
            {
                return (System.Boolean)Type.GetField("isToken", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("isToken", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 isCarddraw
        {
            get
            {
                return (System.Int32)Type.GetField("isCarddraw", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("isCarddraw", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean damagesTarget
        {
            get
            {
                return (System.Boolean)Type.GetField("damagesTarget", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("damagesTarget", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean damagesTargetWithSpecial
        {
            get
            {
                return (System.Boolean)Type.GetField("damagesTargetWithSpecial", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("damagesTargetWithSpecial", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 targetPriority
        {
            get
            {
                return (System.Int32)Type.GetField("targetPriority", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("targetPriority", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean isSpecialMinion
        {
            get
            {
                return (System.Boolean)Type.GetField("isSpecialMinion", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("isSpecialMinion", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 spellpowervalue
        {
            get
            {
                return (System.Int32)Type.GetField("spellpowervalue", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("spellpowervalue", AllFlags).SetValue(Inst, value);
            }
        }

        public cardIDEnum cardIDenum
        {
            get
            {
                return (cardIDEnum)Type.GetField("cardIDenum", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardIDenum", AllFlags).SetValue(Inst, value);
            }
        }

        public object trigers
        {
            get
            {
                return (object)Type.GetField("trigers", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("trigers", AllFlags).SetValue(Inst, value);
            }
        }

        public object sim_card
        {
            get
            {
                return (object)Type.GetField("sim_card", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("sim_card", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 TAG_SCRIPT_DATA_NUM_1
        {
            get
            {
                return (System.Int32)Type.GetField("TAG_SCRIPT_DATA_NUM_1", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TAG_SCRIPT_DATA_NUM_1", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 TAG_SCRIPT_DATA_NUM_2
        {
            get
            {
                return (System.Int32)Type.GetField("TAG_SCRIPT_DATA_NUM_2", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TAG_SCRIPT_DATA_NUM_2", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 TAG_SCRIPT_DATA_NUM_3
        {
            get
            {
                return (System.Int32)Type.GetField("TAG_SCRIPT_DATA_NUM_3", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TAG_SCRIPT_DATA_NUM_3", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 TAG_SCRIPT_DATA_NUM_4
        {
            get
            {
                return (System.Int32)Type.GetField("TAG_SCRIPT_DATA_NUM_4", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TAG_SCRIPT_DATA_NUM_4", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 DECK_ACTION_COST
        {
            get
            {
                return (System.Int32)Type.GetField("DECK_ACTION_COST", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("DECK_ACTION_COST", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Dredge
        {
            get
            {
                return (System.Boolean)Type.GetField("Dredge", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Dredge", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 CooldownTurn
        {
            get
            {
                return (System.Int32)Type.GetField("CooldownTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("CooldownTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Infuse
        {
            get
            {
                return (System.Boolean)Type.GetField("Infuse", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Infuse", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Infused
        {
            get
            {
                return (System.Boolean)Type.GetField("Infused", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Infused", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 InfuseNum
        {
            get
            {
                return (System.Int32)Type.GetField("InfuseNum", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("InfuseNum", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 Manathirst
        {
            get
            {
                return (System.Int32)Type.GetField("Manathirst", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Manathirst", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Finale
        {
            get
            {
                return (System.Boolean)Type.GetField("Finale", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Finale", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Overheal
        {
            get
            {
                return (System.Boolean)Type.GetField("Overheal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Overheal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Titan
        {
            get
            {
                return (System.Boolean)Type.GetField("Titan", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Titan", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean TitanAbilityUsed1
        {
            get
            {
                return (System.Boolean)Type.GetField("TitanAbilityUsed1", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TitanAbilityUsed1", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean TitanAbilityUsed2
        {
            get
            {
                return (System.Boolean)Type.GetField("TitanAbilityUsed2", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TitanAbilityUsed2", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean TitanAbilityUsed3
        {
            get
            {
                return (System.Boolean)Type.GetField("TitanAbilityUsed3", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TitanAbilityUsed3", AllFlags).SetValue(Inst, value);
            }
        }

        public object TitanAbility
        {
            get
            {
                return (object)Type.GetField("TitanAbility", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TitanAbility", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Forge
        {
            get
            {
                return (System.Boolean)Type.GetField("Forge", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Forge", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ForgeCost
        {
            get
            {
                return (System.Int32)Type.GetField("ForgeCost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ForgeCost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Forged
        {
            get
            {
                return (System.Boolean)Type.GetField("Forged", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Forged", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Quickdraw
        {
            get
            {
                return (System.Boolean)Type.GetField("Quickdraw", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Quickdraw", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Excavate
        {
            get
            {
                return (System.Boolean)Type.GetField("Excavate", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Excavate", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Elusive
        {
            get
            {
                return (System.Boolean)Type.GetField("Elusive", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Elusive", AllFlags).SetValue(Inst, value);
            }
        }

        public string textCN
        {
            get
            {
                return (string)Type.GetField("textCN", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("textCN", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 count
        {
            get
            {
                return (System.Int32)Type.GetField("count", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("count", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean _honorableKill
        {
            get
            {
                return (System.Boolean)Type.GetField("_honorableKill", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("_honorableKill", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean _overkill
        {
            get
            {
                return (System.Boolean)Type.GetField("_overkill", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("_overkill", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean _spellburst
        {
            get
            {
                return (System.Boolean)Type.GetField("_spellburst", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("_spellburst", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean _frenzy
        {
            get
            {
                return (System.Boolean)Type.GetField("_frenzy", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("_frenzy", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean HonorableKill
        {
            get
            {
                return (System.Boolean)Type.GetProperty("HonorableKill", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("HonorableKill", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Overkill
        {
            get
            {
                return (System.Boolean)Type.GetProperty("Overkill", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("Overkill", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Spellburst
        {
            get
            {
                return (System.Boolean)Type.GetProperty("Spellburst", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("Spellburst", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Frenzy
        {
            get
            {
                return (System.Boolean)Type.GetProperty("Frenzy", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("Frenzy", AllFlags).SetValue(Inst, value);
            }
        }

        public string OnlineCardImage
        {
            get
            {
                return (string)Type.GetProperty("OnlineCardImage", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("OnlineCardImage", AllFlags).SetValue(Inst, value);
            }
        }

        public string OnlineCardTile
        {
            get
            {
                return (string)Type.GetProperty("OnlineCardTile", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("OnlineCardTile", AllFlags).SetValue(Inst, value);
            }
        }

        public string CardInfo
        {
            get
            {
                return (string)Type.GetProperty("CardInfo", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("CardInfo", AllFlags).SetValue(Inst, value);
            }
        }

        public string Status
        {
            get
            {
                return (string)Type.GetProperty("Status", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("Status", AllFlags).SetValue(Inst, value);
            }
        }

        public string Color
        {
            get
            {
                return (string)Type.GetProperty("Color", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetProperty("Color", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ExistErrorType(ErrorType2 errorType)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+ErrorType2");
            return (System.Boolean)Type.GetMethod("ExistErrorType", AllFlags, null, sigs, null).Invoke(Inst, new object[] { errorType });
        }

        public object getTargetsForCard(object p, System.Boolean isLethalCheck, System.Boolean own)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            return (object)Type.GetMethod("getTargetsForCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, isLethalCheck, own });
        }

        public object getTargetsForHeroPower(object p, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Boolean);
            return (object)Type.GetMethod("getTargetsForHeroPower", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, own });
        }

        public object getTargetsForLocation(object p, System.Boolean isLethalCheck, System.Boolean own)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            return (object)Type.GetMethod("getTargetsForLocation", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, isLethalCheck, own });
        }

        public System.Int32 calculateManaCost(object p)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            return (System.Int32)Type.GetMethod("calculateManaCost", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p });
        }

        public System.Int32 getManaCost(object p, System.Int32 currentcost)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getManaCost", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, currentcost });
        }

        public System.Boolean canplayCard(object p, System.Int32 manacost, System.Boolean own)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            return (System.Boolean)Type.GetMethod("canplayCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, manacost, own });
        }

        public string chnInfo()
        {
            var sigs = new Type[0];
            return (string)Type.GetMethod("chnInfo", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object GetTitanAbility()
        {
            var sigs = new Type[0];
            return (object)Type.GetMethod("GetTitanAbility", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Boolean Equals(object obj)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Object);
            return (System.Boolean)Type.GetMethod("Equals", AllFlags, null, sigs, null).Invoke(Inst, new object[] { obj });
        }

        public System.Int32 GetHashCode()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("GetHashCode", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void Finalize()
        {
            var sigs = new Type[0];
            Type.GetMethod("Finalize", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object GetType()
        {
            var sigs = new Type[0];
            return (object)Type.GetMethod("GetType", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object MemberwiseClone()
        {
            var sigs = new Type[0];
            return (object)Type.GetMethod("MemberwiseClone", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public string ToString()
        {
            var sigs = new Type[0];
            return (string)Type.GetMethod("ToString", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

    }
}
