using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Ai
    {
        public object Inst;
        public static Type Type;

        public Ai(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public System.Int32 maxdeep
        {
            get
            {
                return (System.Int32)Type.GetField("maxdeep", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("maxdeep", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 maxwide
        {
            get
            {
                return (System.Int32)Type.GetField("maxwide", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("maxwide", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 maxCal
        {
            get
            {
                return (System.Int32)Type.GetField("maxCal", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("maxCal", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 playaroundprob2
        {
            get
            {
                return (System.Int32)Type.GetField("playaroundprob2", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playaroundprob2", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 maxNumberOfThreads
        {
            get
            {
                return (System.Int32)Type.GetField("maxNumberOfThreads", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("maxNumberOfThreads", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean usePenalityManager
        {
            get
            {
                return (System.Boolean)Type.GetField("usePenalityManager", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("usePenalityManager", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean useCutingTargets
        {
            get
            {
                return (System.Boolean)Type.GetField("useCutingTargets", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("useCutingTargets", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean dontRecalc
        {
            get
            {
                return (System.Boolean)Type.GetField("dontRecalc", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("dontRecalc", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean useLethalCheck
        {
            get
            {
                return (System.Boolean)Type.GetField("useLethalCheck", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("useLethalCheck", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean useComparison
        {
            get
            {
                return (System.Boolean)Type.GetField("useComparison", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("useComparison", AllFlags).SetValue(Inst, value);
            }
        }

        public object bestplay
        {
            get
            {
                return (object)Type.GetField("bestplay", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("bestplay", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 lethalMissing
        {
            get
            {
                return (System.Int32)Type.GetField("lethalMissing", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("lethalMissing", AllFlags).SetValue(Inst, value);
            }
        }

        public object mainTurnSimulator
        {
            get
            {
                return (object)Type.GetField("mainTurnSimulator", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("mainTurnSimulator", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemyTurnSim
        {
            get
            {
                return (object)Type.GetField("enemyTurnSim", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyTurnSim", AllFlags).SetValue(Inst, value);
            }
        }

        public object nextTurnSimulator
        {
            get
            {
                return (object)Type.GetField("nextTurnSimulator", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextTurnSimulator", AllFlags).SetValue(Inst, value);
            }
        }

        public object enemySecondTurnSim
        {
            get
            {
                return (object)Type.GetField("enemySecondTurnSim", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemySecondTurnSim", AllFlags).SetValue(Inst, value);
            }
        }

        public string currentCalculatedBoard
        {
            get
            {
                return (string)Type.GetField("currentCalculatedBoard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("currentCalculatedBoard", AllFlags).SetValue(Inst, value);
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

        public object posmoves
        {
            get
            {
                return (object)Type.GetField("posmoves", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("posmoves", AllFlags).SetValue(Inst, value);
            }
        }

        public object hp
        {
            get
            {
                return (object)Type.GetField("hp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("hp", AllFlags).SetValue(Inst, value);
            }
        }

        public object hm
        {
            get
            {
                return (object)Type.GetField("hm", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("hm", AllFlags).SetValue(Inst, value);
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

        public object bestmove
        {
            get
            {
                return (object)Type.GetField("bestmove", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("bestmove", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Single bestmoveValue
        {
            get
            {
                return (System.Single)Type.GetField("bestmoveValue", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("bestmoveValue", AllFlags).SetValue(Inst, value);
            }
        }

        public object nextMoveGuess
        {
            get
            {
                return (object)Type.GetField("nextMoveGuess", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextMoveGuess", AllFlags).SetValue(Inst, value);
            }
        }

        public object botBase
        {
            get
            {
                return (object)Type.GetField("botBase", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("botBase", AllFlags).SetValue(Inst, value);
            }
        }

        public object bestActions
        {
            get
            {
                return (object)Type.GetField("bestActions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("bestActions", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean secondturnsim
        {
            get
            {
                return (System.Boolean)Type.GetField("secondturnsim", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("secondturnsim", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean playaround
        {
            get
            {
                return (System.Boolean)Type.GetField("playaround", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playaround", AllFlags).SetValue(Inst, value);
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

        public void setMaxWide(System.Int32 mw)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("setMaxWide", AllFlags, null, sigs, null).Invoke(Inst, new object[] { mw });
        }

        public void setMaxDeep(System.Int32 mw)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("setMaxDeep", AllFlags, null, sigs, null).Invoke(Inst, new object[] { mw });
        }

        public void setMaxCal(System.Int32 mw)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("setMaxCal", AllFlags, null, sigs, null).Invoke(Inst, new object[] { mw });
        }

        public void setTwoTurnSimulation(System.Boolean stts, System.Int32 amount)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("setTwoTurnSimulation", AllFlags, null, sigs, null).Invoke(Inst, new object[] { stts, amount });
        }

        public void updateTwoTurnSim()
        {
            var sigs = new Type[0];
            Type.GetMethod("updateTwoTurnSim", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void setPlayAround()
        {
            var sigs = new Type[0];
            Type.GetMethod("setPlayAround", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void doallmoves(System.Boolean test, System.Boolean isLethalCheck)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("doallmoves", AllFlags, null, sigs, null).Invoke(Inst, new object[] { test, isLethalCheck });
        }

        public void doNextCalcedMove()
        {
            var sigs = new Type[0];
            Type.GetMethod("doNextCalcedMove", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void dosomethingclever(object bbase)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Behavior");
            Type.GetMethod("dosomethingclever", AllFlags, null, sigs, null).Invoke(Inst, new object[] { bbase });
        }

        public object autoTester(System.Boolean printstuff, string data, System.Int32 mode)
        {
            var sigs = new Type[3];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.String);
            sigs[2] = typeof(System.Int32);
            return (object)Type.GetMethod("autoTester", AllFlags, null, sigs, null).Invoke(Inst, new object[] { printstuff, data, mode });
        }

        public void simmulateWholeTurn(object bt)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.BoardTester");
            Type.GetMethod("simmulateWholeTurn", AllFlags, null, sigs, null).Invoke(Inst, new object[] { bt });
        }

        public void simmulateWholeTurnandPrint()
        {
            var sigs = new Type[0];
            Type.GetMethod("simmulateWholeTurnandPrint", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void updateEntitiy(System.Int32 old, System.Int32 newone)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Int32);
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("updateEntitiy", AllFlags, null, sigs, null).Invoke(Inst, new object[] { old, newone });
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
