public class Card
{
    public enum Suit
    {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum FaceValue
    {
        ACE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5,
        SIX = 6,
        SEVEN = 7,
        EIGHT = 8,
        NINE = 9,
        TEN = 10,
        JACK = 10,
        QUEEN = 10,
        KING = 10
    }

    public Suit suit;
    public FaceValue faceValue;

    public Card(Suit suit, FaceValue faceValue)
    {
        this.suit = suit;
        this.faceValue = faceValue;
    }

    public string GetFaceValueString()
    {
        if (this.faceValue == FaceValue.JACK)
            return "JACK";
        else if (this.faceValue == FaceValue.QUEEN)
            return "QUEEN";
        else if (this.faceValue == FaceValue.KING)
            return "KING";
        else
            return this.faceValue.ToString();
    }

    public override string ToString()
    {
        return $"{GetFaceValueString()} of {this.suit} (waarde: {this.faceValue})";
    }
}
