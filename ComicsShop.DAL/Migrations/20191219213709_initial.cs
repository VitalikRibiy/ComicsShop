using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PublishingHouse.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Format = table.Column<string>(nullable: false),
                    Cover = table.Column<string>(nullable: false),
                    PagesAmount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Deliver = table.Column<string>(nullable: false),
                    DeliverAddress = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCategory_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookOrder_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Вацлав Гавел (Переклад з чеської: Надія Лобур, Надія Брилинська, Наталія Ємчура)" },
                    { 18, "Г. Кипаренко" },
                    { 17, " С. Мовчан" },
                    { 16, "Юрій Зацний" },
                    { 14, "Володимир Здоровега" },
                    { 13, "Ігор Лубкович" },
                    { 12, "Борис Потятиник" },
                    { 11, "Зенон Дмитровський" },
                    { 10, "Анатолій Капелюшний" },
                    { 15, "Людмила Мар’їна" },
                    { 8, "Тетяна Костенко" },
                    { 7, "Павло Лозинський" },
                    { 6, "Ева Магітт" },
                    { 5, "Дмитро Шурхало" },
                    { 4, "Олександр Богданович" },
                    { 3, "Дмитро Безуглий" },
                    { 2, "Спільне видання" },
                    { 9, "Зорислава Ромовська" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cover", "Description", "Format", "ImageUrl", "Language", "PagesAmount", "Price", "Title", "Year" },
                values: new object[,]
                {
                    { 15, "тверда ", "У посібнику викладено основні теоретичні положення курсу «Редагування в ЗМІ». До кожної теми подано також питання для самоперевірки, практичні завдання і рекомендовану літературу. Навчальним посібником можуть скористатися не тільки студенти факультету журналістики, для яких його, власне, й призначено, але й журналісти - практики, а також працівники всіх сфер діяльності, чия робота пов’язана з редагуванням і саморедагуванням.", "70х100/16", "~/images/Kapeluh_zmi_.png", "українська", 432, 80, "Редагування в засобах масової інформації", 2009 },
                    { 16, "тверда", "У посібнику висвітлено специфіку праці журналістів у прямому ефірі. Книга, зокрема, охоплює особливості стилістичного використання в мовленні працівників телебачення лексичних, фразеологічних, морфологічних і синтаксичних засобів, дає рекомендації для глибшого засвоєння норм акцентології. Подано питання для самоперевірки і завдання.", "70х100/16", "~/images/Kapeluh_tv_.png", "українська", 400, 80, "Телебачення прямого ефіру: практика мовлення, типові помилки", 2011 },
                    { 17, "м’яка ", "У посібнику розглянуто специфіку тележурналістики, особливості роботи журналіста на телебаченні, аудіовізуальні жанри, технологію підготовки окремих матеріалів, проблеми сучасного ефірного телемовлення, коротко пояснено телевізійну термінологію. Для студентів факультетів та відділень журналістики університетів, творчих працівників телебачення.", "60х84/16 ", "~/images/Dmytrovsky_.png", "українська", 224, 50, "Телевізійна журналістика", 2009 },
                    { 18, "тверда", "Автор розглядає інтернет-журналістику як історично четвертий (після преси, радіо і телебачення) різновид журналістики. Посібник містить практичні рекомендації стосовно підготовки і техніки написання матеріалів для новинно-аналітичних онлайнових ресурсів, а також прогнози розвитку мережевих медій.", "60х84/16", "~/images/potjatynyk_.png", "українська", 246, 60, "Інтернет-журналістика", 2010 },
                    { 19, "м’яка ", "У книзі з’ясовано вплив соціології на суспільну, передусім журналістську діяльність, проаналізовано використання соціологічних методів у журналістській практиці. Підручник дає загальне уявлення про соціологію як науку, про соціологічні методи збору інформації, про методику проведення конкретного соціологічного дослідження, про вплив соціологічної методики на роботу журналіста, значення соціології у журналістській діяльності.", "60х84/16 ", "~/images/Lubkovich_.png", "українська", 232, 70, "Соціологія і журналістика", 2013 },
                    { 23, "м’яка", "У навчальному посібнику розглянуто соціальні параметри інноваційних процесів в англійській мові на початку ХХІ сторіччя, якісні зміни в шляхах, способах, тенденціях і механізмах збагачення словникового складу. Для студентів, аспірантів, викладачів, науковців.", "60х84/16", "~/images/zacnyj_.png", "українська", 228, 50, "Сучасний англомовний світ і збагачення словникового складу", 2007 },
                    { 21, "м'яка", "Пропонована книга – перший у пострадянських країнах підручник, присвячений найважливішій частині теорії та практики журналізму: аналізу природи літературної праці у засобах масової інформації.", "60х84/16", "~/images/zdorovega_.png", "українська", 276, 100, "Теорія і методика журналістської творчості", 2008 },
                    { 22, "тверда", "Данное учебное пособие – это попытка представить журналистику как продукт духовной культуры общества, рассмотреть культурологические аспекты журналистики, ее место в глобальном контексте социокультурной динамики. Теоретико- методологическое осмысление особенностей журналистики как культурного феномена сопровождается организацией познавательной деятельности студентов при постановке и решении культурологических проблем на основе изучения первоисточников, ознакомления со спорными точками зрения. Учебное пособие носит междисциплинарный характер, хотя ориентировано, прежде всего, на студентов-журналистов, но, тем не менее, представляет интерес для специалистов самых разных научных направлений.", "60х84/16", "~/images/Marjna_.png", "російська", 288, 70, "Журналистика и культура: динамика взаимодействия", 2013 },
                    { 24, "тверда", "У навчальному посібнику вперше зроблено спробу комплексно висвітлити сучасну географію Великої Британії, її соціально- економічну й політичну історію, процес зародження та розвитку британської культури від найдавніших часів до сьогодення.", "60х84/16", "~/images/GreateBritain_.png", "українська", 496, 100, "Велика Британія: географія, історія, культура", 2012 },
                    { 14, "тверда", "Посібник містить основні положення курсу \"Практичної стилістики української мови\", який вивчають студенти факультету журналістики. Книга охоплює всі розділи цього курсу: в ній висвітлено особливості стилістичного використання в мові ЗМІ лексичних, фразеологічних, морфологічних і синтаксичних засобів. Сформульовано питання для самоперевірки і перелік завдань.", "60х84/16", "~/images/kapeluh_.png", "українська", 400, 70, "Практична стилістика української мови", 2007 },
                    { 20, "м’яка ", "У підручнику проаналізовано застосування методів соціальної психології у журналістській практиці, розкрито з соціально- психологічної точки зору журналістську методику збору інформації та спілкування журналіста з аудиторією. Для студентів вищих навчальних закладів, журналістів-практиків.", "60х84/16 ", "~/images/Lubkovich_com_.png", "українська", 252, 70, "Соціальна психологія масової комунікації", 2013 },
                    { 13, "тверда ", "Дана книга – унікальне в поліграфії видання – є підсумком копіткої багаторічної праці, започаткованої ще наприкінці 60-х років минулого століття. Книга, яка, власне, успішно витримала вже два видання у 2004 і 2008 роках, узагальнює і суттєво розширює «досвід» попередниць у кількості процитованих висловів, представлених авторів та «навігації» тематичного, алфавітного і географічного покажчиків. Всього у пропонованій Енциклопедії зібрано понад 19 200 афоризмів, крилатих фраз, цитат і висловів 3 300 авторів – про природу творчості, про майстерність журналіста, про ЗМІ та свободу слова, про зв’язки журналістики з іншими сферами буття тощо.", "60х84/8", "~/images/2011Encyclopedia_.png", "українська", 960, 280, "Енциклопедія афоризмів, крилатих фраз, цитат", 2011 },
                    { 4, "тверда", "Действия первой книги серии \"Граф Воронцов\" разворачиваются в лихие 90‐е, сразу же после развала СССР. Главный герой романа Данила Воронцов приходится потомком знаменитому графу и светлейшему князю, генерал‐фельдмаршалу и герою войны 1812‐го года Михаилу Семеновичу Воронцову. В погоне за легкой наживой он вместе со своими друзьями оказывается втянут в сомнительную криминальную историю, связанную с кражей одной вещи, которая неожиданно для них представляет огромную ценность для криминальных авторитетов и руководства города и области. Завладев этой вещью, герои книги сталкиваются с начавшейся войной между уголовными авторитетами и криминальными разборками. Они скрываются от преследования бандитов и уголовного розыска, а их авантюрные приключения насыщены комедийными и одновременно с этим жестокими событиями, характеризующими период времени начала 90‐х годов. Книга \"Отдых по пятницам\" ‐ это горячая смесь авантюрно‐приключенческого, криминального и детективного жанров современной литературы. Читая ее, словно погружаешься в динамичный сюжет сериала или кинофильма, с желанием досмотреть его до конца сразу же…", "60х84/16", "~/images/Bezuglyy_2.png", "російська", 368, 90, "Отдых по пятницам", 2018 },
                    { 11, "м'яка", "Вашій увазі пропонуємо книжку, що є результатом дослідження життєвого шляху непересічної особистості, перекладачки і фольклористки Ольги Рошкевич-Озаркевич, її стосунків з Іваном Франком на основі листування. В молоді роки їх поєднувало взаємне перше палке кохання, яке надихало поета на створення ліричних поезій. Проте закоханим не судилось бути разом. Читач дізнається маловідомі факти з життя Ольги та родини Рошкевичів, її чоловіка Володимира Озаркевича, Івана Франка і його соратників – Михайла та Анни Павликів. Рекомендуємо до прочитання дослідникам і шанувальникам творчості Івана Франка.", "60х84/16", "~/images/Kostenko_.png", "українська", 164, 90, "Мелодія сердця", 2017 },
                    { 10, "тверда", "Як відомо, шпак – це невеличкий птах ряду горобцеподібних, який завдяки своїй здатності до багатоголосся нерідко передражнює інших пернатих, а деколи навіть і людей. Недарма ж українська версія його назви походить від праслов'янського \"ščьpakъ\", яке, своєю чергою, утворилося від дієслова \"ščipati\" – \"щипати\", вжитого у значенні \"дражнити\", \"імітувати\". Звісно, нічого страшного, якщо цей халамидник сидить на дереві і знущається зі своїх жертв дистанційно, але як бути, коли голосистий шибеник оселяється у чиїйсь голові? Перед вами збірка історій людей, про яких так і кажуть: \"має шпака\". Вони – поряд: ходять тими самими вулицями, їздять у маршрутках, метро чи електричках, сидять за сусідніми столиками у кнайпах. Однак дуже часто ми навіть не здогадуємося, що в головах цих людей виводить трелі Sturnus vulgaris.", "70х100/32", "~/images/Lozynskyy_.png", "українська", 120, 60, "Застрелити шпака", 2017 },
                    { 9, "м'яка", "Авторські казкові історії про пригоди равлика Капучіно призначені для дітей дошкільного віку і покликані розвивати їх творче мислення та уяву. Переконані, що короткочасне повернення у казковий світ буде приємним та захопливим також і для їхніх батьків.", "70х84/16", "~/images/ravlik.jpg", "українська", 24, 30, "Місто виноградних слимаків", 2018 },
                    { 8, "м’яка ", "Чому кавалеристи не знали, що танк марно рубати шаблею? Де насправді відбулася найбільша танкова битва? Скільки чорнозему вивезли німці з окупованих територій?.. У цій книжці спростовуються поширені уявлення про війну 1939-1945 років, які насправді не відповідають дійсності, розповідається про те, як ці міфи з’явились і яким є їхнє реальне підґрунтя.", "60х84/8", "~/images/Shurhalo_.png", "українська", 140, 40, "Міфи Другої світової війни", 2011 },
                    { 7, "м’яка ", "Автор цієї книжки намагається зрозуміти суперечливу постать гетьмана Павла Скоропадського, порівнюючи його не з тогочасними українськими політиками, а з товаришами по службі: Карлом Густавом Маннергеймом та Петром Врангелем. Ці генерали-кавалеристи належали до свити останнього російського імператора і добре знали одне одного. До 1917 року їхні кар’єри розвивалися дуже схоже. Після розвалу Російської імперії вони почали на її уламках створювати нові держави. Впоратися із цим завданням пощастило лише Маннергейму.", "60х84/8", "~/images/Shurhalo_2_.png", "українська", 224, 50, "Скоропадський, Маннергейм, Врангель: кавалеристи-державники", 2013 },
                    { 6, "тверда", "Друга частина роману-дилогії «Таємниця Святоюрської гори» є самостійним цілісним твором і водночас продовженням першої частини. У попередній книзі події розгортаються у столиці Галичини в роки Першої світової війни, а друга книга занурює читача у вир Другої світової війни. Головний герой – російський офіцер царської армії, тричі відвідує Львів та щоразу застає місто в іншому державному підпорядкуванні – австрійському, польському та радянському. Художнє відтворення колоритного життя поліетнічної спільноти міста у драматичні та трагічні періоди його історії – це авторський задум. О. Богданович сповна його реалізував, спираючись на свідчення очевидців та їхні особисті архіви. Книга розрахована на широке коло читачів, передусім – шанувальників історико - пригодницького жанру, а також тих, хто цікавиться шпигунсько - контррозвідувальною тематикою, захоплюється історією Львова та прагне до глибокого її пізнання через виразне художнє слово.", "60х90/16", "~/images/Bogdanovich_2.png", "українська", 156, 90, "Таємниця Святоюрської гори: книга друга", 2019 },
                    { 5, "тверда", "Історико-пригодницький роман «Таємниця Святоюрської гори» оповідає про події в Галичині під час її окупації російськими військами в період Першої світової війни (вересень 1914 – червень 1915 рр.). Спроби російської контррозвідки запровадити в шпигунську мережу австрійців капітана Бєлінського виявляють таємницю, яку ретельно приховують уніатські ченці в надрах Святоюрської гори. Читач познайомиться з атмосферою, що панувала в дні важких випробувань в багатонаціональному місті, багатьма історичними особистостями, які опинилися в той час у Львові, діяльністю російської адміністрації, що намагалася перетворити Галицький край в нові губернії Росії. В основу книги лягли матеріали з фондів російських та українських держархівів і бібліотек, а також спогади учасників описуваних подій.", "60х90/16", "~/images/Bogdanovich_.png", "українська", 348, 110, "Таємниця Святоюрської гори: книга перша", 2017 },
                    { 3, "тверда", "Франция, Долина Замков. Из таинственного дома на холме «Medmor» исчезает знаменитая писательница, автор исторических романов Гаэлль Вильнёв. Ее имя известно всей Европе: она занимает первые строчки в рейтинге популярных писателей- романистов. Дело берут под свой контроль префект департамента и лично министр внутренних дел Франции. Являясь близким другом Гаэлль, к расследованию подключается бывший комиссар национальной полиции департамента Лютгард Аллар. Основная версия – похищение. Но от похитителей не поступает никаких требований. Одновременно с этим начинают происходить необъяснимые мистические события, связанные с теми, что свершались более трехсот лет назад, когда еще были сильны Инквизиция и Святой Трибунал. Противостояние тайных религиозных орденов, одержимость демонами и экзорцизм, странная община деревни Крессо и, конечно же, дом на холме «Medmor» – символ сатанизма и пристанище чернокнижников. С этим придется столкнуться Лютгарду Аллару и его бывшему подчиненному, а ныне комиссару полиции Ренальду Рою. Ошеломительный финал книги никого не оставит равнодушным…", "60х90/16", "~/images/Bezuglyy_.png", "російська", 712, 150, "Когда сердце плачет, или Казнь одержимости", 2017 },
                    { 2, "тверда", "Пропонована авторським колективом книга про пригоди й перипетії студентів у третьому трудовому семестрі – це щирі і відверті спогади, роздуми і зізнання учасників студзагонівського руху про роки своєї молодості і дивовижний світ Сибіру, Казахстану, Далекого Сходу та Крайньої Півночі. Їх романтика поєднувалась із прагматизмом. Студенти самоорганізовувались, мандрували у незвідані краї, адаптовувались до місцевих реалій, закохувались, одружувались і щиро вірили у перспективу завтрашнього дня. Книга написана у доступному стилі і розрахована на якнайширшу аудиторію.", "60х90/16", "~/images/Studzagony_.png", "українська", 288, 100, "Сибірський семестр: пригоди, спогади, роздуми студзагонівців", 2018 },
                    { 1, "м'яка", "Це остання прижиттєва книга останнього Президента Чехословаччини і першого Президента Чеської Республіки Вацлава Гавела, світла особа якого досі асоціюється у багатьох людей з уособленням честі, обов’язку і беззаперечного морального авторитету. Своєрідний белетризований підсумок власного життя автор подає у надзвичайно оригінальній оправі колажу, у якому природно переплелися спогади, роздуми, допити-інтерв’ю із самим собою, фрагменти особистих щоденників та службових записок. Це, по суті, дуже густий і пізнавальний «концентрат» знакових подій, рішень та дій недалекого минулого за участі багатьох непересічних персонажів. Переконані, що ця книга, вперше видана українською мовою, здатна стати настільним підручником-настановою для вітчизняних державотворців та фахівців-гуманітаріїв, а також – вагомою підмогою для всіх, хто намагається збагнути сутність політичних процесів сучасності.", "70х100/16 ", "~/images/Gavel_.png", "українська", 288, 130, "Прошу коротко: розмова з Карелом Гвіждялою, примітки, документи", 2016 },
                    { 12, "м’яка", "У цій книжечці зібрано рядки про кохання, написані українськими поетами різних часів. Вони засвідчують глибинну народну мудрість, довершеність і красу української мови. Метою цієї книжечки є утвердження верховенства любові.", "60х84/32", "~/images/Struny_.png", "українська", 208, 30, "Кохання струни золоті", 2015 }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Художня література" },
                    { 2, "Навчальна та довідкова література" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 24, 17, 24 },
                    { 23, 16, 23 },
                    { 22, 15, 22 },
                    { 21, 14, 21 },
                    { 20, 13, 20 },
                    { 19, 13, 19 },
                    { 18, 12, 18 },
                    { 17, 11, 17 },
                    { 16, 10, 16 },
                    { 15, 10, 15 },
                    { 14, 10, 14 },
                    { 25, 18, 24 },
                    { 12, 9, 12 },
                    { 11, 8, 11 },
                    { 10, 7, 10 },
                    { 9, 6, 9 },
                    { 8, 5, 8 },
                    { 7, 5, 7 },
                    { 6, 4, 6 },
                    { 5, 4, 5 },
                    { 4, 3, 4 },
                    { 3, 3, 3 },
                    { 2, 2, 2 },
                    { 13, 10, 13 }
                });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "Id", "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 14, 14, 2 },
                    { 15, 15, 2 },
                    { 16, 16, 2 },
                    { 17, 17, 2 },
                    { 22, 22, 2 },
                    { 19, 19, 2 },
                    { 20, 20, 2 },
                    { 21, 21, 2 },
                    { 13, 13, 2 },
                    { 18, 18, 2 },
                    { 12, 12, 1 },
                    { 6, 6, 1 },
                    { 10, 10, 1 },
                    { 9, 9, 1 },
                    { 8, 8, 1 },
                    { 7, 7, 1 },
                    { 5, 5, 1 },
                    { 4, 4, 1 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 23, 23, 2 },
                    { 11, 11, 1 },
                    { 24, 24, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_BookId",
                table: "BookCategory",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_CategoryId",
                table: "BookCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrder_BookId",
                table: "BookOrder",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrder_OrderId",
                table: "BookOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_BookId",
                table: "Carts",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerId",
                table: "Carts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookId",
                table: "Comments",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerId",
                table: "Comments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropTable(
                name: "BookOrder");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
