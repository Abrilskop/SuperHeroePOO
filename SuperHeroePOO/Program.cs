
// creacion de objeto superman a partir de la clase superheroe
var superman = new SuperHeroe();
var batman = new SuperHeroe();

// Superpoderes
var superVolar = new SuperPoder();
superVolar.Nombre = "Volar";
superVolar.Descripcion = "Capacidad de Volar";
superVolar.Nivel = (int)NivelPoder.N1;


var SuperVelocidad = new SuperPoder();
SuperVelocidad.Nombre = "Velocidad";
SuperVelocidad.Descripcion = "Poder romper la cara de sonido";
SuperVelocidad.Nivel = (int)NivelPoder.N2;

var SuperFuerza = new SuperPoder();
SuperFuerza.Nombre = "Super Fuerza";
SuperFuerza.Descripcion = "Habilidad para romper de todo";
SuperFuerza.Nivel = (int)NivelPoder.N2;

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
superman.SuperPoderes = new[] { "Vision de rayos X", "Volar", "Super fueza", "Ojos rayos lazer" };

// class
class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public string[] SuperPoderes;
    public bool PuedeVolar;
}
class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public int Nivel; 
}
// al asignar 1 nivel siempre usar esos valores
enum NivelPoder
{
    N1, N2, N3
}