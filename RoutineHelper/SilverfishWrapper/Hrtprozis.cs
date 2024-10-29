using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Hrtprozis
    {
        public object Inst;
        public static Type Type;

        public Hrtprozis(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public System.Int32 pId
        {
            get
            {
                return (System.Int32)Type.GetField("pId", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("pId", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 attackFaceHp
        {
            get
            {
                return (System.Int32)Type.GetField("attackFaceHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("attackFaceHp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroFatigue
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroFatigue", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroFatigue", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownDeckSize
        {
            get
            {
                return (System.Int32)Type.GetField("ownDeckSize", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownDeckSize", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyDeckSize
        {
            get
            {
                return (System.Int32)Type.GetField("enemyDeckSize", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyDeckSize", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroFatigue
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroFatigue", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroFatigue", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 gTurn
        {
            get
            {
                return (System.Int32)Type.GetField("gTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("gTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 gTurnStep
        {
            get
            {
                return (System.Int32)Type.GetField("gTurnStep", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("gTurnStep", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroEntity
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroEntity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroEntity", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroEntitiy
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroEntitiy", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroEntitiy", AllFlags).SetValue(Inst, value);
            }
        }

        public System.DateTime roundstart
        {
            get
            {
                return (System.DateTime)Type.GetField("roundstart", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("roundstart", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 currentMana
        {
            get
            {
                return (System.Int32)Type.GetField("currentMana", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("currentMana", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 heroHp
        {
            get
            {
                return (System.Int32)Type.GetField("heroHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("heroHp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHp
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 heroAtk
        {
            get
            {
                return (System.Int32)Type.GetField("heroAtk", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("heroAtk", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyAtk
        {
            get
            {
                return (System.Int32)Type.GetField("enemyAtk", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyAtk", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 heroDefence
        {
            get
            {
                return (System.Int32)Type.GetField("heroDefence", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("heroDefence", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyDefence
        {
            get
            {
                return (System.Int32)Type.GetField("enemyDefence", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyDefence", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownheroisread
        {
            get
            {
                return (System.Boolean)Type.GetField("ownheroisread", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownheroisread", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroNumAttacksThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroNumAttacksThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroNumAttacksThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownHeroWindfury
        {
            get
            {
                return (System.Boolean)Type.GetField("ownHeroWindfury", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroWindfury", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean herofrozen
        {
            get
            {
                return (System.Boolean)Type.GetField("herofrozen", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("herofrozen", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemyfrozen
        {
            get
            {
                return (System.Boolean)Type.GetField("enemyfrozen", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyfrozen", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownSecretList
        {
            get
            {
                return (object)Type.GetField("ownSecretList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownSecretList", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemySecretCount
        {
            get
            {
                return (System.Int32)Type.GetField("enemySecretCount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemySecretCount", AllFlags).SetValue(Inst, value);
            }
        }

        public object DiscoverCards
        {
            get
            {
                return (object)Type.GetField("DiscoverCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("DiscoverCards", AllFlags).SetValue(Inst, value);
            }
        }

        public object turnDeck
        {
            get
            {
                return (object)Type.GetField("turnDeck", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("turnDeck", AllFlags).SetValue(Inst, value);
            }
        }

        public object deckCardForCost
        {
            get
            {
                return (object)Type.GetField("deckCardForCost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("deckCardForCost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean noDuplicates
        {
            get
            {
                return (System.Boolean)Type.GetField("noDuplicates", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("noDuplicates", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean patchesInDeck
        {
            get
            {
                return (System.Boolean)Type.GetField("patchesInDeck", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("patchesInDeck", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numTauntCards
        {
            get
            {
                return (System.Int32)Type.GetField("numTauntCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numTauntCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numDivineShieldCards
        {
            get
            {
                return (System.Int32)Type.GetField("numDivineShieldCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numDivineShieldCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numLifestealCards
        {
            get
            {
                return (System.Int32)Type.GetField("numLifestealCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numLifestealCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numWindfuryCards
        {
            get
            {
                return (System.Int32)Type.GetField("numWindfuryCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numWindfuryCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numSecretCards
        {
            get
            {
                return (System.Int32)Type.GetField("numSecretCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numSecretCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean setGameRule
        {
            get
            {
                return (System.Boolean)Type.GetField("setGameRule", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("setGameRule", AllFlags).SetValue(Inst, value);
            }
        }

        public HeroEnum heroname
        {
            get
            {
                return (HeroEnum)Type.GetField("heroname", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("heroname", AllFlags).SetValue(Inst, value);
            }
        }

        public HeroEnum enemyHeroname
        {
            get
            {
                return (HeroEnum)Type.GetField("enemyHeroname", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroname", AllFlags).SetValue(Inst, value);
            }
        }

        public string heronameingame
        {
            get
            {
                return (string)Type.GetField("heronameingame", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("heronameingame", AllFlags).SetValue(Inst, value);
            }
        }

        public string enemyHeronameingame
        {
            get
            {
                return (string)Type.GetField("enemyHeronameingame", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeronameingame", AllFlags).SetValue(Inst, value);
            }
        }

        public TAG_CLASS ownHeroStartClass
        {
            get
            {
                return (TAG_CLASS)Type.GetField("ownHeroStartClass", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroStartClass", AllFlags).SetValue(Inst, value);
            }
        }

        public TAG_CLASS enemyHeroStartClass
        {
            get
            {
                return (TAG_CLASS)Type.GetField("enemyHeroStartClass", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroStartClass", AllFlags).SetValue(Inst, value);
            }
        }

        public object heroAbility
        {
            get
            {
                return (object)Type.GetField("heroAbility", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("heroAbility", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownAbilityisReady
        {
            get
            {
                return (System.Boolean)Type.GetField("ownAbilityisReady", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownAbilityisReady", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroPowerCost
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroPowerCost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroPowerCost", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyAbility
        {
            get
            {
                return (object)Type.GetField("enemyAbility", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyAbility", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroPowerCost
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroPowerCost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroPowerCost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numOptionsPlayedThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("numOptionsPlayedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numOptionsPlayedThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numMinionsPlayedThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("numMinionsPlayedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numMinionsPlayedThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public cardIDEnum OwnLastDiedMinion
        {
            get
            {
                return (cardIDEnum)Type.GetField("OwnLastDiedMinion", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("OwnLastDiedMinion", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 cardsPlayedThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("cardsPlayedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardsPlayedThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ueberladung
        {
            get
            {
                return (System.Int32)Type.GetField("ueberladung", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ueberladung", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lockedMana
        {
            get
            {
                return (System.Int32)Type.GetField("lockedMana", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lockedMana", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownMaxMana
        {
            get
            {
                return (System.Int32)Type.GetField("ownMaxMana", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMaxMana", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyMaxMana
        {
            get
            {
                return (System.Int32)Type.GetField("enemyMaxMana", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyMaxMana", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownHero
        {
            get
            {
                return (object)Type.GetField("ownHero", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHero", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyHero
        {
            get
            {
                return (object)Type.GetField("enemyHero", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHero", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownWeapon
        {
            get
            {
                return (object)Type.GetField("ownWeapon", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownWeapon", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyWeapon
        {
            get
            {
                return (object)Type.GetField("enemyWeapon", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyWeapon", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownMinions
        {
            get
            {
                return (object)Type.GetField("ownMinions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMinions", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyMinions
        {
            get
            {
                return (object)Type.GetField("enemyMinions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyMinions", AllFlags).SetValue(Inst, value);
            }
        }

        public object LurkersDB
        {
            get
            {
                return (object)Type.GetField("LurkersDB", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("LurkersDB", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOgOwnCThunHpBonus
        {
            get
            {
                return (System.Int32)Type.GetField("anzOgOwnCThunHpBonus", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOgOwnCThunHpBonus", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOgOwnCThunAngrBonus
        {
            get
            {
                return (System.Int32)Type.GetField("anzOgOwnCThunAngrBonus", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOgOwnCThunAngrBonus", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOgOwnCThunTaunt
        {
            get
            {
                return (System.Int32)Type.GetField("anzOgOwnCThunTaunt", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOgOwnCThunTaunt", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnJadeGolem
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnJadeGolem", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnJadeGolem", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyJadeGolem
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyJadeGolem", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyJadeGolem", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownCrystalCore
        {
            get
            {
                return (System.Int32)Type.GetField("ownCrystalCore", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownCrystalCore", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownMinionsInDeckCost0
        {
            get
            {
                return (System.Boolean)Type.GetField("ownMinionsInDeckCost0", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMinionsInDeckCost0", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnElementalsThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnElementalsThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnElementalsThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnElementalsLastTurn
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnElementalsLastTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnElementalsLastTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 useNature
        {
            get
            {
                return (System.Int32)Type.GetField("useNature", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("useNature", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownElementalsHaveLifesteal
        {
            get
            {
                return (System.Int32)Type.GetField("ownElementalsHaveLifesteal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownElementalsHaveLifesteal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownPlayerController
        {
            get
            {
                return (System.Int32)Type.GetField("ownPlayerController", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownPlayerController", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean LothraxionsPower
        {
            get
            {
                return (System.Boolean)Type.GetField("LothraxionsPower", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("LothraxionsPower", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean anzTamsin
        {
            get
            {
                return (System.Boolean)Type.GetField("anzTamsin", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzTamsin", AllFlags).SetValue(Inst, value);
            }
        }

        public string enemyDeckName
        {
            get
            {
                return (string)Type.GetField("enemyDeckName", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyDeckName", AllFlags).SetValue(Inst, value);
            }
        }

        public string enemyDeckCode
        {
            get
            {
                return (string)Type.GetField("enemyDeckCode", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyDeckCode", AllFlags).SetValue(Inst, value);
            }
        }

        public object guessEnemyDeck
        {
            get
            {
                return (object)Type.GetField("guessEnemyDeck", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("guessEnemyDeck", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyDirectDmg
        {
            get
            {
                return (System.Int32)Type.GetField("enemyDirectDmg", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyDirectDmg", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 similarity
        {
            get
            {
                return (System.Int32)Type.GetField("similarity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("similarity", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownConsecutiveElementalTurns
        {
            get
            {
                return (System.Int32)Type.GetField("ownConsecutiveElementalTurns", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownConsecutiveElementalTurns", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownElementalsPlayedLastTurn
        {
            get
            {
                return (System.Int32)Type.GetField("ownElementalsPlayedLastTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownElementalsPlayedLastTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public object enchs
        {
            get
            {
                return (object)Type.GetField("enchs", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enchs", AllFlags).SetValue(Inst, value);
            }
        }

        public object penman
        {
            get
            {
                return (object)Type.GetField("penman", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("penman", AllFlags).SetValue(Inst, value);
            }
        }

        public object settings
        {
            get
            {
                return (object)Type.GetField("settings", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("settings", AllFlags).SetValue(Inst, value);
            }
        }

        public object help
        {
            get
            {
                return (object)Type.GetField("help", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("help", AllFlags).SetValue(Inst, value);
            }
        }

        public object cdb
        {
            get
            {
                return (object)Type.GetField("cdb", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cdb", AllFlags).SetValue(Inst, value);
            }
        }

        public static object instance
        {
            get
            {
                return (object)Type.GetField("instance", AllFlags).GetValue(null);
            }
            set
            {
                Type.GetField("instance", AllFlags).SetValue(null, value);
            }
        }


        public static object Instance
        {
            get
            {
                return (object)Type.GetProperty("Instance", AllFlags).GetValue(null);
            }
        }

        public void setInstances()
        {
            var sigs = new Type[0];
            Type.GetMethod("setInstances", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void setAttackFaceHP(System.Int32 hp)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("setAttackFaceHP", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hp });
        }

        public System.Int32 getPid()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("getPid", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void clearAllNewGame()
        {
            var sigs = new Type[0];
            Type.GetMethod("clearAllNewGame", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void clearAllRecalc()
        {
            var sigs = new Type[0];
            Type.GetMethod("clearAllRecalc", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void setOwnPlayer(System.Int32 player)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("setOwnPlayer", AllFlags, null, sigs, null).Invoke(Inst, new object[] { player });
        }

        public System.Int32 getOwnController()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("getOwnController", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void updatePlayerAttachments(System.Boolean LothraxionsPower)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("updatePlayerAttachments", AllFlags, null, sigs, null).Invoke(Inst, new object[] { LothraxionsPower });
        }

        public void updateJadeGolemsInfo(System.Int32 anzOwnJG, System.Int32 anzEmemyJG)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("updateJadeGolemsInfo", AllFlags, null, sigs, null).Invoke(Inst, new object[] { anzOwnJG, anzEmemyJG });
        }

        public void updateCrystalCore(System.Int32 num)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("updateCrystalCore", AllFlags, null, sigs, null).Invoke(Inst, new object[] { num });
        }

        public void updateOwnMinionsInDeckCost0(System.Boolean tmp)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("updateOwnMinionsInDeckCost0", AllFlags, null, sigs, null).Invoke(Inst, new object[] { tmp });
        }

        public void updateElementals(System.Int32 anzOwnElemTT, System.Int32 anzOwnElemLT, System.Int32 ownElementalsHaveLS)
        {
            var sigs = new Type[3];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("updateElementals", AllFlags, null, sigs, null).Invoke(Inst, new object[] { anzOwnElemTT, anzOwnElemLT, ownElementalsHaveLS });
        }

        public string heroIDtoName(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (string)Type.GetMethod("heroIDtoName", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public string heroPowerToName(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (string)Type.GetMethod("heroPowerToName", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public HeroEnum heroNametoEnum(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (HeroEnum)Type.GetMethod("heroNametoEnum", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public TAG_CLASS heroEnumtoTagClass(HeroEnum he)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.HeroEnum");
            return (TAG_CLASS)Type.GetMethod("heroEnumtoTagClass", AllFlags, null, sigs, null).Invoke(Inst, new object[] { he });
        }

        public HeroEnum heroTAG_CLASSstringToEnum(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (HeroEnum)Type.GetMethod("heroTAG_CLASSstringToEnum", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public cardIDEnum getDeckCardsForCost(System.Int32 cost)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (cardIDEnum)Type.GetMethod("getDeckCardsForCost", AllFlags, null, sigs, null).Invoke(Inst, new object[] { cost });
        }

        public System.Int32 numDeckCardsByTag(GAME_TAGs tag)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.GAME_TAGs");
            return (System.Int32)Type.GetMethod("numDeckCardsByTag", AllFlags, null, sigs, null).Invoke(Inst, new object[] { tag });
        }

        public void updatePlayer(System.Int32 maxmana, System.Int32 currentmana, System.Int32 cardsplayedthisturn, System.Int32 numMinionsplayed, System.Int32 optionsPlayedThisTurn, System.Int32 overload, System.Int32 lockedmana, System.Int32 heroentity, System.Int32 enemyentity)
        {
            var sigs = new Type[9];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            sigs[4] = typeof(System.Int32);
            sigs[5] = typeof(System.Int32);
            sigs[6] = typeof(System.Int32);
            sigs[7] = typeof(System.Int32);
            sigs[8] = typeof(System.Int32);
            Type.GetMethod("updatePlayer", AllFlags, null, sigs, null).Invoke(Inst, new object[] { maxmana, currentmana, cardsplayedthisturn, numMinionsplayed, optionsPlayedThisTurn, overload, lockedmana, heroentity, enemyentity });
        }

        public void updateHeroStartClass(TAG_CLASS ownHSClass, TAG_CLASS enemyHSClass)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.TAG_CLASS");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.TAG_CLASS");
            Type.GetMethod("updateHeroStartClass", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ownHSClass, enemyHSClass });
        }

        public void updateHero(object w, string heron, object ability, System.Boolean abrdy, System.Int32 abCost, object hero, System.Int32 enMaxMana)
        {
            var sigs = new Type[7];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Weapon");
            sigs[1] = typeof(System.String);
            sigs[2] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            sigs[3] = typeof(System.Boolean);
            sigs[4] = typeof(System.Int32);
            sigs[5] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[6] = typeof(System.Int32);
            Type.GetMethod("updateHero", AllFlags, null, sigs, null).Invoke(Inst, new object[] { w, heron, ability, abrdy, abCost, hero, enMaxMana });
        }

        public void updateTurnInfo(System.Int32 turn, System.Int32 step)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("updateTurnInfo", AllFlags, null, sigs, null).Invoke(Inst, new object[] { turn, step });
        }

        public void updateCThunInfo(System.Int32 OgOwnCThunAngrBonus, System.Int32 OgOwnCThunHpBonus, System.Int32 OgOwnCThunTaunt)
        {
            var sigs = new Type[3];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("updateCThunInfo", AllFlags, null, sigs, null).Invoke(Inst, new object[] { OgOwnCThunAngrBonus, OgOwnCThunHpBonus, OgOwnCThunTaunt });
        }

        public void updateFatigueStats(System.Int32 ods, System.Int32 ohf, System.Int32 eds, System.Int32 ehf)
        {
            var sigs = new Type[4];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            Type.GetMethod("updateFatigueStats", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ods, ohf, eds, ehf });
        }

        public void updatePositions()
        {
            var sigs = new Type[0];
            Type.GetMethod("updatePositions", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void updateOwnLastDiedMinion(cardIDEnum cid)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardIDEnum");
            Type.GetMethod("updateOwnLastDiedMinion", AllFlags, null, sigs, null).Invoke(Inst, new object[] { cid });
        }

        public object createNewMinion(object hc, System.Int32 id)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = typeof(System.Int32);
            return (object)Type.GetMethod("createNewMinion", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, id });
        }

        public void printHero()
        {
            var sigs = new Type[0];
            Type.GetMethod("printHero", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void printOwnMinions()
        {
            var sigs = new Type[0];
            Type.GetMethod("printOwnMinions", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void printEnemyMinions()
        {
            var sigs = new Type[0];
            Type.GetMethod("printEnemyMinions", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void printOwnDeck()
        {
            var sigs = new Type[0];
            Type.GetMethod("printOwnDeck", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
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
