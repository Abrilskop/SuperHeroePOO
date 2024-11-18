

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

// Superheroes
var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
List<SuperPoder> poderesSuperman = new List<SuperPoder>(); // creacion del objeto de tipo lista(coleccion de elementos)
poderesSuperman.Add(SuperFuerza);
poderesSuperman.Add(superVolar);
poderesSuperman.Add(SuperVelocidad);

superman.SuperPoderes = poderesSuperman;// asignamos lista

var batman = new SuperHeroe();


// class
class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes; // clase dentro de otra clase
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