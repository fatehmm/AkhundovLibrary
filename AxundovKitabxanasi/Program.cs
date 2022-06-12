using System;

namespace AxundovKitabxanasi
{
    class Program
    {
        static void Main(string[] args)
        {


            


            Book book1 = new Book()
            {
                Name = "Sapiens",
                Author = "Y.N.Harari",
                Genre = "Science",
                Price = 15.2
            };

            Book book2 = new Book()
            {
                Name = "Calculus for dummies",
                Author = "Mark Ryan",
                Genre = "Textbook",
                Price = 200
            };

            Book book3 = new Book()
            {
                Name = "Harry Potter",
                Author = "J.K.Rawling",
                Genre = "Fiction",
                Price = 30.3
            };

            Book book4 = new Book()
            {
                Name = "Harry Potter 2",
                Author = "J.K.Rowling",
                Genre = "Fiction",
                Price = 15.2
            };

            Book book5 = new Book()
            {
                Name = "Cosmos",
                Author = "Carl Sagan",
                Genre = "Science",
                Price = 5
            };

            Book book6 = new Book()
            {
                Name = "Contact",
                Author = "Carl Sagan",
                Genre = "Science",
                Price = 5.3
            };

            Book book7 = new Book()
            {
                Name = "IOS 16 Manual",
                Author = "Apple",
                Genre = "Manual",
                Price = 0
            };

            Library axundovKitabxanasi = new Library();

            Library.AddBook(ref axundovKitabxanasi.books, book1);
            Library.AddBook(ref axundovKitabxanasi.books, book2);
            Library.AddBook(ref axundovKitabxanasi.books, book3);
            Library.AddBook(ref axundovKitabxanasi.books, book4);
            Library.AddBook(ref axundovKitabxanasi.books, book5);
            Library.AddBook(ref axundovKitabxanasi.books, book6);
            Library.AddBook(ref axundovKitabxanasi.books, book7);

            
            string answer = "";
            do
            {
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine(" ");
                Console.WriteLine("Axundov kitabxanasina xos gelmisiniz menudan istediyinizi secin");
                Console.WriteLine("1. Kitablara baxmaq...");
                Console.WriteLine("2. Kitabxanaya kitab elave etmek...");
                Console.WriteLine("3. Kitablari janrina gore filtrelemek...");
                Console.WriteLine("4. Kitabxana haqqinda melumat almaq...");
                Console.WriteLine("0. Menudan cixmaq");
                do
                {
                    answer = Console.ReadLine();


                } while (answer ==null || (answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer != "0"));

                switch (answer)
                {
                    case "1":
                        foreach (var item in axundovKitabxanasi.books)
                        {
                            Console.WriteLine($"{item.IdentifierAccess}. {item.Name} , {item.Author}, {item.Genre}");
                        }
                        break;
                    case "2":
                        string name = "";
                        string author = "";
                        string genre = "";
                        string answerGenre = "";
                        double priceBook;
                        Console.Write("Sisteme elave etmek istediyiniz kitabin adini yazin....");
                        name = Console.ReadLine().Capitalize();
                        Console.Write("Sisteme elave etmek istediyiniz kitabin muellifini yazin....");
                        author = Console.ReadLine().Capitalize();
                        Console.WriteLine("Sisteme elave etmek istediyiniz kitabin janrini secin....");
                        Console.WriteLine("1. Fiction");
                        Console.WriteLine("2. Science");
                        Console.WriteLine("3. Textbook");
                        Console.WriteLine("4. Manual");
                        do
                        {
                            Console.Write("Secimizi daxil edin...");
                            answerGenre = Console.ReadLine();


                        } while (answer == null || (answer != "1" && answer != "2" && answer != "3" && answer != "4"));
                        switch (answerGenre)
                        {
                            case "1":
                                genre = "Fiction";
                                break;
                            case "2":
                                genre = "Science";
                                break;
                            case "3":
                                genre = "Textbook";
                                break;
                            case "4":
                                genre = "Manual";
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Sisteme elave etmek istediyiniz kitabin qiymetini yazin....");
                        bool checkPrice = double.TryParse(Console.ReadLine(), out priceBook);

                        if (checkPrice == true && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(author))
                        {
                            Book bookWillBeAdded = new Book()
                            {
                                Name = name,
                                Author = author,
                                Price = priceBook,
                                Genre = genre
                            };
                            Library.AddBook(ref axundovKitabxanasi.books, bookWillBeAdded);
                            Console.WriteLine("Kitabiniz ugurla elave olundu ..");

                        }
                        else
                        {
                            Console.WriteLine("Prosesde xeta bas verdi, yeniden yoxlayin....");
                            goto case "2";
                        }
                        break;
                    case "3":
                        Console.WriteLine("Kitablari hansi janra gore filtrelemek isteyirsiniz???");
                        Console.WriteLine("1. Fiction");
                        Console.WriteLine("2. Science");
                        Console.WriteLine("3. Textbook");
                        Console.WriteLine("4. Manual");

                        string answerFilter = "";

                        do
                        {
                            Console.Write("Secimizi daxil edin...");
                            answerFilter = Console.ReadLine();


                        } while (answer == null || (answer != "1" && answer != "2" && answer != "3" && answer != "4"));

                        switch (answerFilter)
                        {
                            case "1":
                                foreach (var item in axundovKitabxanasi.books)
                                {
                                    if (item.Genre == "Fiction")
                                    {
                                        Console.WriteLine($"{item.IdentifierAccess}. {item.Name} , {item.Author}, {item.Genre}");
                                    }
                                }
                                break;
                            case "2":
                                foreach (var item in axundovKitabxanasi.books)
                                {
                                    if (item.Genre == "Science")
                                    {
                                        Console.WriteLine($"{item.IdentifierAccess}. {item.Name} , {item.Author}, {item.Genre}");
                                    }
                                }
                                break;
                            case "3":
                                foreach (var item in axundovKitabxanasi.books)
                                {
                                    if (item.Genre == "Textbook")
                                    {
                                        Console.WriteLine($"{item.IdentifierAccess}. {item.Name} , {item.Author}, {item.Genre}");
                                    }
                                }
                                break;
                            case "4":
                                foreach (var item in axundovKitabxanasi.books)
                                {
                                    if (item.Genre == "Manual")
                                    {
                                        Console.WriteLine($"{item.IdentifierAccess}. {item.Name} , {item.Author}, {item.Genre}");
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;

                    case "4":
                        Console.WriteLine("Mirzə Fətəli Axundov adına Azərbaycan Milli Kitabxanası — \n Azərbaycanda kitabxana işi sahəsində dövlət siyasətini həyata keçirən, \n milli nəşrləri, xarici ölkələrdə Azərbaycan haqqında nəşr olunmuş çap məhsullarını \n və Azərbaycan müəlliflərinin əsərlərini, \n dünya əhəmiyyətli nəşrləri, o cümlədən xarici dillərdə çap olunmuş məlumat daşıyıcılarını toplayıb mühafizə edən kitabxana və dövlət kitabsaxlayıcısıdır.");
                        break;
                    default:
                        break;
                }

            } while (answer != "0");
            



        }
       
    }
}

