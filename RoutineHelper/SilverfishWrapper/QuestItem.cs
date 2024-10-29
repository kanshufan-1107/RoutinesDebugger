using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class QuestItem
    {
        public object Inst;
        public static Type Type;

        public QuestItem(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public object mobsTurn
        {
            get
            {
                return (object)Type.GetField("mobsTurn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("mobsTurn", AllFlags).SetValue(Inst, value);
            }
        }

        public cardIDEnum Id
        {
            get
            {
                return (cardIDEnum)Type.GetField("Id", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("Id", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 questProgress
        {
            get
            {
                return (System.Int32)Type.GetField("questProgress", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("questProgress", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 maxProgress
        {
            get
            {
                return (System.Int32)Type.GetField("maxProgress", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("maxProgress", AllFlags).SetValue(Inst, value);
            }
        }

        public void Copy(object q)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Questmanager+QuestItem");
            Type.GetMethod("Copy", AllFlags, null, sigs, null).Invoke(Inst, new object[] { q });
        }

        public void Reset()
        {
            var sigs = new Type[0];
            Type.GetMethod("Reset", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void trigger_MinionWasPlayed(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("trigger_MinionWasPlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void trigger_MinionWasSummoned(object m)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            Type.GetMethod("trigger_MinionWasSummoned", AllFlags, null, sigs, null).Invoke(Inst, new object[] { m });
        }

        public void trigger_SpellWasPlayed(object target, System.Int32 qId)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Minion");
            sigs[1] = typeof(System.Int32);
            Type.GetMethod("trigger_SpellWasPlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { target, qId });
        }

        public void trigger_WasDiscard(System.Int32 num)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("trigger_WasDiscard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { num });
        }

        public cardIDEnum Reward()
        {
            var sigs = new Type[0];
            return (cardIDEnum)Type.GetMethod("Reward", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
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
