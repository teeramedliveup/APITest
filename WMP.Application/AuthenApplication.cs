using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMP.ViewModels;
using WMP.Data.Repositories;
using WMP.Models;

namespace WMP.Application
{
    public class AuthenApplication
    {
        public VMResponse GetUserSignIn(VMSignIn param)
        {
            VMResponse result = new VMResponse();
            try
            {
                UsersRepository userRepo = new UsersRepository();
                users res = userRepo.Signin(username: param.username, password: param.password);
                if(res != null)
                {
                    result.is_success = true;
                    result.message = string.Empty;
                    result.result = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJkODZlYTM4OTJhY2E4ZTU4Y2EwNjJmODllODM1YjAyYSIsInVzZXJuYW1lIjoiYWRtaW4iLCJ1c2VyX3JvbGVzIjoiW1wiTVE9PVwiXSIsImFkZGl0aW9uYWwiOiJ7XCJVc2VyRW50aXR5XCI6XCJNUT09XCIsXCJFbXBGdWxsTmFtZVRIXCI6XCJBZG1pblwiLFwiRW1wRnVsbE5hbWVFTlwiOlwiQWRtaW5cIn0iLCJuYmYiOjE1NTM4NDk2MzUsImV4cCI6MTU1Mzg1MzIzNSwiaXNzIjoiTGl2ZXVwLldNUC5XZWIiLCJhdWQiOiJMaXZldXAuV01QLlVzZXIifQ.CYizHRAcejfTUQGAZOmPUcPfNIHE4kBxl9Es-WCTZd8";
                }
                else
                {
                    result.message = "User not found.";
                }
            }catch(Exception ex)
            {
                result.message = ex.Message;
            }
            return result;
        }
    }
}
