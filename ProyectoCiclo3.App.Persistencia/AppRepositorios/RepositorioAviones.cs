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
                new Aviones{id=1,marca="boeing",modelo= 2022,num_asientos= 200, num_baños= 10, cap_max_peso=10000},
                new Aviones{id=2,marca="pilatus",modelo= 2021,num_asientos= 400, num_baños= 11, cap_max_peso=20000},
                new Aviones{id=3,marca="airbus",modelo= 2020,num_asientos= 500, num_baños= 12, cap_max_peso=40000}
            };
}
public IEnumerable<Aviones> GetAll()
{
return aviones;
}
public Aviones GetAvionWithId(int id){
return aviones.SingleOrDefault(b => b.id == id);
}
public Aviones Create(Aviones newAvion)
{
if(aviones.Count > 0){
newAvion.id=aviones.Max(r => r.id) +1;
}else{
newAvion.id = 1;
}
aviones.Add(newAvion);
return newAvion;
}

public Aviones Delete(int id)
{
var avion= aviones.SingleOrDefault(b => b.id == id);
aviones.Remove(avion);
return avion;
}

public Aviones Update(Aviones newAvion){
            var avion= aviones.SingleOrDefault(b => b.id == newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.num_asientos = newAvion.num_asientos;
                avion.num_baños = newAvion.num_baños;
                avion.cap_max_peso = newAvion.cap_max_peso;
            }
        return avion;
        }
}
}