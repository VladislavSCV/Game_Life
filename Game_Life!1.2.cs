
public class Person
{
    public int Id;
    public string Name;
    public int FirstName;
    public int AgeM;
    public int AgeT;
    public int AgeW;
    public string Birthday;
    public string Birthmonth;
    public string Birthyear;
    public int Balance;

    
}
public class Programm
{
    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Clear();
        Console.WriteLine("Введите свой логин");
        string x1 = Console.ReadLine();
        string[] PlayersLog = new[] { x1 };

        Console.WriteLine("Введите свой пароль");
        string x = Console.ReadLine();
        string[] PlayersPasw = new[] { x };
        Console.Clear();

        foreach (string player_log in PlayersLog)
        {
            Console.WriteLine("Введите свой логин!" +
                "\n Это нужно для подтверждения вашей авторизации");
            string avtorLog;
            avtorLog = Console.ReadLine();
            if (avtorLog == player_log)
            {
                Console.WriteLine("");
                foreach (string player_pasw in PlayersPasw)
                {
                    Console.WriteLine("Введите свой пароль!");
                    string avtorPasw;
                    avtorPasw = Console.ReadLine();
                    if (avtorPasw == player_pasw)
                    {
                        Console.WriteLine("Доступ разрешен!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();

                        Random rnd = new Random();
                        int id = rnd.Next(124232, 98327282);

                        Person Player = new Person();
                        Player.Id = id;

                        Console.WriteLine("Введите ваше имя!");
                        Player.Name = Console.ReadLine();
                        Console.WriteLine("Введите ваш день рождения!");
                        Player.Birthday = Console.ReadLine();
                        Console.WriteLine("Введите ваш месяц! рождения!");
                        Player.Birthmonth = Console.ReadLine();
                        Console.WriteLine("Введите ваш год рождения!");
                        Player.Birthyear = Console.ReadLine();


                        void Print_Info_About_MeM()
                        {
                            Console.WriteLine($"Привет, меня зовут {Player.Name}. Мне {Player.AgeM} лет. Класс! БУГАГА! " +
                                $"\n Ваш Id:{Player.Id}");
                        }
                        void Print_Info_About_MeT()
                        {
                            Console.WriteLine($"Привет, меня зовут {Player.Name}. Мне {Player.AgeT} лет. Ну что? Какие планы? Строим карьеру или ростим детей? Или..." +
                                $"\n Ваш Id:{Player.Id}");
                        }
                        void Print_Info_About_MeW()
                        {
                            Console.WriteLine($"Привет, меня зовут {Player.Name}. Мне {Player.AgeW} лет. Когда на пенсию? Хмм... НИКОГДА! ХАХАХА" +
                                $"\n Ваш Id:{Player.Id}");
                        }


                        Player.AgeM = 0;
                        Player.AgeT = 20;
                        Player.AgeW = 50;

                        Console.WriteLine($"Привет {Player.Name}!!! Игра дает вам шанс раз и на всегда выбрать ваш возраст" +
                            $"\nЭтот возраст будет в течении игры использоваться для определния вашей дальнейшей судьбы)" +
                            $"\nНа ваш выбор вы можете получить {Player.AgeM} ,{Player.AgeT},{Player.AgeW} эти года жизни!" +
                            $"\n И эти года будут считаться вашей отправной точкой в начало игры)" +
                            $"\n Выбирайте) Чтобы выбрать самое начало жизни, то есть {Player.AgeM} лет. То введите слово 'Начало'" +
                            $"\n Чтобы выбрать самый расцвет сил человека, то есть{Player.AgeT}. То введите слово 'Сила'" +
                            $"\n Чтобы выбрать счастливую старость(хотя может и не счастливую), то есть {Player.AgeW}.То введите слово 'Конец'");
                        Thread.Sleep(5000);
                        Console.WriteLine("");
                        Console.WriteLine("В зависимости от вашего ответа ваш игровой паспорт будет иметь такой вид!");
                        Thread.Sleep(1000);
                        Print_Info_About_MeM();
                        Print_Info_About_MeT();
                        Print_Info_About_MeW();

                        string first_one = Console.ReadLine();
                        if (first_one == "Начало")
                        {
                            Console.WriteLine("Введите ваше имя");
                            string Name_in_game = Console.ReadLine();
                            Console.WriteLine($"{Name_in_game} теперь ты существуешь в этом мире по настоящему!" +
                                $"\n На свои первый день рождения тебе дарят детские игрушки и тд" +
                                $"\n Ты  можешь пропустить несколько лет скуки и изучения первых шагов жизни тогда введи слово 'Speed' или " +
                                $"же просто введи любую цифру или букву для того чтобы остаться на этом этапе)");
                            string secon_one = Console.ReadLine();
                            if (secon_one == "Speed")
                            {
                                Console.WriteLine("Хах, любите все по быстрому?" +
                                    "\n Хорошо вам 9 лет " +
                                    "\n И у тебя сегодня день рождения!" +
                                    "\n У тебя есть 3 варианта подарка на др" +
                                    "\n 1)Книги по программированию" +
                                    "\n 2)Футбольный мяч" +
                                    "\n 3)Ничего");
                                Thread.Sleep(500);
                                Console.WriteLine("Введите цифру");
                                string zifra1 = Console.ReadLine();
                                switch (zifra1)
                                {
                                    case "1":
                                        Console.WriteLine("Вау! Ваш взгяд пал на мир IT. Это невероятно круто!" +
                                            "\n Я вам советую начать изучение уже сегодня! Для того чтобы в будущем стать великим программистом!" +
                                            "");
                                        break;
                                    case "2":
                                        Console.WriteLine("Любите азарт, спорт, игры? Это для вас! Начинайте работать над собой для того чтобы в будущем за вас было не стыдно!" +
                                            "Ну что продолжим жизнь спортсмена? Да/Нет?");
                                        string SportLive = Console.ReadLine();
                                        if (SportLive == "Да")
                                        {
                                            Console.WriteLine("Отлично! Перед вами выбор) Вы можете всю жизнь посвятить своему любимому виду спорта или же можете прожить свою жизнь как и все обычные люди!" +
                                                "\n Выберите вариант исхода событий. " +
                                                "\n 1)Это труд, боль, кровь, слезы и в каких то местах одиночество, а может и нет)" +
                                                "\n 2)Это обычная жизнь. Как у обычного человека)" +
                                                "\n Введите цифру. Но помните в этой жизни есть два варианта смысла жизни:" +
                                                "\n 1)Это борьба не только с самим с собой но и с обществом и с жизнью. Смысл заключается в том чтобы после своей смерти ты мог что то после себя остаавить.)" +
                                                "\n Ну а впрочем не факт что в вашей жизни все будет гладко и у вас все получится. И тогда итог будет то что вы эту жизнь зря прожили)" +
                                                "\n 2) Некоторые люди живут эту жизнь чтобы ее просто посмотреть. Я думаю это самые спокойные и неосознающие происходящего люди. " +
                                                "\n ВВЕДИТЕ ЦИФРУ!!!");
                                            string SportLive1 = Console.ReadLine();
                                            switch (SportLive1)
                                            {
                                                case "1":
                                                    Console.WriteLine("Вау! Вы выбрали тяжкий путь, но это к лучшему.");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine("Стоп... Что? Вас заметили два клуба! Один местный (вы там будете играть все время в основе ,но получать зарплату будете реже и меньше(  в отличии от другого клуба)" +
                                                        "\n Но есть и  второой клуб! Это самый популярный клуб в вашем городе, так что если вы себя там хорошо проявите то есть шанс попасть в зарубежные клубы!");
                                                    string SportLive2 = Console.ReadLine();
                                                    if (SportLive2 == "1")
                                                    {
                                                        Console.WriteLine("Хорошо, вы часто играли за основной состав! И смогли многому научиться. Вам предлагают изменить клуб(на более крутой)" +
                                                            "\n Но перед вами есть выбор пойти в другой клуб или остаться в этом на всегда!" +
                                                            "\n Введите 1 для того чтобы перейти в другой клуб " +
                                                            "\n Введите 2 чтобы остаться в клубе");
                                                        string SportLive3 = Console.ReadLine();
                                                        if (SportLive3 == "1")
                                                        {
                                                            Console.WriteLine("Чтож поздравляю! В новом клубе вы часто играли в основе и хорошо себя проявили " +
                                                                "Вы уже 50 летний человек и ваше тело молит вас остановиться играть)" +
                                                                "Выберите продолжить карьеру(1) или ЗАКОНЧИТЬ!!!(2)");
                                                            string SportLive4 = Console.ReadLine();
                                                            switch (SportLive4)
                                                            {
                                                                case "1":
                                                                    Console.WriteLine("Эх. Боюсь ваше старое сердце не выдержало нагрузки" +
                                                                        "\n И вы умерли!" +
                                                                        "\n DEAD!" +
                                                                        "\n Но не растраивайтесь) Я надеюсь вы прожили эту жизнь не зря) Все равно переселения душ не существует( Так что нужно было дышать и жить каждым днем как последним!" +
                                                                        "\n Пока!");
                                                                    break;
                                                                case "2":

                                                                    Console.WriteLine("Вау! Вы во время остановились). Если бы вы продолжили играть вы бы умерли. Но не спешите радоваться) Вы психически больны!!! " +
                                                                        "\n Вы в течении всей жизни любили, играли, жили футболом и у вас такой конец!" +
                                                                        "\n Нет, вы психически это не выдержали и покончили с собой на любимом месте) На футбольном поле" +
                                                                        "\n DEAD!");
                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Нужно было ввести одну из цифр. Но боюсь что уже поздно... Пока!)");
                                                                    break;




                                                            }

                                                        }
                                                    }

                                                    break;
                                                case "2":
                                                    Console.WriteLine("Ух не ожидал что вы выберите этот вариант) Но это отлично, в каком то смысле! " +
                                                        "\n Так, давайте посмотрим на вас) вы, человек с великолепной физической формой! " +
                                                        "\n Так что вы можете стать грузчиком или тренером в спорт зале! Вы берите что вам ближе) 1 или 2 вариант!     ");
                                                    break;
                                            }
                                        }
                                        else if (SportLive == "Нет")
                                        {
                                            Console.WriteLine("Согласен! Кому нужен этот спорт, все равно там выигрывают те кто изначально был крепкип малым)" +
                                                "\n Ну ничего) Растраиваться точно не стоит. У вас будет великолепная судьба! Вы можете продать этот мяч и заработать немного денег!");
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("НУУУУ ЛАДНО \n Вы ничего не получили(");
                                        break;
                                    default:
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("Мне кажется вы ошиблись когда вводили ответ) И боюсь что ваша игра окончена(\n Пока!");
                                        Console.WriteLine("Ошибка 404(");
                                        break;
                                }


                            }
                            else
                            {
                                Console.WriteLine("Ну блин( Это слишком долго( " +
                                    "\n Так как в каждой игре есть правильные и не правильные ответы) А мы не исключение, в данный момент , то боюсь вы протграли эту жизнь)");
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Боюсь что пароль не правильный(");
                    }
                }
            }
            else if (avtorLog != player_log)
            {
                Console.WriteLine("Боюсь что логин или пароль не правильный(");
            }
        }




        

        


    }
}


