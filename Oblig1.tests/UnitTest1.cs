using Oblig1;
using NUnit.Framework;

namespace Oblig1.tests

    {

        public class PersonTest
        {
            [Test]
            public void TestAllFields()
            {

                var p = new Person
                {
                    Id = 17,
                    FirstName = "Ola",
                    LastName = "Nordmann",
                    BirthYear = 2000,
                    DeathYear = 3000,
                    Father = new Person() { Id = 23, FirstName = "Per" },
                    Mother = new Person() { Id = 29, FirstName = "Lise" },
                };

                var actualDescription = p.GetDescription();
                var expectedDescription = "Ola Nordmann (Id=17) F?dt: 2000 D?d: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

                Assert.AreEqual(expectedDescription, actualDescription);

            }

            [Test]

            public void TestNoFields()
            {
                var p = new Person
                {
                    Id = 1,
                };

                var actualDescription = p.GetDescription();
                var expectedDescription = "(Id=1)";

                Assert.AreEqual(expectedDescription, actualDescription);
            }

            [Test]
            public void Mingtest()
            {
                var p = new Person
                {
                    Id = 15,
                    FirstName = " Janne",
                    LastName = "Torgersen",

                };

                var actualDescription = p.GetDescription();
                var expectedDescription = " Janne Torgersen (Id=15)";

                Assert.AreEqual(expectedDescription, actualDescription);
            }
        }
    }
