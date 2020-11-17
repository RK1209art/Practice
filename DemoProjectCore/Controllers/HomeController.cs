using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoProjectCore.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoProjectCore.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginViewModel userLoginViewModel)
        {
            return View();
        }
        public ActionResult UserRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegistration(UserIdentityViewModel userIdentityViewModel)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Insert into dbo.UserIdentity(User_Name,EmailId,Phone_No,Address,IsActive,CreatedBy,CreatedDateTime,PassWord) Values(@name,@email,@Ph,@Add,@IsA,@CB,@CDT,@Pass)", con);
            cmd.Parameters.Add(new SqlParameter("@name", userIdentityViewModel.User_Name));
            cmd.Parameters.Add(new SqlParameter("@email", userIdentityViewModel.EmailId));
            cmd.Parameters.Add(new SqlParameter("@Ph", userIdentityViewModel.Phone_No));
            cmd.Parameters.Add(new SqlParameter("@Add", userIdentityViewModel.Address)); 
            cmd.Parameters.Add(new SqlParameter("@IsA", userIdentityViewModel.IsActive = true));
            cmd.Parameters.Add(new SqlParameter("@CB", userIdentityViewModel.CreatedBy = 1));
            cmd.Parameters.Add(new SqlParameter("@CDT", userIdentityViewModel.CreatedDateTime = DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@Pass", userIdentityViewModel.Password));
            
            if(userIdentityViewModel.Password == userIdentityViewModel.Confirm_Password)
            {
                con.Open();
                int noOfRowAffected = cmd.ExecuteNonQuery();
                con.Close();
                if (noOfRowAffected > 0)
                {
                    ViewBag.Success = "Registration Successful";
                    return View();
                }
                else
                {
                    ViewBag.Warning = "Try again";
                    return View();
                }
            }
            else
            {
                ViewBag.Warning = "Please check your Password again";
                return View();
            }
        }
    }
}