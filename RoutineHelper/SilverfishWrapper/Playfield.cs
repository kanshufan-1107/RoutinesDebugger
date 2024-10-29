using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Playfield
    {
        public object Inst;
        public static Type Type;

        public Playfield(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public System.Boolean loatheb
        {
            get
            {
                return (System.Boolean)Type.GetField("loatheb", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("loatheb", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 loathebEffect
        {
            get
            {
                return (System.Int32)Type.GetField("loathebEffect", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("loathebEffect", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyHand
        {
            get
            {
                return (object)Type.GetField("enemyHand", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHand", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownDeck
        {
            get
            {
                return (object)Type.GetField("ownDeck", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownDeck", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownGraveyard
        {
            get
            {
                return (object)Type.GetField("ownGraveyard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownGraveyard", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownSecretsIDList
        {
            get
            {
                return (object)Type.GetField("ownSecretsIDList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownSecretsIDList", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemySecretList
        {
            get
            {
                return (object)Type.GetField("enemySecretList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemySecretList", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyCardsOut
        {
            get
            {
                return (object)Type.GetField("enemyCardsOut", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyCardsOut", AllFlags).SetValue(Inst, value);
            }
        }

        public object nextPlayfields
        {
            get
            {
                return (object)Type.GetField("nextPlayfields", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextPlayfields", AllFlags).SetValue(Inst, value);
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

        public object diedMinions
        {
            get
            {
                return (object)Type.GetField("diedMinions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("diedMinions", AllFlags).SetValue(Inst, value);
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

        public object owncards
        {
            get
            {
                return (object)Type.GetField("owncards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("owncards", AllFlags).SetValue(Inst, value);
            }
        }

        public object playactions
        {
            get
            {
                return (object)Type.GetField("playactions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playactions", AllFlags).SetValue(Inst, value);
            }
        }

        public object pIdHistory
        {
            get
            {
                return (object)Type.GetField("pIdHistory", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("pIdHistory", AllFlags).SetValue(Inst, value);
            }
        }

        public string name
        {
            get
            {
                return (string)Type.GetField("name", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("name", AllFlags).SetValue(Inst, value);
            }
        }

        public string enemyGuessDeck
        {
            get
            {
                return (string)Type.GetField("enemyGuessDeck", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyGuessDeck", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean logging
        {
            get
            {
                return (System.Boolean)Type.GetField("logging", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("logging", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean complete
        {
            get
            {
                return (System.Boolean)Type.GetField("complete", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("complete", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 bestBoard
        {
            get
            {
                return (System.Int32)Type.GetField("bestBoard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("bestBoard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean dirtyTwoTurnSim
        {
            get
            {
                return (System.Boolean)Type.GetField("dirtyTwoTurnSim", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("dirtyTwoTurnSim", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean checkLostAct
        {
            get
            {
                return (System.Boolean)Type.GetField("checkLostAct", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("checkLostAct", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 totalAngr
        {
            get
            {
                return (System.Int32)Type.GetField("totalAngr", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("totalAngr", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyTotalAngr
        {
            get
            {
                return (System.Int32)Type.GetField("enemyTotalAngr", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyTotalAngr", AllFlags).SetValue(Inst, value);
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

        public System.Int32 ownMinionsDied
        {
            get
            {
                return (System.Int32)Type.GetField("ownMinionsDied", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMinionsDied", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean anzSolor
        {
            get
            {
                return (System.Boolean)Type.GetField("anzSolor", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzSolor", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyMinionStartCount
        {
            get
            {
                return (System.Int32)Type.GetField("enemyMinionStartCount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyMinionStartCount", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 healOrDamageTimes
        {
            get
            {
                return (System.Int32)Type.GetField("healOrDamageTimes", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("healOrDamageTimes", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 healTimes
        {
            get
            {
                return (System.Int32)Type.GetField("healTimes", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("healTimes", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean setMankrik
        {
            get
            {
                return (System.Boolean)Type.GetField("setMankrik", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("setMankrik", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 deckAngrBuff
        {
            get
            {
                return (System.Int32)Type.GetField("deckAngrBuff", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("deckAngrBuff", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 deckHpBuff
        {
            get
            {
                return (System.Int32)Type.GetField("deckHpBuff", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("deckHpBuff", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 nextEntity
        {
            get
            {
                return (System.Int32)Type.GetField("nextEntity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextEntity", AllFlags).SetValue(Inst, value);
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

        public System.Boolean isLethalCheck
        {
            get
            {
                return (System.Boolean)Type.GetField("isLethalCheck", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("isLethalCheck", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyTurnsCount
        {
            get
            {
                return (System.Int32)Type.GetField("enemyTurnsCount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyTurnsCount", AllFlags).SetValue(Inst, value);
            }
        }

        public object tempTrigger
        {
            get
            {
                return (object)Type.GetField("tempTrigger", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("tempTrigger", AllFlags).SetValue(Inst, value);
            }
        }

        public object prozis
        {
            get
            {
                return (object)Type.GetField("prozis", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("prozis", AllFlags).SetValue(Inst, value);
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

        public System.Int32 AnzSoulFragments
        {
            get
            {
                return (System.Int32)Type.GetField("AnzSoulFragments", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("AnzSoulFragments", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnRaidleader
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnRaidleader", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnRaidleader", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyRaidleader
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyRaidleader", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyRaidleader", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnVessina
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnVessina", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnVessina", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyVessina
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyVessina", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyVessina", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnStormwindChamps
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnStormwindChamps", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnStormwindChamps", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyStormwindChamps
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyStormwindChamps", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyStormwindChamps", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnWarhorseTrainer
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnWarhorseTrainer", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnWarhorseTrainer", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyWarhorseTrainer
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyWarhorseTrainer", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyWarhorseTrainer", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnTundrarhino
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnTundrarhino", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnTundrarhino", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyTundrarhino
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyTundrarhino", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyTundrarhino", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnMrSmite
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnMrSmite", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnMrSmite", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyMrSmite
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyMrSmite", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyMrSmite", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnTimberWolfs
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnTimberWolfs", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnTimberWolfs", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyTimberWolfs
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyTimberWolfs", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyTimberWolfs", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnMurlocWarleader
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnMurlocWarleader", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnMurlocWarleader", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyMurlocWarleader
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyMurlocWarleader", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyMurlocWarleader", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzAcidmaw
        {
            get
            {
                return (System.Int32)Type.GetField("anzAcidmaw", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzAcidmaw", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnGrimscaleOracle
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnGrimscaleOracle", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnGrimscaleOracle", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyGrimscaleOracle
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyGrimscaleOracle", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyGrimscaleOracle", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnShadowfiend
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnShadowfiend", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnShadowfiend", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnAuchenaiSoulpriest
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnAuchenaiSoulpriest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnAuchenaiSoulpriest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyAuchenaiSoulpriest
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyAuchenaiSoulpriest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyAuchenaiSoulpriest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnSouthseacaptain
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnSouthseacaptain", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnSouthseacaptain", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemySouthseacaptain
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemySouthseacaptain", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemySouthseacaptain", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnMalGanis
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnMalGanis", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnMalGanis", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyMalGanis
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyMalGanis", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyMalGanis", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnPiratesStarted
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnPiratesStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnPiratesStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnMurlocStarted
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnMurlocStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnMurlocStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnChromaggus
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnChromaggus", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnChromaggus", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyChromaggus
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyChromaggus", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyChromaggus", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnDragonConsort
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnDragonConsort", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnDragonConsort", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnMurlocConsort
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnMurlocConsort", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnMurlocConsort", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnDragonConsortStarted
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnDragonConsortStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnDragonConsortStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownElementCost
        {
            get
            {
                return (System.Int32)Type.GetField("ownElementCost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownElementCost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownElementCostStarted
        {
            get
            {
                return (System.Int32)Type.GetField("ownElementCostStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownElementCostStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownBeastCostLessOnce
        {
            get
            {
                return (System.Int32)Type.GetField("ownBeastCostLessOnce", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownBeastCostLessOnce", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownBeastCostLessOnceStarted
        {
            get
            {
                return (System.Int32)Type.GetField("ownBeastCostLessOnceStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownBeastCostLessOnceStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnBolfRamshield
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnBolfRamshield", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnBolfRamshield", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyBolfRamshield
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyBolfRamshield", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyBolfRamshield", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnHorsemen
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnHorsemen", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnHorsemen", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyHorsemen
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyHorsemen", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyHorsemen", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnAnimatedArmor
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnAnimatedArmor", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnAnimatedArmor", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyAnimatedArmor
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyAnimatedArmor", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyAnimatedArmor", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzMoorabi
        {
            get
            {
                return (System.Int32)Type.GetField("anzMoorabi", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzMoorabi", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzDark
        {
            get
            {
                return (System.Int32)Type.GetField("anzDark", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzDark", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzTamsinroame
        {
            get
            {
                return (System.Int32)Type.GetField("anzTamsinroame", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzTamsinroame", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOldWoman
        {
            get
            {
                return (System.Int32)Type.GetField("anzOldWoman", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOldWoman", AllFlags).SetValue(Inst, value);
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

        public System.Int32 anzUsedOwnHeroPower
        {
            get
            {
                return (System.Int32)Type.GetField("anzUsedOwnHeroPower", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzUsedOwnHeroPower", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzUsedEnemyHeroPower
        {
            get
            {
                return (System.Int32)Type.GetField("anzUsedEnemyHeroPower", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzUsedEnemyHeroPower", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnExtraAngrHp
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnExtraAngrHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnExtraAngrHp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyExtraAngrHp
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyExtraAngrHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyExtraAngrHp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnMechwarper
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnMechwarper", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnMechwarper", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnMechwarperStarted
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnMechwarperStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnMechwarperStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyMechwarper
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyMechwarper", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyMechwarper", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzEnemyMechwarperStarted
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyMechwarperStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyMechwarperStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOgOwnCThun
        {
            get
            {
                return (System.Int32)Type.GetField("anzOgOwnCThun", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOgOwnCThun", AllFlags).SetValue(Inst, value);
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

        public System.Int32 anzEnemyTaunt
        {
            get
            {
                return (System.Int32)Type.GetField("anzEnemyTaunt", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzEnemyTaunt", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnTaunt
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnTaunt", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnTaunt", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 usedUndeadAllies
        {
            get
            {
                return (System.Int32)Type.GetField("usedUndeadAllies", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("usedUndeadAllies", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownAbilityFreezesTarget
        {
            get
            {
                return (System.Int32)Type.GetField("ownAbilityFreezesTarget", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownAbilityFreezesTarget", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyAbilityFreezesTarget
        {
            get
            {
                return (System.Int32)Type.GetField("enemyAbilityFreezesTarget", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyAbilityFreezesTarget", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroPowerCostLessOnce
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroPowerCostLessOnce", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroPowerCostLessOnce", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroPowerCostLessOnce
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroPowerCostLessOnce", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroPowerCostLessOnce", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroPowerCostLessTwice
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroPowerCostLessTwice", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroPowerCostLessTwice", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownDemonCostLessOnce
        {
            get
            {
                return (System.Int32)Type.GetField("ownDemonCostLessOnce", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownDemonCostLessOnce", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroPowerExtraDamage
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroPowerExtraDamage", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroPowerExtraDamage", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroPowerExtraDamage
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroPowerExtraDamage", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroPowerExtraDamage", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroPowerAllowedQuantity
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroPowerAllowedQuantity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroPowerAllowedQuantity", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroPowerAllowedQuantity
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroPowerAllowedQuantity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroPowerAllowedQuantity", AllFlags).SetValue(Inst, value);
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

        public System.Int32 blackwaterpirate
        {
            get
            {
                return (System.Int32)Type.GetField("blackwaterpirate", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("blackwaterpirate", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 blackwaterpirateStarted
        {
            get
            {
                return (System.Int32)Type.GetField("blackwaterpirateStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("blackwaterpirateStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 embracetheshadow
        {
            get
            {
                return (System.Int32)Type.GetField("embracetheshadow", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("embracetheshadow", AllFlags).SetValue(Inst, value);
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

        public System.Int32 ownMinionsDiedTurn
        {
            get
            {
                return (System.Int32)Type.GetField("ownMinionsDiedTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMinionsDiedTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyMinionsDiedTurn
        {
            get
            {
                return (System.Int32)Type.GetField("enemyMinionsDiedTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyMinionsDiedTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean feugenDead
        {
            get
            {
                return (System.Boolean)Type.GetField("feugenDead", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("feugenDead", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean stalaggDead
        {
            get
            {
                return (System.Boolean)Type.GetField("stalaggDead", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("stalaggDead", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean weHavePlayedMillhouseManastorm
        {
            get
            {
                return (System.Boolean)Type.GetField("weHavePlayedMillhouseManastorm", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("weHavePlayedMillhouseManastorm", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean weHaveSteamwheedleSniper
        {
            get
            {
                return (System.Boolean)Type.GetField("weHaveSteamwheedleSniper", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("weHaveSteamwheedleSniper", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemyHaveSteamwheedleSniper
        {
            get
            {
                return (System.Boolean)Type.GetField("enemyHaveSteamwheedleSniper", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHaveSteamwheedleSniper", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownSpiritclaws
        {
            get
            {
                return (System.Boolean)Type.GetField("ownSpiritclaws", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownSpiritclaws", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemySpiritclaws
        {
            get
            {
                return (System.Boolean)Type.GetField("enemySpiritclaws", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemySpiritclaws", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean needGraveyard
        {
            get
            {
                return (System.Boolean)Type.GetField("needGraveyard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("needGraveyard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 doublepriest
        {
            get
            {
                return (System.Int32)Type.GetField("doublepriest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("doublepriest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemydoublepriest
        {
            get
            {
                return (System.Int32)Type.GetField("enemydoublepriest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemydoublepriest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownMistcaller
        {
            get
            {
                return (System.Int32)Type.GetField("ownMistcaller", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMistcaller", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lockandload
        {
            get
            {
                return (System.Int32)Type.GetField("lockandload", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lockandload", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 stampede
        {
            get
            {
                return (System.Int32)Type.GetField("stampede", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("stampede", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownBaronRivendare
        {
            get
            {
                return (System.Int32)Type.GetField("ownBaronRivendare", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownBaronRivendare", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyBaronRivendare
        {
            get
            {
                return (System.Int32)Type.GetField("enemyBaronRivendare", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyBaronRivendare", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownBrannBronzebeard
        {
            get
            {
                return (System.Int32)Type.GetField("ownBrannBronzebeard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownBrannBronzebeard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyBrannBronzebeard
        {
            get
            {
                return (System.Int32)Type.GetField("enemyBrannBronzebeard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyBrannBronzebeard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownTurnEndEffectsTriggerTwice
        {
            get
            {
                return (System.Int32)Type.GetField("ownTurnEndEffectsTriggerTwice", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownTurnEndEffectsTriggerTwice", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyTurnEndEffectsTriggerTwice
        {
            get
            {
                return (System.Int32)Type.GetField("enemyTurnEndEffectsTriggerTwice", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyTurnEndEffectsTriggerTwice", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownFandralStaghelm
        {
            get
            {
                return (System.Int32)Type.GetField("ownFandralStaghelm", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownFandralStaghelm", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 tempanzOwnCards
        {
            get
            {
                return (System.Int32)Type.GetField("tempanzOwnCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("tempanzOwnCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 tempanzEnemyCards
        {
            get
            {
                return (System.Int32)Type.GetField("tempanzEnemyCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("tempanzEnemyCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean isOwnTurn
        {
            get
            {
                return (System.Boolean)Type.GetField("isOwnTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("isOwnTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 turnCounter
        {
            get
            {
                return (System.Int32)Type.GetField("turnCounter", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("turnCounter", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean attacked
        {
            get
            {
                return (System.Boolean)Type.GetField("attacked", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("attacked", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 attackFaceHP
        {
            get
            {
                return (System.Int32)Type.GetField("attackFaceHP", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("attackFaceHP", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownController
        {
            get
            {
                return (System.Int32)Type.GetField("ownController", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownController", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 evaluatePenality
        {
            get
            {
                return (System.Int32)Type.GetField("evaluatePenality", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("evaluatePenality", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ruleWeight
        {
            get
            {
                return (System.Int32)Type.GetField("ruleWeight", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ruleWeight", AllFlags).SetValue(Inst, value);
            }
        }

        public string rulesUsed
        {
            get
            {
                return (string)Type.GetField("rulesUsed", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("rulesUsed", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean useSecretsPlayAround
        {
            get
            {
                return (System.Boolean)Type.GetField("useSecretsPlayAround", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("useSecretsPlayAround", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean print
        {
            get
            {
                return (System.Boolean)Type.GetField("print", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("print", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int64 hashcode
        {
            get
            {
                return (System.Int64)Type.GetField("hashcode", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("hashcode", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Single value
        {
            get
            {
                return (System.Single)Type.GetField("value", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("value", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 guessingHeroHP
        {
            get
            {
                return (System.Int32)Type.GetField("guessingHeroHP", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("guessingHeroHP", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Single doDirtyTts
        {
            get
            {
                return (System.Single)Type.GetField("doDirtyTts", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("doDirtyTts", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 mana
        {
            get
            {
                return (System.Int32)Type.GetField("mana", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("mana", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 manaTurnEnd
        {
            get
            {
                return (System.Int32)Type.GetField("manaTurnEnd", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("manaTurnEnd", AllFlags).SetValue(Inst, value);
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

        public HeroEnum ownHeroName
        {
            get
            {
                return (HeroEnum)Type.GetField("ownHeroName", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroName", AllFlags).SetValue(Inst, value);
            }
        }

        public HeroEnum enemyHeroName
        {
            get
            {
                return (HeroEnum)Type.GetField("enemyHeroName", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroName", AllFlags).SetValue(Inst, value);
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

        public object ownQuest
        {
            get
            {
                return (object)Type.GetField("ownQuest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownQuest", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyQuest
        {
            get
            {
                return (object)Type.GetField("enemyQuest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyQuest", AllFlags).SetValue(Inst, value);
            }
        }

        public object sideQuest
        {
            get
            {
                return (object)Type.GetField("sideQuest", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("sideQuest", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 owncarddraw
        {
            get
            {
                return (System.Int32)Type.GetField("owncarddraw", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("owncarddraw", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemycarddraw
        {
            get
            {
                return (System.Int32)Type.GetField("enemycarddraw", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemycarddraw", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyAnzCards
        {
            get
            {
                return (System.Int32)Type.GetField("enemyAnzCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyAnzCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 libram
        {
            get
            {
                return (System.Int32)Type.GetField("libram", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("libram", AllFlags).SetValue(Inst, value);
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

        public System.Int32 spellpowerStarted
        {
            get
            {
                return (System.Int32)Type.GetField("spellpowerStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("spellpowerStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyspellpower
        {
            get
            {
                return (System.Int32)Type.GetField("enemyspellpower", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyspellpower", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyspellpowerStarted
        {
            get
            {
                return (System.Int32)Type.GetField("enemyspellpowerStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyspellpowerStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 wehaveCounterspell
        {
            get
            {
                return (System.Int32)Type.GetField("wehaveCounterspell", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("wehaveCounterspell", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lethlMissing
        {
            get
            {
                return (System.Int32)Type.GetField("lethlMissing", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lethlMissing", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean nextSecretThisTurnCost0
        {
            get
            {
                return (System.Boolean)Type.GetField("nextSecretThisTurnCost0", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextSecretThisTurnCost0", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean playedPreparation
        {
            get
            {
                return (System.Boolean)Type.GetField("playedPreparation", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playedPreparation", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean nextSpellThisTurnCost0
        {
            get
            {
                return (System.Boolean)Type.GetField("nextSpellThisTurnCost0", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextSpellThisTurnCost0", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean nextMurlocThisTurnCostHealth
        {
            get
            {
                return (System.Boolean)Type.GetField("nextMurlocThisTurnCostHealth", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextMurlocThisTurnCostHealth", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean nextSpellThisTurnCostHealth
        {
            get
            {
                return (System.Boolean)Type.GetField("nextSpellThisTurnCostHealth", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextSpellThisTurnCostHealth", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 winzigebeschwoererin
        {
            get
            {
                return (System.Int32)Type.GetField("winzigebeschwoererin", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("winzigebeschwoererin", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 startedWithWinzigebeschwoererin
        {
            get
            {
                return (System.Int32)Type.GetField("startedWithWinzigebeschwoererin", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedWithWinzigebeschwoererin", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 winRazormaneBattleguard
        {
            get
            {
                return (System.Int32)Type.GetField("winRazormaneBattleguard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("winRazormaneBattleguard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 startedRazormaneBattleguard
        {
            get
            {
                return (System.Int32)Type.GetField("startedRazormaneBattleguard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedRazormaneBattleguard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 managespenst
        {
            get
            {
                return (System.Int32)Type.GetField("managespenst", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("managespenst", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 startedWithManagespenst
        {
            get
            {
                return (System.Int32)Type.GetField("startedWithManagespenst", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedWithManagespenst", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownMinionsCostMore
        {
            get
            {
                return (System.Int32)Type.GetField("ownMinionsCostMore", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMinionsCostMore", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownMinionsCostMoreAtStart
        {
            get
            {
                return (System.Int32)Type.GetField("ownMinionsCostMoreAtStart", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMinionsCostMoreAtStart", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownSpelsCostMore
        {
            get
            {
                return (System.Int32)Type.GetField("ownSpelsCostMore", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownSpelsCostMore", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownSpelsCostMoreAtStart
        {
            get
            {
                return (System.Int32)Type.GetField("ownSpelsCostMoreAtStart", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownSpelsCostMoreAtStart", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownDRcardsCostMore
        {
            get
            {
                return (System.Int32)Type.GetField("ownDRcardsCostMore", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownDRcardsCostMore", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownDRcardsCostMoreAtStart
        {
            get
            {
                return (System.Int32)Type.GetField("ownDRcardsCostMoreAtStart", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownDRcardsCostMoreAtStart", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 beschwoerungsportal
        {
            get
            {
                return (System.Int32)Type.GetField("beschwoerungsportal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("beschwoerungsportal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 startedWithbeschwoerungsportal
        {
            get
            {
                return (System.Int32)Type.GetField("startedWithbeschwoerungsportal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedWithbeschwoerungsportal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 myCardsCostLess
        {
            get
            {
                return (System.Int32)Type.GetField("myCardsCostLess", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("myCardsCostLess", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 startedWithmyCardsCostLess
        {
            get
            {
                return (System.Int32)Type.GetField("startedWithmyCardsCostLess", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedWithmyCardsCostLess", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnAviana
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnAviana", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnAviana", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnScargil
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnScargil", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnScargil", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 anzOwnCloakedHuntress
        {
            get
            {
                return (System.Int32)Type.GetField("anzOwnCloakedHuntress", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("anzOwnCloakedHuntress", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 nerubarweblord
        {
            get
            {
                return (System.Int32)Type.GetField("nerubarweblord", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nerubarweblord", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 startedWithnerubarweblord
        {
            get
            {
                return (System.Int32)Type.GetField("startedWithnerubarweblord", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedWithnerubarweblord", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean startedWithDamagedMinions
        {
            get
            {
                return (System.Boolean)Type.GetField("startedWithDamagedMinions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedWithDamagedMinions", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownWeaponAttackStarted
        {
            get
            {
                return (System.Int32)Type.GetField("ownWeaponAttackStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownWeaponAttackStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownMobsCountStarted
        {
            get
            {
                return (System.Int32)Type.GetField("ownMobsCountStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMobsCountStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownCardsCountStarted
        {
            get
            {
                return (System.Int32)Type.GetField("ownCardsCountStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownCardsCountStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyMobsCountStarted
        {
            get
            {
                return (System.Int32)Type.GetField("enemyMobsCountStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyMobsCountStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyCardsCountStarted
        {
            get
            {
                return (System.Int32)Type.GetField("enemyCardsCountStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyCardsCountStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroHpStarted
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroHpStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroHpStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroHpStarted
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroHpStarted", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroHpStarted", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 mobsplayedThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("mobsplayedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("mobsplayedThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 startedWithMobsPlayedThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("startedWithMobsPlayedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("startedWithMobsPlayedThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 spellsplayedSinceRecalc
        {
            get
            {
                return (System.Int32)Type.GetField("spellsplayedSinceRecalc", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("spellsplayedSinceRecalc", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 secretsplayedSinceRecalc
        {
            get
            {
                return (System.Int32)Type.GetField("secretsplayedSinceRecalc", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("secretsplayedSinceRecalc", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 optionsPlayedThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("optionsPlayedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("optionsPlayedThisTurn", AllFlags).SetValue(Inst, value);
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

        public System.Int32 enemyOptionsDoneThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("enemyOptionsDoneThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyOptionsDoneThisTurn", AllFlags).SetValue(Inst, value);
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

        public System.Int32 lostDamage
        {
            get
            {
                return (System.Int32)Type.GetField("lostDamage", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lostDamage", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lostHeal
        {
            get
            {
                return (System.Int32)Type.GetField("lostHeal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lostHeal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lostWeaponDamage
        {
            get
            {
                return (System.Int32)Type.GetField("lostWeaponDamage", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lostWeaponDamage", AllFlags).SetValue(Inst, value);
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

        public System.Boolean ownAbilityReady
        {
            get
            {
                return (System.Boolean)Type.GetField("ownAbilityReady", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownAbilityReady", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownHeroAblility
        {
            get
            {
                return (object)Type.GetField("ownHeroAblility", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroAblility", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemyAbilityReady
        {
            get
            {
                return (System.Boolean)Type.GetField("enemyAbilityReady", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyAbilityReady", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyHeroAblility
        {
            get
            {
                return (object)Type.GetField("enemyHeroAblility", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroAblility", AllFlags).SetValue(Inst, value);
            }
        }

        public object bestEnemyPlay
        {
            get
            {
                return (object)Type.GetField("bestEnemyPlay", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("bestEnemyPlay", AllFlags).SetValue(Inst, value);
            }
        }

        public object endTurnState
        {
            get
            {
                return (object)Type.GetField("endTurnState", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("endTurnState", AllFlags).SetValue(Inst, value);
            }
        }

        public cardIDEnum revivingOwnMinion
        {
            get
            {
                return (cardIDEnum)Type.GetField("revivingOwnMinion", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("revivingOwnMinion", AllFlags).SetValue(Inst, value);
            }
        }

        public cardIDEnum revivingEnemyMinion
        {
            get
            {
                return (cardIDEnum)Type.GetField("revivingEnemyMinion", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("revivingEnemyMinion", AllFlags).SetValue(Inst, value);
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

        public System.Int32 shadowmadnessed
        {
            get
            {
                return (System.Int32)Type.GetField("shadowmadnessed", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("shadowmadnessed", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyHeroTurnStartedHp
        {
            get
            {
                return (System.Int32)Type.GetField("enemyHeroTurnStartedHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyHeroTurnStartedHp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownHeroTurnStartedHp
        {
            get
            {
                return (System.Int32)Type.GetField("ownHeroTurnStartedHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroTurnStartedHp", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownSpellSchoolCounts
        {
            get
            {
                return (object)Type.GetField("ownSpellSchoolCounts", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownSpellSchoolCounts", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownElizagoreblade
        {
            get
            {
                return (System.Int32)Type.GetField("ownElizagoreblade", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownElizagoreblade", AllFlags).SetValue(Inst, value);
            }
        }

        public object cardsToReturnAtEndOfTurn
        {
            get
            {
                return (object)Type.GetField("cardsToReturnAtEndOfTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardsToReturnAtEndOfTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownSunscreenTurns
        {
            get
            {
                return (System.Int32)Type.GetField("ownSunscreenTurns", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownSunscreenTurns", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemySunscreenTurns
        {
            get
            {
                return (System.Int32)Type.GetField("enemySunscreenTurns", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemySunscreenTurns", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownPlayedDeathrattleCards
        {
            get
            {
                return (object)Type.GetField("ownPlayedDeathrattleCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownPlayedDeathrattleCards", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyPlayedDeathrattleCards
        {
            get
            {
                return (object)Type.GetField("enemyPlayedDeathrattleCards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyPlayedDeathrattleCards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownHeroPowerCanBeUsedMultipleTimes
        {
            get
            {
                return (System.Boolean)Type.GetField("ownHeroPowerCanBeUsedMultipleTimes", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownHeroPowerCanBeUsedMultipleTimes", AllFlags).SetValue(Inst, value);
            }
        }

        public object ownMinionsPlayedThisGame
        {
            get
            {
                return (object)Type.GetField("ownMinionsPlayedThisGame", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownMinionsPlayedThisGame", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 excavationCount
        {
            get
            {
                return (System.Int32)Type.GetField("excavationCount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("excavationCount", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 allExcavationCount
        {
            get
            {
                return (System.Int32)Type.GetField("allExcavationCount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("allExcavationCount", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 nextBattlecryTriggers
        {
            get
            {
                return (System.Int32)Type.GetField("nextBattlecryTriggers", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextBattlecryTriggers", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownRelicDoubleCast
        {
            get
            {
                return (System.Boolean)Type.GetField("ownRelicDoubleCast", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownRelicDoubleCast", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemyRelicDoubleCast
        {
            get
            {
                return (System.Boolean)Type.GetField("enemyRelicDoubleCast", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyRelicDoubleCast", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean nextMinionBecomesFiveFive
        {
            get
            {
                return (System.Boolean)Type.GetField("nextMinionBecomesFiveFive", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextMinionBecomesFiveFive", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 tempSpellPower
        {
            get
            {
                return (System.Int32)Type.GetField("tempSpellPower", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("tempSpellPower", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean nextChooseOneHasBothEffects
        {
            get
            {
                return (System.Boolean)Type.GetField("nextChooseOneHasBothEffects", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextChooseOneHasBothEffects", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 parrotSanctuaryCount
        {
            get
            {
                return (System.Int32)Type.GetField("parrotSanctuaryCount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("parrotSanctuaryCount", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lastDrawnCardEntityID
        {
            get
            {
                return (System.Int32)Type.GetField("lastDrawnCardEntityID", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lastDrawnCardEntityID", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownLegionInvasion
        {
            get
            {
                return (System.Boolean)Type.GetField("ownLegionInvasion", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownLegionInvasion", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemyLegionInvasion
        {
            get
            {
                return (System.Boolean)Type.GetField("enemyLegionInvasion", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyLegionInvasion", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean ownAmitusThePeacekeeper
        {
            get
            {
                return (System.Boolean)Type.GetField("ownAmitusThePeacekeeper", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownAmitusThePeacekeeper", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemyAmitusThePeacekeeper
        {
            get
            {
                return (System.Boolean)Type.GetField("enemyAmitusThePeacekeeper", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyAmitusThePeacekeeper", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 damageDealtToEnemyHeroThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("damageDealtToEnemyHeroThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("damageDealtToEnemyHeroThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 nextElementalReduction
        {
            get
            {
                return (System.Int32)Type.GetField("nextElementalReduction", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextElementalReduction", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 thisTurnNextElementalReduction
        {
            get
            {
                return (System.Int32)Type.GetField("thisTurnNextElementalReduction", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("thisTurnNextElementalReduction", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lastPlayedCardCost
        {
            get
            {
                return (System.Int32)Type.GetField("lastPlayedCardCost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lastPlayedCardCost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean playedElementalThisTurn
        {
            get
            {
                return (System.Boolean)Type.GetField("playedElementalThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playedElementalThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 ownElementalsPlayedThisTurn
        {
            get
            {
                return (System.Int32)Type.GetField("ownElementalsPlayedThisTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("ownElementalsPlayedThisTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public object rng
        {
            get
            {
                return (object)Type.GetField("rng", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("rng", AllFlags).SetValue(Inst, value);
            }
        }

        public static object ilog_0
        {
            get
            {
                return (object)Type.GetField("ilog_0", AllFlags).GetValue(null);
            }
            set
            {
                Type.GetField("ilog_0", AllFlags).SetValue(null, value);
            }
        }


        public System.Int32 lethalMissing()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("lethalMissing", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Boolean nextTurnWin()
        {
            var sigs = new Type[0];
            return (System.Boolean)Type.GetMethod("nextTurnWin", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Int32 CalculatePotentialDamage()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("CalculatePotentialDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Int32 calDirectDmg(System.Int32 mana, System.Boolean force, System.Boolean calNextTurn, System.Int32 maxCal, System.Int32 calMax)
        {
            var sigs = new Type[5];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            sigs[3] = typeof(System.Int32);
            sigs[4] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("calDirectDmg", AllFlags, null, sigs, null).Invoke(Inst, new object[] { mana, force, calNextTurn, maxCal, calMax });
        }

        public void minionSetAngrToX(object m, System.Int32 newAngr)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("minionSetAngrToX", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, newAngr });
        }

        public void minionSetLifetoX(object m, System.Int32 newHp)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("minionSetLifetoX", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, newHp });
        }

        public void minionSetAngrToHP(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionSetAngrToHP", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void minionSwapAngrAndHP(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionSwapAngrAndHP", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void minionGetDamageOrHeal(object m, System.Int32 dmgOrHeal, System.Boolean dontDmgLoss)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("minionGetDamageOrHeal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, dmgOrHeal, dontDmgLoss });
        }

        public void allMinionOfASideGetDamage(System.Boolean own, System.Int32 damages, System.Boolean frozen)
        {
            var sigs = new Type[3];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("allMinionOfASideGetDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, damages, frozen });
        }

        public void allCharsOfASideGetDamage(System.Boolean own, System.Int32 damages)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("allCharsOfASideGetDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, damages });
        }

        public void allCharsOfASideGetRandomDamage(System.Boolean ownSide, System.Int32 times)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("allCharsOfASideGetRandomDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ownSide, times });
        }

        public void allCharsGetDamage(System.Int32 damages, System.Int32 exceptID)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("allCharsGetDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { damages, exceptID });
        }

        public void allMinionsGetDamage(System.Int32 damages, System.Int32 exceptID)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("allMinionsGetDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { damages, exceptID });
        }

        public void DealDamageToRandomCharacter(System.Boolean isEnemy, System.Int32 damage)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("DealDamageToRandomCharacter", AllFlags, null, sigs, null).Invoke(Inst, new object[] { isEnemy, damage });
        }

        public void setNewHeroPower(cardIDEnum newHeroPower, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardIDEnum");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("setNewHeroPower", AllFlags, null, sigs, null).Invoke(Inst, new object[] { newHeroPower, own });
        }

        public System.Int32 calTotalAngr()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("calTotalAngr", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Int32 calEnemyTotalAngr()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("calEnemyTotalAngr", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object getNextJadeGolem(System.Boolean own)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            return (object)Type.GetMethod("getNextJadeGolem", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own });
        }

        public void debugMinions()
        {
            var sigs = new Type[0];
            Type.GetMethod("debugMinions", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void printBoard()
        {
            var sigs = new Type[0];
            Type.GetMethod("printBoard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public string printBoardString()
        {
            var sigs = new Type[0];
            return (string)Type.GetMethod("printBoardString", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void printBoardDebug()
        {
            var sigs = new Type[0];
            Type.GetMethod("printBoardDebug", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object getNextAction()
        {
            var sigs = new Type[0];
            return (object)Type.GetMethod("getNextAction", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public cardIDEnum CheckTurnDeckExists(TAG_RACE race)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.TAG_RACE");
            return (cardIDEnum)Type.GetMethod("CheckTurnDeckExists", AllFlags, null, sigs, null).Invoke(Inst, new object[] { race });
        }

        public object CheckTurnDeckForType(cardtype type, System.Int32 num)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardtype");
            sigs[1] = typeof(System.Int32);
            return (object)Type.GetMethod("CheckTurnDeckForType", AllFlags, null, sigs, null).Invoke(Inst, new object[] { type, num });
        }

        public void printActions(System.Boolean toBuffer)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("printActions", AllFlags, null, sigs, null).Invoke(Inst, new object[] { toBuffer });
        }

        public void printActionforDummies(object a)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            Type.GetMethod("printActionforDummies", AllFlags, null, sigs, null).Invoke(Inst, new object[] { a });
        }

        public System.Int32 getRandomNumber(System.Int32 minValue, System.Int32 maxValue)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getRandomNumber", AllFlags, null, sigs, null).Invoke(Inst, new object[] { minValue, maxValue });
        }

        public object handleExcavation()
        {
            var sigs = new Type[0];
            return (object)Type.GetMethod("handleExcavation", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object getTreasurePool(string quality)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (object)Type.GetMethod("getTreasurePool", AllFlags, null, sigs, null).Invoke(Inst, new object[] { quality });
        }

        public object getLegendaryTreasure()
        {
            var sigs = new Type[0];
            return (object)Type.GetMethod("getLegendaryTreasure", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object getRandomCardFromPool(string quality)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (object)Type.GetMethod("getRandomCardFromPool", AllFlags, null, sigs, null).Invoke(Inst, new object[] { quality });
        }

        public System.Boolean hasLegendaryTreasure()
        {
            var sigs = new Type[0];
            return (System.Boolean)Type.GetMethod("hasLegendaryTreasure", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void useLocation(object own, object target)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("useLocation", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, target });
        }

        public void useTitanAbility(object own, System.Int32 titanAbilityNO, object target)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            sigs[2] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("useTitanAbility", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, titanAbilityNO, target });
        }

        public void drawTemporaryCard(cardIDEnum ss, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardIDEnum");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("drawTemporaryCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ss, own });
        }

        public void removeTemporaryCards(System.Boolean own)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("removeTemporaryCards", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own });
        }

        public System.Int32 CountSpellSchoolsPlayed()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("CountSpellSchoolsPlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void allMinionsGetRandomDamage(System.Int32 totalDamage)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("allMinionsGetRandomDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { totalDamage });
        }

        public System.Boolean hasMinionsInDeck()
        {
            var sigs = new Type[0];
            return (System.Boolean)Type.GetMethod("hasMinionsInDeck", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void RandomEnemyMinionsAttackEachOther()
        {
            var sigs = new Type[0];
            Type.GetMethod("RandomEnemyMinionsAttackEachOther", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void PlayHeroPower(object target, System.Int32 penality, System.Boolean ownturn, System.Int32 choice)
        {
            var sigs = new Type[4];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            sigs[3] = typeof(System.Int32);
            Type.GetMethod("PlayHeroPower", AllFlags, null, sigs, null).Invoke(Inst, new object[] { target, penality, ownturn, choice });
        }

        public void lowerWeaponDurability(System.Int32 value, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("lowerWeaponDurability", AllFlags, null, sigs, null).Invoke(Inst, new object[] { value, own });
        }

        public void HandleWeaponBreak(object weapon, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Weapon");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("HandleWeaponBreak", AllFlags, null, sigs, null).Invoke(Inst, new object[] { weapon, own });
        }

        public void doDmgTriggers()
        {
            var sigs = new Type[0];
            Type.GetMethod("doDmgTriggers", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void ResetMinionDeathTriggers()
        {
            var sigs = new Type[0];
            Type.GetMethod("ResetMinionDeathTriggers", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Boolean HasPendingTriggers()
        {
            var sigs = new Type[0];
            return (System.Boolean)Type.GetMethod("HasPendingTriggers", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void triggerACharGotHealed()
        {
            var sigs = new Type[0];
            Type.GetMethod("triggerACharGotHealed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void triggerAMinionGotHealed()
        {
            var sigs = new Type[0];
            Type.GetMethod("triggerAMinionGotHealed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void triggerAMinionGotDmg()
        {
            var sigs = new Type[0];
            Type.GetMethod("triggerAMinionGotDmg", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void triggerAMinionLosesDivineShield()
        {
            var sigs = new Type[0];
            Type.GetMethod("triggerAMinionLosesDivineShield", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void triggerAMinionDied()
        {
            var sigs = new Type[0];
            Type.GetMethod("triggerAMinionDied", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void HandleHeroAbilitySummon(object ability, System.Int32 minionsDied, System.Boolean isOwn)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("HandleHeroAbilitySummon", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ability, minionsDied, isOwn });
        }

        public void InfuseDeckCards()
        {
            var sigs = new Type[0];
            Type.GetMethod("InfuseDeckCards", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void InfuseHandCards()
        {
            var sigs = new Type[0];
            Type.GetMethod("InfuseHandCards", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void InfuseCard(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("InfuseCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public void HandleWeaponEffectOnMinionDeath(object weapon, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Weapon");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("HandleWeaponEffectOnMinionDeath", AllFlags, null, sigs, null).Invoke(Inst, new object[] { weapon, own });
        }

        public void triggerAMinionIsGoingToAttack(object attacker, object target)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("triggerAMinionIsGoingToAttack", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, target });
        }

        public void triggerAMinionDealedDmg(object m, System.Int32 dmgDone, System.Boolean isAttacker)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("triggerAMinionDealedDmg", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, dmgDone, isAttacker });
        }

        public void triggerACardWillBePlayed(object hc, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("triggerACardWillBePlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, own });
        }

        public void triggerAMinionIsSummoned(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("triggerAMinionIsSummoned", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void triggerAMinionWasSummoned(object mnn)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("triggerAMinionWasSummoned", AllFlags, null, sigs, null).Invoke(Inst, new object[] { mnn });
        }

        public void triggerEndTurn(System.Boolean ownturn)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("triggerEndTurn", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ownturn });
        }

        public void HandleShadowMadnessEffect(System.Boolean ownturn)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("HandleShadowMadnessEffect", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ownturn });
        }

        public void ResetSpecialCardEffects()
        {
            var sigs = new Type[0];
            Type.GetMethod("ResetSpecialCardEffects", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void triggerStartTurn(System.Boolean ownturn)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("triggerStartTurn", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ownturn });
        }

        public void triggerAHeroGotArmor(System.Boolean ownHero)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("triggerAHeroGotArmor", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ownHero });
        }

        public void triggerCardsChanged(System.Boolean own)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("triggerCardsChanged", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own });
        }

        public void triggerInspire(System.Boolean ownturn)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("triggerInspire", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ownturn });
        }

        public System.Int32 secretTrigger_CharIsAttacked(object attacker, object defender)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            return (System.Int32)Type.GetMethod("secretTrigger_CharIsAttacked", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender });
        }

        public void secretTrigger_HeroGotDmg(System.Boolean own, System.Int32 dmg)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("secretTrigger_HeroGotDmg", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, dmg });
        }

        public void secretTrigger_MinionIsPlayed(object playedMinion)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("secretTrigger_MinionIsPlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { playedMinion });
        }

        public System.Int32 secretTrigger_SpellIsPlayed(object target, object c)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            return (System.Int32)Type.GetMethod("secretTrigger_SpellIsPlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { target, c });
        }

        public void secretTrigger_MinionDied(System.Boolean own)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("secretTrigger_MinionDied", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own });
        }

        public void secretTrigger_HeroPowerUsed()
        {
            var sigs = new Type[0];
            Type.GetMethod("secretTrigger_HeroPowerUsed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Int32 getSecretTriggersByType(System.Int32 type, System.Boolean actedMinionOwn, System.Boolean actedMinionIsHero, object target)
        {
            var sigs = new Type[4];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            sigs[3] = Type.Assembly.GetType("HREngine.Bots.Minion");
            return (System.Int32)Type.GetMethod("getSecretTriggersByType", AllFlags, null, sigs, null).Invoke(Inst, new object[] { type, actedMinionOwn, actedMinionIsHero, target });
        }

        public void updateBoards()
        {
            var sigs = new Type[0];
            Type.GetMethod("updateBoards", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void handleSpiritClaws(object weapon, object hero, System.Int32 currentSpellPower, System.Int32 initialSpellPower, object spiritClawsActive)
        {
            var sigs = new Type[5];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Weapon");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            sigs[4] = typeof(System.Boolean);
            Type.GetMethod("handleSpiritClaws", AllFlags, null, sigs, null).Invoke(Inst, new object[] { weapon, hero, currentSpellPower, initialSpellPower, spiritClawsActive });
        }

        public void minionGetOrEraseAllAreaBuffs(object m, System.Boolean get)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("minionGetOrEraseAllAreaBuffs", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, get });
        }

        public void handleRaceSpecificBuffs(object m, System.Boolean get, System.Boolean own)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("handleRaceSpecificBuffs", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, get, own });
        }

        public void updateAdjacentBuffs(System.Boolean own)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("updateAdjacentBuffs", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own });
        }

        public object createNewMinion(object hc, System.Int32 zonepos, System.Boolean own)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            return (object)Type.GetMethod("createNewMinion", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, zonepos, own });
        }

        public void placeAmobSomewhere(object hc, System.Int32 choice, System.Int32 zonepos)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("placeAmobSomewhere", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, choice, zonepos });
        }

        public void addMinionToBattlefield(object m, System.Boolean isSummon)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("addMinionToBattlefield", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, isSummon });
        }

        public void equipWeapon(object c, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("equipWeapon", AllFlags, null, sigs, null).Invoke(Inst, new object[] { c, own });
        }

        public void callKid(object c, System.Int32 zonepos, System.Boolean own, System.Boolean spawnKid, System.Boolean oneMoreIsAllowed)
        {
            var sigs = new Type[5];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Boolean);
            sigs[3] = typeof(System.Boolean);
            sigs[4] = typeof(System.Boolean);
            Type.GetMethod("callKid", AllFlags, null, sigs, null).Invoke(Inst, new object[] { c, zonepos, own, spawnKid, oneMoreIsAllowed });
        }

        public void minionGetFrozen(object target)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionGetFrozen", AllFlags, null, sigs, null).Invoke(Inst, new object[] { target });
        }

        public void minionGetSilenced(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionGetSilenced", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void allMinionsGetSilenced(System.Boolean own)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("allMinionsGetSilenced", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own });
        }

        public void drawACard(cardNameEN ss, System.Boolean own, System.Boolean nopen)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardNameEN");
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("drawACard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ss, own, nopen });
        }

        public void drawACard(cardIDEnum ss, System.Boolean own, System.Boolean nopen)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardIDEnum");
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("drawACard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { ss, own, nopen });
        }

        public void removeCard(object hcc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("removeCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hcc });
        }

        public void attackEnemyHeroWithoutKill(System.Int32 dmg)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("attackEnemyHeroWithoutKill", AllFlags, null, sigs, null).Invoke(Inst, new object[] { dmg });
        }

        public void minionGetDestroyed(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionGetDestroyed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void RemoveMinionWithoutDeathrattle(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("RemoveMinionWithoutDeathrattle", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void allMinionsGetDestroyed()
        {
            var sigs = new Type[0];
            Type.GetMethod("allMinionsGetDestroyed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void minionGetArmor(object m, System.Int32 armor)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("minionGetArmor", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, armor });
        }

        public void minionReturnToHand(object m, System.Boolean own, System.Int32 manachange)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("minionReturnToHand", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, own, manachange });
        }

        public void minionReturnToDeck(object m, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("minionReturnToDeck", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, own });
        }

        public void minionTransform(object m, object c)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            Type.GetMethod("minionTransform", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, c });
        }

        public object getRandomCardForManaMinion(System.Int32 manaCost)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (object)Type.GetMethod("getRandomCardForManaMinion", AllFlags, null, sigs, null).Invoke(Inst, new object[] { manaCost });
        }

        public object getEnemyCharTargetForRandomSingleDamage(System.Int32 damage, System.Boolean onlyMinions)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Boolean);
            return (object)Type.GetMethod("getEnemyCharTargetForRandomSingleDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { damage, onlyMinions });
        }

        public void minionGetControlled(object m, System.Boolean newOwner, System.Boolean canAttack, System.Boolean forced)
        {
            var sigs = new Type[4];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Boolean);
            sigs[2] = typeof(System.Boolean);
            sigs[3] = typeof(System.Boolean);
            Type.GetMethod("minionGetControlled", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, newOwner, canAttack, forced });
        }

        public void Magnetic(object mOwn)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("Magnetic", AllFlags, null, sigs, null).Invoke(Inst, new object[] { mOwn });
        }

        public void minionGetWindfurry(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionGetWindfurry", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void minionGetCharge(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionGetCharge", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void minionGetRush(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionGetRush", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void minionLostCharge(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionLostCharge", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void minionGetTempBuff(object m, System.Int32 tempAttack, System.Int32 tempHp)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("minionGetTempBuff", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, tempAttack, tempHp });
        }

        public void minionGetAdjacentBuff(object m, System.Int32 angr, System.Int32 vert)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("minionGetAdjacentBuff", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, angr, vert });
        }

        public void allMinionOfASideGetBuffed(System.Boolean own, System.Int32 attackbuff, System.Int32 hpbuff)
        {
            var sigs = new Type[3];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("allMinionOfASideGetBuffed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, attackbuff, hpbuff });
        }

        public void minionGetBuffed(object m, System.Int32 attackbuff, System.Int32 hpbuff)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("minionGetBuffed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m, attackbuff, hpbuff });
        }

        public void cthunGetBuffed(System.Int32 attackbuff, System.Int32 hpbuff, System.Int32 tauntbuff)
        {
            var sigs = new Type[3];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("cthunGetBuffed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attackbuff, hpbuff, tauntbuff });
        }

        public void minionLosesDivineShield(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("minionLosesDivineShield", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void discardCards(System.Int32 num, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("discardCards", AllFlags, null, sigs, null).Invoke(Inst, new object[] { num, own });
        }

        public System.Int32 calculateCardValue(object hc, object c)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            return (System.Int32)Type.GetMethod("calculateCardValue", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, c });
        }

        public System.Int32 getCardValueRatio(System.Int32 manaCost)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getCardValueRatio", AllFlags, null, sigs, null).Invoke(Inst, new object[] { manaCost });
        }

        public void onEnemyTurnStart()
        {
            var sigs = new Type[0];
            Type.GetMethod("onEnemyTurnStart", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void onEnemyTurnEnd()
        {
            var sigs = new Type[0];
            Type.GetMethod("onEnemyTurnEnd", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void applyLoathebEffect()
        {
            var sigs = new Type[0];
            Type.GetMethod("applyLoathebEffect", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void AddToEnemyHand(object card)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("AddToEnemyHand", AllFlags, null, sigs, null).Invoke(Inst, new object[] { card });
        }

        public void RemoveFromEnemyHand(object card)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("RemoveFromEnemyHand", AllFlags, null, sigs, null).Invoke(Inst, new object[] { card });
        }

        public void AddToDeck(object card)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            Type.GetMethod("AddToDeck", AllFlags, null, sigs, null).Invoke(Inst, new object[] { card });
        }

        public void RemoveFromDeck(object card)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            Type.GetMethod("RemoveFromDeck", AllFlags, null, sigs, null).Invoke(Inst, new object[] { card });
        }

        public void addCorpses(System.Int32 count)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("addCorpses", AllFlags, null, sigs, null).Invoke(Inst, new object[] { count });
        }

        public void corpseConsumption(System.Int32 count)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("corpseConsumption", AllFlags, null, sigs, null).Invoke(Inst, new object[] { count });
        }

        public System.Int32 getCorpseCount()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("getCorpseCount", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void copyValuesFrom(object p)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            Type.GetMethod("copyValuesFrom", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p });
        }

        public System.Boolean isEqual(object p, System.Boolean logg)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Boolean);
            return (System.Boolean)Type.GetMethod("isEqual", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, logg });
        }

        public System.Boolean isEqualf(object p)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            return (System.Boolean)Type.GetMethod("isEqualf", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p });
        }

        public System.Int64 GetPHash()
        {
            var sigs = new Type[0];
            return (System.Int64)Type.GetMethod("GetPHash", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void enemyPlaysAoe(System.Int32 pprob, System.Int32 pprob2)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("enemyPlaysAoe", AllFlags, null, sigs, null).Invoke(Inst, new object[] { pprob, pprob2 });
        }

        public System.Int32 EnemyCardPlaying(TAG_CLASS enemyHeroStrtClass, System.Int32 currmana, System.Int32 cardcount, System.Int32 playAroundProb, System.Int32 pap2)
        {
            var sigs = new Type[5];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.TAG_CLASS");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            sigs[4] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("EnemyCardPlaying", AllFlags, null, sigs, null).Invoke(Inst, new object[] { enemyHeroStrtClass, currmana, cardcount, playAroundProb, pap2 });
        }

        public System.Int32 EnemyPlaysACard(cardNameEN cardname, System.Int32 currmana, System.Int32 playAroundProb, System.Int32 pap2)
        {
            var sigs = new Type[4];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardNameEN");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("EnemyPlaysACard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { cardname, currmana, playAroundProb, pap2 });
        }

        public System.Int32 getNextEntity()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("getNextEntity", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public object getAttackTargets(System.Boolean own, System.Boolean isLethalCheck)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Boolean);
            return (object)Type.GetMethod("getAttackTargets", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, isLethalCheck });
        }

        public System.Int32 getBestPlace(object card, System.Boolean lethal)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            sigs[1] = typeof(System.Boolean);
            return (System.Int32)Type.GetMethod("getBestPlace", AllFlags, null, sigs, null).Invoke(Inst, new object[] { card, lethal });
        }

        public System.Int32 getBestAdapt(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            return (System.Int32)Type.GetMethod("getBestAdapt", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public System.Int32 guessEnemyHeroLethalMissing()
        {
            var sigs = new Type[0];
            return (System.Int32)Type.GetMethod("guessEnemyHeroLethalMissing", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void guessHeroDamage()
        {
            var sigs = new Type[0];
            Type.GetMethod("guessHeroDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Boolean ownHeroHasDirectLethal()
        {
            var sigs = new Type[0];
            return (System.Boolean)Type.GetMethod("ownHeroHasDirectLethal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void simulateTrapsStartEnemyTurn()
        {
            var sigs = new Type[0];
            Type.GetMethod("simulateTrapsStartEnemyTurn", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void simulateTrapsEndEnemyTurn()
        {
            var sigs = new Type[0];
            Type.GetMethod("simulateTrapsEndEnemyTurn", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void endTurn()
        {
            var sigs = new Type[0];
            Type.GetMethod("endTurn", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void startTurn()
        {
            var sigs = new Type[0];
            Type.GetMethod("startTurn", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void unlockMana()
        {
            var sigs = new Type[0];
            Type.GetMethod("unlockMana", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Int32 getHeroPowerDamage(System.Int32 dmg)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getHeroPowerDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { dmg });
        }

        public System.Int32 getEnemyHeroPowerDamage(System.Int32 dmg)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getEnemyHeroPowerDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { dmg });
        }

        public System.Int32 getSpellDamageDamage(System.Int32 dmg)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getSpellDamageDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { dmg });
        }

        public System.Int32 getSpellHeal(System.Int32 heal)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getSpellHeal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { heal });
        }

        public void applySpellLifesteal(System.Int32 heal, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("applySpellLifesteal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { heal, own });
        }

        public System.Int32 getMinionHeal(System.Int32 heal)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getMinionHeal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { heal });
        }

        public System.Int32 getEnemySpellDamageDamage(System.Int32 dmg)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getEnemySpellDamageDamage", AllFlags, null, sigs, null).Invoke(Inst, new object[] { dmg });
        }

        public System.Int32 getEnemySpellHeal(System.Int32 heal)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getEnemySpellHeal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { heal });
        }

        public System.Int32 getEnemyMinionHeal(System.Int32 heal)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("getEnemyMinionHeal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { heal });
        }

        public void doAction(object aa)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            Type.GetMethod("doAction", AllFlags, null, sigs, null).Invoke(Inst, new object[] { aa });
        }

        public object FindMinionByEntityId(object target)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            return (object)Type.GetMethod("FindMinionByEntityId", AllFlags, null, sigs, null).Invoke(Inst, new object[] { target });
        }

        public object FindHandCard(object aa)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            return (object)Type.GetMethod("FindHandCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { aa });
        }

        public void HandleMinionAttack(object a)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            Type.GetMethod("HandleMinionAttack", AllFlags, null, sigs, null).Invoke(Inst, new object[] { a });
        }

        public void HandleTamsinRoameEffect(object a)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            Type.GetMethod("HandleTamsinRoameEffect", AllFlags, null, sigs, null).Invoke(Inst, new object[] { a });
        }

        public void HandlePatchesSummon(object a)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            Type.GetMethod("HandlePatchesSummon", AllFlags, null, sigs, null).Invoke(Inst, new object[] { a });
        }

        public void HandleQuestCompletion()
        {
            var sigs = new Type[0];
            Type.GetMethod("HandleQuestCompletion", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void HandleTrade(object a)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            Type.GetMethod("HandleTrade", AllFlags, null, sigs, null).Invoke(Inst, new object[] { a });
        }

        public void HandleForge(object a)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Action");
            Type.GetMethod("HandleForge", AllFlags, null, sigs, null).Invoke(Inst, new object[] { a });
        }

        public void minionAttacksMinion(object attacker, object defender, System.Boolean dontcount)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("minionAttacksMinion", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender, dontcount });
        }

        public void HandleHeroAttack(object attacker, object defender, System.Int32 oldHp)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("HandleHeroAttack", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender, oldHp });
        }

        public System.Int32 AdjustDamageForWeapon(object attacker, System.Int32 dmg)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            return (System.Int32)Type.GetMethod("AdjustDamageForWeapon", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, dmg });
        }

        public void DecreaseWeaponDurability(System.Boolean own)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("DecreaseWeaponDurability", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own });
        }

        public void HandleWeaponSpecialEffects(object attacker, object defender, System.Int32 oldHp)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("HandleWeaponSpecialEffects", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender, oldHp });
        }

        public void HandleDefenderDamageEffects(object attacker, object defender, System.Int32 oldHp, System.Boolean defenderHasDivineshild)
        {
            var sigs = new Type[4];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Boolean);
            Type.GetMethod("HandleDefenderDamageEffects", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender, oldHp, defenderHasDivineshild });
        }

        public void HandleAttackerDamageEffects(object attacker, object defender, System.Int32 oldHp)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("HandleAttackerDamageEffects", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender, oldHp });
        }

        public void HandleOverkillAndHonorableKill(object attacker, object defender, System.Int32 oldHp, System.Int32 attackerAngr, System.Boolean defenderHasDivineshild)
        {
            var sigs = new Type[5];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            sigs[4] = typeof(System.Boolean);
            Type.GetMethod("HandleOverkillAndHonorableKill", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender, oldHp, attackerAngr, defenderHasDivineshild });
        }

        public void HealHero(System.Boolean own, System.Int32 amount)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("HealHero", AllFlags, null, sigs, null).Invoke(Inst, new object[] { own, amount });
        }

        public void HandlePostAttackEffects(object attacker, object defender, System.Boolean dontcount)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Boolean);
            Type.GetMethod("HandlePostAttackEffects", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender, dontcount });
        }

        public void AttackAdjacentMinions(object attacker, object defender)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("AttackAdjacentMinions", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker, defender });
        }

        public void SummonMurlocs(object attacker)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("SummonMurlocs", AllFlags, null, sigs, null).Invoke(Inst, new object[] { attacker });
        }

        public void attackWithWeapon(object hero, object target, System.Int32 penality)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("attackWithWeapon", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hero, target, penality });
        }

        public void PlayACard(object hc, object target, System.Int32 position, System.Int32 choice, System.Int32 penality)
        {
            var sigs = new Type[5];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            sigs[4] = typeof(System.Int32);
            Type.GetMethod("PlayACard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, target, position, choice, penality });
        }

        public void HandleSpecialCardCost(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("HandleSpecialCardCost", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public void PayHealthForSpell(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("PayHealthForSpell", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public void PayHealthForMurloc(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("PayHealthForMurloc", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public void RemoveOtherDiscoveredCards(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("RemoveOtherDiscoveredCards", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public void UpdateElementalAndNatureFlags(object c)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            Type.GetMethod("UpdateElementalAndNatureFlags", AllFlags, null, sigs, null).Invoke(Inst, new object[] { c });
        }

        public void UpdateElementalFlag()
        {
            var sigs = new Type[0];
            Type.GetMethod("UpdateElementalFlag", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void UpdateNatureSpellFlag(object c)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            Type.GetMethod("UpdateNatureSpellFlag", AllFlags, null, sigs, null).Invoke(Inst, new object[] { c });
        }

        public void HandleSpellCardEffects(object hc, object target, System.Int32 choice)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("HandleSpellCardEffects", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, target, choice });
        }

        public void HandleSpellTargetEffects(object hc, object target, System.Int32 choice)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("HandleSpellTargetEffects", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, target, choice });
        }

        public object UpdateTargetBasedOnSecret(System.Int32 newTarget, object target)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            return (object)Type.GetMethod("UpdateTargetBasedOnSecret", AllFlags, null, sigs, null).Invoke(Inst, new object[] { newTarget, target });
        }

        public void HandleMinionOrSpellPlay(object hc, object target, System.Int32 position, System.Int32 choice)
        {
            var sigs = new Type[4];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            Type.GetMethod("HandleMinionOrSpellPlay", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, target, position, choice });
        }

        public void HandleMinionPlay(object hc, System.Int32 position, System.Int32 choice)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = typeof(System.Int32);
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("HandleMinionPlay", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, position, choice });
        }

        public void HandleSpellPlay(object hc, object target, System.Int32 choice)
        {
            var sigs = new Type[3];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            Type.GetMethod("HandleSpellPlay", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, target, choice });
        }

        public void HandleOutcastEffect(object hc, System.Boolean outcast)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("HandleOutcastEffect", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, outcast });
        }

        public void HandleSpellburstEffect(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("HandleSpellburstEffect", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public void HandleCounterspellOrSpellbender(object c, object target)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("HandleCounterspellOrSpellbender", AllFlags, null, sigs, null).Invoke(Inst, new object[] { c, target });
        }

        public void ApplyBuffEffect(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("ApplyBuffEffect", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public void EnemyplaysACard(object c, object target, System.Int32 position, System.Int32 choice, System.Int32 penality)
        {
            var sigs = new Type[5];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+Card");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            sigs[4] = typeof(System.Int32);
            Type.GetMethod("EnemyplaysACard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { c, target, position, choice, penality });
        }

        public object EnemyUpdateTargetBasedOnSecret(System.Int32 newTarget, object target)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            return (object)Type.GetMethod("EnemyUpdateTargetBasedOnSecret", AllFlags, null, sigs, null).Invoke(Inst, new object[] { newTarget, target });
        }

        public void EnemyHandleEnemyMinionPlay(object hc, object target, System.Int32 position, System.Int32 choice)
        {
            var sigs = new Type[4];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            sigs[1] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[2] = typeof(System.Int32);
            sigs[3] = typeof(System.Int32);
            Type.GetMethod("EnemyHandleEnemyMinionPlay", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc, target, position, choice });
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
