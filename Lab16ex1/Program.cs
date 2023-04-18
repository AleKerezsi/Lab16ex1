// See https://aka.ms/new-console-template for more information
using Lab16ex1.Models;

//SeedDb();

//ShowAllStudents();

AfiseazaStudentiiInOrdineAlfabetica();

AfiseazaStudentSpecialConstructii();


/*
 * Afisati toti studentii din DB in ordine alfabetica
 */
static void AfiseazaStudentiiInOrdineAlfabetica()
{
    using var catalogContext = new StudentsDbContext();

    Console.WriteLine("Studentii ordonati alfabetic: ");

    catalogContext.Students.OrderBy(student => student.Nume).ThenBy(student => student.Prenume).ToList().ForEach(student => Console.WriteLine(student));
}

/*
 * Afisati cel mai tanar student de la constructii cu varsta de peste 20 de ani
 */
static void AfiseazaStudentSpecialConstructii()
{
    using var catalogContext = new StudentsDbContext();

    Console.WriteLine("Cel mai tanar student de la Constructii cu varsta de peste 20 de ani: ");

    var studentSpecial = catalogContext.Students.OrderBy(student => student.Varsta).Where(student => student.SpecializareId == 3 && student.Varsta > 20).FirstOrDefault();

    Console.WriteLine(studentSpecial);
}

static void ShowAllStudents() 
{
    using var catalogContext = new StudentsDbContext();

    catalogContext.Students.ToList().ForEach(student => Console.WriteLine(student));
}

static void SeedDb() 
{
    using var catalogContext = new StudentsDbContext();

    catalogContext.Students.Add(
        new Student() { 
            Nume = "Gicu",
            Prenume="Mihai",
            Varsta=28,
            SpecializareId = 3
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Constantin",
            Prenume = "Dorina",
            Varsta = 20,
            SpecializareId = 3
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Marchis",
            Prenume = "Ioan",
            Varsta = 20,
            SpecializareId = 3
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Bob",
            Prenume = "Florentina",
            Varsta = 21,
            SpecializareId = 2
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Georgescu",
            Prenume = "Marius",
            Varsta = 19,
            SpecializareId = 2
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Popescu",
            Prenume = "Maria",
            Varsta = 19,
            SpecializareId = 2
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Har",
            Prenume = "Iustinian",
            Varsta = 21,
            SpecializareId = 1
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Crisan",
            Prenume = "Nicu",
            Varsta = 20,
            SpecializareId = 1
        });

    catalogContext.Students.Add(
        new Student()
        {
            Nume = "Temisan",
            Prenume = "Daniel",
            Varsta = 20,
            SpecializareId = 1
        });


    catalogContext.Specializari.Add(
        new Specializare()
        {
            NumeSpecializare = "Informatica"
        });

    catalogContext.Specializari.Add(
        new Specializare()
        {
            NumeSpecializare = "Litere"
        });

    catalogContext.Specializari.Add(
        new Specializare()
        {
            NumeSpecializare = "Constructii"
        });

    catalogContext.SaveChanges();

}