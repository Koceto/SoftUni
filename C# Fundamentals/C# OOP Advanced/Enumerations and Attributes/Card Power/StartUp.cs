using System;
using System.Linq;

public class StartUp
{
    private static Deck deck = new Deck();

    public static void Main()
    {
        Player first = new Player(Console.ReadLine());
        Player second = new Player(Console.ReadLine());

        GetPlayerCards(first);
        GetPlayerCards(second);

        if (first.StrongestCard.CompareTo(second.StrongestCard) > 0)
        {
            PrintPlayer(first);
        }
        else if (first.StrongestCard.CompareTo(second.StrongestCard) < 0)
        {
            PrintPlayer(second);
        }
    }

    private static void GetPlayerCards(Player player)
    {
        while (player.Cards.Count < 5)
        {
            string[] cardInfo = Console.ReadLine().Split(' ');

            try
            {
                Card card = GetCard(cardInfo);

                if (!IsCardInDeck(card))
                {
                    player.Add(card);
                    deck.Add(card);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }

    private static bool IsCardInDeck(Card card)
    {
        if (deck.Cards.Any(c => c.CompareTo(card) == 0))
        {
            throw new ArgumentException("Card is not in the deck.");
        }

        return false;
    }

    private static Card GetCard(string[] cardInfo)
    {
        Card card = null;

        try
        {
            var rank = Enum.Parse(typeof(CardRanks), cardInfo[0]).ToString();
            var suit = Enum.Parse(typeof(CardSuits), cardInfo[2]).ToString();

            card = new Card(rank, suit);
        }
        catch (ArgumentException)
        {
            throw new ArgumentException("No such card exists.");
        }

        return card;
    }

    private static void PrintPlayer(Player player)
    {
        Console.WriteLine($"{player.Name} wins with {player.StrongestCard.Rank} of {player.StrongestCard.Suit}.");
    }
}