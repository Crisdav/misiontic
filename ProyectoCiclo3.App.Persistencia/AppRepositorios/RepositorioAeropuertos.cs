using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
public class RepositorioAeropuertos
{
List<Aeropuertos> aeropuertos;
public RepositorioAeropuertos()
{
aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,nombre="El dorado",ciudad= "Bogota",pais= "Colombia", coord_x= 40, coord_y=40},
                new Aeropuertos{id=2,nombre="Palonegro",ciudad= "Bucaramanga",pais= "Colombia", coord_x= 50, coord_y=50},
                new Aeropuertos{id=4,nombre="El Eden",ciudad= "Armenia",pais= "Colombia", coord_x= 60, coord_y=60}
            };
}
public IEnumerable<Aeropuertos> GetAll()
{
return aeropuertos;
}
public Aeropuertos GetAeropuertoWithId(int id){
return aeropuertos.SingleOrDefault(b => b.id == id);
}
public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.ciudad = newAeropuerto.ciudad;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.coord_x = newAeropuerto.coord_x;
                aeropuerto.coord_y = newAeropuerto.coord_y;
            }
        return aeropuerto;
        }
}
}