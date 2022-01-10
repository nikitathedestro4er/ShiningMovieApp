using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infrastructure.Configurations
{
    internal sealed class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable(nameof(Actor));

            builder.HasKey(actor => actor.Id);

            builder.Property(actor => actor.Id).ValueGeneratedOnAdd();

            builder.Property(actor => actor.Name).IsRequired().HasMaxLength(50);

            builder.Property(actor => actor.Image).IsRequired();

            builder.Property(actor => actor.Birthday).IsRequired().HasColumnType("date");

            builder.Property(actor => actor.Rating).IsRequired();

            builder.Property(actor => actor.Description).IsRequired().HasMaxLength(500);

            builder.Property(actor => actor.CreationTime).IsRequired();

            builder.Property(actor => actor.ModifiedDate).IsRequired();

            builder.HasData(
                new Actor
                {
                    Id = 1,
                    Name = "Jack Nicholson",
                    Birthday = new DateTime(1937, 04, 22),
                    Rating = 11,
                    Image = "Jack Nicholson--928401a8-56b7-4b88-beb6-90e19399789c.jpg",
                    Description = "Jack Nicholson, an American actor, producer, director and screenwriter, is a three-time Academy Award winner and twelve-time nominee. Nicholson is also notable for being one of two actors - the other being Michael Caine - who have received an Oscar nomination in every decade from the '60s through the '00s. Nicholson was born on April 22, 1937, in ... "
                },
                new Actor
                {
                    Id = 2,
                    Name = "Shelley Duvall",
                    Birthday = new DateTime(1949, 07, 7),
                    Rating = 8,
                    Image = "Shelley Duvall--0cd507e8-1bb4-4230-9422-bff54b5307a2.jpg",
                    Description = "Shelley Alexis Duvall was born in Fort Worth, Texas, the first child to Bobbie Ruth (Massengale, 1929-2020), a real estate broker, and Robert Richardson Duvall (1919-1994), a lawyer. At the time of her birth, her mother was visiting her grandmother in Fort Worth, though Duvall was raised in Houston. During her childhood, Shelley's mother ... "
                },
                new Actor
                {
                    Id = 3,
                    Name = "Keir Dullea",
                    Birthday = new DateTime(1936, 05, 30),
                    Rating = 9,
                    Image = "Keir Dullea--c1354574-199c-4ec3-836a-ed880b3f2156.jpg",
                    Description = "all, slim, remote and boyishly handsome, one of Keir Dullea's most arresting features is his pale blue eyes, which featured in a number of watershed films of the 1960s. His major breakthrough (providing him legendary status) was the starring role as astronaut Dave Bowman in Stanley Kubrick's 2001: A Space Odyssey. After that, he persevered quite ..."

                },
                new Actor
                {
                    Id = 4,
                    Name = "Gary Lockwood",
                    Birthday = new DateTime(1937, 02, 21),
                    Rating = 8.6,
                    Image = "Gary Lockwood--3c477cc2-7e75-4c84-925d-cfda401b50cc.jpg",
                    Description = "Gary Lockwood was born John Gary Yurosek in Van Nuys, California to John and Margaret Emma (Kiel) Yurosek . He attended UCLA on a football scholarship. He began his career as a movie stuntman, and a stand-in for Anthony Perkins, prior to his acting debut in 1959 in an uncredited bit role in Warlock (1959). He also appeared as a police officer in ..."
                },
                new Actor
                {
                    Id = 5,
                    Name = "Christian Bale",
                    Birthday = new DateTime(1974, 01, 30),
                    Rating = 11.5,
                    Image = "Christian Bale--78888617-872a-4041-8ca2-57bd6f6b11b2.jpg",
                    Description = "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer Jenny (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal,... "

                },
                new Actor
                {
                    Id = 6,
                    Name = "Heath Ledger",
                    Birthday = new DateTime(1979, 01, 22),
                    Rating = 10.3,
                    Image = "Heath Ledger--5bf42bcc-786a-4b70-a185-d4eade846817.jpg",
                    Description = "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a pretty boy and an actor of little depth. He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About ..."

                },
                new Actor
                {
                    Id = 7,
                    Name = "Leonardo DiCaprio",
                    Birthday = new DateTime(1974, 11, 11),
                    Rating = 12.1,
                    Image = "Leonardo DiCaprio--5ad2fa35-054b-4fce-8e84-916b9aa773f0.jpg",
                    Description = "Few actors in the world have had a career quite as diverse as Leonardo DiCaprio's. DiCaprio has gone from relatively humble beginnings, as a supporting cast member of the sitcom Growing Pains (1985) and low budget horror movies, such as Critters 3 (1991), to a major teenage heartthrob in the 1990s, as the hunky lead actor in movies such as Romeo +..."

                },
                new Actor
                {
                    Id = 8,
                    Name = "Joseph Gordon-Levitt",
                    Birthday = new DateTime(1981, 11, 17),
                    Rating = 9.6,
                    Image = "Joseph Gordon-Levitt--e3d1fd7c-ce25-4bb7-add8-d12950640509.jpg",
                    Description = "Joseph Leonard Gordon-Levitt was born February 17, 1981 in Los Angeles, California, to Jane Gordon and Dennis Levitt. Joseph was raised in a Jewish family with his late older brother, Dan Gordon-Levitt, who passed away in October 2010. His parents worked for the Pacifica Radio station KPFK-FM and his maternal grandfather, Michael Gordon, had been ..."


                },
                new Actor
                {
                    Id = 9,
                    Name = "Tom Hardy",
                    Birthday = new DateTime(1977, 09, 15),
                    Rating = 10.2,
                    Image = "Tom Hardy--cc26260e-c69f-4262-925b-32f0af2b8fc5.jpg",
                    Description = "With his breakthrough performance as Eames in Christopher Nolan's sci-fi thriller Inception (2010), English actor Tom Hardy has been brought to the attention of mainstream audiences worldwide. However, the versatile actor has been steadily working on both stage and screen since his television debut in the miniseries Band of Brothers (2001). After ..."

                },

                new Actor
                {
                    Id = 10,
                    Name = "Michael Caine",
                    Birthday = new DateTime(1933, 03, 14),
                    Rating = 9.2,
                    Image = "Michael Cain--4a1329ba-f3c3-469f-89d5-ee1c5c3eadcd.jpg",
                    Description = "Michael Caine was born Maurice Joseph Micklewhite in London, to Ellen Frances Marie (Burchell), a charlady, and Maurice Joseph Micklewhite, a fish-market porter. He left school at age 15 and took a series of working-class jobs before joining the British army and serving in Korea during the Korean War, where he saw combat. Upon his return to ..."

                },
                new Actor
                {
                    Id = 11,
                    Name = "Cillian Murphy",
                    Birthday = new DateTime(1976, 05, 25),
                    Rating = 10.9,
                    Image = "Cillian Murphy--2265ad64-8a71-4da4-a898-53c1a9c15791.jpg",
                    Description = "Striking Irish actor Cillian Murphy was born in Douglas, the oldest child of Brendan Murphy, who works for the Irish Department of Education, and a mother who is a teacher of French. He has three younger siblings. Murphy was educated at Presentation Brothers College, Cork. He went on to study law at University College Cork, but dropped out after ..."

                },
                new Actor
                {
                    Id = 12,
                    Name = "Marion Cotillard",
                    Birthday = new DateTime(1975, 09, 30),
                    Rating = 10.3,
                    Image = "Marion Cotillard--ab70db7f-1474-4683-bfcc-a1051b85691c.jpg",
                    Description = "Academy Award-winning actress Marion Cotillard was born on September 30, 1975 in Paris. Cotillard is the daughter of Jean-Claude Cotillard, an actor, playwright and director, and Niseema Theillaud, an actress and drama teacher. Her father's family is from Brittany. Raised in Orléans, France, she made her acting debut as a child with a role in one ... "

                },
                new Actor
                {
                    Id = 13,
                    Name = "Jason Flemyng",
                    Birthday = new DateTime(1966, 09, 25),
                    Rating = 9.3,
                    Image = "Jason Flemyng--39ae09e1-8325-43b0-a869-d662a56b5818.jpg",
                    Description = "Jason Flemyng was born on September 25, 1966 in Putney, London, England as Jason Iain Flemyng. He is an actor and producer, known for Lock, Stock and Two Smoking Barrels (1998), The Curious Case of Benjamin Button (2008) and Deep Rising (1998). He has been married to Elly Fairman since June 6, 2008."

                },
                new Actor
                {
                    Id = 14,
                    Name = "Jason Statham",
                    Birthday = new DateTime(1967, 07, 26),
                    Rating = 10.9,
                    Image = "Jason Statham--571b29e4-0eca-4f79-a832-6ab4a0ed906d.jpg",
                    Description = "Jason Statham was born in Shirebrook, Derbyshire, to Eileen (Yates), a dancer, and Barry Statham, a street merchant and lounge singer. He was a Diver on the British National Diving Team and finished twelfth in the World Championships in 1992. He has also been a fashion model, black market salesman and finally of course, actor. He received the ..."

                },
                new Actor
                {
                    Id = 15,
                    Name = "Vinnie Jones",
                    Birthday = new DateTime(1965, 01, 5),
                    Rating = 9.7,
                    Image = "Vinnie Jones--dc0031b4-5b0d-4b71-ba77-e39b2e1601d0.jpg",
                    Description = "Vincent Peter Jones was born on January 5, 1965 in Watford, England. He first came to public notice as a professional footballer, playing in the English Football League. Noted as one of football's hard men, he leaped to fame when a photographer, at a match, snapped him marking Newcastle United's Paul Gascoigne, by grabbing his testicles. He has ..."

                },
                new Actor
                {
                    Id = 16,
                    Name = "Robert Downey Jr.",
                    Birthday = new DateTime(1965, 04, 04),
                    Rating = 11.9,
                    Image = "Robert Downey Jr--8d269864-287f-40ba-b86d-74f00329be91.jpg",
                    Description = "Robert Downey Jr. has evolved into one of the most respected actors in Hollywood. With an amazing list of credits to his name, he has managed to stay new and fresh even after over four decades in the business. Downey was born April 4, 1965 in Manhattan, New York, the son of writer, director and filmographer Robert Downey Sr. and actress Elsie Downey..."

                },
                new Actor
                {
                    Id = 17,
                    Name = "Jude Law",
                    Birthday = new DateTime(1972, 12, 29),
                    Rating = 9.7,
                    Image = "Jude Law--2fe2b13d-b8e6-489e-997e-f62c8c1e0725.jpg",
                    Description = "Jude Law is an English actor. Law has been nominated for two Academy Awards and continues to build a prolific body of work that spans from early successes such as Gattaca (1997) and The Talented Mr. Ripley (1999) to more recent turns as Dr. John Watson in Sherlock Holmes (2009) and Sherlock Holmes: A Game of Shadows (2011), as Hugo's father in Hugo..."

                },
                new Actor
                {
                    Id = 18,
                    Name = "Mark Strong",
                    Birthday = new DateTime(1963, 08, 5),
                    Rating = 9.6,
                    Image = "Mark Strong--bde9e7fb-7e3f-418d-97d2-826e041171d6.jpg",
                    Description = "British actor Mark Strong, who played Jim Prideaux in the 2011 remake of Tinker Tailor Soldier Spy (2011), is often cast as cold, calculating villains. But before he became a famous actor, he intended to pursue a career in law. Strong was born Marco Giuseppe Salussolia in London, England, to an Austrian mother and an Italian father. His father left..."

                },
                new Actor
                {
                    Id = 19,
                    Name = "Jamie Foxx",
                    Birthday = new DateTime(1967, 12, 13),
                    Rating = 10.1,
                    Image = "Jamie Foxx--44f9c50f-bbbe-4049-8f8c-e86df663cfb4.jpg",
                    Description = "Jamie Foxx is an American actor, singer and comedian. He won an Academy Award for Best Actor, BAFTA Award for Best Actor in a Leading Role, and Golden Globe Award for Best Actor in a Musical or Comedy, for his work in the biographical film Ray (2004). The same year, he was nominated for the Academy Award for Best Supporting Actor for his role in ..."

                },
                new Actor
                {
                    Id = 20,
                    Name = "Christoph Waltz",
                    Birthday = new DateTime(1956, 10, 04),
                    Rating = 10.5,
                    Image = "Christoph Waltz--b7bd4de2-1536-405f-b460-ec32a601cb70.jpg",
                    Description = "Christoph Waltz is an Austrian-German actor. He is known for his work with American filmmaker Quentin Tarantino, receiving acclaim for portraying SS-Standartenführer Hans Landa in Inglourious Basterds (2009) and bounty hunter Dr. King Schultz in Django Unchained (2012). For each performance, he won an Academy Award, a BAFTA Award, and a Golden ..."
                },
                new Actor
                {
                    Id = 21,
                    Name = "Samuel L. Jackson",
                    Birthday = new DateTime(1948, 12, 21),
                    Rating = 11.7,
                    Image = "Samuel L Jackson--cbb52077-7f31-4e7d-b0fe-73a35589a1ed.jpg",
                    Description = "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard: With a Vengeance (1995), Unbreakable (2000), Shaft (2000), The 51st State (2001), Black Snake Moan (2006), Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe. ..."
                },
                new Actor
                {
                    Id = 22,
                    Name = "Kurt Russell",
                    Birthday = new DateTime(1951, 03, 17),
                    Rating = 10.3,
                    Image = "Kurt Russell--f9f3a0e2-b112-49cb-ab8c-d0dbb0353409.jpg",
                    Description = "Kurt Vogel Russell was born on March 17, 1951 in Springfield, Massachusetts, to Louise Julia Russell (née Crone), a dancer, and Bing Russell, an actor. He is of English, German, Scottish and Irish descent. His first roles were as a child on television series, including a lead role on the Western series The Travels of Jaimie McPheeters (1963). ..."
                },
                new Actor
                {
                    Id = 23,
                    Name = "Tim Roth",
                    Birthday = new DateTime(1961, 04, 14),
                    Rating = 10.9,
                    Image = "Tim Roth--12106310-2f00-410a-8cbb-20b4c142d976.jpg",
                    Description = "Often mistaken for an American because of his skill at imitating accents, actor Tim Roth was born Timothy Simon Roth on May 14, 1961 in Lambeth, London, England. His mother, Ann, was a teacher and landscape painter. His father, Ernie, was a journalist who had changed the family name from Smith to Roth; Ernie was born in Brooklyn, New York, to ... "
                },
                new Actor
                {
                    Id = 24,
                    Name = "Michael Madsen",
                    Birthday = new DateTime(1957, 09, 25),
                    Rating = 10.1,
                    Image = "Michael Madsen--49923597-e932-4797-8f2c-141e4855f3af.jpg",
                    Description = "Michael Madsen's long career spans nearly 40 years and more than 170 films in which he has played memorable characters in myriad box office hits, including: Kill Bill: Vol. 1 (2003), Kill Bill: Vol. 2 (2004) Sin City (2005), Hell Ride (2008), Die Another Day (2002), Donnie Brasco (1997), Species (1995), The Getaway (1994), Thelma & Louise (..."
                },
                new Actor
                {
                    Id = 25,
                    Name = "Samy Naceri",
                    Birthday = new DateTime(1961, 07, 02),
                    Rating = 10.9,
                    Image = "Samy Naceri--6bfda92a-99f8-47ec-a67f-ce41682fcae5.jpg",
                    Description = "Samy Naceri is born in Paris from an Algerian father and a French mother. He grew up in the suburbs of Paris in a modest family of seven siblings. Since his youngest age, Samy dreamt about making movies. After many years of struggling and hard work, he will finally have a chance to meet a famous casting director (Bruno Delahaye) who will offer him ..."
                },
                new Actor
                {
                    Id = 26,
                    Name = "Frédéric Diefenthal",
                    Birthday = new DateTime(1968, 07, 26),
                    Rating = 9.7,
                    Image = "Frederic Diefenthal--c5cb3a61-5bd5-4a21-9dba-a3708c1a5ba9.jpg",
                    Description = "Frédéric Diefenthal was born on July 26, 1968 in Saint-Mandé, Val-de-Marne, France as Frédéric Pierre Diefenthal-Girau-Guyard. He is an actor and producer, known for Taxi (1998), Taxi 4 (2007) and Taxi 3 (2003). He was previously married to Gwendoline Hamon."
                },
                new Actor
                {
                    Id = 27,
                    Name = "Robert De Niro",
                    Birthday = new DateTime(1943, 08, 17),
                    Rating = 12.1,
                    Image = "Robert De Niro--4b3892c6-4bb5-4fdd-a0d9-d14a0d09f6f3.jpg",
                    Description = "One of the greatest actors of all time, Robert De Niro was born on August 17, 1943 in Manhattan, New York City, to artists Virginia (Admiral) and Robert De Niro Sr. His paternal grandfather was of Italian descent, and his other ancestry is Irish, English, Dutch, German, and French. He was trained at the Stella Adler Conservatory and the American ..."
                },
                new Actor
                {
                    Id = 28,
                    Name = "Michelle Pfeiffer",
                    Birthday = new DateTime(1958, 04, 29),
                    Rating = 10.1,
                    Image = "Michelle Pfeiffer--c0b03f74-aa00-4780-904e-63f987105c7e.jpg",
                    Description = "Michelle Pfeiffer was born in Santa Ana, California to Dick and Donna Pfeiffer. She has an older brother and two younger sisters - Dedee Pfeiffer, and Lori Pfeiffer, who both dabbled in acting and modeling but decided against making it their lives' work. She graduated from Fountain Valley High School in 1976, and attended one year at the Golden ..."
                },
                new Actor
                {
                    Id = 29,
                    Name = "Tommy Lee Jones",
                    Birthday = new DateTime(1946, 09, 15),
                    Rating = 11.9,
                    Image = "Tommy Lee Jones--3dae989f-7820-4935-b9df-e838db27bdf6.jpg",
                    Description = "Tommy Lee Jones was born in San Saba, Texas, the son of Lucille Marie (Scott), a police officer and beauty shop owner, and Clyde C. Jones, who worked on oil fields. Tommy himself worked in underwater construction and on an oil rig. He attended St. Mark's School of Texas, a prestigious prep school for boys in Dallas, on a scholarship, and went to ..."
                },
                new Actor
                {
                    Id = 30,
                    Name = "Jean Reno",
                    Birthday = new DateTime(1948, 07, 30),
                    Rating = 11.7,
                    Image = "Jean Reno--5fb8a62d-76ef-4dc2-9395-9c58cad00ca9.jpg",
                    Description = "Jean Reno was born Juan Moreno y Herrera-Jiménez in Casablanca, Morocco, to Spanish parents (from Andalucía) who moved to North Africa to seek work. His father was a linotypist. Reno settled in France at 17. He began studying drama and has credits in French television and theater as well as films. His first two marriages both ended in divorce, and... "
                },
                new Actor
                {
                    Id = 31,
                    Name = "Gary Oldman",
                    Birthday = new DateTime(1958, 03, 21),
                    Rating = 10.9,
                    Image = "Gary Oldman--b00256e6-4062-48e9-b78c-31987722644e.jpg",
                    Description = "Gary Oldman is a talented English movie star and character actor, renowned for his expressive acting style. One of the most celebrated thespians of his generation, with a diverse career encompassing theatre, film and television, he is known for his roles as Sid Vicious in Sid and Nancy (1986), Drexl in True Romance (1993), George Smiley in Tinker ..."
                },
                new Actor
                {
                    Id = 32,
                    Name = "Natalie Portman",
                    Birthday = new DateTime(1981, 06, 09),
                    Rating = 9.7,
                    Image = "Natalie Portman--6e1e75b7-0825-4cb9-ad4c-edb1d5e1c066.jpg",
                    Description = "Natalie Portman is the first person born in the 1980s to have won the Academy Award for Best Actress (for Black Swan (2010)). Natalie was born Natalie Hershlag on June 9, 1981, in Jerusalem, Israel. She is the only child of Avner Hershlag, a Israeli-born doctor, and Shelley Stevens, an American-born artist (from Cincinnati, Ohio), who also acts as ..."
                },
                new Actor
                {
                    Id = 33,
                    Name = "Hugh Jackman",
                    Birthday = new DateTime(1968, 10, 12),
                    Rating = 10.6,
                    Image = "Hugh Jackman--cdb0aa4e-8478-4081-bfea-2de2551224b2.jpg",
                    Description = "Hugh Michael Jackman is an Australian actor, singer, multi-instrumentalist, dancer and producer. Jackman has won international recognition for his roles in major films, notably as superhero, period, and romance characters. He is best known for his long-running role as Wolverine in the X-Men film series, as well as for his lead roles in the ..."
                },
                new Actor
                {
                    Id = 34,
                    Name = "Scarlett Johansson",
                    Birthday = new DateTime(1984, 11, 22),
                    Rating = 10.5,
                    Image = "Scarlett Johansson--e34e9d1f-6866-4384-ba63-93d0bb0ed526.jpg",
                    Description = "Scarlett Ingrid Johansson was born on November 22, 1984 in Manhattan, New York City, New York. Her mother, Melanie Sloan is from a Jewish family from the Bronx and her father, Karsten Johansson is a Danish-born architect from Copenhagen. She has a sister, Vanessa Johansson, who is also an actress, a brother, Adrian, a twin brother, Hunter Johansson..."
                },
                new Actor
                {
                    Id = 35,
                    Name = "Mark Ruffalo",
                    Birthday = new DateTime(1967, 11, 22),
                    Rating = 10.5,
                    Image = "Mark Ruffalo--f5ce9649-c855-4694-aef3-17d89ea9b46e.jpg",
                    Description = "Award-winning actor Mark Ruffalo was born on November 22, 1967, in Kenosha, Wisconsin, of humble means to father Frank Lawrence Ruffalo, a construction painter and Marie Rose (Hebert), a stylist and hairdresser; his father's ancestry is Italian and his mother is of half French-Canadian and half Italian descent. Mark moved with his family to ..."
                },
                new Actor
                {
                    Id = 36,
                    Name = "Bill Skarsgård",
                    Birthday = new DateTime(1990, 08, 09),
                    Rating = 9.9,
                    Image = "Bill Skarsgard--346a9d0e-6157-498c-a2c7-cc2b087491c6.jpg",
                    Description = "Bill Skarsgård was born on August 9, 1990 in Vällingby, Sweden as Bill Istvan Günther Skarsgård. He is an actor and producer, known for It (2017), It: Chapter Two (2019) and Deadpool 2 (2018)."
                },
                new Actor
                {
                    Id = 37,
                    Name = "Sophia Lillis",
                    Birthday = new DateTime(2002, 02, 13),
                    Rating = 9.2,
                    Image = "Sophia Lillis--ae27a52f-8b18-4f9e-8679-458237baffbb.jpg",
                    Description = "Sophia Lillis was born in Crown Heights, Brooklyn. She started her acting career at the age of seven, when her stepfather encouraged her to take acting classes at Lee Strasberg Theatre and Film Institute in Manhattan. While studying there, a teacher recommended her for a role in an NYU student film. She then signed a deal with an agent and started..."
                },
                new Actor
                {
                    Id = 38,
                    Name = "John Travolta",
                    Birthday = new DateTime(1954, 02, 18),
                    Rating = 10.9,
                    Image = "John Travolta--042fccc4-fe89-455f-97d8-fc0063203b8b.jpg",
                    Description = "John Joseph Travolta was born in Englewood, New Jersey, one of six children of Helen Travolta (née Helen Cecilia Burke) and Salvatore/Samuel J. Travolta. His father was of Italian descent and his mother was of Irish ancestry. His father owned a tire repair shop called Travolta Tires in Hillsdale, NJ. Travolta started acting appearing in a local ..."
                },
                new Actor
                {
                    Id = 39,
                    Name = "Uma Thurman",
                    Birthday = new DateTime(1970, 04, 29),
                    Rating = 11.0,
                    Image = "Uma Thurman--d7e85d7d-70dd-4c4c-bca6-b535bbc02406.jpg",
                    Description = "Uma Karuna Thurman was born in Boston, Massachusetts, into a highly unorthodox and internationally-minded family. She is the daughter of Nena Thurman (née Birgitte Caroline von Schlebrügge), a fashion model and socialite who now runs a mountain retreat, and of Robert Thurman (Robert Alexander Farrar Thurman), a professor and academic who is one of..."
                },
                new Actor
                {
                    Id = 40,
                    Name = "Bruce Willis",
                    Birthday = new DateTime(1955, 03, 19),
                    Rating = 11.5,
                    Image = "Bruce Willis--4e95b8ae-dad4-4e7d-bdef-7fc555815c02.jpg",
                    Description = "Actor and musician Bruce Willis is well known for playing wisecracking or hard-edged characters, often in spectacular action films. Collectively, he has appeared in films that have grossed in excess of $2.5 billion USD, placing him in the top ten stars in terms of box office receipts. Walter Bruce Willis was born on March 19, 1955, in ... "
                },
                new Actor
                {
                    Id = 41,
                    Name = "Keanu Reeves",
                    Birthday = new DateTime(1964, 09, 02),
                    Rating = 11.7,
                    Image = "Keanu Reeves--8b83d385-87a2-4b66-bde6-f0130efc3785.jpg",
                    Description = "Keanu Charles Reeves, whose first name means cool breeze over the mountains in Hawaiian, was born September 2, 1964 in Beirut, Lebanon. He is the son of Patricia Taylor, a showgirl and costume designer, and Samuel Nowlin Reeves, a geologist. Keanu's father was born in Hawaii, of British, Portuguese, Native Hawaiian, and Chinese ancestry, and ..."
                },
                new Actor
                {
                    Id = 42,
                    Name = "Laurence Fishburne",
                    Birthday = new DateTime(1961, 07, 30),
                    Rating = 10.2,
                    Image = "Laurence Fishburne--a17f41cd-f562-471d-9c7b-811367255624.jpg",
                    Description = "Critically hailed for his forceful, militant, authoritative figures and one of Hollywood's most talented and versatile performers, Laurence (John) Fishburne III has been the recipient of numerous awards, including a number of NAACP Image honors. Born in Augusta, Georgia on July 30, 1961, to Hattie Bell (Crawford), a teacher, and Laurence John ..."
                },
                new Actor
                {
                    Id = 43,
                    Name = "Carrie-Anne Moss",
                    Birthday = new DateTime(1967, 08, 21),
                    Rating = 10.0,
                    Image = "Carrie-Anne Moss--ced7b68c-ce41-4178-aeb1-bd875150177b.jpg",
                    Description = "Carrie-Anne Moss was born and raised in Vancouver, Canada. At age 20, after studying at the American Academy of Dramatic Arts, she moved to Europe to pursue a career in modeling. While in Spain she was cast in the TV show Dark Justice which was produced in Barcelona for its first season and Los Angeles for its second. Once in LA, Carrie-Anne was ..."
                },
                new Actor
                {
                    Id = 44,
                    Name = "Hugo Weaving",
                    Birthday = new DateTime(1960, 04, 04),
                    Rating = 9.7,
                    Image = "Hugo Weaving--738b5541-6bee-43ad-bae1-b4ae24db5ddd.jpg",
                    Description = "Hugo Wallace Weaving was born on April 4, 1960 in Nigeria, to English parents Anne (Lennard), a tour guide and teacher, and Wallace Weaving, a seismologist. Hugo has an older brother, Simon, and a younger sister, Anna, who both also live and work in Australia. During his early childhood, the Weaving family spent most of their time traveling ..."
                }


);


        }
    }
}
