using Microsoft.EntityFrameworkCore;
using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Infrastructure.Seed
{
    public class MovieSeeder
    {
        public static void SeedMovies(ModelBuilder builder)
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3, Director = "Frank Darabont", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg",
                TrailerUrl = "https://www.youtube.com/embed/6hB3S9bIaco",
                Description = "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit. The film portrays the man's unique way of dealing with his new, torturous life; along the way he befriends a number of fellow prisoners, most notably a wise long-term inmate named Red." },

                new Movie { Id = 2, Title = "The Godfather", Year = 1972, Rating = 9.2, Director = "Francis Ford Coppola", Genre = "Crime",
                PosterUrl = "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg",
                TrailerUrl = "https://www.youtube.com/embed/sY1S34973zA",
                Description = "The Godfather 'Don' Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. His youngest son, Michael, and a decorated WWII marine is also at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not." },

                new Movie { Id = 3, Title = "The Dark Knight", Year = 2008, Rating = 9.0, Director = "Christopher Nolan", Genre = "Action",
                PosterUrl = "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
                TrailerUrl = "https://www.youtube.com/embed/EXeTwQWrcwY",
                Description = "With the help of allies Lt. Jim Gordon and DA Harvey Dent, Batman has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism as he fights to prevent the city from falling into complete anarchy." },

                new Movie { Id = 4, Title = "Pulp Fiction", Year = 1994, Rating = 8.9, Director = "Quentin Tarantino", Genre = "Crime",
                PosterUrl = "https://image.tmdb.org/t/p/w500/fIE3lAGcZDV1G6XM5KmuWnNsPp1.jpg",
                TrailerUrl = "https://www.youtube.com/embed/s7EdQ4FqbhY",
                Description = "Jules Winnfield and Vincent Vega are two hitmen who are out to retrieve a suitcase stolen from their employer, mob boss Marsellus Wallace. Wallace has also asked Vincent to take his wife Mia out a few days later while Wallace himself is out of town. Butch Coolidge is an aging boxer who is paid by Wallace to lose his fight. The lives of these seemingly unrelated people are woven together comprising of a series of funny, bizarre and uncalled-for incidents." },

                new Movie { Id = 5, Title = "The Lord of the Rings: The Return of the King", Year = 2003, Rating = 8.9, Director = "Peter Jackson", Genre = "Fantasy",
                PosterUrl = "https://image.tmdb.org/t/p/w500/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg",
                TrailerUrl = "https://www.youtube.com/embed/r5X-hFf6Bwo",
                Description = "The final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Frodo and Sam reach Mordor in their quest to destroy the One Ring, while Aragorn leads the forces of good against Sauron's evil army at the stone city of Minas Tirith. As the end of the journey draws near, the true strength of heroes is tested in a battle that will decide the fate of all life." },

                new Movie { Id = 6, Title = "Forrest Gump", Year = 1994, Rating = 8.8, Director = "Robert Zemeckis", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/saHP97rTPS5eLmrLQEcANmKrsFl.jpg",
                TrailerUrl = "https://www.youtube.com/embed/bLvqoHBptjg",
                Description = "Forrest Gump is a simple man with a low I.Q. but good intentions. He is running through childhood with his best and only friend Jenny. His 'mama' teaches him the ways of life and leaves him to choose his destiny. Forrest joins the army for service in Vietnam, finding new friends called Dan and Bubba, he wins medals, creates a famous shrimp fishing fleet, inspires people to jog, starts a ping-pong craze, and meets the president several times." },

                new Movie { Id = 7, Title = "Fight Club", Year = 1999, Rating = 8.8, Director = "David Fincher", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/bptfVGEQuv6vDTIMVCHjJ9Dz8PX.jpg",
                TrailerUrl = "https://www.youtube.com/embed/SUXWAEX2jlg",
                Description = "A nameless first person narrator attends support groups in attempts to subdue his emotional state and relieve his insomniac state. When he meets Tyler Durden, he is dragged into an underground fight club and soap making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power in a world where modern consumerist society is the enemy." },

                new Movie { Id = 8, Title = "Inception", Year = 2010, Rating = 8.7, Director = "Christopher Nolan", Genre = "Sci-Fi",
                PosterUrl = "https://image.tmdb.org/t/p/w500/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg",
                TrailerUrl = "https://www.youtube.com/embed/YoHD9XEInc0",
                Description = "Dom Cobb is a skilled thief, the absolute best in the dangerous art of extraction, stealing valuable secrets from deep within the subconscious during the dream state, when the mind is at its most vulnerable. Cobb's rare ability has made him a coveted player in this treacherous new world of corporate espionage, but it has also made him an international fugitive and cost him everything he has ever loved. Now Cobb is offered a chance at redemption." },

                new Movie { Id = 9, Title = "The Matrix", Year = 1999, Rating = 8.7, Director = "The Wachowskis", Genre = "Sci-Fi",
                PosterUrl = "https://image.tmdb.org/t/p/w500/f89U3ADr1oiB1s9GkdPOEpXUk5H.jpg",
                TrailerUrl = "https://www.youtube.com/embed/vKQi3bBA1y8",
                Description = "Thomas A. Anderson is a man living two lives. By day he is an average computer programmer and by night a hacker known as Neo. Neo has always questioned his reality, but the truth is far beyond his imagination. Neo finds himself targeted by the police when he is contacted by Morpheus, a legendary computer hacker branded a terrorist by the government, who leads him into a gritty underworld where he discovers the shocking truth: the life he knows is the elaborate deception of an evil cyber-intelligence." },

                new Movie { Id = 10, Title = "Goodfellas", Year = 1990, Rating = 8.7, Director = "Martin Scorsese", Genre = "Crime",
                PosterUrl = "https://image.tmdb.org/t/p/w500/aKuFiU82s5ISJpGZp7YkIr3kCUd.jpg",
                TrailerUrl = "https://www.youtube.com/embed/qo5jJpHtI1Y",
                Description = "Henry Hill is a small-time gangster who takes part in a robbery with Jimmy Conway and Tommy De Vito, two other gangsters who might be getting a little too ambitious. Tommy and Jimmy kill everyone else who was involved in the robbery, and slowly start to run the Italian mob. Henry, however, is badly affected by his partners' success, and eventually turns into an informant for the FBI to save his own life and his family." },

                new Movie { Id = 11, Title = "Se7en", Year = 1995, Rating = 8.6, Director = "David Fincher", Genre = "Thriller",
                PosterUrl = "https://image.tmdb.org/t/p/w500/6yoghtyTpznpBik8EngEmJskVUO.jpg",
                TrailerUrl = "https://www.youtube.com/embed/znmZoVkCjpI",
                Description = "A film about two undercover detectives, Somerset and Mills, on a desperate hunt for a serial killer who justifies his crimes as absolution for the world's ignorance of the Seven Deadly Sins. The movie takes us from the tortured remains of one victim to the next as the sociopathic 'John Doe' sermonizes to Detectives Somerset and Mills one sin at a time. The sin of Gluttony comes first, and the killer's terrible capacity is graphically demonstrated in the dark and subdued tones characteristic of film noir." },

                new Movie { Id = 12, Title = "Interstellar", Year = 2014, Rating = 8.6, Director = "Christopher Nolan", Genre = "Sci-Fi",
                PosterUrl = "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg",
                TrailerUrl = "https://www.youtube.com/embed/zSWdZVtXT7E",
                Description = "In Earth's future, a global crop blight and second Dust Bowl are slowly rendering the planet uninhabitable. Professor Brand, a brilliant NASA physicist, is working on plans to save mankind by transporting Earth's population to a new home via a wormhole. But first, Brand must send former NASA pilot Cooper and a team of researchers through the wormhole and across the galaxy to find out which of three planets could be mankind's new home." },

                new Movie { Id = 13, Title = "The Silence of the Lambs", Year = 1991, Rating = 8.6, Director = "Jonathan Demme", Genre = "Thriller",
                PosterUrl = "https://image.tmdb.org/t/p/w500/uS9m8OBk1A8eM9I042bx8XXpqAq.jpg",
                TrailerUrl = "https://www.youtube.com/embed/W6Mm8Sbe__o",
                Description = "Clarice Starling, a young intelligent FBI trainee, has been sent to the Baltimore state hospital for the criminally insane to interview an inmate, Dr. Hannibal 'the Cannibal' Lecter, a brilliant psychiatrist and a gruesome killer. She believes Lecter may have insight into a case and that her classification as an attractive young woman may dally him into talking. Her task is to get Lecter to help the FBI catch 'Buffalo Bill', a serial killer who has been skinning young women." },

                new Movie { Id = 14, Title = "Saving Private Ryan", Year = 1998, Rating = 8.6, Director = "Steven Spielberg", Genre = "War",
                PosterUrl = "https://image.tmdb.org/t/p/w500/uqx37cS8cpHg8U35f9U5IBlrCV3.jpg",
                TrailerUrl = "https://www.youtube.com/embed/9CiW_DgxCnQ",
                Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action. Captain John Miller and his seven men must navigate through the horrific reality of war to find one man, Private James Ryan, and bring him home. As the squad pushes deeper into German-held territory, they begin to question why one man's life is worth more than all of theirs." },

                new Movie { Id = 15, Title = "City of God", Year = 2002, Rating = 8.6, Director = "Fernando Meirelles", Genre = "Crime",
                PosterUrl = "https://image.tmdb.org/t/p/w500/k7eYdWvhYQyRQoU2TB2A2Xu2TfD.jpg",
                TrailerUrl = "https://www.youtube.com/embed/dcUOO4Itgmw",
                Description = "In the poverty-stricken favelas of Rio de Janeiro in the 1970s, two young men choose different paths. Rocket is a budding photographer who documents the increasing drug-related violence of his neighborhood, while Zé Pequeno is an ambitious drug dealer who uses Rocket and his photos as a way to increase his fame as a gang leader. This visceral journey depicts the cyclical nature of violence in a world where hope is a rare commodity." },

                new Movie { Id = 16, Title = "The Green Mile", Year = 1999, Rating = 8.6, Director = "Frank Darabont", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/o0lO84GI7qrG6XFvtsPOSV7CTNa.jpg",
                TrailerUrl = "https://www.youtube.com/embed/Ki4haFrqSrw",
                Description = "Death Row guards at a penitentiary, in the 1930s, have a moral dilemma with their job when they discover one of their prisoners, a convicted murderer, has a special gift. John Coffey, a giant of a man who is as gentle as a lamb, possesses the ability to heal the sick and wounded. As the guards witness his miracles, they begin to doubt his guilt and struggle with the reality of his impending execution." },

                new Movie { Id = 17, Title = "Parasite", Year = 2019, Rating = 8.5, Director = "Bong Joon-ho", Genre = "Thriller",
                PosterUrl = "https://image.tmdb.org/t/p/w500/7IiTTgloJzvGI1TAYymCfbfl3vT.jpg",
                TrailerUrl = "https://www.youtube.com/embed/SEUXfv87Wpk",
                Description = "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan. The Kims, living in a cramped sub-basement, slowly infiltrate the Parks' luxurious home by posing as unrelated, highly qualified workers. As their lives become inextricably intertwined, a series of dark events unfolds, exposing the harsh realities of social inequality in modern Korea." },

                new Movie { Id = 18, Title = "Léon: The Professional", Year = 1994, Rating = 8.5, Director = "Luc Besson", Genre = "Action",
                PosterUrl = "https://image.tmdb.org/t/p/w500/yI6X2cCM5YPJtxMhUd3dPGqDAhw.jpg",
                TrailerUrl = "https://www.youtube.com/embed/jawVxq1Iyl0",
                Description = "Léon, a professional hitman, reluctantly takes in 12-year-old Mathilda after her family is murdered by corrupt DEA agents. As the two form an unusual bond, Léon begins to teach Mathilda the 'cleaner' trade, while she helps him rediscover his humanity. Their relationship is put to the ultimate test as they seek revenge against the man responsible for the death of her family." },

                new Movie { Id = 19, Title = "Gladiator", Year = 2000, Rating = 8.5, Director = "Ridley Scott", Genre = "Action",
                PosterUrl = "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg",
                TrailerUrl = "https://www.youtube.com/embed/owK1qxDselE",
                Description = "Maximus is a powerful Roman general, loved by the people and the aging Emperor, Marcus Aurelius. Before his death, the Emperor chooses Maximus to be his heir over his own son, Commodus, and a power struggle leaves Maximus and his family condemned to death. The powerful general is unable to save his family, and his loss of will allows him to get captured and put into the Gladiator games until he dies." },

                new Movie { Id = 20, Title = "Whiplash", Year = 2014, Rating = 8.5, Director = "Damien Chazelle", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/6uSPcdGJAkF6P5kP1K9z5i2nV8p.jpg",
                TrailerUrl = "https://www.youtube.com/embed/7d_jQycdQGo",
                Description = "Andrew Neiman is an ambitious young jazz drummer, single-minded in his pursuit to rise to the top of his elite East Coast music conservatory. Terence Fletcher, an instructor equally known for his terrifying teaching methods as he is for his musical genius, discovers Andrew and transfers the aspiring drummer into his band. Andrew's passion to achieve perfection quickly spirals into obsession, as his ruthless teacher continues to push him to the brink of both his ability and his sanity." },

                new Movie { Id = 21, Title = "The Prestige", Year = 2006, Rating = 8.5, Director = "Christopher Nolan", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/5MXyQfz8xUP3dIFPTubhTsbFY6N.jpg",
                TrailerUrl = "https://www.youtube.com/embed/o4gHCmTQDVI",
                Description = "In the end of the 19th century, in London, Robert Angier, his beloved wife Julia McCullough, and Alfred Borden are friends and assistants of a magician. When Julia accidentally dies during a performance, Robert blames Alfred for her death and they become enemies. As both become famous and rival magicians, they start a deadly competition that pushes their obsession to the extreme with tragic consequences." },

                new Movie { Id = 22, Title = "The Departed", Year = 2006, Rating = 8.5, Director = "Martin Scorsese", Genre = "Crime",
                PosterUrl = "https://image.tmdb.org/t/p/w500/nT97ifVT2J1yMQmeqJ6K94mEZM1.jpg",
                TrailerUrl = "https://www.youtube.com/embed/iojhqm0JTW4",
                Description = "To take down South Boston's Irish Mafia, the police send in one of their own to infiltrate the organization, unaware the syndicate has done the same thing. Billy Costigan is a young undercover cop assigned to infiltrate the mob syndicate run by gangland chief Frank Costello. While Billy quickly gains Costello's confidence, Colin Sullivan, a hardened young criminal who has infiltrated the state police department as an informer for the syndicate, is rising to a position of power." },

                new Movie { Id = 23, Title = "The Pianist", Year = 2002, Rating = 8.5, Director = "Roman Polanski", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/2hFvxCCWrTmCYwfy7yum0GKRi3Y.jpg",
                TrailerUrl = "https://www.youtube.com/embed/BFwGqLa_oAo",
                Description = "A brilliant Polish pianist, Wladyslaw Szpilman, a Jew, is playing the piano on the radio in Warsaw when the first German bombs fall in 1939. During the occupation, he and his family are forced into the Warsaw Ghetto, where they face horrific conditions and the threat of deportation to the concentration camps. Szpilman manages to survive by hiding in the ruins of the city with the help of a few brave Polish resistance members and a sympathetic German officer." },

                new Movie { Id = 24, Title = "The Lion King", Year = 1994, Rating = 8.5, Director = "Roger Allers", Genre = "Animation",
                PosterUrl = "https://image.tmdb.org/t/p/w500/2bXbqYdUdNVa8VIWXVfclP2ICtT.jpg",
                TrailerUrl = "https://www.youtube.com/embed/4sj1MT05lAA",
                Description = "A young lion prince, Simba, is born to King Mufasa and Queen Sarabi, and is the heir to the Pride Lands. However, Mufasa's brother, Scar, is jealous of Simba's position and plots to kill both Mufasa and Simba to become king himself. After Mufasa's death, Scar convinces Simba that he is responsible and tells him to run away. Simba finds a new life with the help of a meerkat and a warthog, but eventually realizes he must return to reclaim his rightful place." },

                new Movie { Id = 25, Title = "Terminator 2: Judgment Day", Year = 1991, Rating = 8.5, Director = "James Cameron", Genre = "Sci-Fi",
                PosterUrl = "https://image.tmdb.org/t/p/w500/5M0j0B18abtBI5gi2RhfjjurTqb.jpg",
                TrailerUrl = "https://www.youtube.com/embed/CRRlbK5w8AE",
                Description = "Over 10 years have passed since the first machine tried to kill Sarah Connor and her unborn son, John. Now John, the future leader of the resistance, is a young boy. However, another Terminator, the more advanced and deadly T-1000, is sent back through time with a mission to kill John Connor while he's still a child. However, Sarah and John don't have to face this threat alone. Another Terminator, a reprogrammed T-800, is also sent back to protect them." },

                new Movie { Id = 26, Title = "Back to the Future", Year = 1985, Rating = 8.5, Director = "Robert Zemeckis", Genre = "Sci-Fi",
                PosterUrl = "https://image.tmdb.org/t/p/w500/pTpxQB1N0waaSc3OSn0e9oc8kx9.jpg",
                TrailerUrl = "https://www.youtube.com/embed/qvsgGtivCgs",
                Description = "Marty McFly, a typical American teenager of the Eighties, is accidentally sent back to 1955 in a plutonium-powered DeLorean 'time machine' invented by slightly mad scientist Doc Brown. During his often hysterical, always amazing trip back in time, Marty must make certain his teenage parents-to-be meet and fall in love - or he'll never exist. Even more dauntingly, Marty has to return to the future and save Doc Brown from a tragic fate." },

                new Movie { Id = 27, Title = "American History X", Year = 1998, Rating = 8.5, Director = "Tony Kaye", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/c2gsmSQ2Cqv8zosqKOCwRS0GFBS.jpg",
                TrailerUrl = "https://www.youtube.com/embed/XfQYHqsiN5g",
                Description = "Derek Vinyard is paroled after serving 3 years in prison for killing two thugs who tried to break into his truck. Through his brother, Danny Vinyard's narration, we learn that before going to prison, Derek was a skinhead and the leader of a violent white supremacist gang. Danny, who is following in his brother's footsteps, is asked by his high school principal to write a report on Derek. Now reformed, Derek tries to prevent his younger brother from going down the same path of hatred." },

                new Movie { Id = 28, Title = "The Usual Suspects", Year = 1995, Rating = 8.5, Director = "Bryan Singer", Genre = "Crime",
                PosterUrl = "https://image.tmdb.org/t/p/w500/bUPmtQzrRhzqYySeiMpv7GurAfm.jpg",
                TrailerUrl = "https://www.youtube.com/embed/oiXdPolca5w",
                Description = "Following a truck hijack in New York, five conmen are arrested and brought together for questioning. As none of them are guilty, they plan a revenge operation against the police. The operation goes well, but then the influence of a legendary mastermind criminal, Keyser Söze, is felt. It becomes clear that each one of them has wronged Söze at some point and must now pay him back. The payback job leaves 27 men dead in a boat explosion, but the real question arises: Who is Keyser Söze?" },

                new Movie { Id = 29, Title = "Spirited Away", Year = 2001, Rating = 8.6, Director = "Hayao Miyazaki", Genre = "Animation",
                PosterUrl = "https://image.tmdb.org/t/p/w500/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg",
                TrailerUrl = "https://www.youtube.com/embed/ByXuk9QqQkk",
                Description = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts. After her parents are turned into pigs, Chihiro must find the courage to work in a bathhouse for spirits and find a way to free herself and her parents from the magical world. Along the way, she meets an array of strange and wonderful characters, and learns the importance of her name and identity." },

                new Movie { Id = 30, Title = "The Intouchables", Year = 2011, Rating = 8.5, Director = "Olivier Nakache", Genre = "Comedy",
                PosterUrl = "https://image.tmdb.org/t/p/w500/4mFsNQwbD0F237Tx7gAPotd0nbJ.jpg",
                TrailerUrl = "https://www.youtube.com/embed/34WIbmXkewU",
                Description = "A true story of two men who should never have met – a quadriplegic aristocrat who was injured in a paragliding accident and a young man from the projects. Driss, a young man out of jail, is hired as the caretaker for Philippe, a wealthy quadriplegic. Despite their different backgrounds, the two men form an unlikely friendship and help each other find a new lease on life. This heartwarming story explores the power of friendship and the importance of looking beyond appearances." },

                new Movie { Id = 31, Title = "Modern Times", Year = 1936, Rating = 8.5, Director = "Charlie Chaplin", Genre = "Comedy",
                PosterUrl = "https://image.tmdb.org/t/p/w500/7u0aYf8E3a2RZkHcZ9zH8fF2A3I.jpg",
                TrailerUrl = "https://www.youtube.com/embed/GLeDdzGUTq0",
                Description = "A factory worker is driven to a nervous breakdown by the repetitive and soul-crushing nature of his job on an assembly line. After being released from a mental institution, he finds himself caught up in a series of misadventures, including being mistaken for a communist leader and ending up in jail. Along the way, he meet a young orphan girl and the two struggle to find happiness and survive in an increasingly industrialized and uncaring society." },

                new Movie { Id = 32, Title = "Psycho", Year = 1960, Rating = 8.5, Director = "Alfred Hitchcock", Genre = "Horror",
                PosterUrl = "https://image.tmdb.org/t/p/w500/81d8oyEFgj7FlxJqSDXWr8JH8kV.jpg",
                TrailerUrl = "https://www.youtube.com/embed/Wz719b9QUqY",
                Description = "Phoenix secretary Marion Crane, on the lam after stealing $40,000 from her employer in order to run away with her boyfriend, Sam Loomis, is overcome by exhaustion during a heavy rainstorm. Traveling on the main highway, she stops for the night at the ramshackle Bates Motel and meets the polite but highly strung proprietor Norman Bates, a young man with an interest in taxidermy and a difficult relationship with his mother." },

                new Movie { Id = 33, Title = "Once Upon a Time in the West", Year = 1968, Rating = 8.5, Director = "Sergio Leone", Genre = "Western",
                PosterUrl = "https://image.tmdb.org/t/p/w500/9uGHEgsiUXjCNq8wdq4r49YL8A1.jpg",
                TrailerUrl = "https://www.youtube.com/embed/ojrVbm5p-UE",
                Description = "There's a single piece of land around Flagstone with water on it, and rail baron Morton hopes to acquire it, knowing the railroad will have to stop there. He sends his henchman Frank to scare the land's owner, McBain, but Frank kills him instead and frames the bandit Cheyenne. Meanwhile, a mysterious stranger with a harmonica arrives in town with his own score to settle with Frank. The lives of these characters intertwine in an epic tale of revenge and the changing American West." },

                new Movie { Id = 34, Title = "Casablanca", Year = 1942, Rating = 8.5, Director = "Michael Curtiz", Genre = "Romance",
                PosterUrl = "https://image.tmdb.org/t/p/w500/5K7cOHoay2mZusSLezBOY0Qxh8a.jpg",
                TrailerUrl = "https://www.youtube.com/embed/BkL9l7qovsE",
                Description = "Rick Blaine, a cynical American expatriate, owns a popular nightclub in Vichy-controlled Casablanca during World War II. When his former lover, Ilsa Lund, arrives with her husband, a renowned resistance leader, Rick is forced to choose between his personal feelings and the greater good. As the war intensifies, Rick must decide whether to help Ilsa and her husband escape the Nazis or seek his own personal happiness." },

                new Movie { Id = 35, Title = "City Lights", Year = 1931, Rating = 8.5, Director = "Charlie Chaplin", Genre = "Comedy",
                PosterUrl = "https://image.tmdb.org/t/p/w500/uZBW2Gf8r8y2UP2Y4Wf0xZPjQzN.jpg",
                TrailerUrl = "https://www.youtube.com/embed/7vl7F8S4cpQ",
                Description = "The Little Tramp falls in love with a beautiful blind flower girl, who mistakes him for a wealthy Duke. When he learns that she and her grandmother are facing eviction and that a costly operation could restore her sight, he sets out to raise the money through a series of misadventures, including a job as a street sweeper and a hilarious stint as a prizefighter. Along the way, he befriends a suicidal millionaire who only recognizes him when he's drunk." },

                new Movie { Id = 36, Title = "The Shining", Year = 1980, Rating = 8.4, Director = "Stanley Kubrick", Genre = "Horror",
                PosterUrl = "https://image.tmdb.org/t/p/w500/9fgh3Ns1iRzlQNYuJyK0ARQZU7w.jpg",
                TrailerUrl = "https://www.youtube.com/embed/5Cb3ik6zP2I",
                Description = "Jack Torrance, a writer and recovering alcoholic, takes a job as an off-season caretaker at the isolated Overlook Hotel in the Colorado Rockies. He settles in with his wife, Wendy, and son, Danny, who possesses 'the shining,' a psychic ability that allows him to see the hotel's horrific past. As the winter isolation sets in, Jack's sanity begins to unravel as the hotel's malevolent spirits influence him, leading to a terrifying confrontation." },

                new Movie { Id = 37, Title = "Avengers: Infinity War", Year = 2018, Rating = 8.4, Director = "Anthony Russo", Genre = "Action",
                PosterUrl = "https://image.tmdb.org/t/p/w500/7WsyChQLEftFiDOVTGkv3hFpyyt.jpg",
                TrailerUrl = "https://www.youtube.com/embed/6ZfuNTqbHE8",
                Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe. As Thanos collects the six Infinity Stones, artifacts of unimaginable power, he intends to use them to wipe out half of all life. The heroes must unite across the galaxy to stop him, leading to a climactic battle with high stakes and unforeseen consequences." },

                new Movie { Id = 38, Title = "Avengers: Endgame", Year = 2019, Rating = 8.4, Director = "Anthony Russo", Genre = "Action",
                PosterUrl = "https://image.tmdb.org/t/p/w500/ulzhLuWrPK07P1YkdWQLZnQh1JL.jpg",
                TrailerUrl = "https://www.youtube.com/embed/TcMBFSGVi1c",
                Description = "After the devastating events of Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe. As they embark on a dangerous mission through time, they must confront their past and make the ultimate sacrifice to ensure a future for all. This epic conclusion to the Infinity Saga brings together heroes from across the Marvel Cinematic Universe." },

                new Movie { Id = 39, Title = "Joker", Year = 2019, Rating = 8.4, Director = "Todd Phillips", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg",
                TrailerUrl = "https://www.youtube.com/embed/zAGVQLHvwOY",
                Description = "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker. This character study explores the origins of one of the most infamous villains in comic book history, providing a dark and gritty look at a man pushed to the edge by a world that doesn't care." },

                new Movie { Id = 40, Title = "Your Name", Year = 2016, Rating = 8.4, Director = "Makoto Shinkai", Genre = "Animation",
                PosterUrl = "https://image.tmdb.org/t/p/w500/q719jXXEzOoYaps6babgKnONONX.jpg",
                TrailerUrl = "https://www.youtube.com/embed/xU47nhruN-Q",
                Description = "Mitsuha is a high school girl living in a rural town in the mountains, while Taki is a high school boy living in Tokyo. One day, they suddenly begin to swap bodies, experiencing each other's lives in their dreams. As they begin to communicate by leaving notes for each other, they develop a deep bond and set out to find each other in reality. However, a mysterious event from the past threatens their connection and the future of Mitsuha's town." },

                new Movie { Id = 41, Title = "Coco", Year = 2017, Rating = 8.4, Director = "Lee Unkrich", Genre = "Animation",
                PosterUrl = "https://image.tmdb.org/t/p/w500/gGEsBPAijhVUFoiNpgZXqRVWJt2.jpg",
                TrailerUrl = "https://www.youtube.com/embed/Ga6RYejo6Hk",
                Description = "Despite his family's baffling generations-old ban on music, Miguel dreams of becoming an accomplished musician like his idol, Ernesto de la Cruz. Desperate to prove his talent, Miguel finds himself in the stunning and colorful Land of the Dead following a mysterious chain of events. Along the way, he meets a charming trickster named Hector, and together, they set off on an extraordinary journey to unlock the real story behind Miguel's family history." },

                new Movie { Id = 42, Title = "Django Unchained", Year = 2012, Rating = 8.4, Director = "Quentin Tarantino", Genre = "Western",
                PosterUrl = "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg",
                TrailerUrl = "https://www.youtube.com/embed/eUdM9vrCbow",
                Description = "In 1858, a bounty hunter named King Schultz seeks out a slave named Django to help him find the Brittle brothers. After a successful mission, Schultz frees Django and the two become partners, hunting down the South's most wanted criminals. Django's ultimate goal is to find and rescue his wife, Broomhilda, who was sold to a ruthless plantation owner, Calvin Candie. Together, Django and Schultz hatch a daring plan to free her." },

                new Movie { Id = 43, Title = "The Wolf of Wall Street", Year = 2013, Rating = 8.4, Director = "Martin Scorsese", Genre = "Biography",
                PosterUrl = "https://image.tmdb.org/t/p/w500/pWHf4khOloNVfCxscsXFj3jj6gP.jpg",
                TrailerUrl = "https://www.youtube.com/embed/iszwuX1AK6A",
                Description = "Based on the true story of Jordan Belfort, from his rise to a wealthy stockbroker living the high life to his fall involving crime, corruption and the federal government. Belfort founds his own brokerage firm, Stratton Oakmont, and together with his trusted lieutenant and a merry band of brokers, he makes a fortune by defrauding wealthy investors out of millions. As his wealth and influence grow, so do his appetites for drugs, sex, and excess." },

                new Movie { Id = 44, Title = "Oldboy", Year = 2003, Rating = 8.4, Director = "Park Chan-wook", Genre = "Thriller",
                PosterUrl = "https://image.tmdb.org/t/p/w500/pWDtjs568ZfOTMbURQBYuT4Qxka.jpg",
                TrailerUrl = "https://www.youtube.com/embed/2HkjrJ6IK5E",
                Description = "Oh Dae-su is an average man who is kidnapped and imprisoned in a sealed hotel room for 15 years without explanation. When he is suddenly released, he is given money, a cell phone, and 5 days to find out why he was imprisoned and who was responsible. As he begins his quest for revenge, he meets a young woman named Mi-do and discovers a dark and twisted conspiracy that leads to a shocking and tragic revelation." },

                new Movie { Id = 45, Title = "Princess Mononoke", Year = 1997, Rating = 8.4, Director = "Hayao Miyazaki", Genre = "Animation",
                PosterUrl = "https://image.tmdb.org/t/p/w500/jHWmNr7m544fJ8eItsfNk8fs2Ed.jpg",
                TrailerUrl = "https://www.youtube.com/embed/4OiMOHRDs14",
                Description = "While protecting his village from a rampaging boar-god, the young warrior Ashitaka becomes afflicted with a deadly curse. To find a cure, he must journey to the forests of the west, where he becomes embroiled in a conflict between a community of iron-workers and the gods of the forest. Ashitaka meets San, the Princess Mononoke, a young woman raised by wolves, and together they must find a way to bring peace between nature and industry." },

                new Movie { Id = 46, Title = "The Truman Show", Year = 1998, Rating = 8.2, Director = "Peter Weir", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/vuza0WqY239yBXOadKlGwJsZJFE.jpg",
                TrailerUrl = "https://www.youtube.com/embed/dlnmQbPGuls",
                Description = "Truman Burbank is a man whose life is a relentless fabrication. He is the unwitting star of 'The Truman Show,' a 24-hour-a-day reality show that has been broadcast since his birth. His every move is captured by hidden cameras and his world is a giant set populated by actors. As Truman begins to notice oddities in his world, he starts to question his reality and sets out on a journey to find the truth about his life and the world beyond." },

                new Movie { Id = 47, Title = "Blade Runner 2049", Year = 2017, Rating = 8.0, Director = "Denis Villeneuve", Genre = "Sci-Fi",
                PosterUrl = "https://image.tmdb.org/t/p/w500/aMpyrCizvSdc0UIMblJ1srVgAEF.jpg",
                TrailerUrl = "https://www.youtube.com/embed/gCcx85zbxz4",
                Description = "Thirty years after the events of the first film, a new blade runner, LAPD Officer K, unearths a long-buried secret that has the potential to plunge what's left of society into chaos. K's discovery leads him on a quest to find Rick Deckard, a former LAPD blade runner who has been missing for three decades. Along the way, K must confront the reality of his own existence and the future of both humans and replicants." },

                new Movie { Id = 48, Title = "The Grand Budapest Hotel", Year = 2014, Rating = 8.1, Director = "Wes Anderson", Genre = "Comedy",
                PosterUrl = "https://image.tmdb.org/t/p/w500/eWdyYQreja6JGCzqHWXpWHDrrPo.jpg",
                TrailerUrl = "https://www.youtube.com/embed/1Fg5iWmQjwk",
                Description = "The adventures of Gustave H, a legendary concierge at a famous European hotel between the wars, and Zero Moustafa, the lobby boy who becomes his most trusted friend. The story involves the theft and recovery of a priceless Renaissance painting and the battle for an enormous family fortune—all against the backdrop of a suddenly and dramatically changing Continent. This whimsical and visually stunning film explores themes of friendship, loyalty, and the passage of time." },

                new Movie { Id = 49, Title = "A Clockwork Orange", Year = 1971, Rating = 8.3, Director = "Stanley Kubrick", Genre = "Crime",
                PosterUrl = "https://image.tmdb.org/t/p/w500/4sHeTAp65WrSSuc05nRBKddhBxO.jpg",
                TrailerUrl = "https://www.youtube.com/embed/T54uZPI4Z8A",
                Description = "In a futuristic Britain, Alex DeLarge is a charismatic and sociopathic delinquent who spends his time with his 'droogs' committing acts of 'ultra-violence.' After being arrested for murder, Alex is offered a chance to reduce his sentence by undergoing a controversial psychological conditioning technique called the Ludovico Technique, designed to make him abhor violence. After his release, Alex finds himself a victim of his former victims and a pawn in a political game." },

                new Movie { Id = 50, Title = "Requiem for a Dream", Year = 2000, Rating = 8.3, Director = "Darren Aronofsky", Genre = "Drama",
                PosterUrl = "https://image.tmdb.org/t/p/w500/nOd6vjEmzCT0k4VYqsA2hwyi87C.jpg",
                TrailerUrl = "https://www.youtube.com/embed/jzk-lmU4KZ4",
                Description = "The film depicts four different forms of drug addiction, which lead to the characters' imprisonment in a world of delusion and reckless desperation that is subsequently overtaken by reality, thus leaving them as hollow shells of their former selves. Sara Goldfarb, a lonely widow, becomes obsessed with losing weight to appear on a television game show, while her son Harry, his girlfriend Marion, and his friend Tyrone become entangled in the dangerous world of heroin addiction." }
            };

            builder.Entity<Movie>().HasData(movies);
        }
    }
}