﻿using CotizacionesLJ.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CotizacionesLJ.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulo { get; set; }

        public Contexto() : base("ConStr")
        {
        }
    }
}
