namespace SecurityDoor.Models
{
    public interface IKeyCardUI
    {
        string RequestKeyCard();

        bool IsValid(string code);
    }
}