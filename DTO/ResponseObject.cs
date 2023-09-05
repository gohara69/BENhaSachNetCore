namespace NhaSachDotNet.DTO
{
    public class ResponseObject<T>
    {
        private int _status { get; set; }
        private string _message { get; set; }
        private T _data { get; set; }

        public ResponseObject(int status, string message, T data)
        {
            _status = status;
            _message = message;
            _data = data;
        }
    }
}
