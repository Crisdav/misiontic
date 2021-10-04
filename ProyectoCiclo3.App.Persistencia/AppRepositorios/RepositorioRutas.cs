using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
public class RepositorioRutas
{
List<Rutas> rutas;
public RepositorioRutas()
{
rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen="bogota",destino= "armenia",tiempo_estimado= 2},
                new Rutas{id=2,origen="bucaramanga",destino= "armenia",tiempo_estimado= 4},
                new Rutas{id=3,origen="bogota",destino= "bucaramanga",tiempo_estimado= 5}
            };
}
public IEnumerable<Rutas> GetAll()
{
return rutas;
}
public Rutas GetRutaWithId(int id){
return rutas.SingleOrDefault(b => b.id == id);
}
public Rutas Create(Rutas newRuta)
{
if(rutas.Count > 0){
newRuta.id=rutas.Max(r => r.id) +1;
}else{
newRuta.id = 1;
}
rutas.Add(newRuta);
return newRuta;
}

public Rutas Delete(int id)
{
var ruta= rutas.SingleOrDefault(b => b.id == id);
rutas.Remove(ruta);
return ruta;
}

public Rutas Update(Rutas newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
            }
        return ruta;
        }
}
}