namespace BackEndClassOne.Common
{
    public class RequestResponse<T>
    {
        public bool IsSuccesful { get; set; }
        public bool IsError { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }

        public RequestResponse<T> CreateSuccesful(T? result)
        {
            IsSuccesful = true;
            IsError = false;
            Result = result;
            return this;
        }

        public RequestResponse<T> CreateSuccesful(T? result, string message)
        {
            IsSuccesful = true;
            IsError = false;
            Message = message;
            Result = result;
            return this;
        }

        public RequestResponse<T> CreateUnSuccesful(string message)
        {
            Message = message;
            return this;
        } 

        public RequestResponse<T> CreateError(string error)
        {
            IsError = true;
            IsSuccesful = false;
            Message = error;
            return this;
        }
    }
}
