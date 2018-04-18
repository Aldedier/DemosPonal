using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //EntTblArticulo articulo1 = new EntTblArticulo();
            //EntTblArticulo articulo2 = new EntTblArticulo();
            //EntTblArticulo articulo3 = new EntTblArticulo();
            //EntTblArticulo articulo4 = new EntTblArticulo();
            //EntTblArticulo articulo5 = new EntTblArticulo();

            //List<EntTblArticulo> lista = new List<EntTblArticulo>();
            //lista.Add(articulo1);
            //lista.Add(articulo2);
            //lista.Add(articulo3);
            //lista.Add(articulo4);
            //lista.Add(articulo5);

            //int cantidadArticulos = lista.Count;

            List<EntTblArticulo> resultadodb = ConsultaDB();

            //for (int i = 0; i < resultadodb.Count; i++)
            //{
            //    if (resultadodb[i].NomArticulo == "nombre 5")
            //    {
            //        Console.WriteLine($"Dentro del articulo {resultadodb[i].NomArticulo}");
            //    }
            //}


            //foreach (EntTblArticulo item in resultadodb)
            //{
            //    Console.WriteLine($"Dentro del articulo {item.IdArticulo}");
            //    Console.WriteLine($"Dentro del articulo {item.NomArticulo} ");
            //    Console.WriteLine($"Dentro del articulo {item.Descripcion}");
            //    Console.WriteLine($"Dentro del articulo {item.Categoria}");
            //    Console.WriteLine($"Dentro del articulo {item.Precio}");
            //}


            //Consulta linQ - from "alias" in "lista" where "alias.propiedad" == "condicion" select "alias".

            //var resultadoLinq = from item in resultadodb
            //                    where item.NomArticulo == "nombre 5"
            //                    select item;

            var resultadoLinq = from item in resultadodb
                                where item.Precio > 30 && item.Precio < 70
                                select item;

            //var resultadoLinq = from item in resultadodb
            //                    where item.Precio > 100
            //                    select item;

            if (resultadoLinq.Count() == 0)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine($"El primer articulo mayor a 30 y menor a 70 es {resultadoLinq.FirstOrDefault().Precio}");

                //foreach (EntTblArticulo item in resultadoLinq)
                //{
                //    Console.WriteLine($"Dentro del articulo {item.NomArticulo}, precio {item.Precio}");
                //}
            }


            Console.ReadKey();
        }


        // Metodo para llenar aleatoriamente 10 registros de la entidad articulo "simulacion base de datos"
        public static List<EntTblArticulo> ConsultaDB()
        {
            List<EntTblArticulo> istaArticulos = new List<EntTblArticulo>();
            for (int i = 0; i < 10; i++)
            {
                EntTblArticulo articulo = new EntTblArticulo();
                articulo.IdArticulo = $"id {i}";
                articulo.NomArticulo = $"nombre {i}";
                articulo.Descripcion = $"descripcion del articulo numero {i}";
                articulo.Categoria = $"categoria del articulo {i}";
                articulo.Precio = i * 10;
                istaArticulos.Add(articulo);
            }
            return istaArticulos;
        }
    }
}
