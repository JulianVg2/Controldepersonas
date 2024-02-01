using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controldepersonas
{
    internal class Persona
    {
        //Campos y Propiedades
        //Privados para cumplir
        //el encapsulados
        string dpi;
        string nombre;
        string apellido;
        DateTime FechaNacimiento;


        //Lo que hace es:
        //get : a = DPI
        //Set : DPI = "112212121"
        public String Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }


        //Propiedades

        //Metodos: Acciones que se realizan 
        //Cuanod no necesitamos devolver algo se usa void

        //Metodo contructor "ctor + TAB"
        // Este codigo se ejecuta al crearse un objeto de esta clase
        //Inicializamos las variables aqui en el constructor:
        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            // Inicializar con la fecha de hoy (la que esta registrada en el sistema)
            FechaNacimiento = DateTime.Now;


        }
        public void PrimerMayuscula()
        {
            if (nombre.Length > 0)
            {
                StringBuilder nombreMayuscula = new StringBuilder(nombre);
                nombreMayuscula[0] = Char.ToUpper(nombreMayuscula[0]);
                // el trim sirve para quitar espacios en blanco
                nombre = nombreMayuscula.ToString().Trim();



            }

            if (apellido.Length > 0)
            {

                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = Char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString().Trim();

            }


        }

        public int calcularedad()

        {
            //aque asignamos a esta variable la fecha de hoy 
            DateTime fecha_actual = DateTime.Now;

            //calcular edad
            //Calcular la edad en base a la fecha de nacimiento menos la actual
            int edad = fecha_actual.Year - FechaNacimiento1.Year;

            //si la fecha de nacimiento actual es mayor que la fecha actual menos la cantidad de años que se haya seleccionado se le restara 1 año
            if (FechaNacimiento1.Date > fecha_actual.AddYears(-edad))
            {
                edad--;

            }

            return edad;
        }

        public void normalizaNombre()
        {
           
            //Borra los espacios
            nombre = nombre.Trim();
            apellido = apellido.Trim();
            //Iniciamos un stringbuilder para recorrer toda la cadena para verificar si hay un caracter en ella
            // NOMBRE
            StringBuilder sincaracteres = new StringBuilder();
            for (int i = 0; i < nombre.Length; i++)
            {
                char cadena= nombre[i];
                //La funcion "char.IsLetter"
                if (char.IsLetter(cadena))
                {
                    //lo que hace aca es que si encuentra un caracter, lo borra y reescribe de nuevo la cadena 
                    sincaracteres.Append(cadena);
                    
                }

            }
            nombre = sincaracteres.ToString();

            //APELLIDO (LO MISMO)

            StringBuilder sincaracteresp = new StringBuilder();
            for (int i = 0; i < apellido.Length; i++)
            {
                char cadena1 = apellido[i];
               
                if (char.IsLetter(cadena1))
                {
                    
                    sincaracteresp.Append(cadena1);

                }

            }
            apellido = sincaracteresp.ToString();

            //Aplicar mayusculas y minusculas automaticas:
            // usamos la libreria "CultureInfo.CurrentCulture" que basicamente proporciona  informacion de una region, idioma, etc
            // "ToTitleCase(sincaracteres" lo que hace es tomar la cadena de arriba  y devuelve una nueva pero donde la primera letra es mayuscula.
            nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sincaracteres.ToString().ToLower());
            apellido = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sincaracteresp.ToString().ToLower());
        }

    }
}
