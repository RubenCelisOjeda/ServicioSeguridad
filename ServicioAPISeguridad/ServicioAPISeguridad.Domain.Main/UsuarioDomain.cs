﻿using ServicioAPISeguridad.Application.Dto;
using ServicioAPISeguridad.Domain.Entities.Auth;
using ServicioAPISeguridad.Domain.Entities.Sesion;
using ServicioAPISeguridad.Domain.Entities.Usuario;
using ServicioAPISeguridad.Domain.Interfaces;
using ServicioAPISeguridad.Infraestructure.Interfaces;

namespace ServicioAPISeguridad.Domain.Main
{
    public class UsuarioDomain : IUsuarioDomain
    {
        private readonly IUsuarioRepository _usuarioRepository;


        public UsuarioDomain(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void GuardarSesion(SesionUsuarioEntities pSesionUsuario)
        {
            _usuarioRepository.GuardarSesion(pSesionUsuario);
        }

        public UserResponseEntities Login(AuthRequestEntities authRequestEntities)
        {
            return _usuarioRepository.Login(authRequestEntities);
        }

        public void UserRegister(UserRegisterDto pUserRegisterDto)
        {
            _usuarioRepository.UserRegister(pUserRegisterDto);
        }
 
        public bool ValidateByUser(string pUser)
        {
            return _usuarioRepository.ValidateByUser(pUser);
        }

        public bool ValidateByEmail(string pEmail)
        {
            return _usuarioRepository.ValidateByEmail(pEmail);
        }
    }
}
