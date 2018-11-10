﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.RapiAuto
{
    public class VehiculosBL
    {
        Contexto _contexto;
        public BindingList<Vehiculo> ListaVehiculos { get; set; }

        public VehiculosBL()
        {
            _contexto = new Contexto();
            ListaVehiculos = new BindingList<Vehiculo>();

        }
        public BindingList<Vehiculo> ObtenerVehiculos()
        {
            _contexto.Vehiculos.Load();
            ListaVehiculos = _contexto.Vehiculos.Local.ToBindingList();
            return ListaVehiculos;
        }
        public Resultado GuardarVehiculo(Vehiculo vehiculo)
        {
            var resultado = Validar(vehiculo);
            if (resultado.Exitoso==false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarVehiculo()
        {
            var nuevoVehiculo = new Vehiculo();
            ListaVehiculos.Add(nuevoVehiculo);
        }
        public bool EliminarVehiculo(int id)
        {
            foreach (var vehiculo in ListaVehiculos)
            {
                if (vehiculo.Id == id)
                {
                    ListaVehiculos.Remove(vehiculo);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        private Resultado Validar(Vehiculo vehiculo)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(vehiculo.Marca) == true)
            {
                resultado.Mensaje = "Ingrese una marca";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(vehiculo.Modelo) == true)
            {
                resultado.Mensaje = "Ingrese un modelo";
                resultado.Exitoso = false;
            }
            if (vehiculo.Año < 0)
            {
                resultado.Mensaje = "Ingrese un año";
                resultado.Exitoso = false;
            }

            if (vehiculo.Kilometraje < 0)
            {
                resultado.Mensaje = "El kilometraje debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (vehiculo.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(vehiculo.Cilindraje) == true)
            {
                resultado.Mensaje = "Ingrese un Cilindraje";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public double Precio { get; set; }
        public int Kilometraje { get; set; }
        public string Cilindraje { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
