namespace SecurityDoor.Models
{
    public interface IPinCodeUI
    {
        int RequestPinCode();

        bool IsValid(int code);
    }
}