public class Alumno
{
    public int Id { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }

    public Alumno(int id, string primerNombre, string segundNombre)
    {
        Id = id;
        PrimerNombre = primerNombre;
        SegundoNombre = segundNombre;
    }

    public string nombreCompleto() {
            return PrimerNombre + " " + SegundoNombre;
        }
}