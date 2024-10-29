using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
using SilverfishWrapper;
using System.Reflection;

namespace RoutineHelper
{
    class PlayfieldSerializer
    {
        private static PlayfieldSerializer playfieldSerializer;
        public static PlayfieldSerializer Instance
        {
            get
            {
                if (playfieldSerializer == null)
                {
                    playfieldSerializer = new PlayfieldSerializer();
                }
                return playfieldSerializer;
            }

        }

        public List<string> SerializeObject(Object self, List<string> serialized)
        {
            List<string> temp = self.GetType()
                     .GetFields()
                     .Where(field => field.FieldType == typeof(bool) || field.FieldType == typeof(int) || field.FieldType == typeof(TAG_CLASS))
                     .Select(field => Convert.ToInt32(field.GetValue(self)).ToString())
                     .ToList();
            foreach (string item in temp)
            {
                serialized.Add(item);
            }
            if (self.GetType().Name == "Minion")
            {
                var m = new Minion(self);
                var hc = new Handcard(m.handcard);
                var card = new Card(hc.card);
                serialized.Add(((int)m.cardClass).ToString());
                if (hc.card != null && card.textCN.Length > 0)
                    serialized.Add(Regex.Replace(card.textCN, @"\t|\n|\r", ""));
                else
                    serialized.Add("空");
                if (hc.card != null)
                    serialized.Add(((int)card.race).ToString());
                else
                    serialized.Add("0");
            }
            if (self.GetType().Name == "Handcard")
            {
                var hc = new Handcard(self);
                var card = new Card(hc.card);
                if (hc.card != null && card.textCN.Length > 0)
                    serialized.Add(Regex.Replace(card.textCN, @"\t|\n|\r", ""));
                else
                    serialized.Add("空");
                if (hc.card != null)
                    serialized.Add(((int)card.race).ToString());
                else
                    serialized.Add("0");
            }
            return serialized;
        }

        public string SerializePlayfield(Playfield playfield)
        {
            List<string> serialized = new List<string>();
            /*
             * General Playfield Info
             */
            serialized = SerializeObject(playfield, serialized);
            /*
             * Own Info
             */
            serialized = SerializeObject(playfield.ownHero, serialized);
            serialized = SerializeObject(playfield.ownWeapon, serialized);
            serialized = SerializeObject(playfield.ownQuest, serialized);

            for (int i = 0; i < 7; i++) // Own Minions
            {
                if (i < playfield.ownMinions.ReflectionCall<int>("get_Count"))
                {
                    serialized = SerializeObject(playfield.ownMinions.ReflectionCall<object>("get_Item", i), serialized);
                }
                else
                {
                    serialized = SerializeObject(Activator.CreateInstance(MainWindow.compiledRoutines.GetType("HREngine.Bots.Minion")), serialized);
                }
            }
            var cardDb = new CardDB(CardDB.Instance);
            for (int i = 0; i < 5; i++) // Own Secrets
            {
                if (i < playfield.ownSecretsIDList.ReflectionCall<int>("get_Count"))
                {
                    serialized = SerializeObject(cardDb.getCardDataFromID(playfield.ownSecretsIDList.ReflectionCall<cardIDEnum>("get_Item", i)), serialized);
                }
                else
                {
                    serialized = SerializeObject(cardDb.unknownCard, serialized);
                }
            }

            /*
             * Enemy Info
             */
            serialized = SerializeObject(playfield.enemyHero, serialized);
            serialized = SerializeObject(playfield.enemyWeapon, serialized);
            serialized = SerializeObject(playfield.enemyQuest, serialized);

            for (int i = 0; i < 7; i++) // Enemy Minions
            {
                if (i < playfield.enemyMinions.ReflectionCall<int>("get_Count"))
                {
                    serialized = SerializeObject(playfield.enemyMinions.ReflectionCall<object>("get_Item", i), serialized);
                }
                else
                {
                    serialized = SerializeObject(Activator.CreateInstance(MainWindow.compiledRoutines.GetType("HREngine.Bots.Minion")), serialized);
                }
            }
            for (int i = 0; i < 5; i++) // Enemy Secrets
            {
                if (i < playfield.enemySecretList.ReflectionCall<int>("get_Count"))
                {
                    serialized = SerializeObject(playfield.enemySecretList.ReflectionCall<object>("get_Item", i), serialized);
                }
                else
                {
                    serialized = SerializeObject(Activator.CreateInstance(MainWindow.compiledRoutines.GetType("HREngine.Bots.SecretItem")), serialized);
                }
            }
            /*
             * Ourself only info
             */
            for (int i = 0; i < 10; i++) // Own Handcards
            {
                if (i < playfield.owncards.ReflectionCall<int>("get_Count"))
                {
                    serialized = SerializeObject(playfield.owncards.ReflectionCall<object>("get_Item", i), serialized);
                }
                else
                {
                    serialized = SerializeObject(Activator.CreateInstance(MainWindow.compiledRoutines.GetType("HREngine.Bots.Handmanager+Handcard")), serialized);
                }
            }
            for (int i = 0; i < 10; i++)    // Max 10 actions for now
            {
                if (i < playfield.playactions.ReflectionCall<int>("get_Count"))
                {
                    serialized.Add(((int)new SilverfishWrapper.Action(playfield.playactions.ReflectionCall<object>("get_Item", i)).actionType).ToString());
                }
                else
                {
                    serialized.Add("0");
                }
            }
            return String.Join(",", serialized);
        }
    }
}
