/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 3, Ejercicio 3: anagrama
    Nombre de la alumna: Ada Nazcais Martin Morales
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
using Microsoft.AspNetCore.Mvc;
using anagrama.Entities;
using System;
using System.Linq;

namespace anagrama.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class letrasController:ControllerBase
     {
            [HttpPost]
        public string analizarPalabras (letras letra)

        {
            string Pl1 = "Si es un anagrama";
            string Pl2 = "No es un anagrama";
            string Plf1 = String.Concat(palabra.Palabranew.OrderBy(c=>c));
            string plf2= String.Concat(palabra.Palabra2.OrderBy(c=>c));

            if (plf1 == plf2)

            {

                return Pl1;

            }

            else

            {

                return Pl2;

            }

        }

    }

}
