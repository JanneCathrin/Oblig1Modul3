namespace Oblig1
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int? BirthYear;
        public int? DeathYear;
        public Person Father;
        public Person Mother;


        public string GetDescription()


        {

            var description = "";


            if (FirstName != null) description += $"{FirstName} ";
            if (LastName != null) description += $"{LastName} ";
            if (Id != 0) description += $"(Id={Id})";
            if (BirthYear != null) description += $" Født: {BirthYear}";
            if (DeathYear != null) description += $" Død: {DeathYear}";
            if (Father != null) description += $" Far: {Father.FirstName} " + $"(Id={Father.Id})";
            if (Mother != null) description += $" Mor: {Mother.FirstName} " + $"(Id={Mother.Id})";
            return description;

        }

            



        }
    }


// if (Id == null)
//{
//  return $" (Id={Id})";
//}


//if (Father != null)
//{
//    description += $"Far: {Father.FirstName} ";
//    description += $"(Id={Father.Id}) ";

//}

//if (Mother != null)
//{
//    description += $"Mor: {Mother.FirstName} ";
//    description += $"(Id={Mother.Id})";
//}

//else if (Id > 0)
//{
//    return $"(Id={Id})";
//}


//-------------------------------------------------------------------------------------------------



// description.($"{Id}");
// if (description !=  )
// {
//   return $"(Id={Id})";
//}


//--------------------------------------------------------------------------------------------------


//(description = !description.Add(Id)

// description.Add($"(Id={Id})









// "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";



