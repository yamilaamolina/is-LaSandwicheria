﻿using La_Sandwicheria.Modelo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Sandwicheria.Interfaces
{
    public interface INuevaVenta
    {
        void ColocarVentaAct(Venta venta);
        void CargarLineasDeVenta(List<LineaDeVenta> lineasDeVenta);
        void CerrarVenta();
    }
}
