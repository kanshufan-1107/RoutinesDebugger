using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class SecretItem
    {
        public object Inst;
        public static Type Type;

        public SecretItem(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public System.Boolean triggered
        {
            get
            {
                return (System.Boolean)Type.GetField("triggered", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("triggered", AllFlags).SetValue(Inst, value);
            }
        }

        public object data
        {
            get
            {
                return (object)Type.GetField("data", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("data", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_snaketrap
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_snaketrap", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_snaketrap", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_snipe
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_snipe", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_snipe", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_explosive
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_explosive", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_explosive", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_beartrap
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_beartrap", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_beartrap", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_freezing
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_freezing", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_freezing", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_missdirection
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_missdirection", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_missdirection", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_darttrap
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_darttrap", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_darttrap", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_cattrick
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_cattrick", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_cattrick", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_counterspell
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_counterspell", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_counterspell", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_icebarrier
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_icebarrier", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_icebarrier", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_iceblock
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_iceblock", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_iceblock", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_mirrorentity
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_mirrorentity", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_mirrorentity", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_spellbender
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_spellbender", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_spellbender", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_vaporize
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_vaporize", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_vaporize", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_duplicate
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_duplicate", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_duplicate", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_effigy
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_effigy", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_effigy", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_flameward
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_flameward", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_flameward", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_explosiverunes
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_explosiverunes", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_explosiverunes", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_eyeforaneye
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_eyeforaneye", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_eyeforaneye", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_noblesacrifice
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_noblesacrifice", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_noblesacrifice", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_redemption
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_redemption", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_redemption", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_repentance
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_repentance", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_repentance", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_avenge
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_avenge", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_avenge", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean canBe_sacredtrial
        {
            get
            {
                return (System.Boolean)Type.GetField("canBe_sacredtrial", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("canBe_sacredtrial", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Int32 entityId
        {
            get
            {
                return (System.Int32)Type.GetField("entityId", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("entityId", AllFlags).SetValue(Inst, value);
            }
        }

        public static object dataToSecretItem(object ba)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Collections.BitArray);
            return (object)Type.GetMethod("dataToSecretItem", AllFlags, null, sigs, null).Invoke(null, new object[] { ba });
        }

        public static object secretItemToData(object si)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.SecretItem");
            return (object)Type.GetMethod("secretItemToData", AllFlags, null, sigs, null).Invoke(null, new object[] { si });
        }

        public void updateCanBeTriggered()
        {
            var sigs = new Type[0];
            Type.GetMethod("updateCanBeTriggered", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void usedTrigger_CharIsAttacked(System.Boolean DefenderIsHero, System.Boolean AttackerIsHero)
        {
            var sigs = new Type[2];
            sigs[0] = typeof(System.Boolean);
            sigs[1] = typeof(System.Boolean);
            Type.GetMethod("usedTrigger_CharIsAttacked", AllFlags, null, sigs, null).Invoke(Inst, new object[] { DefenderIsHero, AttackerIsHero });
        }

        public void usedTrigger_MinionIsPlayed(System.Int32 i)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Int32);
            Type.GetMethod("usedTrigger_MinionIsPlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { i });
        }

        public void usedTrigger_SpellIsPlayed(System.Boolean minionIsTarget)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("usedTrigger_SpellIsPlayed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { minionIsTarget });
        }

        public void usedTrigger_MinionDied()
        {
            var sigs = new Type[0];
            Type.GetMethod("usedTrigger_MinionDied", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public void usedTrigger_HeroGotDmg(System.Boolean deadly)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.Boolean);
            Type.GetMethod("usedTrigger_HeroGotDmg", AllFlags, null, sigs, null).Invoke(Inst, new object[] { deadly });
        }

        public void usedTrigger_HeroPowerUsed()
        {
            var sigs = new Type[0];
            Type.GetMethod("usedTrigger_HeroPowerUsed", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public string returnAString()
        {
            var sigs = new Type[0];
            return (string)Type.GetMethod("returnAString", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
        }

        public System.Boolean isEqual(object s)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.SecretItem");
            return (System.Boolean)Type.GetMethod("isEqual", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
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
