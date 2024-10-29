using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Playfield.cs", CodeGen.Generate(typeof(HREngine.Bots.Playfield)));
            File.WriteAllText("Action.cs", CodeGen.Generate(typeof(HREngine.Bots.Action)));
            File.WriteAllText("CardDB.cs", CodeGen.Generate(typeof(HREngine.Bots.CardDB)));
            File.WriteAllText("Card.cs", CodeGen.Generate(typeof(HREngine.Bots.CardDB.Card)));
            File.WriteAllText("Minion.cs", CodeGen.Generate(typeof(HREngine.Bots.Minion)));
            File.WriteAllText("Handcard.cs", CodeGen.Generate(typeof(HREngine.Bots.Handmanager.Handcard)));
            File.WriteAllText("SecretItem.cs", CodeGen.Generate(typeof(HREngine.Bots.SecretItem)));
            File.WriteAllText("QuestItem.cs", CodeGen.Generate(typeof(HREngine.Bots.Questmanager.QuestItem)));
            File.WriteAllText("Hrtprozis.cs", CodeGen.Generate(typeof(HREngine.Bots.Hrtprozis)));
            File.WriteAllText("Settings.cs", CodeGen.Generate(typeof(HREngine.Bots.Settings)));
            File.WriteAllText("Ai.cs", CodeGen.Generate(typeof(HREngine.Bots.Ai)));
            File.WriteAllText("TestBase.cs", CodeGen.Generate(typeof(HREngine.Bots.TestBase)));
        }
    }
}
