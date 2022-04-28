﻿using ClientesNuevos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNuevos.Domain.Services
{
    interface IUsuarioNuevoService
    {
        public List<UsuarioNuevo> ConsultaClientesNuevos();

        public List<UsuarioNuevo> ConsultaClientesNuevosFecha(DateTime FechaMin, DateTime FechaMax);

        public bool ClienteNuevoRangoFecha(DateTime FechaCreacion, DateTime fechaMin, DateTime fechaMax);

        public List<UsuarioNuevo> UsuariosNuevosRegistrar(List<UsuarioNuevo> usuariosNuevos);

        public Boolean UsuariosNuevosARegistrar(UsuarioNuevo usuarioNuevos);
    }
}
