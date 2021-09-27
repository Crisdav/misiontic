using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
public class RepositorioAviones
{
List<Aviones> aviones;
public RepositorioAviones()
{
aviones= new List<Aviones>()
            {
                new Aviones{id=4,marca="Audi",modelo= 2020,num_asientos= 4, num_baños= 4, cap_max_peso=150},
                new Aviones{id=5,marca="Toyota",modelo= 2021,num_asientos= 16, num_baños= 4, cap_max_peso=200},
                new Aviones{id=6,marca="Mazda",modelo= 2000,num_asientos= 24, num_baños= 4, cap_max_peso=80}
            };
}
public IEnumerable<Aviones> GetAll()
{
return aviones;
}
public Aviones GetAvionWithId(int id){
return aviones.SingleOrDefault(b => b.id == id);
}
}
}