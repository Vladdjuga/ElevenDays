using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ElevenDays_Service.DTOS
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PasswordHash { get; set; }
    }
}
