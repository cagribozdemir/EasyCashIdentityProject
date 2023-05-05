﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
	public class AppUserRegisterDto
	{
		//[Required(ErrorMessage ="Ad Alanı Zorunludur")]
		//[Display(Name ="İsim:")]
		//[MaxLength(50,ErrorMessage ="Maksimum 50 Karakter İçermelidir")]
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
        public string Username { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
    }
}
