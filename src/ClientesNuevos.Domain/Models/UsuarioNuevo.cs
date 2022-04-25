﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesNuevos.Domain.Models
{
    public class UsuarioNuevo
    {
        public String IdAbogado { get; set; }

        public string CodigoFactura { get; set; }

        public string SubTotalFactura { get; set; }

        public DateTime FechaCreacionFactura { get; set; }

        public UsuarioNuevo(string idAbogado, string codigoFactura, string subTotalFactura, DateTime fechaCreacionFactura)
        {
            IdAbogado = idAbogado;
            CodigoFactura = codigoFactura;
            SubTotalFactura = subTotalFactura;
            FechaCreacionFactura = fechaCreacionFactura;
        }

        public UsuarioNuevo()
        {
        }
    }
}
