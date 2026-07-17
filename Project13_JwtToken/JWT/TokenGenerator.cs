using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project13_JwtToken.JWT
{
    public class TokenGenerator
    {
        public string GenerateJwtToken(string Username, string Email, string name,string surname)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20derste20ProjeToken+-*/1234tokenJWT")); //token için oluşturdugumuz imza gibi düşünülebilir
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);//security'keyimi ve token oluştururken kullanıcagım şifreleme algoritması
            var claimsExample = new[]//Tokenin temel paramatrelerini tutuyor
            {
                new Claim(JwtRegisteredClaimNames.Sub,Username),//ıd
                new Claim(JwtRegisteredClaimNames.Email,Email),//email   
                new Claim(JwtRegisteredClaimNames.GivenName,name),
                new Claim(JwtRegisteredClaimNames.FamilyName,surname),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())//oluşturulan deger
            };
            var token = new JwtSecurityToken(
                issuer: "localhost",//tokenin yayıncısı(kim tarafından oluşturuldugu)
                audience:"localhost",//tokenin Dinleyicisi(kim dinliyor)
                claims:claimsExample,//tokenin parametreleri nerden geliyo
                expires:DateTime.Now.AddMinutes(5),//Token ne zamana kadar gecerli
                signingCredentials:credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);//Tokeni oluşturuyorsun
        
        }
    }
}
