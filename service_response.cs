using System;

public class service_response
{
	public service_response()
	{

        public bool Success { get; set; } = true

        public Object Data { get; set; } = null

        public string msg { get; set; } = 'Thanhf coong'
        public enum SubCode { get; set; } = SubCode.Success
        public enum SubCode : int
        {
            Success = 200;
            Unauthorized = 401;
            Server = 500;
        }
    }
}
