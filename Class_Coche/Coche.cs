﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Coche
{
    public class Coche{
        public String marca { get; set; }
        public String modelo { get; set; }
        public String color { get; set; }
        public String matricula { get; set; }
        public int numeroPuertas { get; set; }
        public int numeroHp { get; set; }
        public Boolean estado { get; set; }
        public int velocidad = 0;

        public Coche(String marca,  String modelo, String color, String matricula, int numeroPuertas, int numeroHp)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color; 
            this.matricula = matricula;
            this.numeroPuertas = numeroPuertas;
            this.numeroHp = numeroHp;
            this.estado = false; // el estado constructor inicializamos parado.
        }

        public bool avanzar() {

            if (estado) {
                return true;
            }
            else {
                estado = true;
                return false; 
            }
        }
        public void acelerar( int km) { 
            if (estado)
            {
                this.velocidad = this.velocidad + km;

            }
        }
        public void detener() { 
        }
        public void cambiarColor() {
            this.color = color;
        }

        public bool pintar() {

            try {
                this.color = color;
                return true;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                return false;
            }
        }
    }
}
