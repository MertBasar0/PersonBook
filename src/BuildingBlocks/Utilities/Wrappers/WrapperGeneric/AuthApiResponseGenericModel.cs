using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Wrappers.WrapperGeneric
{
    public class AuthApiResponseGenericModel<T>
    {
        public T? Data { get; set; }

        public HttpStatusCode HttpStatusCode { get; set; }

        public string? ErrorMessage { get; set; }

        public bool Success { get; set; }

        public AuthApiResponseGenericModel() //Buradaki boş constructure'ın kaldırıl kaldırılmayacağına sonra karar verilecek. Kullanım mantığıyla alakalı deneyime ihtiyaç var.
        {
            
        }

        public AuthApiResponseGenericModel(T? data, HttpStatusCode httpStatusCode, string? errorMessage)
        {
            Data = data;
            HttpStatusCode = httpStatusCode;
            ErrorMessage = errorMessage;


            if(HttpStatusCode != HttpStatusCode.OK) { Success = false; }
        }
    }
}
