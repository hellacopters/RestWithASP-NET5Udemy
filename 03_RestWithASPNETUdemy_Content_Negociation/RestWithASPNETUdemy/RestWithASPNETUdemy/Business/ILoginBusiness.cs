using RestWithASPNETUdemy.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidationCredentials(UserVO user);
        TokenVO ValidationCredentials(TokenVO token);
        bool RevokeToken(string userName);
    }
}
