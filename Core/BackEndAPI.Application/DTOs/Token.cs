using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.DTOs
{
    public class Token
    {
       public string AccessToken { get; set; } = string.Empty;
       public  DateTime Expiration { get; set; }
    }
}
