using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Action
    {
        public object Inst;
        public static Type Type;

        public Action(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public actionEnum actionType
        {
            get
            {
                return (actionEnum)Type.GetField("actionType", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("actionType", AllFlags).SetValue(Inst, value);
            }
        }

        public object card
        {
            get
            {
                return (object)Type.GetField("card", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("card", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 place
        {
            get
            {
                return (System.Int32)Type.GetField("place", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("place", AllFlags).SetValue(Inst, value);
            }
        }

        public object own
        {
            get
            {
                return (object)Type.GetField("own", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("own", AllFlags).SetValue(Inst, value);
            }
        }

        public object target
        {
            get
            {
                return (object)Type.GetField("target", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("target", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 druidchoice
        {
            get
            {
                return (System.Int32)Type.GetField("druidchoice", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("druidchoice", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 penalty
        {
            get
            {
                return (System.Int32)Type.GetField("penalty", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("penalty", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 turn
        {
            get
            {
                return (System.Int32)Type.GetField("turn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("turn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 prevHpOwn
        {
            get
            {
                return (System.Int32)Type.GetField("prevHpOwn", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("prevHpOwn", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 prevHpTarget
        {
            get
            {
                return (System.Int32)Type.GetField("prevHpTarget", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("prevHpTarget", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 titanAbilityNO
        {
            get
            {
                return (System.Int32)Type.GetField("titanAbilityNO", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("titanAbilityNO", AllFlags).SetValue(Inst, value);
            }
        }

        public void print(System.Boolean tobuffer)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("print", AllFlags, null, sigs, null).Invoke(Inst, new object[] { tobuffer });
        }

        public string GetActionString()
        {
            var sigs = new Type[0];
            return (string)Type.GetMethod("GetActionString", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public string printString()
        {
            var sigs = new Type[0];
            return (string)Type.GetMethod("printString", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
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
