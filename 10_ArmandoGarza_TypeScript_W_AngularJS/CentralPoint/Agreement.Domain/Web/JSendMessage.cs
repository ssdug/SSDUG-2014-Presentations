namespace Agreement.Domain.Web
{
    public enum JSendMessageType
    {
        Info,
        Alert,
        Warning,
        Error
    }

    public class JSendMessage
    {
        public string MessageType { get; set; }
        public string Message { get; set; }

        public JSendMessage()
        {
        }

        public JSendMessage(string message)
        {
            MessageType = "info";
            Message = message;
        }

        public JSendMessage(JSendMessageType messageType, string message)
        {
            MessageType = messageType.ToString().ToLower();
            Message = message;
        }
    }
}
