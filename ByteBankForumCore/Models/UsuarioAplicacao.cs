using Microsoft.AspNetCore.Identity;

namespace ByteBankForumCore.Models
{
    public class UsuarioAplicacao : IdentityUser
    {

        public string NomeCompleto { get; set; }
        public UsuarioAplicacao()
        {
        }
    }
}
