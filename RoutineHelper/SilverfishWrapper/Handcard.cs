using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class Handcard
    {
        public object Inst;
        public static Type Type;

        public Handcard(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public System.Int32 position
        {
            get
            {
                return (System.Int32)Type.GetField("position", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("position", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 entity
        {
            get
            {
                return (System.Int32)Type.GetField("entity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("entity", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 manacost
        {
            get
            {
                return (System.Int32)Type.GetField("manacost", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("manacost", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 addattack
        {
            get
            {
                return (System.Int32)Type.GetField("addattack", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("addattack", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 addHp
        {
            get
            {
                return (System.Int32)Type.GetField("addHp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("addHp", AllFlags).SetValue(Inst, value);
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

        public System.Int32 poweredUp
        {
            get
            {
                return (System.Int32)Type.GetField("poweredUp", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("poweredUp", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 darkmoon_num
        {
            get
            {
                return (System.Int32)Type.GetField("darkmoon_num", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("darkmoon_num", AllFlags).SetValue(Inst, value);
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

        public System.Boolean extraParam3
        {
            get
            {
                return (System.Boolean)Type.GetField("extraParam3", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("extraParam3", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 SCRIPT_DATA_NUM_1
        {
            get
            {
                return (System.Int32)Type.GetField("SCRIPT_DATA_NUM_1", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("SCRIPT_DATA_NUM_1", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 TAG_ONE_TURN_EFFECT
        {
            get
            {
                return (System.Int32)Type.GetField("TAG_ONE_TURN_EFFECT", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("TAG_ONE_TURN_EFFECT", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 LUNAHIGHLIGHTHINT
        {
            get
            {
                return (System.Int32)Type.GetField("LUNAHIGHLIGHTHINT", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("LUNAHIGHLIGHTHINT", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 scheme
        {
            get
            {
                return (System.Int32)Type.GetField("scheme", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("scheme", AllFlags).SetValue(Inst, value);
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

        public System.Boolean discovered
        {
            get
            {
                return (System.Boolean)Type.GetField("discovered", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("discovered", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean temporary
        {
            get
            {
                return (System.Boolean)Type.GetField("temporary", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("temporary", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 conditionalCount
        {
            get
            {
                return (System.Int32)Type.GetField("conditionalCount", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("conditionalCount", AllFlags).SetValue(Inst, value);
            }
        }

        public object conditionalList
        {
            get
            {
                return (object)Type.GetField("conditionalList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("conditionalList", AllFlags).SetValue(Inst, value);
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

        public void setHCtoHC(object hc)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Handmanager+Handcard");
            Type.GetMethod("setHCtoHC", AllFlags, null, sigs, null).Invoke(Inst, new object[] { hc });
        }

        public System.Int32 getManaCost(object p)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            return (System.Int32)Type.GetMethod("getManaCost", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p });
        }

        public System.Boolean canplayCard(object p, System.Boolean own)
        {
            var sigs = new Type[2];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.Playfield");
            sigs[1] = typeof(System.Boolean);
            return (System.Boolean)Type.GetMethod("canplayCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { p, own });
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
