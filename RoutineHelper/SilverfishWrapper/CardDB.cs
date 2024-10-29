using System;
using System.Reflection;

namespace SilverfishWrapper
{
    public class CardDB
    {
        public object Inst;
        public static Type Type;

        public CardDB(object inst)
        {
            this.Inst = inst;
        }
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public object cardlist
        {
            get
            {
                return (object)Type.GetField("cardlist", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardlist", AllFlags).SetValue(Inst, value);
            }
        }

        public object cardidToCardList
        {
            get
            {
                return (object)Type.GetField("cardidToCardList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardidToCardList", AllFlags).SetValue(Inst, value);
            }
        }

        public object carddbfidToCardList
        {
            get
            {
                return (object)Type.GetField("carddbfidToCardList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("carddbfidToCardList", AllFlags).SetValue(Inst, value);
            }
        }

        public object cardNameCNToCardList
        {
            get
            {
                return (object)Type.GetField("cardNameCNToCardList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardNameCNToCardList", AllFlags).SetValue(Inst, value);
            }
        }

        public object cardNameENToCardList
        {
            get
            {
                return (object)Type.GetField("cardNameENToCardList", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("cardNameENToCardList", AllFlags).SetValue(Inst, value);
            }
        }

        public object unknownCard
        {
            get
            {
                return (object)Type.GetField("unknownCard", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("unknownCard", AllFlags).SetValue(Inst, value);
            }
        }

        public System.Boolean installedWrong
        {
            get
            {
                return (System.Boolean)Type.GetField("installedWrong", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("installedWrong", AllFlags).SetValue(Inst, value);
            }
        }

        public object burlyrockjaw
        {
            get
            {
                return (object)Type.GetField("burlyrockjaw", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("burlyrockjaw", AllFlags).SetValue(Inst, value);
            }
        }

        public object treasurePools
        {
            get
            {
                return (object)Type.GetField("treasurePools", AllFlags).GetValue(Inst);
            }
            set
            {
                Type.GetField("treasurePools", AllFlags).SetValue(Inst, value);
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

        public object chnNameToCard(string chnName)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (object)Type.GetMethod("chnNameToCard", AllFlags, null, sigs, null).Invoke(Inst, new object[] { chnName });
        }

        public cardIDEnum cardIdstringToEnum(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (cardIDEnum)Type.GetMethod("cardIdstringToEnum", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public cardNameEN cardNameENstringToEnum(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (cardNameEN)Type.GetMethod("cardNameENstringToEnum", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public cardNameCN cardNameENstringToEnumCN(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (cardNameCN)Type.GetMethod("cardNameENstringToEnumCN", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public cardNameCN cardNameCNstringToEnum(string s)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (cardNameCN)Type.GetMethod("cardNameCNstringToEnum", AllFlags, null, sigs, null).Invoke(Inst, new object[] { s });
        }

        public object getCardData(cardNameEN cardname)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardNameEN");
            return (object)Type.GetMethod("getCardData", AllFlags, null, sigs, null).Invoke(Inst, new object[] { cardname });
        }

        public object getCardData(cardNameCN cardname)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardNameCN");
            return (object)Type.GetMethod("getCardData", AllFlags, null, sigs, null).Invoke(Inst, new object[] { cardname });
        }

        public object getCardDataFromID(cardIDEnum id)
        {
            var sigs = new Type[1];
            sigs[0] = Type.Assembly.GetType("HREngine.Bots.CardDB+cardIDEnum");
            return (object)Type.GetMethod("getCardDataFromID", AllFlags, null, sigs, null).Invoke(Inst, new object[] { id });
        }

        public object getCardDataFromDbfID(string dbfID)
        {
            var sigs = new Type[1];
            sigs[0] = typeof(System.String);
            return (object)Type.GetMethod("getCardDataFromDbfID", AllFlags, null, sigs, null).Invoke(Inst, new object[] { dbfID });
        }

        public void setAdditionalData()
        {
            var sigs = new Type[0];
            Type.GetMethod("setAdditionalData", AllFlags, null, sigs, null).Invoke(Inst, new object[] { });
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
