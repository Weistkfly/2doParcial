using System;
using System.Collections.Generic;
using System.Linq;

namespace Segundo_Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleado = new List<Empleado>();
            Empleado empl = new Empleado();

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                empl.Codigo = i.ToString();
                empl.Nombre = i.ToString();
                empl.Apellido = i.ToString();
                empl.Direccion = i.ToString();
                empl.Cedula = i.ToString();
                empl.Sexo = i.ToString();
                empl.Telefono = i.ToString();
                empl.Correo = i.ToString();
                empl.Departamento = i.ToString();
                empl.Sueldo = Convert.ToDouble(i * 10000);
                empl.insertIntoList(listaEmpleado, empl.Codigo, empl.Nombre, empl.Apellido, empl.Direccion,
                    empl.Cedula, empl.Sexo, empl.Telefono, empl.Correo, empl.Departamento, empl.Sueldo);
            }

            int opc = 0;

            while (opc != 4)
            {
                Console.WriteLine("Ingrese una opcion");
                Console.WriteLine("1- Ingresar empleado");
                Console.WriteLine("2- Listar empleados");
                Console.WriteLine("3- Buscar empleado");
                Console.WriteLine("4- Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese el codigo del empleado");
                        empl.Codigo = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del empleado");
                        empl.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del empleado");
                        empl.Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese la direccion del empleado");
                        empl.Direccion = Console.ReadLine();
                        Console.WriteLine("Ingrese la cedula del empleado");
                        empl.Cedula = Console.ReadLine();
                        Console.WriteLine("Ingrese el sexo del empleado");
                        empl.Sexo = Console.ReadLine();
                        Console.WriteLine("Ingrese el telefono del empleado");
                        empl.Telefono = Console.ReadLine();
                        Console.WriteLine("Ingrese el correo del empleado");
                        empl.Correo = Console.ReadLine();
                        Console.WriteLine("Ingrese el departamento del empleado");
                        empl.Departamento = Console.ReadLine();
                        Console.WriteLine("Ingrese el sueldo del empleado");
                        empl.Sueldo = Convert.ToDouble(Console.ReadLine());
                        empl.insertIntoList(listaEmpleado, empl.Codigo, empl.Nombre, empl.Apellido, empl.Direccion, 
                            empl.Cedula, empl.Sexo, empl.Telefono, empl.Correo, empl.Departamento,empl.Sueldo);
                        break;
                    case 2:
                        Console.Clear();
                        var listaOrdenada = listaEmpleado.OrderBy(o => o.Nombre).ToList();

                        foreach (var item in listaOrdenada)
                        {
                            Console.WriteLine(item.Nombre + " " + item.Apellido);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese el codigo del empleado");
                        string codigo = Console.ReadLine();
                        empl.getUser(listaEmpleado, codigo);
                        break;
                }
            }
        }
    }

    public class Empleado
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Departamento { get; set; }
        public double Sueldo { get; set; }

        public void insertIntoList(List<Empleado> listaEmpleados, string id, string nombre, string apellido, string direccion, string cedula, string sexo, string telefono, string correo, string departamento, double sueldo)
        {
            listaEmpleados.Add(new Empleado
            {
                Codigo = id,
                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion ,
                Cedula = cedula,
                Sexo = sexo,
                Telefono = telefono,
                Correo = correo,
                Departamento = departamento,
                Sueldo = sueldo
            });
        }

        public void getUser(List<Empleado> listaEmpleados, string id)
        {
            var empleado = listaEmpleados.Find(x => x.Codigo == id);
            if (empleado != null)
            {
                Console.WriteLine(empleado.Codigo);
                Console.WriteLine(empleado.Nombre);
                Console.WriteLine(empleado.Apellido);
                Console.WriteLine(empleado.Direccion);
                Console.WriteLine(empleado.Cedula);
                Console.WriteLine(empleado.Sexo);
                Console.WriteLine(empleado.Telefono);
                Console.WriteLine(empleado.Correo);
                Console.WriteLine(empleado.Departamento);
                Console.WriteLine(empleado.Sueldo);
            }
            else
            {
                Console.WriteLine("Empleado no existe");
            }

        }
    }
}
