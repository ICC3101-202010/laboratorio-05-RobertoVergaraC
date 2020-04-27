using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5Robertovergara
{
    public class User
    {
        //1.- Definir el delegate
        public delegate void VerifiedEmailEventHandler(object source, EventArgs args);
        //2.- Definir el evento basado en el delegate anterior
        public event VerifiedEmailEventHandler EmailVerified;
        //3.- Disparar el evento
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EventArgs());
            }
        }
        
        public void OnEmailSent(object source, EventArgs args)
        {
            Console.Write("¿Quiere revisar su correo? (si)(no)");
            while (true)
            {
                string option = Console.ReadLine();
                if (option == "si")
                {
                    OnEmailSent(source, args);
                }
                else if (option == "no") { break; }
                else { Console.WriteLine("La opción que selecciono no es válida seleccione (si) o (no)"); }
            }
        }
    }
}
