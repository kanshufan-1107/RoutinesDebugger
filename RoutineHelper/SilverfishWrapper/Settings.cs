using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Settings
    {
        public object Inst;
        public static Type Type;

        public Settings(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public System.Int32 enfacehp
        {
            get
            {
                return (System.Int32)Type.GetField("enfacehp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enfacehp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 weaponOnlyAttackMobsUntilEnfacehp
        {
            get
            {
                return (System.Int32)Type.GetField("weaponOnlyAttackMobsUntilEnfacehp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("weaponOnlyAttackMobsUntilEnfacehp", AllFlags).SetValue(Inst, value);
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

        public System.Int32 playaroundprob
        {
            get
            {
                return (System.Int32)Type.GetField("playaroundprob", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("playaroundprob", AllFlags).SetValue(Inst, value);
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

        public System.Int32 twotsamount
        {
            get
            {
                return (System.Int32)Type.GetField("twotsamount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("twotsamount", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyTurnMaxWide
        {
            get
            {
                return (System.Int32)Type.GetField("enemyTurnMaxWide", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyTurnMaxWide", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 enemyTurnMaxWideSecondStep
        {
            get
            {
                return (System.Int32)Type.GetField("enemyTurnMaxWideSecondStep", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyTurnMaxWideSecondStep", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 nextTurnDeep
        {
            get
            {
                return (System.Int32)Type.GetField("nextTurnDeep", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextTurnDeep", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 nextTurnMaxWide
        {
            get
            {
                return (System.Int32)Type.GetField("nextTurnMaxWide", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextTurnMaxWide", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 nextTurnTotalBoards
        {
            get
            {
                return (System.Int32)Type.GetField("nextTurnTotalBoards", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("nextTurnTotalBoards", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 berserkIfCanFinishNextTour
        {
            get
            {
                return (System.Int32)Type.GetField("berserkIfCanFinishNextTour", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("berserkIfCanFinishNextTour", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 alpha
        {
            get
            {
                return (System.Int32)Type.GetField("alpha", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("alpha", AllFlags).SetValue(Inst, value);
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

        public System.Int32 placement
        {
            get
            {
                return (System.Int32)Type.GetField("placement", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("placement", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean useExternalProcess
        {
            get
            {
                return (System.Boolean)Type.GetField("useExternalProcess", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("useExternalProcess", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean passiveWaiting
        {
            get
            {
                return (System.Boolean)Type.GetField("passiveWaiting", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("passiveWaiting", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 speedupLevel
        {
            get
            {
                return (System.Int32)Type.GetField("speedupLevel", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("speedupLevel", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 adjustActions
        {
            get
            {
                return (System.Int32)Type.GetField("adjustActions", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("adjustActions", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 printRules
        {
            get
            {
                return (System.Int32)Type.GetField("printRules", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("printRules", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 concedeMode
        {
            get
            {
                return (System.Int32)Type.GetField("concedeMode", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("concedeMode", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Single firstweight
        {
            get
            {
                return (System.Single)Type.GetField("firstweight", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("firstweight", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Single secondweight
        {
            get
            {
                return (System.Single)Type.GetField("secondweight", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("secondweight", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 numberOfThreads
        {
            get
            {
                return (System.Int32)Type.GetField("numberOfThreads", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("numberOfThreads", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean simulateEnemysTurn
        {
            get
            {
                return (System.Boolean)Type.GetField("simulateEnemysTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("simulateEnemysTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 secondTurnAmount
        {
            get
            {
                return (System.Int32)Type.GetField("secondTurnAmount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("secondTurnAmount", AllFlags).SetValue(Inst, value);
            }
        }

        public string mainPath
        {
            get
            {
                return (string)Type.GetField("mainPath", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("mainPath", AllFlags).SetValue(Inst, value);
            }
        }

        public string path
        {
            get
            {
                return (string)Type.GetField("path", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("path", AllFlags).SetValue(Inst, value);
            }
        }

        public string logpath
        {
            get
            {
                return (string)Type.GetField("logpath", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("logpath", AllFlags).SetValue(Inst, value);
            }
        }

        public string logfile
        {
            get
            {
                return (string)Type.GetField("logfile", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("logfile", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean concede
        {
            get
            {
                return (System.Boolean)Type.GetField("concede", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("concede", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean enemyConcede
        {
            get
            {
                return (System.Boolean)Type.GetField("enemyConcede", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("enemyConcede", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean writeToSingleFile
        {
            get
            {
                return (System.Boolean)Type.GetField("writeToSingleFile", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("writeToSingleFile", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean learnmode
        {
            get
            {
                return (System.Boolean)Type.GetField("learnmode", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("learnmode", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean printlearnmode
        {
            get
            {
                return (System.Boolean)Type.GetField("printlearnmode", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("printlearnmode", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean test
        {
            get
            {
                return (System.Boolean)Type.GetField("test", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("test", AllFlags).SetValue(Inst, value);
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

        public void setSettings(string behavName, System.Boolean nameIsPath)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.String);
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("setSettings", AllFlags, null, sigs, null).Invoke(Inst, new object[] { behavName, nameIsPath });
        }

        public void endOfSetSettings()
        {
            var sigs = new Type[0];
            Type.GetMethod("endOfSetSettings", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void setWeights(System.Int32 alpha)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("setWeights", AllFlags, null, sigs, null).Invoke(Inst, new object[] { alpha });
        }

        public void setFilePath(string path)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            Type.GetMethod("setFilePath", AllFlags, null, sigs, null).Invoke(Inst, new object[] { path });
        }

        public void setLoggPath(string path)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            Type.GetMethod("setLoggPath", AllFlags, null, sigs, null).Invoke(Inst, new object[] { path });
        }

        public void setLoggFile(string path)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            Type.GetMethod("setLoggFile", AllFlags, null, sigs, null).Invoke(Inst, new object[] { path });
        }

        public void printSettings()
        {
            var sigs = new Type[0];
            Type.GetMethod("printSettings", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
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
