using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SilverfishWrapper;

namespace RoutineHelper
{
	internal static class VarInt
	{
		public static byte[] GetBytes(ulong value)
		{
			using (var ms = new MemoryStream())
			{
				while (value != 0)
				{
					var b = value & 0x7f;
					value >>= 7;
					if (value != 0)
						b |= 0x80;
					ms.WriteByte((byte)b);
				}
				return ms.ToArray();
			}
		}

		public static ulong ReadNext(byte[] bytes, out int length)
		{
			length = 0;
			ulong result = 0;
			foreach (var b in bytes)
			{
				var value = (ulong)b & 0x7f;
				result |= value << length * 7;
				if ((b & 0x80) != 0x80)
					break;
				length++;
			}
			length++;
			return result;
		}

	}
	public class DeckHelper
	{
		/// <summary>
		/// Deserializes a given deckstring into a deck object
		/// </summary>
		/// <exception cref="ArgumentException"></exception>
		/// <param name="input">Deckstring to be deserialized</param>
		/// <returns>Deserialized deck object</returns>
		public static List<Card> Deserialize(string input)
		{
			List<Card> deck = null;
			var lines = input.Split('\n').Select(x => x.Trim());
			string deckName = null;
			string deckId = null;
			foreach (var line in lines)
			{
				if (string.IsNullOrEmpty(line))
					continue;
				if (line.StartsWith("#"))
				{
					if (line.StartsWith("###"))
						deckName = line.Substring(3).Trim();
					if (line.StartsWith("# Deck ID:"))
						deckId = line.Substring(10).Trim();
					continue;
				}
				if (deck == null)
					deck = DeserializeDeckString(line);
			}
			return deck;
		}

		private static List<Card> DeserializeDeckString(string deckString)
		{
			var deck = new List<Card>();
			byte[] bytes;
			try
			{
				bytes = Convert.FromBase64String(deckString);
			}
			catch (Exception e)
			{
				throw new ArgumentException("Input is not a valid deck string.", e);
			}
			var offset = 0;
			ulong Read()
			{
				if (offset > bytes.Length)
					throw new ArgumentException("Input is not a valid deck string.");
				var value = VarInt.ReadNext(bytes.Skip(offset).ToArray(), out var length);
				offset += length;
				return value;
			}

			//Zero byte
			offset++;

			//Version - always 1
			Read();

			Read(); // Format Type

			//Num Heroes - always 1
			Read();

			Read(); // Hero ID

			void AddCard(int? dbfId = null, int count = 1)
			{
				dbfId = dbfId ?? (int)Read();
				var cardDb = new CardDB(CardDB.Instance);
				Card card = new Card(cardDb.getCardDataFromDbfID(dbfId.ToString()));
				card.count = count;
				deck.Add(card);
			}

			var numSingleCards = (int)Read();
			for (var i = 0; i < numSingleCards; i++)
				AddCard();

			var numDoubleCards = (int)Read();
			for (var i = 0; i < numDoubleCards; i++)
				AddCard(count: 2);

			var numMultiCards = (int)Read();
			for (var i = 0; i < numMultiCards; i++)
			{
				var dbfId = (int)Read();
				var count = (int)Read();
				AddCard(dbfId, count);
			}
			return deck;
		}

		private static string TitleCase(string str)
		{
			if (string.IsNullOrEmpty(str))
				return string.Empty;
			if (str.Length == 1)
				return str.ToUpperInvariant();
			return str.Substring(0, 1).ToUpperInvariant() + str.Substring(1, str.Length - 1).ToLowerInvariant();
		}
	}
}
