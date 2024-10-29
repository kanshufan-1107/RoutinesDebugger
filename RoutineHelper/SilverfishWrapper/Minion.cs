using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Minion
    {
        public object Inst;
        public static Type Type;

        public Minion(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
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

        public System.Int32 anzGotDmg
        {
            get
            {
                return (System.Int32)Type.GetField("anzGotDmg", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzGotDmg", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 GotDmgValue
        {
            get
            {
                return (System.Int32)Type.GetField("GotDmgValue", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("GotDmgValue", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzGotHealed
        {
            get
            {
                return (System.Int32)Type.GetField("anzGotHealed", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzGotHealed", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 GotHealedValue
        {
            get
            {
                return (System.Int32)Type.GetField("GotHealedValue", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("GotHealedValue", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean gotInspire
        {
            get
            {
                return (System.Boolean)Type.GetField("gotInspire", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("gotInspire", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean isHero
        {
            get
            {
                return (System.Boolean)Type.GetField("isHero", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("isHero", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean own
        {
            get
            {
                return (System.Boolean)Type.GetField("own", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("own", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 pID
        {
            get
            {
                return (System.Int32)Type.GetField("pID", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("pID", AllFlags).SetValue(Inst, value);
            }
        }

        public cardNameEN name
        {
            get
            {
                return (cardNameEN)Type.GetField("name", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("name", AllFlags).SetValue(Inst, value);
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

        public TAG_CLASS cardClass
        {
            get
            {
                return (TAG_CLASS)Type.GetField("cardClass", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardClass", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 synergy
        {
            get
            {
                return (System.Int32)Type.GetField("synergy", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("synergy", AllFlags).SetValue(Inst, value);
            }
        }

        public object handcard
        {
            get
            {
                return (object)Type.GetField("handcard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("handcard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 entitiyID
        {
            get
            {
                return (System.Int32)Type.GetField("entitiyID", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("entitiyID", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 zonepos
        {
            get
            {
                return (System.Int32)Type.GetField("zonepos", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("zonepos", AllFlags).SetValue(Inst, value);
            }
        }

        public object deathrattle2
        {
            get
            {
                return (object)Type.GetField("deathrattle2", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("deathrattle2", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean playedThisTurn
        {
            get
            {
                return (System.Boolean)Type.GetField("playedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playedThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean playedPrevTurn
        {
            get
            {
                return (System.Boolean)Type.GetField("playedPrevTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playedPrevTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numAttacksThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("numAttacksThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numAttacksThisTurn", AllFlags).SetValue(Inst, value);
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

        public System.Boolean allreadyAttacked
        {
            get
            {
                return (System.Boolean)Type.GetField("allreadyAttacked", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("allreadyAttacked", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean shadowmadnessed
        {
            get
            {
                return (System.Boolean)Type.GetField("shadowmadnessed", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("shadowmadnessed", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean destroyOnOwnTurnStart
        {
            get
            {
                return (System.Boolean)Type.GetField("destroyOnOwnTurnStart", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("destroyOnOwnTurnStart", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean destroyOnEnemyTurnStart
        {
            get
            {
                return (System.Boolean)Type.GetField("destroyOnEnemyTurnStart", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("destroyOnEnemyTurnStart", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean destroyOnOwnTurnEnd
        {
            get
            {
                return (System.Boolean)Type.GetField("destroyOnOwnTurnEnd", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("destroyOnOwnTurnEnd", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean destroyOnEnemyTurnEnd
        {
            get
            {
                return (System.Boolean)Type.GetField("destroyOnEnemyTurnEnd", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("destroyOnEnemyTurnEnd", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean changeOwnerOnTurnStart
        {
            get
            {
                return (System.Boolean)Type.GetField("changeOwnerOnTurnStart", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("changeOwnerOnTurnStart", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean conceal
        {
            get
            {
                return (System.Boolean)Type.GetField("conceal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("conceal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ancestralspirit
        {
            get
            {
                return (System.Int32)Type.GetField("ancestralspirit", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ancestralspirit", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 desperatestand
        {
            get
            {
                return (System.Int32)Type.GetField("desperatestand", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("desperatestand", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 souloftheforest
        {
            get
            {
                return (System.Int32)Type.GetField("souloftheforest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("souloftheforest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 stegodon
        {
            get
            {
                return (System.Int32)Type.GetField("stegodon", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("stegodon", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 livingspores
        {
            get
            {
                return (System.Int32)Type.GetField("livingspores", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("livingspores", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 explorershat
        {
            get
            {
                return (System.Int32)Type.GetField("explorershat", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("explorershat", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 libramofwisdom
        {
            get
            {
                return (System.Int32)Type.GetField("libramofwisdom", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("libramofwisdom", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 returnToHand
        {
            get
            {
                return (System.Int32)Type.GetField("returnToHand", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("returnToHand", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 infest
        {
            get
            {
                return (System.Int32)Type.GetField("infest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("infest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownBlessingOfWisdom
        {
            get
            {
                return (System.Int32)Type.GetField("ownBlessingOfWisdom", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownBlessingOfWisdom", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyBlessingOfWisdom
        {
            get
            {
                return (System.Int32)Type.GetField("enemyBlessingOfWisdom", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyBlessingOfWisdom", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownPowerWordGlory
        {
            get
            {
                return (System.Int32)Type.GetField("ownPowerWordGlory", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownPowerWordGlory", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyPowerWordGlory
        {
            get
            {
                return (System.Int32)Type.GetField("enemyPowerWordGlory", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyPowerWordGlory", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 spellpower
        {
            get
            {
                return (System.Int32)Type.GetField("spellpower", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("spellpower", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean cantBeTargetedBySpellsOrHeroPowers
        {
            get
            {
                return (System.Boolean)Type.GetField("cantBeTargetedBySpellsOrHeroPowers", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cantBeTargetedBySpellsOrHeroPowers", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean cantAttackHeroes
        {
            get
            {
                return (System.Boolean)Type.GetField("cantAttackHeroes", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cantAttackHeroes", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean cantAttack
        {
            get
            {
                return (System.Boolean)Type.GetField("cantAttack", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cantAttack", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 Hp
        {
            get
            {
                return (System.Int32)Type.GetField("Hp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Hp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 maxHp
        {
            get
            {
                return (System.Int32)Type.GetField("maxHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("maxHp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 armor
        {
            get
            {
                return (System.Int32)Type.GetField("armor", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("armor", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 Angr
        {
            get
            {
                return (System.Int32)Type.GetField("Angr", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Angr", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 AdjacentAngr
        {
            get
            {
                return (System.Int32)Type.GetField("AdjacentAngr", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("AdjacentAngr", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 tempAttack
        {
            get
            {
                return (System.Int32)Type.GetField("tempAttack", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("tempAttack", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 justBuffed
        {
            get
            {
                return (System.Int32)Type.GetField("justBuffed", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("justBuffed", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean Ready
        {
            get
            {
                return (System.Boolean)Type.GetField("Ready", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Ready", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean taunt
        {
            get
            {
                return (System.Boolean)Type.GetField("taunt", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("taunt", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean wounded
        {
            get
            {
                return (System.Boolean)Type.GetField("wounded", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("wounded", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean divineshild
        {
            get
            {
                return (System.Boolean)Type.GetField("divineshild", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("divineshild", AllFlags).SetValue(Inst, value);
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

        public System.Boolean frozen
        {
            get
            {
                return (System.Boolean)Type.GetField("frozen", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("frozen", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean stealth
        {
            get
            {
                return (System.Boolean)Type.GetField("stealth", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("stealth", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean immune
        {
            get
            {
                return (System.Boolean)Type.GetField("immune", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("immune", AllFlags).SetValue(Inst, value);
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

        public System.Boolean exhausted
        {
            get
            {
                return (System.Boolean)Type.GetField("exhausted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("exhausted", AllFlags).SetValue(Inst, value);
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

        public System.Boolean outcast
        {
            get
            {
                return (System.Boolean)Type.GetField("outcast", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("outcast", AllFlags).SetValue(Inst, value);
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

        public System.Int32 charge
        {
            get
            {
                return (System.Int32)Type.GetField("charge", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("charge", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 rush
        {
            get
            {
                return (System.Int32)Type.GetField("rush", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("rush", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 hChoice
        {
            get
            {
                return (System.Int32)Type.GetField("hChoice", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("hChoice", AllFlags).SetValue(Inst, value);
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

        public System.Boolean cantLowerHPbelowONE
        {
            get
            {
                return (System.Boolean)Type.GetField("cantLowerHPbelowONE", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cantLowerHPbelowONE", AllFlags).SetValue(Inst, value);
            }
        }

        public string enchs
        {
            get
            {
                return (string)Type.GetField("enchs", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enchs", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean silenced
        {
            get
            {
                return (System.Boolean)Type.GetField("silenced", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("silenced", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean playedFromHand
        {
            get
            {
                return (System.Boolean)Type.GetField("playedFromHand", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playedFromHand", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean extraParam
        {
            get
            {
                return (System.Boolean)Type.GetField("extraParam", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("extraParam", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 extraParam2
        {
            get
            {
                return (System.Int32)Type.GetField("extraParam2", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("extraParam2", AllFlags).SetValue(Inst, value);
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

        public void setMinionToMinion(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("setMinionToMinion", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public System.Int32 getRealAttack()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("getRealAttack", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void getDamageOrHeal(System.Int32 dmg, object p, System.Boolean isMinionAttack, System.Boolean dontCalcLostDmg)
        {
            var sigs = new Type[4];
            sigs[0] = typeof(System.Int32);
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[2] = typeof(System.Boolean);
            sigs[3] = typeof(System.Boolean);
            Type.GetMethod("getDamageOrHeal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { dmg, p, isMinionAttack, dontCalcLostDmg });
        }

        public void minionDied(object p)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            Type.GetMethod("minionDied", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p });
        }

        public void updateReadyness()
        {
            var sigs = new Type[0];
            Type.GetMethod("updateReadyness", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void becomeSilence(object p)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            Type.GetMethod("becomeSilence", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p });
        }

        public object GetTargetForMinionWithSurvival(object p, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Boolean);
            return (object)Type.GetMethod("GetTargetForMinionWithSurvival", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, own });
        }

        public string info()
        {
            var sigs = new Type[0];
            return (string)Type.GetMethod("info", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
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
