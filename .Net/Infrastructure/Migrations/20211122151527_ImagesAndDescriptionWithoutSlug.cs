using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ImagesAndDescriptionWithoutSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Actor");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movie",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Length",
                table: "Movie",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Genre",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Director",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Director",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Director",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Director",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Director",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Director",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Actor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Actor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Actor",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Actor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating", "Year" },
                values: new object[] { new DateTime(1937, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(926), "Jack Nicholson, an American actor, producer, director and screenwriter, is a three-time Academy Award winner and twelve-time nominee. Nicholson is also notable for being one of two actors - the other being Michael Caine - who have received an Oscar nomination in every decade from the '60s through the '00s. Nicholson was born on April 22, 1937, in ... ", "Jack Nicholson--928401a8-56b7-4b88-beb6-90e19399789c.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(937), 11.0, 0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1949, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1820), "Shelley Alexis Duvall was born in Fort Worth, Texas, the first child to Bobbie Ruth (Massengale, 1929-2020), a real estate broker, and Robert Richardson Duvall (1919-1994), a lawyer. At the time of her birth, her mother was visiting her grandmother in Fort Worth, though Duvall was raised in Houston. During her childhood, Shelley's mother ... ", "Shelley Duvall--0cd507e8-1bb4-4230-9422-bff54b5307a2.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1821), 8.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1936, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1823), "all, slim, remote and boyishly handsome, one of Keir Dullea's most arresting features is his pale blue eyes, which featured in a number of watershed films of the 1960s. His major breakthrough (providing him legendary status) was the starring role as astronaut Dave Bowman in Stanley Kubrick's 2001: A Space Odyssey. After that, he persevered quite ...", "Keir Dullea--c1354574-199c-4ec3-836a-ed880b3f2156.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1823), 9.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1937, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1825), "Gary Lockwood was born John Gary Yurosek in Van Nuys, California to John and Margaret Emma (Kiel) Yurosek . He attended UCLA on a football scholarship. He began his career as a movie stuntman, and a stand-in for Anthony Perkins, prior to his acting debut in 1959 in an uncredited bit role in Warlock (1959). He also appeared as a police officer in ...", "Gary Lockwood--3c477cc2-7e75-4c84-925d-cfda401b50cc.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1825), 8.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1826), "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer Jenny (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal,... ", "Christian Bale--78888617-872a-4041-8ca2-57bd6f6b11b2.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1827), 11.5 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1979, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1828), "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a pretty boy and an actor of little depth. He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About ...", "Heath Ledger--5bf42bcc-786a-4b70-a185-d4eade846817.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1828), 10.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1829), "Few actors in the world have had a career quite as diverse as Leonardo DiCaprio's. DiCaprio has gone from relatively humble beginnings, as a supporting cast member of the sitcom Growing Pains (1985) and low budget horror movies, such as Critters 3 (1991), to a major teenage heartthrob in the 1990s, as the hunky lead actor in movies such as Romeo +...", "Leonardo DiCaprio--5ad2fa35-054b-4fce-8e84-916b9aa773f0.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1830), 12.1 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1981, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1831), "Joseph Leonard Gordon-Levitt was born February 17, 1981 in Los Angeles, California, to Jane Gordon and Dennis Levitt. Joseph was raised in a Jewish family with his late older brother, Dan Gordon-Levitt, who passed away in October 2010. His parents worked for the Pacifica Radio station KPFK-FM and his maternal grandfather, Michael Gordon, had been ...", "Joseph Gordon-Levitt--e3d1fd7c-ce25-4bb7-add8-d12950640509.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1831), 9.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1977, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1832), "With his breakthrough performance as Eames in Christopher Nolan's sci-fi thriller Inception (2010), English actor Tom Hardy has been brought to the attention of mainstream audiences worldwide. However, the versatile actor has been steadily working on both stage and screen since his television debut in the miniseries Band of Brothers (2001). After ...", "Tom Hardy--cc26260e-c69f-4262-925b-32f0af2b8fc5.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1833), 10.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1933, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1835), "Michael Caine was born Maurice Joseph Micklewhite in London, to Ellen Frances Marie (Burchell), a charlady, and Maurice Joseph Micklewhite, a fish-market porter. He left school at age 15 and took a series of working-class jobs before joining the British army and serving in Korea during the Korean War, where he saw combat. Upon his return to ...", "Michael Cain--4a1329ba-f3c3-469f-89d5-ee1c5c3eadcd.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1835), 9.1999999999999993 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1976, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1837), "Striking Irish actor Cillian Murphy was born in Douglas, the oldest child of Brendan Murphy, who works for the Irish Department of Education, and a mother who is a teacher of French. He has three younger siblings. Murphy was educated at Presentation Brothers College, Cork. He went on to study law at University College Cork, but dropped out after ...", "Cillian Murphy--2265ad64-8a71-4da4-a898-53c1a9c15791.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1838), 10.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1975, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1839), "Academy Award-winning actress Marion Cotillard was born on September 30, 1975 in Paris. Cotillard is the daughter of Jean-Claude Cotillard, an actor, playwright and director, and Niseema Theillaud, an actress and drama teacher. Her father's family is from Brittany. Raised in Orléans, France, she made her acting debut as a child with a role in one ... ", "Marion Cotillard--ab70db7f-1474-4683-bfcc-a1051b85691c.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1840), 10.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1966, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1840), "Jason Flemyng was born on September 25, 1966 in Putney, London, England as Jason Iain Flemyng. He is an actor and producer, known for Lock, Stock and Two Smoking Barrels (1998), The Curious Case of Benjamin Button (2008) and Deep Rising (1998). He has been married to Elly Fairman since June 6, 2008.", "Jason Flemyng--39ae09e1-8325-43b0-a869-d662a56b5818.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1841), 9.3000000000000007 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1967, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1842), "Jason Statham was born in Shirebrook, Derbyshire, to Eileen (Yates), a dancer, and Barry Statham, a street merchant and lounge singer. He was a Diver on the British National Diving Team and finished twelfth in the World Championships in 1992. He has also been a fashion model, black market salesman and finally of course, actor. He received the ...", "Jason Statham--571b29e4-0eca-4f79-a832-6ab4a0ed906d.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1842), 10.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1965, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1843), "Vincent Peter Jones was born on January 5, 1965 in Watford, England. He first came to public notice as a professional footballer, playing in the English Football League. Noted as one of football's hard men, he leaped to fame when a photographer, at a match, snapped him marking Newcastle United's Paul Gascoigne, by grabbing his testicles. He has ...", "Vinnie Jones--dc0031b4-5b0d-4b71-ba77-e39b2e1601d0.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1844), 9.6999999999999993 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1845), "Robert Downey Jr. has evolved into one of the most respected actors in Hollywood. With an amazing list of credits to his name, he has managed to stay new and fresh even after over four decades in the business. Downey was born April 4, 1965 in Manhattan, New York, the son of writer, director and filmographer Robert Downey Sr. and actress Elsie Downey...", "Robert Downey Jr--8d269864-287f-40ba-b86d-74f00329be91.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1845), 11.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1972, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1846), "Jude Law is an English actor. Law has been nominated for two Academy Awards and continues to build a prolific body of work that spans from early successes such as Gattaca (1997) and The Talented Mr. Ripley (1999) to more recent turns as Dr. John Watson in Sherlock Holmes (2009) and Sherlock Holmes: A Game of Shadows (2011), as Hugo's father in Hugo...", "Jude Law--2fe2b13d-b8e6-489e-997e-f62c8c1e0725.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1847), 9.6999999999999993 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1963, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1848), "British actor Mark Strong, who played Jim Prideaux in the 2011 remake of Tinker Tailor Soldier Spy (2011), is often cast as cold, calculating villains. But before he became a famous actor, he intended to pursue a career in law. Strong was born Marco Giuseppe Salussolia in London, England, to an Austrian mother and an Italian father. His father left...", "Mark Strong--bde9e7fb-7e3f-418d-97d2-826e041171d6.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1848), 9.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1967, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1849), "Jamie Foxx is an American actor, singer and comedian. He won an Academy Award for Best Actor, BAFTA Award for Best Actor in a Leading Role, and Golden Globe Award for Best Actor in a Musical or Comedy, for his work in the biographical film Ray (2004). The same year, he was nominated for the Academy Award for Best Supporting Actor for his role in ...", "Jamie Foxx--44f9c50f-bbbe-4049-8f8c-e86df663cfb4.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1850), 10.1 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1956, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1851), "Christoph Waltz is an Austrian-German actor. He is known for his work with American filmmaker Quentin Tarantino, receiving acclaim for portraying SS-Standartenführer Hans Landa in Inglourious Basterds (2009) and bounty hunter Dr. King Schultz in Django Unchained (2012). For each performance, he won an Academy Award, a BAFTA Award, and a Golden ...", "Christoph Waltz--b7bd4de2-1536-405f-b460-ec32a601cb70.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1851), 10.5 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1852), "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard: With a Vengeance (1995), Unbreakable (2000), Shaft (2000), The 51st State (2001), Black Snake Moan (2006), Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe. ...", "Samuel L Jackson--cbb52077-7f31-4e7d-b0fe-73a35589a1ed.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1853), 11.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1951, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1854), "Kurt Vogel Russell was born on March 17, 1951 in Springfield, Massachusetts, to Louise Julia Russell (née Crone), a dancer, and Bing Russell, an actor. He is of English, German, Scottish and Irish descent. His first roles were as a child on television series, including a lead role on the Western series The Travels of Jaimie McPheeters (1963). ...", "Kurt Russell--f9f3a0e2-b112-49cb-ab8c-d0dbb0353409.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1854), 10.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1961, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1855), "Often mistaken for an American because of his skill at imitating accents, actor Tim Roth was born Timothy Simon Roth on May 14, 1961 in Lambeth, London, England. His mother, Ann, was a teacher and landscape painter. His father, Ernie, was a journalist who had changed the family name from Smith to Roth; Ernie was born in Brooklyn, New York, to ... ", "Tim Roth--12106310-2f00-410a-8cbb-20b4c142d976.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1856), 10.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1957, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1857), "Michael Madsen's long career spans nearly 40 years and more than 170 films in which he has played memorable characters in myriad box office hits, including: Kill Bill: Vol. 1 (2003), Kill Bill: Vol. 2 (2004) Sin City (2005), Hell Ride (2008), Die Another Day (2002), Donnie Brasco (1997), Species (1995), The Getaway (1994), Thelma & Louise (...", "Michael Madsen--49923597-e932-4797-8f2c-141e4855f3af.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1857), 10.1 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1961, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1858), "Samy Naceri is born in Paris from an Algerian father and a French mother. He grew up in the suburbs of Paris in a modest family of seven siblings. Since his youngest age, Samy dreamt about making movies. After many years of struggling and hard work, he will finally have a chance to meet a famous casting director (Bruno Delahaye) who will offer him ...", "Samy Naceri--6bfda92a-99f8-47ec-a67f-ce41682fcae5.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1858), 10.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1968, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1859), "Frédéric Diefenthal was born on July 26, 1968 in Saint-Mandé, Val-de-Marne, France as Frédéric Pierre Diefenthal-Girau-Guyard. He is an actor and producer, known for Taxi (1998), Taxi 4 (2007) and Taxi 3 (2003). He was previously married to Gwendoline Hamon.", "Frédéric Diefenthal--c5cb3a61-5bd5-4a21-9dba-a3708c1a5ba9.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1860), 9.6999999999999993 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1943, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1862), "One of the greatest actors of all time, Robert De Niro was born on August 17, 1943 in Manhattan, New York City, to artists Virginia (Admiral) and Robert De Niro Sr. His paternal grandfather was of Italian descent, and his other ancestry is Irish, English, Dutch, German, and French. He was trained at the Stella Adler Conservatory and the American ...", "Robert De Niro--4b3892c6-4bb5-4fdd-a0d9-d14a0d09f6f3.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1862), 12.1 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1958, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1863), "Michelle Pfeiffer was born in Santa Ana, California to Dick and Donna Pfeiffer. She has an older brother and two younger sisters - Dedee Pfeiffer, and Lori Pfeiffer, who both dabbled in acting and modeling but decided against making it their lives' work. She graduated from Fountain Valley High School in 1976, and attended one year at the Golden ...", "Michelle Pfeiffer--c0b03f74-aa00-4780-904e-63f987105c7e.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1864), 10.1 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1946, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1865), "Tommy Lee Jones was born in San Saba, Texas, the son of Lucille Marie (Scott), a police officer and beauty shop owner, and Clyde C. Jones, who worked on oil fields. Tommy himself worked in underwater construction and on an oil rig. He attended St. Mark's School of Texas, a prestigious prep school for boys in Dallas, on a scholarship, and went to ...", "Tommy Lee Jones--3dae989f-7820-4935-b9df-e838db27bdf6.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1865), 11.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1948, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1866), "Jean Reno was born Juan Moreno y Herrera-Jiménez in Casablanca, Morocco, to Spanish parents (from Andalucía) who moved to North Africa to seek work. His father was a linotypist. Reno settled in France at 17. He began studying drama and has credits in French television and theater as well as films. His first two marriages both ended in divorce, and... ", "Jean Reno--5fb8a62d-76ef-4dc2-9395-9c58cad00ca9.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1867), 11.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1958, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1868), "Gary Oldman is a talented English movie star and character actor, renowned for his expressive acting style. One of the most celebrated thespians of his generation, with a diverse career encompassing theatre, film and television, he is known for his roles as Sid Vicious in Sid and Nancy (1986), Drexl in True Romance (1993), George Smiley in Tinker ...", "Gary Oldman--b00256e6-4062-48e9-b78c-31987722644e.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1868), 10.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1869), "Natalie Portman is the first person born in the 1980s to have won the Academy Award for Best Actress (for Black Swan (2010)). Natalie was born Natalie Hershlag on June 9, 1981, in Jerusalem, Israel. She is the only child of Avner Hershlag, a Israeli-born doctor, and Shelley Stevens, an American-born artist (from Cincinnati, Ohio), who also acts as ...", "Natalie Portman--6e1e75b7-0825-4cb9-ad4c-edb1d5e1c066.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1870), 9.6999999999999993 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1968, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1871), "Hugh Michael Jackman is an Australian actor, singer, multi-instrumentalist, dancer and producer. Jackman has won international recognition for his roles in major films, notably as superhero, period, and romance characters. He is best known for his long-running role as Wolverine in the X-Men film series, as well as for his lead roles in the ...", "Hugh Jackman--cdb0aa4e-8478-4081-bfea-2de2551224b2.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1871), 10.6 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1872), "Scarlett Ingrid Johansson was born on November 22, 1984 in Manhattan, New York City, New York. Her mother, Melanie Sloan is from a Jewish family from the Bronx and her father, Karsten Johansson is a Danish-born architect from Copenhagen. She has a sister, Vanessa Johansson, who is also an actress, a brother, Adrian, a twin brother, Hunter Johansson...", "Scarlett Johansson--e34e9d1f-6866-4384-ba63-93d0bb0ed526.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1873), 10.5 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1967, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1874), "Award-winning actor Mark Ruffalo was born on November 22, 1967, in Kenosha, Wisconsin, of humble means to father Frank Lawrence Ruffalo, a construction painter and Marie Rose (Hebert), a stylist and hairdresser; his father's ancestry is Italian and his mother is of half French-Canadian and half Italian descent. Mark moved with his family to ...", "Mark Ruffalo--f5ce9649-c855-4694-aef3-17d89ea9b46e.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1874), 10.5 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1875), "Bill Skarsgård was born on August 9, 1990 in Vällingby, Sweden as Bill Istvan Günther Skarsgård. He is an actor and producer, known for It (2017), It: Chapter Two (2019) and Deadpool 2 (2018).", "Bill Skarsgård--346a9d0e-6157-498c-a2c7-cc2b087491c6.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1876), 9.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(2002, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1877), "Sophia Lillis was born in Crown Heights, Brooklyn. She started her acting career at the age of seven, when her stepfather encouraged her to take acting classes at Lee Strasberg Theatre and Film Institute in Manhattan. While studying there, a teacher recommended her for a role in an NYU student film. She then signed a deal with an agent and started...", "Sophia Lillis--ae27a52f-8b18-4f9e-8679-458237baffbb.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1877), 9.1999999999999993 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1954, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1878), "John Joseph Travolta was born in Englewood, New Jersey, one of six children of Helen Travolta (née Helen Cecilia Burke) and Salvatore/Samuel J. Travolta. His father was of Italian descent and his mother was of Irish ancestry. His father owned a tire repair shop called Travolta Tires in Hillsdale, NJ. Travolta started acting appearing in a local ...", "John Travolta--042fccc4-fe89-455f-97d8-fc0063203b8b.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1879), 10.9 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1970, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1880), "Uma Karuna Thurman was born in Boston, Massachusetts, into a highly unorthodox and internationally-minded family. She is the daughter of Nena Thurman (née Birgitte Caroline von Schlebrügge), a fashion model and socialite who now runs a mountain retreat, and of Robert Thurman (Robert Alexander Farrar Thurman), a professor and academic who is one of...", "Uma Thurman--d7e85d7d-70dd-4c4c-bca6-b535bbc02406.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1880), 11.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1955, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1881), "Actor and musician Bruce Willis is well known for playing wisecracking or hard-edged characters, often in spectacular action films. Collectively, he has appeared in films that have grossed in excess of $2.5 billion USD, placing him in the top ten stars in terms of box office receipts. Walter Bruce Willis was born on March 19, 1955, in ... ", "Bruce Willis--4e95b8ae-dad4-4e7d-bdef-7fc555815c02.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1882), 11.5 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1883), "Keanu Charles Reeves, whose first name means cool breeze over the mountains in Hawaiian, was born September 2, 1964 in Beirut, Lebanon. He is the son of Patricia Taylor, a showgirl and costume designer, and Samuel Nowlin Reeves, a geologist. Keanu's father was born in Hawaii, of British, Portuguese, Native Hawaiian, and Chinese ancestry, and ...", "Keanu Reeves--8b83d385-87a2-4b66-bde6-f0130efc3785.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1883), 11.699999999999999 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1961, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1884), "Critically hailed for his forceful, militant, authoritative figures and one of Hollywood's most talented and versatile performers, Laurence (John) Fishburne III has been the recipient of numerous awards, including a number of NAACP Image honors. Born in Augusta, Georgia on July 30, 1961, to Hattie Bell (Crawford), a teacher, and Laurence John ...", "Laurence Fishburne--a17f41cd-f562-471d-9c7b-811367255624.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1885), 10.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1967, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1886), "Carrie-Anne Moss was born and raised in Vancouver, Canada. At age 20, after studying at the American Academy of Dramatic Arts, she moved to Europe to pursue a career in modeling. While in Spain she was cast in the TV show Dark Justice which was produced in Barcelona for its first season and Los Angeles for its second. Once in LA, Carrie-Anne was ...", "Carrie-Anne Moss--ced7b68c-ce41-4178-aeb1-bd875150177b.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1886), 10.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1960, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1887), "Hugo Wallace Weaving was born on April 4, 1960 in Nigeria, to English parents Anne (Lennard), a tour guide and teacher, and Wallace Weaving, a seismologist. Hugo has an older brother, Simon, and a younger sister, Anna, who both also live and work in Australia. During his early childhood, the Weaving family spent most of their time traveling ...", "Hugo Weaving--738b5541-6bee-43ad-bae1-b4ae24db5ddd.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1888), 9.6999999999999993 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1928, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 19, DateTimeKind.Utc).AddTicks(9672), "Stanley Kubrick was born in Manhattan, New York City, to Sadie Gertrude (Perveler) and Jacob Leonard Kubrick, a physician. His family were Jewish immigrants (from Austria, Romania, and Russia). Stanley was considered intelligent, despite poor grades at school. Hoping that a change of scenery would produce better academic performance, Kubrick's ...", "Stanley Kubrick--0db9f42e-0a59-4179-a72e-334f5483f5a3.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 19, DateTimeKind.Utc).AddTicks(9679), 12.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(536), "Best known for his cerebral, often nonlinear, storytelling, acclaimed writer-director Christopher Nolan was born on July 30, 1970, in London, England. Over the course of 15 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made. At 7 years old, Nolan began making short movies ...", "Christopher Nolan--d28e2806-d48a-4f03-bf09-6be7cf7b7d43.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(537), 12.5 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1968, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(539), "Guy Ritchie was born in Hatfield, Hertfordshire, UK on September 10, 1968. After watching Butch Cassidy and the Sundance Kid (1969) as a child, Guy realized that what he wanted to do was make films. He never attended film school, saying that the work of film school graduates was boring and unwatchable. At 15 years old, he dropped out of school and...", "Guy Ritchie--0ec7447e-bfe1-4a5d-a413-cd27ca7447d9.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(539), 12.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(540), "Quentin Jerome Tarantino was born in Knoxville, Tennessee. His father, Tony Tarantino, is an Italian-American actor and musician from New York, and his mother, Connie (McHugh), is a nurse from Tennessee. Quentin moved with his mother to Torrance, California, when he was four years old. In January of 1992, first-time writer-director Tarantino's ...", "Quentin Tarantino--f1408446-a750-4d4a-9a34-d3eab361410a.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(541), 13.0 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1959, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(542), "Luc Besson spent the first years of his life following his parents, scuba diving instructors, around the world. His early life was entirely aquatic. He already showed amazing creativity as a youth, writing early drafts of The Big Blue (1988) and The Fifth Element (1997), as an adolescent bored in school. He planned on becoming a marine biologist ...", "Luc Besson-ae52a9f6-7f52-491a-ae0c-10c0f43a00ab.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(543), 12.6 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(544), "Martin Charles Scorsese was born on November 17, 1942 in Queens, New York City, to Catherine Scorsese (née Cappa) and Charles Scorsese, who both worked in Manhattan's garment district, and whose families both came from Palermo, Sicily. He was raised in the neighborhood of Little Italy, which later provided the inspiration for several of his films....", "Martin Scorsese--877c1c9a-eb59-4ccd-9638-0a098af349ee.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(544), 11.9 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Rating" },
                values: new object[] { new DateTime(1973, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(545), "Andy Muschietti was born on August 26, 1973 in Buenos Aires, Federal District, Argentina as Andrés Muschietti. He is a producer and director, known for Mama (2013), It (2017) and It: Chapter Two (2019).", "Andy Muschietti--c1b94fad-1a6f-4fec-b86a-cda7c4806877.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(546), 10.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Birthday", "CreationTime", "Description", "Image", "ModifiedDate", "Name", "Rating" },
                values: new object[] { new DateTime(1967, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(547), "Director, writer, and producer Lilly Wachowski was born in 1967 in Chicago, the daughter of Lynne, a nurse and painter, and Ron, a businessman. Lilly was educated at Kellogg Elementary School in Chicago, before moving on to Whitney M. Young High School. After graduating from high school, she attended Emerson College in Boston but dropped out. Lilly...", "Lilly Wachowski--c5d08ab1-730d-40f2-a332-d6a226684a50.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(547), "Lilly Wachowski", 12.300000000000001 });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(1826), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2190), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2192), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2193), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2195), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2196), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(6016), "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future.", "Shining--216171b4-557f-498b-97fb-89265e2f6976.jpg", new TimeSpan(0, 2, 26, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7261), "The Monoliths push humanity to reach for the stars; after their discovery in Africa generations ago, the mysterious objects lead mankind on an awesome journey to Jupiter, with the help of H....", "2001 A Space Odyssey--4bb2a106-b137-4c41-b87d-ad78bc617c44.jpg", new TimeSpan(0, 2, 29, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7265), "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "The Dark Knight--843dd091-41c3-48dd-8c87-ffd116d4a2db.jpg", new TimeSpan(0, 2, 32, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7266), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the pro...", "Inception--c41f5f44-f7d1-4f5a-b9d2-f76006150c35.jpg", new TimeSpan(0, 2, 28, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7269), "Eddy persuades his three pals to pool money for a vital poker game against a powerful local mobster, Hatchet Harry. Eddy loses, after which Harry gives him a week to pay back 500,000 pounds.", "Lock, Stock and Two Smoking Barrels--dd1478a7-0f13-4795-a455-d8ba9b19e4df.jpg", new TimeSpan(0, 1, 47, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7271), "Detective Sherlock Holmes and his stalwart partner Watson engage in a battle of wits and brawn with a nemesis whose plot is a threat to all of England.", "Sherlock Holmes--7cdcdde5-876c-4694-b9e7-2ce7978d6c04.jpg", new TimeSpan(0, 2, 8, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7273), "With the help of a German bounty-hunter, a freed slave sets out to rescue his wife from a brutal plantation-owner in Mississippi.", "Django Unchained--ff44c1db-aeca-42d0-9c54-6262b4524d79.jpg", new TimeSpan(0, 2, 45, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7274), "In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.", "The Hatefull Eight--430c1969-55b9-46c5-92ef-eb511f72a4e3.jpg", new TimeSpan(0, 2, 48, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7277), "To work off his tarnished driving record, a hip taxi driver must chauffeur a loser police inspector on the trail of German bank robbers.", "Taxi--730f60f3-73b5-4411-a970-ed5589c3af85.jpg", new TimeSpan(0, 1, 26, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7278), "The Manzoni family, a notorious mafia clan, is relocated to Normandy, France under the Witness Protection Program, where fitting in soon becomes challenging, as their old habits die hard.", "The Family--b7bd1a39-9063-4a47-b7a2-117da0e272da.jpg", new TimeSpan(0, 1, 51, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7279), "The Family" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7280), "Mathilda, a 12-year-old girl, is reluctantly taken in by Léon, a professional assassin, after her family is murdered. An unusual relationship forms as she becomes his protégée and learns the...", "Leon The Professional--7619839c-e7ad-4e0a-af43-5e862b840725.jpg", new TimeSpan(0, 1, 50, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7282), "After a tragic accident, two stage magicians in 1890s London engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.", "The Prestige--b52f0f04-d67a-442e-8853-60667d5ff871.jpg", new TimeSpan(0, 2, 10, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7284), "In 1954, a U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane.", "Shutter Island--90fea998-b36e-41cf-be61-d62a95eec933.jpg", new TimeSpan(0, 2, 18, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7285), "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town...", "It--11df08d0-fb79-4999-8167-9fd1e5913fb8.jpg", new TimeSpan(0, 2, 15, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7287), "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Pulp Fiction--204ed3ec-457b-4726-bbd1-5b81acade5be.jpg", new TimeSpan(0, 2, 34, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "Description", "Image", "Length", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7289), "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", "The Matrix--7a3d7838-91e7-4c5c-8e4a-277721761a50.jpg", new TimeSpan(0, 2, 16, 0, 0), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7289) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Actor");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Rating", "Slug", "Year" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/e/ec/Jack_Nicholson_2001.jpg", 13.0, "jack-nicholson--1", 1937 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Image", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "The Wachowskis");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/1/1d/The_Shining_%281980%29_U.K._release_poster_-_The_tide_of_terror_that_swept_America_IS_HERE.jpg", "shinig--1980--1" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/1/11/2001_A_Space_Odyssey_%281968%29.png", "2001-a-space-odyssey--1968--2" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/8/8a/Dark_Knight.jpg", "the-dark-knight--2008" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg", "inception--2010" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://images.wolfgangsvault.com/m/xlarge/ZZZ061560-PO/lock-stock-and-two-smoking-barrels-poster-mar-5-1999.webp", "lock-stock-and-two-smoking-barrels--1998" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://m.media-amazon.com/images/M/MV5BMTg0NjEwNjUxM15BMl5BanBnXkFtZTcwMzk0MjQ5Mg@@._V1_.jpg", "sherlock-holmes--2009" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/8/8b/Django_Unchained_Poster.jpg", "django-unchained--2012" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/d/d4/The_Hateful_Eight.jpg", "the-hatefull-eight--2015" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/7/7e/TaxiPoster.jpg", "taxi--1998" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Image", "Name", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/7/75/The_Family_2013%2C_Poster.jpg", "Malavita", "malavita--2013" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/uk/e/e1/L%C3%A9on_poster.JPG", "léon-the-proffesional--1994" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://i.pinimg.com/originals/02/88/8a/02888af9053561a41e4276e33588403b.jpg", "prestige--2006" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/7/76/Shutterislandposter.jpg", "shutter-island--2010" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/5/5a/It_%282017%29_poster.jpg", "it--2017" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/3/3b/Pulp_Fiction_%281994%29_poster.jpg", "pulp-fiction--1994" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Image", "Slug" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/The_Matrix_Poster.jpg/220px-The_Matrix_Poster.jpg", "the-matrix--1999" });
        }
    }
}
