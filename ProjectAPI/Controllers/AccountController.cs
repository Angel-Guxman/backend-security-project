using Application.Contracts.IRepositories;
using Application.DTOs.Request.Account;
using Application.DTOs.Response.Account;
using Application.Extensions;
using Application.DTOs.Response.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Security.Claims;

namespace ProjectAPI.Controllers
{
    public class AccountController(IAccountRepository account) : ControllerBase
    {




       

        public class UserDTO
        {
            public string Id { get; set; }
            public string FullName { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
        }



        [Authorize]
        [HttpGet("user-info")]
        public ActionResult<UserClaimsDTO> GetUserInfo()
        {

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var fullName = User.FindFirst("Fullname")?.Value;
            var userName = User.FindFirst("Name")?.Value;
            var email = User.FindFirst("Email")?.Value;
            var role = User.FindFirst("Role")?.Value;
            var user = new UserDTO
            {
                Id = userId,
                FullName = fullName,
                UserName = userName,
                Email = email,
                Role = role
            };
            return Ok(user);
        }



        [HttpPost("identity/create")]
        public async Task<ActionResult<GeneralResponse>> CreateAccount(CreateAccountDTO model)
        {

            if (!ModelState.IsValid) return BadRequest("Model cannot be null");
            model.Role = Constant.Role.User;
            var result = await account.CreateAccountAsync(model);
            if (!result.Flag) return BadRequest(result.Flag);
            return Ok(result);
        }
        [HttpPost("identity/createDash")]
        public async Task<ActionResult<GeneralResponse>> CreateAccountDash(CreateAccountDTO model)
        {

            if (!ModelState.IsValid) return BadRequest("Model cannot be null");

            var result = await account.CreateAccountAsync(model);
            if (!result.Flag) return BadRequest(result.Flag);
            return Ok(result);
        }
        [HttpPost("identity/login")]
        public async Task<ActionResult<GeneralResponse>> LoginAccount(LoginDTO model)
        {
            if (!ModelState.IsValid) return BadRequest("Model cannot be null");
            var result = await account.LoginAccountAsync(model);
            if (!result.Flag) return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpPost("identity/refresh-token")]
        public async Task<ActionResult<GeneralResponse>> RefreshToken(RefreshTokenDTO model)
        {
            if (!ModelState.IsValid) return BadRequest("Model cannot be null");
            var result = await account.RefreshTokenAsync(model);
            if (!result.Flag) return BadRequest(result.Message);
            return Ok(result);

        }
        [HttpPost("identity/role/create")]
        public async Task<ActionResult<GeneralResponse>> CreateRole(CreateRoleDTO model)
        {
            if (!ModelState.IsValid) return BadRequest("Model cannot be null");
            var result = await account.CreateRoleAsync(model);
            if (!result.Flag) return BadRequest(result.Flag);
            return Ok(result);

        }
        [HttpGet("identity/role/list")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GetRoleDTO>>> GetRoles() => Ok(await account.GetRolesAsync());

        [HttpPost("/setting")]
        public async Task<ActionResult<GeneralResponse>> CreateAdmin()
        {
            var (flag, message) = await account.CreateAdmin();
            if (!flag) return BadRequest(message);

            return Ok(message);
        }

        [HttpGet("identity/users-with-roles")]
        public async Task<ActionResult<IEnumerable<GetUsersWithRolesResponseDTO>>> GetUserWithRoles() => Ok(await account.GetUsersWithRolesAsync());

        [HttpPost("identity/change-role")]
        public async Task<ActionResult<GeneralResponse>> ChangeUserRole(ChangeUserRoleRequestDTO model)
        {

            var result = await account.ChangeUserRoleAsync(model);
            if (!result.Flag) return BadRequest(result.Message);
            return Ok(result);
        }

    }
}
